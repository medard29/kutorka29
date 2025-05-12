// Import potřebných knihoven pro práci s GUI, textem, daty atd.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Definice jmenného prostoru aplikace
namespace Posílání_paketů__polí_2_
{
    public partial class Form1 : Form
    {
        // Deklarace proměnných používaných v aplikaci
        string[] Paket;       // Pole pro uložené pakety
        string[] Defpaket;    // Pole pro přijaté a správně uspořádané pakety
        char[] Pismena;       // Pole jednotlivých znaků ze vstupního textu
        int cykly;            // Počet znaků ve zpracovávaném paketu
        int poradi_pismena = 1; // Pořadí znaku (začíná od 1)
        string Pomoc;         // Pomocný string pro skládání paketu
        string Pomoc2;        // Záložní kopie aktuálního paketu
        int index;            // Index aktuálního paketu
        string mezera = " ";  // Řetězec s mezerou (nepoužitý)
        int konec2 = 0;       // Počet znaků na konci (zřejmě pro doplnění podtržítek)
        int Cislo;            // Celkový počet paketů
        int pocet;            // Velikost jednoho paketu (zadaná uživatelem)

        public Form1()
        {
            InitializeComponent(); // Inicializace GUI komponent
        }

        // Tlačítko pro vytvoření paketů z textu
        private void button1_Click(object sender, EventArgs e)
        {
            pocet = Convert.ToInt32(Velikost.Text); // Získání velikosti paketu od uživatele
            string veta = Data.Text;                // Načtení textu, který se má rozdělit
            int konec = 0;                          // Příznak konce

            try
            {
                // Inicializace polí
                Pismena = new char[veta.Length + 2];
                Paket = new string[(int)Math.Ceiling((double)veta.Length / pocet) + 1];
                Defpaket = new string[Paket.Length];
                Pismena = veta.ToArray(); // Převedení textu na pole znaků
                Cislo = Pismena.Length / pocet; // Počet kompletních paketů

                // Smyčka přes každý znak + doplnění paketů podtržítky
                for (int i = 0; i <= veta.Length + pocet; i++)
                {
                    if (cykly == pocet)
                    {
                        index++; // Posun na další paket
                        if (index >= Cislo) { }
                        else { Pomoc2 = ""; } // Reset záložní kopie

                        Paket[index] = Pomoc; // Uložení hotového paketu
                        Pomoc = "";           // Vymazání pomocné proměnné

                        if (i >= veta.Length)
                        {
                            konec = 1; // Pokud jsme na konci vstupu
                        }

                        // Výpis paketu do výstupního textového pole
                        Vypis_poli.Text += Convert.ToString(index) + ". " +
                                           Convert.ToString(poradi_pismena) + " " +
                                           Convert.ToString(Paket[index]) + " " +
                                           Convert.ToString(konec) + Environment.NewLine;

                        cykly = 0;
                        poradi_pismena = i + 1;

                        // Začátek dalšího paketu
                        Pomoc += Convert.ToString(Pismena[i]);
                        Pomoc2 += Convert.ToString(Pismena[i]);
                    }
                    else
                    {
                        if (i >= veta.Length)
                        {
                            Pomoc += "_"; // Pokud už nejsou znaky, doplň podtržítko
                            konec = 1;
                            konec2++;
                        }
                        else
                        {
                            // Jinak přidej znak do aktuálního paketu
                            Pomoc += Convert.ToString(Pismena[i]);
                            Pomoc2 += Convert.ToString(Pismena[i]);
                        }
                    }

                    cykly++; // Zvýší počet znaků v paketu
                }
            }
            catch
            {
                // V případě chyby se nic nestane
            }
        }

        // Tlačítko pro zobrazení jednoho paketu a rekonstrukci zprávy
        private void button2_Click(object sender, EventArgs e)
        {
            Obracene.Text = ""; // Vymazání výstupního pole

            try
            {
                // Smyčka přes všechny pakety
                for (int i = 0; i <= Paket.Length; i++)
                {
                    if (i == Convert.ToInt32(cislo.Text))
                    {
                        Jeden_paket.Text = Paket[i]; // Zobrazení vybraného paketu

                        // Pokud je to poslední paket, použij Pomoc2
                        if (i == index)
                        {
                            Defpaket[i] = Pomoc2;
                        }
                        else
                        {
                            Defpaket[i] = Paket[i];
                        }
                    }
                }

                // Rekonstrukce zprávy z přijatých paketů
                for (int i = 1; i <= Defpaket.Length; i++)
                {
                    if (Defpaket[i] == null)
                    {
                        // Pokud paket chybí, doplň hvězdičky
                        for (int j = 0; j < pocet; j++) { Obracene.Text += "*"; }
                    }
                    else
                    {
                        Obracene.Text += Defpaket[i];
                    }
                }
            }
            catch
            {
                // V případě chyby se nic neděje
            }

            // Pokud se přijatý text rovná originálu, informuj uživatele
            if (Data.Text == Obracene.Text)
            {
                MessageBox.Show("Dorazil celý paket");
            }
        }

        // Tlačítko pro výpis všech (definovaných) paketů
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder(); // Pro efektivní skládání textu

            try
            {
                for (int i = 1; i < Defpaket.Length; i++)
                {
                    // Vypiš paket nebo hvězdičky, pokud chybí
                    message.AppendLine($"{i}.{(Defpaket[i] == null ? new string('*', pocet) : Defpaket[i])}");
                }

                // Zobrazení výsledku v MessageBoxu
                MessageBox.Show(message.ToString());
            }
            catch
            {
                // Tiché zachycení chyb
            }
        }
    }
}
