using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace menu
{
    public partial class Form1 : Form
    {
        // Vytvoření instance pro otevření souborového dialogu
        OpenFileDialog oknosouboruopen = new OpenFileDialog();

        // Konstruktor formuláře, inicializuje komponenty a DataGridView
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView(); // Inicializace DataGridView
        }

        // Inicializace DataGridView
        private void InitializeDataGridView()
        {
            // Nastavení tří sloupců v DataGridView
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Příjmení";
            dataGridView1.Columns[1].Name = "Jméno";
            dataGridView1.Columns[2].Name = "Místo bydliště";
        }

        // Metoda pro otevření souboru při kliknutí na položku v menu
        private void OtevritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nastavení filtrů pro otevření souboru
            oknosouboruopen.Filter = "CSV soubory|*.csv|Všechny soubory|*.*";
            DialogResult odpoved = oknosouboruopen.ShowDialog(); // Zobrazení dialogu pro výběr souboru

            // Kontrola, zda byla vybrána nějaká cesta k souboru
            if (odpoved == DialogResult.OK)
            {
                string cesta = oknosouboruopen.FileName;

                try
                {
                    // Kontrola, zda soubor existuje
                    if (File.Exists(cesta))
                    {
                        Encoding encoding = DetekovatKodovani(cesta); // Zjištění kódování souboru
                        NacistData(cesta, encoding); // Načtení dat ze souboru
                        MessageBox.Show($"Soubor byl úspěšně načten s kódováním: {encoding.EncodingName}");
                    }
                    else
                    {
                        MessageBox.Show("Soubor neexistuje.");
                    }
                }
                catch (Exception ex)
                {
                    // Zobrazení chybové zprávy v případě problému s načítáním souboru
                    MessageBox.Show($"Chyba při načítání souboru: {ex.Message}");
                }
            }
        }

        // Metoda pro detekci kódování souboru
        private Encoding DetekovatKodovani(string cesta)
        {
            // Otevření souboru v režimu čtení
            using (var reader = new FileStream(cesta, FileMode.Open, FileAccess.Read))
            {
                byte[] bom = new byte[4];
                reader.Read(bom, 0, 4); // Přečtení prvních čtyř bajtů pro detekci BOM (Byte Order Mark)

                // Porovnání prvních bajtů s kódováním souboru
                if (bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
                    return Encoding.UTF8; // UTF-8
                if (bom[0] == 0xFF && bom[1] == 0xFE)
                    return Encoding.Unicode; // Unicode (UTF-16 little endian)
                if (bom[0] == 0xFE && bom[1] == 0xFF)
                    return Encoding.BigEndianUnicode; // Unicode (UTF-16 big endian)
                if (bom[0] == 0x00 && bom[1] == 0x00 && bom[2] == 0xFE && bom[3] == 0xFF)
                    return Encoding.UTF32; // UTF-32

                return Encoding.Default; // Pokud BOM není detekován, použijeme výchozí kódování
            }
        }

        // Metoda pro načtení dat ze souboru a jejich zobrazení v DataGridView
        private void NacistData(string cesta, Encoding encoding)
        {
            // Vyčištění předchozích řádků v DataGridView
            dataGridView1.Rows.Clear();

            // Načtení všech řádků ze souboru (vynecháme první řádek, pokud obsahuje hlavičky)
            var radky = File.ReadAllLines(cesta, encoding)
                            .Skip(1) // Vynechání prvního řádku (obvykle hlavička)
                            .Select(r => r.Split(';')) // Rozdělení každého řádku podle středníku
                            .Where(pole => pole.Length >= 2) // Filtrace, aby řádky měly alespoň dvě hodnoty
                            .ToList();

            // Přidání načtených dat do DataGridView
            foreach (var pole in radky)
            {
                string prijmeni = pole[0]; // Přiřazení první hodnoty do "Příjmení"
                string jmeno = pole.Length > 1 ? pole[1] : "Neznámé"; // Pokud existuje druhá hodnota, použije se jako "Jméno", jinak se použije "Neznámé"
                string misto = pole.Length > 2 ? pole[2] : "Neznámé"; // Stejný princip pro "Místo bydliště"

                // Přidání hodnot do DataGridView
                dataGridView1.Rows.Add(prijmeni, jmeno, misto);
            }
        }
    }
}
