using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulačka_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Nastavení události pro změnu textu v kalkulačce (TextChanged)
            Kalkulačka.TextChanged += Kalkulačka_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Funkce při načtení formuláře - v tomto případě není nic potřeba provádět
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Rozměry panelu pro vykreslení tlačítek
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;

            // Pole s hodnotami tlačítek
            string[,] klavesy = new string[,]
            {
                { "<---", "/", "*", "-" },
                { "7", "8", "9", "+" },
                { "4", "5", "6", "+" },
                { "1", "2", "3", "Enter" },
                { "0", "0", ".", "Enter" }
            };

            int radky = klavesy.GetLength(0);
            int sloupce = klavesy.GetLength(1);

            // Parametry pro mezery a rozměry tlačítek
            int mezera = 5; // mezera mezi tlačítky
            int ctverceVelX = (panelWidth - mezera * (sloupce + 1)) / sloupce; // šířka tlačítek
            int ctverceVelY = (panelHeight - mezera * (radky + 1)) / radky;    // výška tlačítek

            // Vykreslování tlačítek v cyklech pro řádky a sloupce
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < sloupce; j++)
                {
                    int x = mezera + j * (ctverceVelX + mezera); // X pozice tlačítka
                    int y = mezera + i * (ctverceVelY + mezera); // Y pozice tlačítka
                    int width = ctverceVelX;
                    int height = ctverceVelY;

                    // Změna velikosti tlačítka "+" a "Enter"
                    if (klavesy[i, j] == "+")
                    {
                        height = 2 * ctverceVelY + mezera;
                        if (i == 2) continue; // Přeskakuje tlačítko "+" v 3. řádku
                    }
                    else if (klavesy[i, j] == "Enter")
                    {
                        height = 2 * ctverceVelY + mezera; // Tlačítko Enter je větší
                        if (i == 4) y -= ctverceVelY + mezera; // Oprava pozice pro tlačítko Enter v posledním řádku
                    }
                    else if (klavesy[i, j] == "0" && j == 0)
                    {
                        width = 2 * ctverceVelX + mezera; // Tlačítko "0" je širší
                    }

                    // Vykreslení tlačítka
                    e.Graphics.FillRectangle(Brushes.LightGray, x, y, width, height);
                    e.Graphics.DrawRectangle(Pens.Black, x, y, width, height);

                    // Vykreslení textu na tlačítko
                    string text = klavesy[i, j];
                    SizeF textSize = e.Graphics.MeasureString(text, this.Font);
                    float textX = x + (width - textSize.Width) / 2;
                    float textY = y + (height - textSize.Height) / 2;
                    e.Graphics.DrawString(text, this.Font, Brushes.Black, textX, textY);

                    // Oprava pro tlačítko "0" (pokud je v prvním sloupci, přeskočíme jedno tlačítko)
                    if (klavesy[i, j] == "0" && j == 0)
                    {
                        j++; // Přeskočíme druhou "0"
                    }
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Pole tlačítek a rozměry zůstávají stejné
            string[,] klavesy = new string[,]
            {
                { "<---", "/", "*", "-" },
                { "7", "8", "9", "+" },
                { "4", "5", "6", "+" },
                { "1", "2", "3", "Enter" },
                { "0", "0", ".", "Enter" }
            };

            int radky = klavesy.GetLength(0);
            int sloupce = klavesy.GetLength(1);

            int mezera = 5;
            int ctverceVelX = (panel1.Width - mezera * (sloupce + 1)) / sloupce;
            int ctverceVelY = (panel1.Height - mezera * (radky + 1)) / radky;

            // Cyklus pro kontrolu, které tlačítko bylo stisknuto
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < sloupce; j++)
                {
                    int x = mezera + j * (ctverceVelX + mezera);
                    int y = mezera + i * (ctverceVelY + mezera);
                    int width = ctverceVelX;
                    int height = ctverceVelY;

                    if (klavesy[i, j] == "+")
                    {
                        height = 2 * ctverceVelY + mezera;
                        if (i == 2) continue;
                    }
                    else if (klavesy[i, j] == "Enter")
                    {
                        height = 2 * ctverceVelY + mezera;
                        if (i == 4) y -= ctverceVelY + mezera;
                    }
                    else if (klavesy[i, j] == "0" && j == 0)
                    {
                        width = 2 * ctverceVelX + mezera;
                    }

                    // Kontrola, zda uživatel kliknul na některé tlačítko
                    if (e.X >= x && e.X <= x + width && e.Y >= y && e.Y <= y + height)
                    {
                        string stisknutaKlavesa = klavesy[i, j];

                        // Funkce pro stisknutí tlačítek a výpočet výsledku
                        if (stisknutaKlavesa == "<---")
                        {
                            if (!string.IsNullOrEmpty(Kalkulačka.Text))
                            {
                                Kalkulačka.Text = Kalkulačka.Text.Substring(0, Kalkulačka.Text.Length - 1);
                            }
                        }
                        else if (stisknutaKlavesa == "Enter")
                        {
                            string vysledek = CalculateResult(Kalkulačka.Text);
                            Kalkulačka.Text = vysledek;
                        }
                        else
                        {
                            Kalkulačka.Text += stisknutaKlavesa;
                        }

                        return;
                    }
                }
            }
        }

        private bool IsValidSyntax(string input)
        {
            // Kontrola syntaktických chyb pomocí regulárního výrazu
            string pattern = @"^\s*-?\d+(\.\d+)?\s*[\+\-\*/]\s*-?\d+(\.\d+)?\s*$";
            return Regex.IsMatch(input, pattern);
        }

        private string CalculateResult(string input)
        {
            try
            {
                if (!IsValidSyntax(input))
                {
                    return "Chyba syntaxe";
                }

                Match match = Regex.Match(input, @"^\s*(\-?\d+(\.\d+)?)\s*([\+\-\*/])\s*(\-?\d+(\.\d+)?)\s*$");
                if (!match.Success)
                {
                    return "Chyba syntaxe";
                }

                double cislo1 = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                double cislo2 = double.Parse(match.Groups[4].Value, CultureInfo.InvariantCulture);
                string operace = match.Groups[3].Value;

                double vysledek = 0;
                switch (operace)
                {
                    case "+":
                        vysledek = cislo1 + cislo2;
                        break;
                    case "-":
                        vysledek = cislo1 - cislo2;
                        break;
                    case "*":
                        vysledek = cislo1 * cislo2;
                        break;
                    case "/":
                        if (cislo2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        vysledek = cislo1 / cislo2;
                        break;
                    default:
                        throw new InvalidOperationException("Neplatná operace");
                }

                return vysledek.ToString(CultureInfo.InvariantCulture);
            }
            catch
            {
                return "Chyba syntaxe";
            }
        }

        private void Kalkulačka_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidSyntax(Kalkulačka.Text))
            {
                // Zde by bylo dobré přidat zpětnou vazbu pro uživatele
            }
            else
            {
                // Pokud je syntaxe správná, není třeba nic provádět
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kalkulačka.Text = "";
        }
    }
}
