using System.Text;
using System.Windows.Forms;

namespace Dinamic_Grafika
{
    public partial class Form1 : Form
    {
        OpenFileDialog oknosouboruopen = new OpenFileDialog(); // Dialog pro v�b�r souboru
        List<int> Hodnoty = new List<int>(); // P�vodn� hodnoty ze souboru
        List<int> NormalizovaneHodnoty = new List<int>(); // Hodnoty p�eveden� na rozsah 0�370 (pro v��ku sloupce)

        public Form1()
        {
            InitializeComponent(); // Inicializace komponent formul��e
        }

        // Spou�t� se po kliknut� na tla��tko pro na�ten� dat
        private void button1_Click(object sender, EventArgs e)
        {
            // Zobraz� dialogov� okno pro v�b�r souboru
            DialogResult odpoved = oknosouboruopen.ShowDialog();

            if (odpoved == DialogResult.OK)
            {
                // Filtr pro CSV soubory (u�ivatel ho ale uvid� a� po znovuotev�en� dialogu)
                oknosouboruopen.Filter = "CSV soubory|*.csv|V�echny soubory|*.*";

                string Pomoc = oknosouboruopen.FileName; // Ulo�� cestu k vybran�mu souboru

                try
                {
                    if (File.Exists(Pomoc)) // Ov��en�, �e soubor existuje
                    {
                        // Na�ten� prvn�ho ��dku, rozd�len� podle st�edn�ku a p�eveden� na ��sla
                        Hodnoty = File.ReadAllLines(Pomoc, Encoding.Default)[0]
                            .Split(';')
                            .Select(h => int.Parse(h.Trim()))
                            .ToList();

                        int min = Hodnoty.Min(); // Nejmen�� hodnota v souboru
                        int max = Hodnoty.Max(); // Nejv�t�� hodnota v souboru

                        // Normalizace v�ech hodnot do rozsahu 0�370 pro vykreslen�
                        NormalizovaneHodnoty = Hodnoty.Select(h => Map(h, min, max, 0, 370)).ToList();

                        // Potvrzen� �sp�n�ho na�ten�
                        MessageBox.Show("Soubor byl �sp�n� na�ten.");

                        // Vyvol�n� p�ekreslen� panelu (grafu)
                        panel1.Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("Soubor neexistuje.");
                    }
                }
                catch (Exception ex)
                {
                    // Chybov� hl�en� p�i na��t�n�
                    MessageBox.Show($"Chyba p�i na��t�n� souboru: {ex.Message}");
                }
            }
        }

        // Funkce pro p�ekreslen� panelu s grafem
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Objekt pro kreslen�
            Pen p = new Pen(Color.Black); // Pero � aktu�ln� se ale nepou��v�
            SolidBrush sb = new SolidBrush(Color.Black); // �t�tec pro v�pl� sloupc� a text

            // Pokud m�me n�jak� normalizovan� hodnoty k vykreslen�
            if (NormalizovaneHodnoty != null && NormalizovaneHodnoty.Any())
            {
                int height = panel1.Height - 10; // V��ka oblasti pro kreslen� (s mezerou dole)
                int width = panel1.Width; // Celkov� ���ka panelu

                int sloupcu = NormalizovaneHodnoty.Count - 1; // Po�et sloupc� (pozor, -1, m��e b�t chyba)
                int mezera = 10; // Mezera mezi sloupci
                int sirkaSloupce = (width - (sloupcu + 1) * mezera) / sloupcu; // V�po�et ���ky jednoho sloupce

                int x = mezera; // Po��te�n� pozice X pro prvn� sloupec
                int SIRKA = (x + sirkaSloupce) / 2; // Pozice X pro text s indexem

                double prumer = NormalizovaneHodnoty.Average(); // Pr�m�r hodnot (aktu�ln� nevyu�ito)

                // Smy�ka pro vykreslen� ka�d�ho sloupce
                for (int i = 1; i < NormalizovaneHodnoty.Count; i++) // Za��n� od 1 (pozor: index 0 se nevyu��v�)
                {
                    int vyskaSloupce = Convert.ToInt32(NormalizovaneHodnoty[i]);

                    // Vykreslen� sloupce
                    g.FillRectangle(sb, x, height - vyskaSloupce, sirkaSloupce, vyskaSloupce);

                    // Vykreslen� ��sla indexu pod sloupec
                    g.DrawString(Convert.ToString(i), this.Font, sb, SIRKA, height - mezera / 2);

                    // Posun na dal�� sloupec
                    x += sirkaSloupce + mezera;
                    SIRKA += sirkaSloupce + mezera;
                }
            }
        }

        // Pomocn� funkce pro normalizaci hodnot do nov�ho rozsahu
        public static int Map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
    }
}
