using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pohyb_kuličky
{
    public partial class Form1 : Form
    {
        // Proměnné pro pozici kuličky a její parametry
        private int micx; // X pozice kuličky
        private int micy; // Y pozice kuličky
        private int velikost = 40; // Velikost kuličky
        private int kllikmimo = 0; // Počet kliknutí mimo kuličku
        private int klikna = 0; // Počet kliknutí na kuličku
        private int cilx, cily; // Cílová pozice kuličky (kam se kulička má pohybovat)
        private int rychlost = 5; // Rychlost pohybu kuličky
        private bool Pohyb = false; // Určuje, zda kulička má být v pohybu

        // Konstruktor formuláře, který inicializuje hru
        public Form1()
        {
            InitializeComponent();  // Inicializace komponent formuláře
            InitializeGame();       // Volání metody pro inicializaci hry
            DoubleBuffered = true;  // Aktivace dvojitého buferování pro hladší vykreslování
        }

        // Metoda pro inicializaci hry
        private void InitializeGame()
        {
            // Nastavení počáteční pozice kuličky na střed panelu
            micx = panel1.Width / 2 - velikost / 2;
            micy = panel1.Height / 2 - velikost / 2;

            // Inicializace hodnot pro textová pole (počet kliknutí)
            textBoxmimo.Text = "0";
            textBoxna.Text = "0";

            // Nastavení cílové pozice kuličky (počátečně stejná jako počáteční pozice)
            cilx = micx;
            cily = micy;

            // Nastavení intervalu timeru a jeho spuštění (pro pohyb kuličky)
            timer1.Interval = 16; // Interval je nastaven na 16 ms, což odpovídá přibližně 60 FPS
            timer1.Start(); // Spuštění timeru
        }

        // Metoda pro vykreslení kuličky na panelu
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;  // Získání objektu Graphics pro kreslení
            g.Clear(panel1.BackColor); // Vyčištění panelu před vykreslením

            // Nastavení barvy kuličky
            Brush ballBrush = Brushes.Red;

            // Vykreslení kuličky (ovál) na základě její pozice
            g.FillEllipse(ballBrush, micx, micy, velikost, velikost);
        }

        // Metoda pro detekci kliknutí na panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Kontrola, zda bylo kliknuto na kuličku
            bool Namici = e.X >= micx && e.X <= micx + velikost && e.Y >= micy && e.Y <= micy + velikost;

            if (Namici) // Kliknuto na kuličku
            {
                Pohyb = false; // Zastavení pohybu kuličky
                klikna++; // Zvýšení počtu kliknutí na kuličku
                textBoxna.Text = klikna.ToString(); // Aktualizace textového pole pro počet kliknutí na kuličku
            }
            else // Kliknuto mimo kuličku
            {
                // Nastavení cílové pozice kuličky na místo, kde bylo kliknuto
                cilx = e.X - velikost / 2;
                cily = e.Y - velikost / 2;
                Pohyb = true; // Zahájení pohybu kuličky
                kllikmimo++; // Zvýšení počtu kliknutí mimo kuličku
                textBoxmimo.Text = kllikmimo.ToString(); // Aktualizace textového pole pro počet kliknutí mimo kuličku
            }
        }

        // Metoda, která je volána při každém tiknutí timeru
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Pohyb) // Pokud je kulička v pohybu
            {
                // Výpočet rozdílu mezi aktuální pozicí a cílovou pozicí
                int rozdilx = cilx - micx;
                int rozdily = cily - micy;

                // Pokud je kulička dostatečně blízko k cílové pozici, zastavíme pohyb
                if (Math.Abs(rozdilx) < rychlost && Math.Abs(rozdily) < rychlost)
                {
                    micx = cilx;  // Nastavení nové pozice kuličky
                    micy = cily;
                    Pohyb = false; // Zastavení pohybu
                }
                else
                {
                    // Výpočet úhlu mezi aktuální pozicí a cílem
                    double angle = Math.Atan2(rozdily, rozdilx);

                    // Výpočet nové pozice kuličky na základě směru a rychlosti
                    int nextX = micx + (int)(rychlost * Math.Cos(angle));
                    int nextY = micy + (int)(rychlost * Math.Sin(angle));

                    micx = nextX; // Aktualizace pozice kuličky
                    micy = nextY;
                }

                // Po každém pohybu kuličky znovu vykreslíme panel
                panel1.Invalidate();
            }
        }
    }
}
