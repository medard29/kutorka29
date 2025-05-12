using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kopáč_v2
{
    public partial class Form1 : Form
    {
        // Seznam pro uchování výšek jednotlivých "sloupců"
        List<int> Kopaci = new List<int>();

        // Konstruktor formuláře, inicializuje komponenty
        public Form1()
        {
            InitializeComponent();
        }

        // Metoda pro vykreslení grafu na panelu
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Získání grafiky pro vykreslení
            Graphics g = e.Graphics;
            // Vytvoření pera pro vykreslování čar
            Pen p = new Pen(Color.Black);
            // Vytvoření štětce pro vyplnění sloupců
            SolidBrush sb = new SolidBrush(Color.Black);

            // Kontrola, zda je seznam Kopaci (obsahuje nějaké hodnoty)
            if (Kopaci != null && Kopaci.Any())
            {
                // Výška panelu - 10 (pro okraj)
                int height = panel1.Height - 10;
                // Šířka panelu
                int width = panel1.Width;

                // Počet sloupců = počet hodnot v seznamu Kopaci
                int sloupcu = Kopaci.Count;
                // Mezera mezi sloupci
                int mezera = 10;
                // Vypočítání šířky jednoho sloupce
                int sirkaSloupce = (width - (sloupcu + 1) * mezera) / sloupcu;

                // Počáteční pozice pro x (začneme od levého okraje)
                int x = mezera;
                // Pozice pro zobrazování čísel na vrcholu sloupců
                int SIRKA = (x + sirkaSloupce) / 2;

                // Vypočítání průměru hodnot v seznamu
                double prumer = Kopaci.Average();

                // Vykreslení sloupců
                for (int i = 0; i < Kopaci.Count; i++)
                {
                    int vyskaSloupce = Kopaci[i]; // Výška aktuálního sloupce
                    // Vyplnění sloupce
                    g.FillRectangle(sb, x, height - vyskaSloupce, sirkaSloupce, vyskaSloupce);
                    // Vykreslení čísla na vrcholu sloupce (pro identifikaci)
                    g.DrawString(Convert.ToString(i + 1), this.Font, sb, SIRKA, height - mezera / 2);
                    // Posunutí pozice pro další sloupec
                    x += sirkaSloupce + mezera;
                    // Aktualizace pozice pro zobrazení čísel
                    SIRKA += sirkaSloupce + mezera;
                }

                // Vykreslení čáry průměru
                int prumerY = height - (int)prumer;
                g.DrawLine(p, 0, prumerY, panel1.Width, prumerY);
            }
        }

        // Metoda pro přidání nové hodnoty do seznamu Kopaci při kliknutí na tlačítko
        private void button1_Click(object sender, EventArgs e)
        {
            // Pokusíme se přeformátovat text z textového pole na celé číslo
            if (int.TryParse(Kopac_hodnota.Text, out int hodnota))
            {
                // Pokud je hodnota platná, přidáme ji do seznamu
                Kopaci.Add(hodnota);
                // Invalidate panelu pro jeho přetření a vykreslení nového grafu
                panel1.Invalidate();
            }
            else
            {
                // Pokud není hodnota platná, zobrazíme hlášku
                MessageBox.Show("Zadej platné číslo.");
            }
        }
    }
}
