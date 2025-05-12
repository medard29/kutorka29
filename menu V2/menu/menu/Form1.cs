// Importování potřebných knihoven
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace menu
{
    // Definice hlavního formuláře aplikace
    public partial class Form1 : Form
    {
        // Dialogové okno pro výběr souboru
        OpenFileDialog oknosouboruopen = new OpenFileDialog();

        // Cesta k aktuálně otevřenému souboru
        private string aktualniSoubor;

        // Příznak, jestli byly provedeny změny
        private bool zmeny = false;

        // Konstruktor formuláře
        public Form1()
        {
            InitializeComponent();             // Inicializace komponent formuláře
            InitializeDataGridView();         // Nastavení tabulky (DataGridView)
        }

        // Inicializace tabulky a nastavení jejích sloupců
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3; // Počet sloupců
            dataGridView1.Columns[0].Name = "Příjmení";
            dataGridView1.Columns[1].Name = "Jméno";
            dataGridView1.Columns[2].Name = "Místo bydliště";

            // Událost pro detekci změny hodnoty v buňce
            dataGridView1.CellValueChanged += (s, e) => zmeny = true;
        }

        // Otevření CSV souboru pomocí dialogu
        private void OtevritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oknosouboruopen.Filter = "CSV soubory|*.csv|Všechny soubory|*.*"; // Filtr souborů
            DialogResult odpoved = oknosouboruopen.ShowDialog(); // Zobrazení dialogu

            if (odpoved == DialogResult.OK) // Pokud uživatel vybral soubor
            {
                aktualniSoubor = oknosouboruopen.FileName; // Uložení cesty
                try
                {
                    if (File.Exists(aktualniSoubor)) // Ověření existence
                    {
                        Encoding encoding = DetekovatKodovani(aktualniSoubor); // Detekce kódování
                        NacistData(aktualniSoubor, encoding); // Načtení dat
                        MessageBox.Show($"Soubor byl úspěšně načten s kódováním: {encoding.EncodingName}");
                        zmeny = false;
                    }
                    else
                    {
                        MessageBox.Show("Soubor neexistuje.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při načítání souboru: {ex.Message}");
                }
            }
        }

        // Detekuje kódování textového souboru
        private Encoding DetekovatKodovani(string cesta)
        {
            using (var reader = new StreamReader(cesta, Encoding.Default, true))
            {
                reader.Peek(); // Trigger pro detekci kódování
                return reader.CurrentEncoding; // Vrátí zjištěné kódování
            }
        }

        // Načte data z CSV souboru do tabulky
        private void NacistData(string cesta, Encoding encoding)
        {
            dataGridView1.Rows.Clear(); // Vymazání předchozích řádků

            using (var reader = new StreamReader(cesta, encoding))
            {
                reader.ReadLine(); // Přeskočení hlavičky
                string radek;
                while ((radek = reader.ReadLine()) != null) // Čtení po řádcích
                {
                    var pole = radek.Split(';'); // Rozdělení podle středníku
                    if (pole.Length >= 2)
                    {
                        string prijmeni = pole[0];
                        string jmeno = pole.Length > 1 ? pole[1] : "Neznámé";
                        string misto = pole.Length > 2 ? pole[2] : "Neznámé";

                        // Přidání dat do tabulky
                        dataGridView1.Rows.Add(prijmeni, jmeno, misto);
                    }
                }
            }
        }

        // Zobrazení aktuálně vybraného záznamu v tabulce
        private void aktuálníZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;
                MessageBox.Show($"Příjmení: {row.Cells[0].Value}, Jméno: {row.Cells[1].Value}, Místo: {row.Cells[2].Value}");
            }
        }

        // Spočítá kolikrát se v tabulce vyskytuje stejné jméno jako ve vybraném řádku
        private void početJmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string jmeno = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
                int count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[1].Value?.ToString() == jmeno);
                MessageBox.Show($"Počet výskytů jména {jmeno}: {count}");
            }
        }

        // Vyhledání osob podle města zadaného v textovém poli "Mesto"
        private void městaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hledaneMesto = Mesto.Text.Trim();
            List<string> vysledky = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[2].Value?.ToString() == hledaneMesto)
                {
                    vysledky.Add($"{row.Cells[1].Value} {row.Cells[0].Value}"); // Přidání do výsledků
                }
            }

            MessageBox.Show(vysledky.Any() ? string.Join("\n", vysledky) : "Žádní zákazníci nebyli nalezeni.");
        }

        // Uloží data do původního souboru
        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(aktualniSoubor)) return;
            UlozitData(aktualniSoubor);
        }

        // Uloží data do nového souboru podle výběru uživatele
        private void uložitJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "CSV soubory|*.csv" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                UlozitData(saveFileDialog.FileName);
            }
        }

        // Uloží data z tabulky do souboru jako CSV
        private void UlozitData(string cesta)
        {
            using (var writer = new StreamWriter(cesta, false, Encoding.UTF8))
            {
                writer.WriteLine("Příjmení;Jméno;Místo bydliště"); // Hlavička
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Zápis hodnot oddělených středníkem
                        writer.WriteLine(string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "")));
                    }
                }
            }
            zmeny = false; // Reset příznaku změn
        }

        // Zavření aplikace s nabídkou uložení změn
        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zmeny && MessageBox.Show("Chcete uložit změny před ukončením?", "Uložit změny", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                uložitToolStripMenuItem_Click(sender, e);
            }
            Application.Exit(); // Ukončení aplikace
        }

        // Přidá nový prázdný řádek do tabulky
        private void novýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(); // Přidání řádku
            zmeny = true;             // Označení změny
        }

        // Odstraní vybraný řádek z tabulky
        private void odstranitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                zmeny = true;
            }
        }
    }
}
