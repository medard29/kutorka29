using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Soubory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicializace formuláře
        }

        // Otevře dialog pro výběr souboru se jmény a uloží cestu do příslušného textboxu
        private void Hledej_Jmen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtJmena.Text = openFileDialog.FileName;
            }
        }

        // Otevře dialog pro výběr souboru s adresami a uloží cestu do příslušného textboxu
        private void Hledej_soub_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAdresy.Text = openFileDialog.FileName;
            }
        }

        // Hlavní funkce, která spojí soubory a uloží výstup
        private void Proved_Click(object sender, EventArgs e)
        {
            string jmenaFile = txtJmena.Text;
            string adresyFile = txtAdresy.Text;
            string vystupniFile = txtVystup.Text;

            // Kontrola, zda byl zadán výstupní soubor
            if (string.IsNullOrWhiteSpace(vystupniFile))
            {
                MessageBox.Show("Vyberte, kam uložit výstupní soubor.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kontrola, zda byly zadány vstupní soubory
            if (!File.Exists(jmenaFile) || !File.Exists(adresyFile))
            {
                MessageBox.Show("Zkontrolujte cesty ke vstupním souborům.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Načtení řádků ze souborů
                List<string> jmena = new List<string>(File.ReadAllLines(jmenaFile));
                List<string> adresy = new List<string>(File.ReadAllLines(adresyFile));

                // Kontrola, že oba soubory mají stejný počet řádků
                if (jmena.Count != adresy.Count)
                {
                    MessageBox.Show("Chyba: Počet řádků v souborech není stejný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Vytvoření výstupních řádků – spojení jména a adresy
                List<string> vystupniRadky = new List<string>();
                for (int i = 0; i < jmena.Count; i++)
                {
                    // Např. "Jan Novák, Praha 1"
                    vystupniRadky.Add($"{jmena[i]}, {adresy[i]}");
                }

                // Zapsání výsledku do výstupního souboru
                File.WriteAllLines(vystupniFile, vystupniRadky);

                MessageBox.Show("Výstupní soubor byl úspěšně vytvořen.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Pokud nastane chyba, zobrazí se informace pro uživatele
                MessageBox.Show($"Došlo k chybě při zpracování souborů:\n{ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Uživatel vybere cestu pro uložení výstupního souboru
        private void Misto_soub_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "txt"; // Předvolená přípona
            saveFileDialog.FileName = "Vysledky.txt"; // Návrh názvu souboru

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtVystup.Text = saveFileDialog.FileName;
            }
        }
    }
}
