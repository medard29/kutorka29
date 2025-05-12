using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sportka
{
    public partial class Form1 : Form
    {
        OpenFileDialog oknosouboruopen = new OpenFileDialog(); // Dialog pro otevření souboru s taženými čísly
        int[] vybranaCisla = new int[6]; // Pole pro uživatelem vybraná čísla (TextBox7–12)
        int[] nactenaCisla;              // Pole pro čísla načtená ze souboru (TextBox1–6)
        int pocetVybranych = 0;         // Kolik čísel uživatel zatím vybral
        const int MaxNumbers = 6;       // Maximální počet čísel, které lze vybrat
        const int MaxRange = 49;        // Nejvyšší číslo, které lze vybrat (1–49)

        public Form1()
        {
            InitializeComponent(); // Inicializace komponent formuláře
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nastaví výchozí adresář pro výběr souboru na Dokumenty uživatele
            oknosouboruopen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            vykresliMrizku(); // První vykreslení prázdné mřížky
        }

        // Znovu překreslí panel mřížky
        private void vykresliMrizku()
        {
            panel1.Invalidate(); // Vyvolá Paint událost -> překreslení mřížky
        }

        // Kreslí samotnou mřížku 7x7 čtverců (celkem 49)
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int ctvercevel = panel1.Width / 7; // Velikost jednoho čtverce
            int aktualni = 1; // Počáteční číslo (1–49)

            for (int i = 0; i < MaxRange; i++)
            {
                int x = (i % 7) * ctvercevel;       // Sloupec (x)
                int y = (i / 7) * ctvercevel;       // Řádek (y)

                // Kontrola, jestli je číslo vybrané uživatelem
                bool jeVybrane = vybranaCisla.Contains(aktualni);
                // Kontrola, jestli je číslo mezi taženými ze souboru
                bool jeNactene = nactenaCisla != null && nactenaCisla.Contains(aktualni);

                // Barva čtverce podle stavu
                Color fillColor;
                if (jeVybrane && jeNactene)
                    fillColor = Color.LightGreen;     // Číslo bylo vybráno i taženo
                else if (jeVybrane)
                    fillColor = Color.LightBlue;      // Jen vybráno uživatelem
                else if (jeNactene)
                    fillColor = Color.Red;            // Jen taženo
                else
                    fillColor = Color.White;          // Jinak bílé

                // Vyplnění čtverce barvou
                using (Brush brush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillRectangle(brush, x, y, ctvercevel, ctvercevel);
                }

                // Oranžový rámeček
                e.Graphics.DrawRectangle(new Pen(Color.Orange, 2), x, y, ctvercevel, ctvercevel);

                // Vykreslení čísla uprostřed čtverce
                string number = aktualni.ToString();
                SizeF textSize = e.Graphics.MeasureString(number, this.Font);
                float textX = x + (ctvercevel - textSize.Width) / 2;
                float textY = y + (ctvercevel - textSize.Height) / 2;
                e.Graphics.DrawString(number, this.Font, Brushes.Black, textX, textY);

                aktualni++;
            }
        }

        // Reaguje na kliknutí do mřížky – výběr čísla uživatelem
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int ctverceVel = panel1.Width / 7; // Velikost jednoho čtverce
            int poleY = e.Y / ctverceVel;
            int poleX = e.X / ctverceVel;
            int cisloVPoli = poleY * 7 + poleX + 1; // Výpočet čísla v čtverci

            // Pokud ještě nejsou všechna čísla vybrána a číslo nebylo vybrané
            if (pocetVybranych < MaxNumbers && !vybranaCisla.Contains(cisloVPoli))
            {
                vybranaCisla[pocetVybranych] = cisloVPoli;
                Controls["textBox" + (pocetVybranych + 7)].Text = cisloVPoli.ToString(); // TextBox7–12
                pocetVybranych++;
                vykresliMrizku();  // Překreslí mřížku
            }
            else if (pocetVybranych >= MaxNumbers)
            {
                MessageBox.Show("Můžeš vybrat max 6 čísel");
            }
        }

        // Načtení čísel ze souboru
        private void Nacti_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                string Jmeno_souboru = oknosouboruopen.FileName;
                try
                {
                    string obsah = File.ReadAllText(Jmeno_souboru); // Načte celý obsah souboru
                    var strCisla = obsah
                        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries) // Rozdělí na části
                        .Select(c => c.Trim())
                        .Distinct() // Odstraní duplicitní čísla
                        .ToArray();

                    if (strCisla.Length != MaxNumbers)
                    {
                        MessageBox.Show("Soubor musí obsahovat přesně 6 čísel");
                        return;
                    }

                    // Převede stringy na int
                    nactenaCisla = strCisla.Select(c => int.Parse(c)).ToArray();

                    // Kontrola rozsahu čísel
                    foreach (int cislo in nactenaCisla)
                    {
                        if (cislo <= 0 || cislo > MaxRange)
                        {
                            MessageBox.Show("Čísla musí být od 1 do 49");
                            return;
                        }
                    }

                    // Zobrazí čísla v TextBox1–6
                    for (int i = 0; i < MaxNumbers; i++)
                    {
                        Controls["textBox" + (i + 1)].Text = nactenaCisla[i].ToString();
                    }

                    vykresliMrizku(); // Aktualizace grafiky
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při čtení souboru: " + ex.Message);
                }
            }
        }

        // Povolení tlačítka „Načti“ až po výběru všech 6 čísel
        private void Vybrat_Click(object sender, EventArgs e)
        {
            if (vybranaCisla != null && vybranaCisla.Length == 6 && vybranaCisla.All(c => c > 0))
            {
                Nacti.Enabled = true; // Povolit načítání ze souboru
            }
            else
            {
                Nacti.Enabled = false;
                MessageBox.Show("Musíš vybrat všech 6 čísel, aby bylo možné načíst soubor.");
            }
        }
    }
}
