using System.Text;
using System.Windows.Forms;

namespace Dinamic_Grafika
{
    public partial class Form1 : Form
    {
        OpenFileDialog oknosouboruopen = new OpenFileDialog(); // Dialog pro výbìr souboru
        List<int> Hodnoty = new List<int>(); // Pùvodní hodnoty ze souboru
        List<int> NormalizovaneHodnoty = new List<int>(); // Hodnoty pøevedené na rozsah 0–370 (pro výšku sloupce)

        public Form1()
        {
            InitializeComponent(); // Inicializace komponent formuláøe
        }

        // Spouští se po kliknutí na tlaèítko pro naètení dat
        private void button1_Click(object sender, EventArgs e)
        {
            // Zobrazí dialogové okno pro výbìr souboru
            DialogResult odpoved = oknosouboruopen.ShowDialog();

            if (odpoved == DialogResult.OK)
            {
                // Filtr pro CSV soubory (uživatel ho ale uvidí až po znovuotevøení dialogu)
                oknosouboruopen.Filter = "CSV soubory|*.csv|Všechny soubory|*.*";

                string Pomoc = oknosouboruopen.FileName; // Uloží cestu k vybranému souboru

                try
                {
                    if (File.Exists(Pomoc)) // Ovìøení, že soubor existuje
                    {
                        // Naètení prvního øádku, rozdìlení podle støedníku a pøevedení na èísla
                        Hodnoty = File.ReadAllLines(Pomoc, Encoding.Default)[0]
                            .Split(';')
                            .Select(h => int.Parse(h.Trim()))
                            .ToList();

                        int min = Hodnoty.Min(); // Nejmenší hodnota v souboru
                        int max = Hodnoty.Max(); // Nejvìtší hodnota v souboru

                        // Normalizace všech hodnot do rozsahu 0–370 pro vykreslení
                        NormalizovaneHodnoty = Hodnoty.Select(h => Map(h, min, max, 0, 370)).ToList();

                        // Potvrzení úspìšného naètení
                        MessageBox.Show("Soubor byl úspìšnì naèten.");

                        // Vyvolání pøekreslení panelu (grafu)
                        panel1.Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("Soubor neexistuje.");
                    }
                }
                catch (Exception ex)
                {
                    // Chybové hlášení pøi naèítání
                    MessageBox.Show($"Chyba pøi naèítání souboru: {ex.Message}");
                }
            }
        }

        // Funkce pro pøekreslení panelu s grafem
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Objekt pro kreslení
            Pen p = new Pen(Color.Black); // Pero – aktuálnì se ale nepoužívá
            SolidBrush sb = new SolidBrush(Color.Black); // Štìtec pro výplò sloupcù a text

            // Pokud máme nìjaké normalizované hodnoty k vykreslení
            if (NormalizovaneHodnoty != null && NormalizovaneHodnoty.Any())
            {
                int height = panel1.Height - 10; // Výška oblasti pro kreslení (s mezerou dole)
                int width = panel1.Width; // Celková šíøka panelu

                int sloupcu = NormalizovaneHodnoty.Count - 1; // Poèet sloupcù (pozor, -1, mùže být chyba)
                int mezera = 10; // Mezera mezi sloupci
                int sirkaSloupce = (width - (sloupcu + 1) * mezera) / sloupcu; // Výpoèet šíøky jednoho sloupce

                int x = mezera; // Poèáteèní pozice X pro první sloupec
                int SIRKA = (x + sirkaSloupce) / 2; // Pozice X pro text s indexem

                double prumer = NormalizovaneHodnoty.Average(); // Prùmìr hodnot (aktuálnì nevyužito)

                // Smyèka pro vykreslení každého sloupce
                for (int i = 1; i < NormalizovaneHodnoty.Count; i++) // Zaèíná od 1 (pozor: index 0 se nevyužívá)
                {
                    int vyskaSloupce = Convert.ToInt32(NormalizovaneHodnoty[i]);

                    // Vykreslení sloupce
                    g.FillRectangle(sb, x, height - vyskaSloupce, sirkaSloupce, vyskaSloupce);

                    // Vykreslení èísla indexu pod sloupec
                    g.DrawString(Convert.ToString(i), this.Font, sb, SIRKA, height - mezera / 2);

                    // Posun na další sloupec
                    x += sirkaSloupce + mezera;
                    SIRKA += sirkaSloupce + mezera;
                }
            }
        }

        // Pomocná funkce pro normalizaci hodnot do nového rozsahu
        public static int Map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
    }
}
