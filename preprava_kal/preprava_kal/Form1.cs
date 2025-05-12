using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace preprava_kal
{
    public partial class Form1 : Form
    {
        // Globální proměnné
        int loop = 0;  // Počet vložených údajů (3 na 1 zásilku)
        int Cena_km;
        int Cena_Prepravy_za_1kg;
        int Cena_EX;
        double Sleva_nad_100_km;   // Sleva za vzdálenost
        double Sleva_za_10_kg;     // Sleva za každých 10 kg
        int Pocet;                 // Počet zásilek
        int pomoc_pocet = 0;       // Pomocná proměnná pro číslování zásilek
        int celkovaCenaPredSlevou = 0;
        double celkovaSleva = 0;
        StringBuilder vypisText = new StringBuilder();  // Textový výstup

        // Pole pro uchování údajů o zásilkách (hmotnost, vzdálenost, typ)
        int[] Polozka;

        public Form1()
        {
            InitializeComponent();
        }

        // Inicializace aplikace po stisknutí tlačítka "Začít"
        private void Zacit_Click(object sender, EventArgs e)
        {
            try
            {
                // Načtení vstupů a převedení na čísla
                Cena_km = Convert.ToInt32(Nas_km.Text);
                Cena_Prepravy_za_1kg = Convert.ToInt32(Preprava.Text);
                Cena_EX = Convert.ToInt32(Cena_express.Text);

                // Sleva za vzdálenost nad 100 km
                Sleva_nad_100_km = Convert.ToDouble(Sleva_100km.Text);
                if (Sleva_nad_100_km > 100)
                {
                    Sleva_nad_100_km = 100;
                    Sleva_100km.Text = "100";
                }

                // Sleva za každých 10 kg
                Sleva_za_10_kg = Convert.ToDouble(Sleva_10kg.Text);
                if (Sleva_za_10_kg > 100)
                {
                    Sleva_za_10_kg = 100;
                    Sleva_10kg.Text = "100";
                }

                // Počet zásilek
                Pocet = Convert.ToInt32(Počet_zasilek.Text);
                if (Pocet > 10)
                {
                    Pocet = 10;
                    Počet_zasilek.Text = "10";
                    MessageBox.Show("Maximální počet zásilek je 10.");
                }

                // Vytvoření pole na údaje o zásilkách (3 údaje na 1 zásilku)
                Polozka = new int[Pocet * 3 + 1];

                // Deaktivace vstupů a aktivace zadání zásilek
                Zacit.Enabled = false;
                Nas_km.Enabled = false;
                Preprava.Enabled = false;
                Cena_express.Enabled = false;
                Sleva_100km.Enabled = false;
                Sleva_10kg.Enabled = false;
                Počet_zasilek.Enabled = false;

                Hmotnost.Enabled = true;
                Vzdálenost.Enabled = true;
                Express.Enabled = true;
                Normal.Enabled = true;
                Hotovo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání vstupů: " + ex.Message);
            }
        }

        // Zpracování jedné zásilky
        private void Hotovo_Click(object sender, EventArgs e)
        {
            int Hmot;
            int Vzdal;
            bool Nor = true;
            int typ = 1;

            try
            {
                Hmot = Convert.ToInt32(Hmotnost.Text);
                Vzdal = Convert.ToInt32(Vzdálenost.Text);

                // Určení typu zásilky
                if (Normal.Checked) { Nor = true; typ = 1; }
                else { Nor = false; typ = 0; }

                Nove_zasilky.Enabled = true;

                // Uložení údajů do pole
                loop += 3;
                Polozka[loop - 2] = Hmot;
                Polozka[loop - 1] = Vzdal;
                Polozka[loop] = typ;

                // Výpočet ceny
                int cenaZaVzdalenost = Vzdal * Cena_km;
                int cenaZaHmotnost = Hmot * Cena_Prepravy_za_1kg;
                int cenaPredSlevou = cenaZaVzdalenost + cenaZaHmotnost + (Nor ? 0 : Cena_EX);

                double sleva = 0;

                // Sleva za vzdálenost > 100 km
                if (Vzdal > 100)
                    sleva += Math.Round((cenaPredSlevou * Sleva_nad_100_km) / 100, 2);

                // Sleva za každých 10 kg hmotnosti
                sleva += Math.Round((cenaPredSlevou * (Hmot / 10) * Sleva_za_10_kg) / 100, 2);

                double cenaPoSleve = Math.Round(cenaPredSlevou - sleva, 2);

                // Aktualizace celkové ceny a slevy
                celkovaCenaPredSlevou += cenaPredSlevou;
                celkovaSleva += sleva;

                pomoc_pocet++;

                // Výpis jednotlivé zásilky
                vypisText.AppendLine($"Zásilka {pomoc_pocet}:");
                vypisText.AppendLine($"Typ: {(Nor ? "Normální" : "Expresní")}");
                vypisText.AppendLine($"Hmotnost: {Hmot} kg, Vzdálenost: {Vzdal} km");
                vypisText.AppendLine($"Cena před slevou: {cenaPredSlevou} Kč");
                vypisText.AppendLine($"Sleva: {sleva} Kč");
                vypisText.AppendLine($"Cena po slevě: {cenaPoSleve} Kč");
                vypisText.AppendLine("------\n");

                // Pokud byly zadány všechny zásilky
                if (loop / 3 == Pocet)
                {
                    vypisText.AppendLine($"Celková cena před slevou: {celkovaCenaPredSlevou} Kč");
                    vypisText.AppendLine($"Celková sleva: {celkovaSleva} Kč");
                    vypisText.AppendLine($"Celková cena po slevě: {Math.Round(celkovaCenaPredSlevou - celkovaSleva, 2)} Kč");

                    Vypis.Text = vypisText.ToString();

                    // Deaktivace vstupů
                    Nove_zasilky.Enabled = false;
                    Hmotnost.Enabled = false;
                    Vzdálenost.Enabled = false;
                }

                // Vyčištění vstupů pro další zásilku
                Hmotnost.Text = "";
                Vzdálenost.Text = "";
                Normal.Checked = true;
                Hotovo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při zpracování zásilky: " + ex.Message);
            }
        }

        // Aktivace vstupu pro novou zásilku
        private void Nove_zasilky_Click(object sender, EventArgs e)
        {
            Nove_zasilky.Enabled = false;
            Hotovo.Enabled = true;

            if (loop / 3 >= Pocet)
            {
                MessageBox.Show("Maximální počet zásilek byl dosažen.");
            }
        }

        // Resetování celé aplikace
        private void Znova_Click(object sender, EventArgs e)
        {
            // Reset všech proměnných a vstupů
            loop = 0;
            Cena_km = 0;
            Cena_Prepravy_za_1kg = 0;
            Cena_EX = 0;
            Sleva_nad_100_km = 0;
            Sleva_za_10_kg = 0;
            Pocet = 0;
            pomoc_pocet = 0;
            celkovaCenaPredSlevou = 0;
            celkovaSleva = 0;
            vypisText.Clear();

            // Vyčištění polí
            Nas_km.Text = "";
            Preprava.Text = "";
            Cena_express.Text = "";
            Sleva_100km.Text = "";
            Sleva_10kg.Text = "";
            Počet_zasilek.Text = "";
            Hmotnost.Text = "";
            Vzdálenost.Text = "";
            Vypis.Text = "";

            // Výchozí nastavení prvků
            Normal.Checked = true;
            Express.Checked = false;

            Zacit.Enabled = true;
            Nas_km.Enabled = true;
            Preprava.Enabled = true;
            Cena_express.Enabled = true;
            Sleva_100km.Enabled = true;
            Sleva_10kg.Enabled = true;
            Počet_zasilek.Enabled = true;

            Hmotnost.Enabled = false;
            Vzdálenost.Enabled = false;
            Express.Enabled = false;
            Normal.Enabled = false;
            Hotovo.Enabled = false;
            Nove_zasilky.Enabled = false;
        }
    }
}
