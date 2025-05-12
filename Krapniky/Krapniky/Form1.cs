using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Krapniky
{
    public partial class Form1 : Form
    {
        // Seznamy pro uchování hodnot horního a dolního "krapu"
        int[] Horni = new int[0];
        int[] Dolni = new int[0];
        string Zaloha; // Záložní řetězec pro uchování aktuálního stavu
        int pocet1; // Počet hodnot pro Horní krap
        int pocet2; // Počet hodnot pro Dolní krap
        int Mezer1; // Mezery mezi jednotlivými sloupci pro Horní krap
        int Mezer2; // Mezery mezi jednotlivými sloupci pro Dolní krap

        // Konstruktor formuláře, inicializuje komponenty
        public Form1()
        {
            InitializeComponent();
        }

        // Uloží aktuální hodnoty do zálohy
        private void UlozDoZaloha()
        {
            // Uložení hodnot do proměnné Zaloha ve formátu "Horní hodnoty; Dolní hodnoty"
            Zaloha = Horni_krap.Text + ";" + Dolni_Krap.Text;
        }

        // Obnoví hodnoty z uložené zálohy
        private void ObnovZeZaloha()
        {
            // Kontrola, zda záloha obsahuje data
            if (!string.IsNullOrEmpty(Zaloha))
            {
                string[] casti = Zaloha.Split(';'); // Rozdělení zálohy na dvě části
                // Převedení hodnot na pole integerů
                Horni = casti[0].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();
                Dolni = casti[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();

                // Nastavení textu v TextBoxech pro Horní a Dolní krap
                Horni_krap.Text = string.Join(", ", Horni);
                Dolni_Krap.Text = string.Join(", ", Dolni);

                // Aktualizace počtu a vykreslení
                UpdateCounts();
                Refresh();
            }
        }

        // Metoda pro provedení změn ve sloupcích podle zadaných hodnot
        private void Proved_Click(object sender, EventArgs e)
        {
            // Pokus o převod textu na celé číslo
            if (int.TryParse(Rust_horni.Text, out int rustHorni) && int.TryParse(Rust_dolni.Text, out int rustDolni))
            {
                // Změna hodnot v poli Horni
                for (int i = 0; i < Horni.Length; i++)
                {
                    Horni[i] += rustHorni;
                }

                // Změna hodnot v poli Dolni
                for (int i = 0; i < Dolni.Length; i++)
                {
                    Dolni[i] += rustDolni;
                }

                // Obnovení vykreslení panelu
                Refresh();
            }
            else
            {
                // Pokud není zadáno platné číslo, zde můžeme přidat chybové hlášení
                MessageBox.Show("Zadejte platné číslo pro obě hodnoty.");
            }
        }

        // Metoda pro vykreslení panelu s grafickým zobrazením
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Inicializace proměnných pro vykreslování
            int sir1 = 0;
            int zac1 = 0;
            int zac12 = 0;
            int sir2 = 0;
            int zac2 = 0;
            SolidBrush blueBrush = new SolidBrush(Color.Blue); // Barva pro vyplnění

            try
            {
                // Výpočet šířky sloupců pro Horní a Dolní krap
                sir1 = (panel1.Width - (Mezer1 * (pocet1 + 1))) / pocet1;
                int Mezer_hor = Mezer1;

                sir2 = (panel1.Width - (Mezer2 * (pocet2 + 1))) / pocet2;
                int Mezer_dol = Mezer2;

                // Vykreslení sloupců pro Horní krap
                foreach (var item in Horni)
                {
                    int vyska = item >= panel1.Height / 2 ? 0 : item; // Výška sloupce, pokud je hodnota menší než polovina panelu, nebude sloupec vykreslen
                    e.Graphics.FillRectangle(blueBrush, zac1 + Mezer_hor, zac12, sir1, vyska);
                    zac1 += sir1 + Mezer_hor;
                }

                // Vykreslení sloupců pro Dolní krap
                foreach (var item in Dolni)
                {
                    int vyska = item >= panel1.Height / 2 ? 0 : item;
                    int heightPos = panel1.Height - vyska; // Vysoká pozice pro dolní sloupce

                    e.Graphics.FillRectangle(blueBrush, zac2 + Mezer_dol, heightPos, sir2, vyska);

                    zac2 += sir2 + Mezer_dol;
                }
            }
            catch
            {
                // Případné zachycení chyb při vykreslování (může se stát při špatných výpočtech nebo neplatných hodnotách)
            }
        }

        // Obnovení hodnot z uložené zálohy při kliknutí na tlačítko
        private void Vychozi_Click(object sender, EventArgs e)
        {
            ObnovZeZaloha();
        }

        // Načtení počátečních hodnot při načtení formuláře
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                UlozDoZaloha(); // Uložení počátečních hodnot do zálohy
                Horni_krap_TextChanged(Horni_krap, EventArgs.Empty); // Inicializace textových polí pro Horní krap
                Dolni_Krap_TextChanged(Dolni_Krap, EventArgs.Empty); // Inicializace textových polí pro Dolní krap
            }
            catch
            {
                // Zde bychom mohli zachytit případné chyby, které mohou nastat při načítání formuláře
            }
        }

        // Metoda pro zpracování změn v textovém poli pro Horní krap
        private void Horni_krap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Přečtení textu a rozdělení na jednotlivé hodnoty
                string input1 = Horni_krap.Text;
                Horni = input1.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();
                // Aktualizace počtu hodnot a vykreslení
                UpdateCounts();
                UlozDoZaloha(); // Uložení do zálohy
                Refresh();
            }
            catch
            {
                // Zachycení chyb při zpracování hodnot pro Horní krap
            }
        }

        // Metoda pro zpracování změn v textovém poli pro Dolní krap
        private void Dolni_Krap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Přečtení textu a rozdělení na jednotlivé hodnoty
                string input2 = Dolni_Krap.Text;
                Dolni = input2.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();
                // Aktualizace počtu hodnot a vykreslení
                UpdateCounts();
                UlozDoZaloha(); // Uložení do zálohy
                Refresh();
            }
            catch
            {
                // Zachycení chyb při zpracování hodnot pro Dolní krap
            }
        }

        // Metoda pro aktualizaci počtu hodnot a mezery pro vykreslování
        private void UpdateCounts()
        {
            pocet1 = Horni.Length; // Počet hodnot v Horní krap
            pocet2 = Dolni.Length; // Počet hodnot v Dolní krap
            Mezer1 = pocet1 + 1; // Mezery pro vykreslování Horní krap
            Mezer2 = pocet2 + 1; // Mezery pro vykreslování Dolní krap
        }
    }
}
