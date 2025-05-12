using System; // Importuje základní třídy systému, jako např. DateTime, String, Exception apod.
using System.Collections.Generic; // Importuje kolekce jako List<T> pro práci s dynamickými seznamy
using System.Globalization; // Pro práci s kulturami a formáty dat (např. formáty data)
using System.IO; // Poskytuje metody pro práci se soubory, jako např. čtení a zápis
using System.Linq; // LINQ pro manipulaci s kolekcemi (např. filtrování a výběr dat)
using System.Text; // Poskytuje metody pro kódování a dekódování textu
using System.Windows.Forms; // Pro práci s komponentami Windows Forms (např. tlačítka, textové boxy apod.)

namespace Filtr_csv
{
    public partial class Form1 : Form
    {
        // Definice proměnných pro práci se soubory a seznamem dat
        OpenFileDialog oknosouboruopen = new OpenFileDialog(); // Dialog pro výběr souboru
        List<string> Seznam = new List<string>(); // Seznam pro uložení řádků souboru CSV

        public Form1()
        {
            InitializeComponent(); // Inicializace komponent formuláře (vytvořeno návrhářem)
        }

        // Událost kliknutí na tlačítko "Prochazet" (Pro výběr souboru)
        private void Prochazet_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog(); // Otevření dialogového okna pro výběr souboru
            if (odpoved == DialogResult.OK) // Pokud uživatel vybere soubor a klikne na OK
            {
                string Pomoc = oknosouboruopen.FileName; // Uložení cesty k souboru
                textBoxcsv.Text = Pomoc; // Zobrazení cesty v textovém poli

                try
                {
                    // Kontrola existence souboru
                    if (File.Exists(Pomoc))
                    {
                        // Načítání všech řádků souboru do seznamu
                        Seznam = File.ReadAllLines(Pomoc, Encoding.Default).ToList();
                        MessageBox.Show("Soubor byl úspěšně načten."); // Úspěšné načtení
                    }
                    else
                    {
                        MessageBox.Show("Soubor neexistuje."); // Pokud soubor neexistuje
                    }
                }
                catch (Exception ex)
                {
                    // Zachycení výjimky, pokud dojde k chybě při čtení souboru
                    MessageBox.Show($"Chyba při načítání souboru: {ex.Message}");
                }
            }
        }

        // Událost kliknutí na tlačítko "Vypsat" (pro filtrování a výpis dat)
        private void Vypsat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Vymazání předchozích výsledků ve ListBoxu
            DateTime dnes = DateTime.Now.Date; // Aktuální datum (používáme pouze datum bez času)
            DateTime zitra = dnes.AddDays(1); // Zítřejší datum

            // Procházení seznamu načtených řádků (skipping první řádek, který je pravděpodobně hlavička)
            foreach (var radek in Seznam.Skip(1))
            {
                try
                {
                    var data = radek.Split(';'); // Rozdělení řádku podle středníků (CSV)

                    if (data.Length >= 4) // Očekáváme alespoň 4 hodnoty (příjmení, jméno, datum narození)
                    {
                        string prijmeni = data[1]; // Příjmení
                        string jmeno = data[2]; // Jméno
                        string datumNarozeni = data[3]; // Datum narození

                        // Pokus o konverzi data na formát DateTime
                        if (DateTime.TryParseExact(datumNarozeni,
                            new[] { "dd.MM.yyyy", "d.M.yyyy", "yyyy.MM.dd", "MM.dd", "dd.MM" },
                            CultureInfo.InvariantCulture, // Použití invariantní kultury (pro globální formáty)
                            DateTimeStyles.None, out DateTime datum))
                        {
                            bool vypis = false;

                            // Kontrola, zda datum odpovídá dnešku
                            if (Dnesek.Checked && datum.Month == dnes.Month && datum.Day == dnes.Day)
                            {
                                vypis = true;
                            }
                            // Kontrola, zda datum odpovídá zítřku
                            else if (Zitrek.Checked && datum.Month == zitra.Month && datum.Day == zitra.Day)
                            {
                                vypis = true;
                            }
                            // Kontrola, zda datum odpovídá uživatelem zadanému datu
                            else if (Jindy.Checked)
                            {
                                if (DateTime.TryParseExact(textBox1.Text, new[] { "dd.MM", "MM.dd" },
                                    CultureInfo.InvariantCulture,
                                    DateTimeStyles.None, out DateTime zadaneDatum))
                                {
                                    if (datum.Month == zadaneDatum.Month && datum.Day == zadaneDatum.Day)
                                    {
                                        vypis = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Zadejte platné datum ve formátu dd.MM nebo MM.dd.");
                                    return; // Ukončení metody, pokud není správný formát
                                }
                            }
                            // Zatím není implementováno: Kalendar.Checked 
                            else if (Kalendar.Checked)
                            {
                                // Tato podmínka není implementována
                            }

                            // Pokud je podmínka splněna, přidáme záznam do listBoxu
                            if (vypis)
                            {
                                listBox1.Items.Add($"{prijmeni} {jmeno} {datum.ToString("dd.MM.yyyy")}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Chybný formát data: {datumNarozeni}"); // Chybně zadané datum
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Zachycení chyb při zpracování každého řádku
                    MessageBox.Show($"Chyba při zpracování řádku: {radek}\n{ex.Message}");
                }
            }

            // Pokud nebyly žádné položky přidány, informujeme uživatele
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Nebyl nalezen žádný záznam odpovídající zadaným kritériím.");
            }
        }
    }
}
