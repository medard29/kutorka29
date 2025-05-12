using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Test02
{
    public partial class Form1 : Form
    {
        // Dialogy pro otevření a uložení souboru
        SaveFileDialog oknosouboruuloz = new SaveFileDialog();
        OpenFileDialog oknosouboruopen = new OpenFileDialog();

        // Seznam závodníků
        List<string> Seznam;

        public Form1()
        {
            InitializeComponent(); // Inicializace komponent
        }

        // Tlačítko: Vybrat vstupní soubor (seznam závodníků)
        private void Hledat_soubor1_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                string cesta = oknosouboruopen.FileName;
                Vstupní_soubor.Text = cesta;

                // Ověření existence souboru
                if (File.Exists(cesta))
                {
                    // Načtení všech řádků do seznamu
                    Seznam = new List<string>(File.ReadAllLines(cesta));
                }
                else
                {
                    MessageBox.Show("Soubor neexistuje.");
                }
            }
        }

        // Tlačítko: Vybrat místo pro uložení výstupního souboru
        private void Hledat_soubor2_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruuloz.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                string cesta = oknosouboruuloz.FileName;
                Vystupni_soubor.Text = cesta;
            }
        }

        // Tlačítko: Vytvořit startovní listinu
        private void Vytvor_Click(object sender, EventArgs e)
        {
            // Kontrola, zda byl načten seznam
            if (Seznam == null || !Seznam.Any())
            {
                MessageBox.Show("Seznam závodníků je prázdný nebo nebyl načten.");
                return;
            }

            // Kontrola, zda byl zadán výstupní soubor
            if (string.IsNullOrWhiteSpace(Vystupni_soubor.Text))
            {
                MessageBox.Show("Vyberte výstupní soubor.");
                return;
            }

            try
            {
                // Kontrola platnosti vstupu pro hodiny, minuty a interval
                if (!int.TryParse(Hodiny.Text, out int starthodiny) ||
                    !int.TryParse(Minuty.Text, out int startminuty) ||
                    !int.TryParse(cas_mezi_zavodniky.Text, out int intervalMinutes))
                {
                    MessageBox.Show("Zadejte platné číselné hodnoty pro čas začátku a interval.");
                    return;
                }

                // Sestavení počátečního času startu
                DateTime startcas = new DateTime(1, 1, 1, starthodiny, startminuty, 0);
                TimeSpan interval = TimeSpan.FromMinutes(intervalMinutes);

                // Zamíchání seznamu závodníků
                Random random = new Random();
                List<string> nahodnySeznam = Seznam.OrderBy(x => random.Next()).ToList();

                // Uložení výstupního souboru se zapsáním časů
                using (StreamWriter writer = new StreamWriter(Vystupni_soubor.Text))
                {
                    foreach (string zavodnik in nahodnySeznam)
                    {
                        writer.WriteLine($"{startcas:HH:mm} - {zavodnik}");
                        startcas = startcas.Add(interval); // Posun času o interval
                    }
                }

                MessageBox.Show("Startovní listina byla úspěšně vytvořena.");
            }
            catch (Exception ex)
            {
                // Pokud dojde k chybě (např. zápis do souboru)
                MessageBox.Show($"Chyba při vytváření startovní listiny:\n{ex.Message}");
            }
        }

        // Událost při změně textu – nepoužito
        private void Vstupní_soubor_TextChanged(object sender, EventArgs e)
        {
            // Zatím neprovádí žádnou akci
        }
    }
}
