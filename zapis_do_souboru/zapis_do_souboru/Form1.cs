using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace zapis_do_souboru
{
    public partial class Form1 : Form
    {
        SaveFileDialog oknosouboruuloz = new SaveFileDialog();
        OpenFileDialog oknosouboruopen = new OpenFileDialog();

        private StreamWriter soubor;

        // Proměnné pro práci s textem
        List<string> Dobre2;
        List<string> Obrat2;
        List<string> Seznam;
        int id; // pro výběr v ListBoxu

        public Form1()
        {
            InitializeComponent();
        }

        // Nastavení výchozí složky při spuštění formuláře
        private void Form1_Load(object sender, EventArgs e)
        {
            string slozka = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            oknosouboruuloz.InitialDirectory = slozka;
            oknosouboruopen.InitialDirectory = slozka;
        }

        // Zavření souboru při zavření aplikace
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (soubor != null)
            {
                soubor.Close();
                soubor = null;
            }
        }

        // Zápis testovacích dat do souboru s vybraným kódováním
        private void Zapis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Jmeno_souboru.Text))
            {
                MessageBox.Show("Zadejte jméno souboru.");
                return;
            }

            string jmeno = Jmeno_souboru.Text;
            Encoding kod = Encoding.UTF8;

            // Výběr kódování dle zaškrtnutí
            if (Win_CP_1250.Checked) kod = Encoding.GetEncoding(1250);
            else if (Win_CP_852.Checked) kod = Encoding.GetEncoding(852);
            else if (Latin_2.Checked) kod = Encoding.GetEncoding(28592);
            else if (UTF_8.Checked) kod = Encoding.UTF8;
            else if (UTF_16_L.Checked) kod = Encoding.Unicode;
            else if (UTF_16_B.Checked) kod = Encoding.BigEndianUnicode;

            using (StreamWriter sw = new StreamWriter(jmeno, false, kod))
            {
                sw.WriteLine("Prvni řádka");
                sw.WriteLine("Druha řádka");

                for (int i = 0; i <= 5; i++)
                {
                    int desetinásobek = 10 * i;
                    sw.WriteLine($"Desetinásobkem čísla {i} je číslo {desetinásobek}");
                }
            }

            MessageBox.Show("Hotovo");
        }

        // Načtení obsahu ze souboru
        private void Cti_Click(object sender, EventArgs e)
        {
            poleobsah.Text = "";

            if (File.Exists(Jmeno_souboru.Text))
            {
                string obsah = File.ReadAllText(Jmeno_souboru.Text);
                poleobsah.Text = obsah;
            }
            else
            {
                DialogResult odpoved = oknosouboruopen.ShowDialog();
                if (odpoved == DialogResult.OK)
                {
                    Jmeno_souboru.Text = oknosouboruopen.FileName;
                    string obsah = File.ReadAllText(oknosouboruopen.FileName);
                    poleobsah.Text = obsah;
                }
            }
        }

        // Otevření souboru – chyba OPRAVENA
        private void Otevritsoubor_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                Jmeno_souboru.Text = oknosouboruopen.FileName; // Původně špatně odkazoval na `oknosouboruuloz`
            }
        }

        // Přidání textu ze vstupu do souboru
        private void ZapisDoSouboru_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Jmeno_souboru.Text))
            {
                MessageBox.Show("Nejprve otevřete nebo zadejte název souboru.");
                return;
            }

            using (StreamWriter sw = new StreamWriter(Jmeno_souboru.Text, true, Encoding.UTF8))
            {
                sw.WriteLine(Psani.Text);
            }

            Psani.Clear();
        }

        // Výběr cesty pomocí uložení
        private void Prochazet_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruuloz.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                Jmeno_souboru.Text = oknosouboruuloz.FileName;
            }
        }

        // Načtení textu ze souboru pro obracení
        private void Hledej_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                Pozpat_text.Text = oknosouboruopen.FileName;

                if (File.Exists(oknosouboruopen.FileName))
                {
                    Dobre2 = new List<string>(File.ReadAllLines(oknosouboruopen.FileName));
                }
                else
                {
                    MessageBox.Show("Soubor neexistuje.");
                }
            }
        }

        private void Hledej2_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                Obrat_vysledek.Text = oknosouboruopen.FileName;

                if (File.Exists(oknosouboruopen.FileName))
                {
                    Obrat2 = new List<string>(File.ReadAllLines(oknosouboruopen.FileName));
                }
                else
                {
                    MessageBox.Show("Soubor neexistuje.");
                }
            }
        }

        // Obrácení obsahu načteného textu a zápis zpět
        private void Obrat_Click(object sender, EventArgs e)
        {
            if (Dobre2 == null || Obrat2 == null)
            {
                MessageBox.Show("Nejprve otevřete soubory pomocí tlačítek Hledej a Hledej2.");
                return;
            }

            string allText = string.Join(Environment.NewLine, Dobre2);
            char[] znaky = allText.ToCharArray();
            Array.Reverse(znaky);
            string reversed = new string(znaky);

            File.WriteAllText(Obrat_vysledek.Text, reversed);

            MessageBox.Show("Text byl úspěšně obrácen a uložen do souboru.");
        }

        // Načtení seznamu do listboxu
        private void Hledej_list_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                Jmeno_list_souboru.Text = oknosouboruopen.FileName;

                if (File.Exists(oknosouboruopen.FileName))
                {
                    Seznam = new List<string>(File.ReadAllLines(oknosouboruopen.FileName));
                }
                else
                {
                    MessageBox.Show("Soubor neexistuje.");
                }
            }
        }

        private void Nacti_list_Click(object sender, EventArgs e)
        {
            if (Seznam != null)
                listBox1.Items.AddRange(Seznam.ToArray());
        }

        // Přidání nového jména do listboxu a seznamu
        private void Vloz_jmeno_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Jmeno_do_list.Text))
            {
                if (Seznam == null)
                    Seznam = new List<string>();

                Seznam.Add(Jmeno_do_list.Text);
                listBox1.Items.Add(Jmeno_do_list.Text);
                Jmeno_do_list.Clear();
            }
            else
            {
                MessageBox.Show("Zadejte jméno.");
            }
        }

        // Posun jména nahoru v seznamu
        private void Posun_nahoru_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index > 0)
            {
                var temp = Seznam[index];
                Seznam[index] = Seznam[index - 1];
                Seznam[index - 1] = temp;

                listBox1.DataSource = null;
                listBox1.DataSource = Seznam;
                listBox1.SelectedIndex = index - 1;
            }
        }

        // Posun jména dolů v seznamu
        private void Posun_dolu_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index < Seznam.Count - 1)
            {
                var temp = Seznam[index];
                Seznam[index] = Seznam[index + 1];
                Seznam[index + 1] = temp;

                listBox1.DataSource = null;
                listBox1.DataSource = Seznam;
                listBox1.SelectedIndex = index + 1;
            }
        }

        // Smazání vybrané položky
        private void Smaz_jmeno_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && Seznam != null)
            {
                int index = listBox1.SelectedIndex;
                Seznam.RemoveAt(index);

                listBox1.DataSource = null;
                listBox1.DataSource = Seznam;
            }
            else
            {
                MessageBox.Show("Není vybrána žádná položka.");
            }
        }

        // Výběr položky – zobrazení zprávy
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vybrana = listBox1.SelectedItem;
            if (vybrana != null)
            {
                MessageBox.Show($"Vybraná položka: {vybrana.ToString()}");
                Smaz_jmeno.Enabled = true;
                id = listBox1.SelectedIndex;
            }
        }

        // Metoda zatím nepoužitá
        private void Vypis_nove_jmeno_Click(object sender, EventArgs e)
        {
            // Nepoužito
        }
    }
}
