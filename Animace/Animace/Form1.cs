using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Animace
{
    public partial class Form1 : Form
    {
        int[] Rych_sloup;    // Pole rychlostí růstu pro každý sloupec (v pixelech za krok)
        int Mezer;           // Mezery mezi sloupci
        int pocet;           // Počet zadaných sloupců
        int[] Sloupec;       // Cílové výšky sloupců
        int[] Vykres;        // Aktuální vykreslené výšky sloupců
        bool growing;        // Určuje směr (true = růst, false = pokles)

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int sir = 0; // Šířka jednoho sloupce
            int zac = 0; // X pozice začátku sloupce
            SolidBrush blueBrush = new SolidBrush(Color.Blue); // Modrý štětec pro sloupce

            try
            {
                // Výpočet šířky sloupce podle počtu a šířky panelu
                sir = (panel1.Width - (Mezer * (pocet + 1))) / pocet;

                for (int i = 0; i < Vykres.Length; i++)
                {
                    int vyska = Vykres[i]; // Aktuální výška
                    int heightPos = panel1.Height - vyska; // Y pozice odspodu

                    // Vykreslení sloupce
                    e.Graphics.FillRectangle(blueBrush, zac + Mezer, heightPos, sir, vyska);

                    // Posun na další sloupec
                    zac += sir + Mezer;
                }
            }
            catch
            {
                // Při chybě nic nedělej (např. dělení nulou při 0 sloupcích)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Načtení hodnot z jednotlivých NumericUpDown
            NumericUpDown[] numericUpDowns = { Sloup1, Sloup2, Sloup3, Sloup4, Sloup5, Sloup6, Sloup7, Sloup8, Sloup9, Sloup10 };
            pocet = 0;

            foreach (var num in numericUpDowns)
            {
                if (num.Value != 0)
                {
                    pocet++;
                }
            }

            // Inicializace polí
            Sloupec = new int[pocet];
            Rych_sloup = new int[pocet];
            Vykres = new int[pocet];
            int index = 0;

            foreach (var num in numericUpDowns)
            {
                // Ošetření příliš vysoké hodnoty (větší než výška panelu)
                if (num.Value > panel1.Height)
                {
                    num.Value = panel1.Height - panel1.Height / 100;
                }

                if (num.Value != 0)
                {
                    Sloupec[index] = (int)num.Value;
                    Vykres[index] = 0; // Startujeme od 0 (spodní výška)
                    index++;
                }
            }

            Mezer = pocet + 1;

            try
            {
                // Výpočet intervalu timeru podle zadané rychlosti (cykly za minutu)
                int rychlostHodnota = (int)Rychlost.Value;

                if (rychlostHodnota <= 0)
                {
                    MessageBox.Show("Rychlost musí být větší než 0.");
                    return;
                }

                // Trvání celého cyklu v milisekundách (nahoru + dolů)
                int casNaCelyCyklus = 60000 / rychlostHodnota;

                // Rozdělíme cyklus na 100 kroků (50 nahoru, 50 dolů)
                int krokInterval = casNaCelyCyklus / 100;

                timer1.Interval = Math.Max(10, krokInterval); // min. 10 ms pro stabilní animaci
            }
            catch
            {
                MessageBox.Show("Neplatná hodnota rychlosti.");
                return;
            }

            // Výpočet kolik pixelů má sloupec vyrůst při každém kroku (jen na fázi růstu)
            for (int i = 0; i < Rych_sloup.Length; i++)
            {
                Rych_sloup[i] = Math.Max(1, Sloupec[i] / 50); // alespoň 1 pixel za krok
            }

            growing = true; // začínáme růstem
            timer1.Start();
            panel1.Invalidate(); // překreslení
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Vykres.Length; i++)
            {
                if (growing)
                {
                    // Růst
                    Vykres[i] += Rych_sloup[i];

                    if (Vykres[i] >= Sloupec[i])
                    {
                        Vykres[i] = Sloupec[i];
                    }
                }
                else
                {
                    // Pokles
                    Vykres[i] -= Rych_sloup[i];

                    if (Vykres[i] <= 0)
                    {
                        Vykres[i] = 0;
                    }
                }
            }

            // Kontrola přepnutí fáze z růstu na pokles
            if (growing && Vykres.Select((v, i) => v >= Sloupec[i]).All(b => b))
            {
                growing = false;
            }
            // Přepnutí z poklesu na růst
            else if (!growing && Vykres.All(v => v <= 0))
            {
                growing = true;
            }

            panel1.Invalidate(); // překreslení
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // zastavení animace
        }
    }
}
