// Import potřebných .NET knihoven
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Namespace pro aplikaci
namespace Editace_tabulkovych_dat
{
    // Hlavní třída formuláře
    public partial class Form1 : Form
    {
        // Ukládá název aktuálně otevřeného souboru
        string jmenoSouboru = null;

        // Indikátor, zda byly provedeny změny
        private bool zmeny = false;

        // Konstruktor formuláře
        public Form1()
        {
            InitializeComponent();
        }

        // Zavření aplikace s možností uložení změn
        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zmeny && MessageBox.Show("Chcete uložit změny před ukončením?", "Uložit změny", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                uložitCtrlSToolStripMenuItem_Click(sender, e);
            }
            Application.Exit();
        }

        // Otevření CSV souboru
        private void otevřítCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV soubory|*.csv|Všechny soubory|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            jmenoSouboru = openFileDialog1.FileName;
            try
            {
                if (File.Exists(jmenoSouboru))
                {
                    Encoding encoding = DetekovatKodovani(jmenoSouboru);
                    NacistData(jmenoSouboru, encoding);
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

        // Detekce kódování textového souboru
        private Encoding DetekovatKodovani(string cesta)
        {
            using (var reader = new StreamReader(cesta, Encoding.Default, true))
            {
                reader.Peek(); // Nutné pro aktivaci detekce kódování
                return reader.CurrentEncoding;
            }
        }

        // Načtení dat z CSV do DataGridView
        private void NacistData(string cesta, Encoding encoding)
        {
            dataGridView1.Rows.Clear();
            using (var reader = new StreamReader(cesta, encoding))
            {
                reader.ReadLine(); // Přeskočení hlavičky
                string radek;
                while ((radek = reader.ReadLine()) != null)
                {
                    var pole = radek.Split(';');
                    if (pole.Length >= 6)
                    {
                        dataGridView1.Rows.Add(pole);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Neimplementováno - může být smazáno
        }

        // Uložení změn do existujícího souboru
        private void uložitCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jmenoSouboru)) return;
            UlozitData(jmenoSouboru);
        }

        // Přidání nového prázdného řádku
        private void novýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            zmeny = true;
        }

        // Odstranění vybraného řádku
        private void odstranitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                zmeny = true;
            }
        }

        // Vyhledávání podle města
        private void mestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hledaneMesto = textBoxMesto.Text.Trim();
            if (string.IsNullOrEmpty(hledaneMesto))
            {
                MessageBox.Show("Zadejte město pro vyhledávání.");
                return;
            }

            List<string> vysledky = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string mesto = row.Cells[5].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(mesto) && mesto.Equals(hledaneMesto, StringComparison.OrdinalIgnoreCase))
                    {
                        string jmeno = row.Cells[0].Value?.ToString();
                        string prijmeni = row.Cells[1].Value?.ToString();
                        vysledky.Add($"{jmeno} {prijmeni}");
                    }
                }
            }

            MessageBox.Show(vysledky.Count > 0 ? "Zákazníci v " + hledaneMesto + ":\n" + string.Join("\n", vysledky) : "Žádní zákazníci v tomto městě nebyli nalezeni.");
        }

        // Tato metoda obsahuje chyby - přepíše obsah textBoxu při každé změně textu
        private void textBoxMesto_TextChanged(object sender, EventArgs e)
        {
            // Tento handler je chybný. Při každé změně textu nastavuje nový text.
            // Doporučuji odstranit nebo nahradit lepší logikou.
        }

        // Zobrazení aktuálního záznamu
        private void aktualniZaznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;
                MessageBox.Show($"Jméno: {row.Cells[0].Value}, Příjmení: {row.Cells[1].Value}, Město: {row.Cells[5].Value}");
            }
        }

        // Při načtení formuláře naplní combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pan");
            comboBox1.Items.Add("Paní");
        }

        private void odebratZeSeznamuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow remove in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(remove.Index);
            }
        }

        // Uložit jako novy soubor
        private void uložitJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "CSV soubory|*.csv" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                UlozitData(saveFileDialog.FileName);
            }
        }

        // Ukládání dat do CSV
        private void UlozitData(string cesta)
        {
            using (var writer = new StreamWriter(cesta, false, Encoding.UTF8))
            {
                writer.WriteLine("Jméno;Příjmení;Ulice;Číslo popisné;PSČ;Město;Email");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        writer.WriteLine(string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "")));
                    }
                }
            }
            zmeny = false;
        }

        // Výpočet počtu výskytů jména
        private void pocetJmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string jmeno = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                int count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[0].Value?.ToString() == jmeno);
                MessageBox.Show($"Počet výskytů jména {jmeno}: {count}");
            }
        }

        // Přidání aktuálního řádku do listBoxu
        private void přidatDoSeznamuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;
                listBoxSeznam.Items.Add($"{comboBox1.SelectedItem} {row.Cells[0].Value} {row.Cells[1].Value}, {row.Cells[2].Value} {row.Cells[3].Value}, {row.Cells[4].Value} {row.Cells[5].Value}");
            }
        }

        // Export obsahu listboxu do TXT
        private void exportDoSouborutxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Textové soubory|*.txt" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, listBoxSeznam.Items.Cast<string>());
            }
        }

        // Vložení emailu do aktuálního řádku
        private void vložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Nebyl vybrán žádný řádek.");
                return;
            }

            string adresa = Adresa_email.Text.Trim();
            string domena = Domena_emailu.Text.Trim();

            if (string.IsNullOrEmpty(adresa) || string.IsNullOrEmpty(domena))
            {
                MessageBox.Show("Vyplňte adresu i doménu.");
                return;
            }

            string email = adresa + "@" + domena;
            int emailColumnIndex = 6;

            if (dataGridView1.CurrentRow.Cells[emailColumnIndex].Value == null ||
                string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[emailColumnIndex].Value.ToString()))
            {
                dataGridView1.CurrentRow.Cells[emailColumnIndex].Value = email;
            }
            else
            {
                MessageBox.Show("Tento řádek již obsahuje e-mail.");
            }
        }

        // Zobrazení záznamů bez emailu
        private void chybějícíEmailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> chybejici = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && string.IsNullOrEmpty(row.Cells[6].Value?.ToString()))
                {
                    chybejici.Add($"{row.Cells[0].Value} {row.Cells[1].Value}, {row.Cells[5].Value}");
                }
            }
            MessageBox.Show(chybejici.Any() ? string.Join("\n", chybejici) : "Všechny emaily jsou vyplněny.");
        }

        // Export emailů do souboru
        private void exportEmailůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Textové soubory|*.txt" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var emails = dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow && !string.IsNullOrEmpty(row.Cells[6].Value?.ToString()))
                    .Select(row => row.Cells[6].Value.ToString());
                File.WriteAllLines(saveFileDialog.FileName, emails);
            }
        }

        // Smazání emailu z aktuálního řádku
        private void smazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[6].Value != null)
            {
                dataGridView1.CurrentRow.Cells[6].Value = null;
            }
            else
            {
                MessageBox.Show("Email ještě nebyl zadaný.");
            }
        }
    }
}