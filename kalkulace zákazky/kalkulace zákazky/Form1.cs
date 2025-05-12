using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulace_zákazky
{
    public partial class Form1 : Form
    {
        // Boolean flagy pro kontrolu správnosti vstupů
        bool DPH_spravne = false;
        bool Sleva_spravne = false;
        bool Cena_spravne = false;
        bool Jmeno_polozky = false;
        bool Mnozstvi_polozek = false;
        bool DPH_spravne2 = false;
        bool Sleva_spravne2 = false;
        bool Cena_spravne2 = false;
        bool Jmeno_polozky2 = false;
        bool Mnozstvi_polozek2 = false;

        // Proměnné pro ceny a množství
        float cena_b_dph;
        float sleva_proc;
        float pocet_produkt;
        float proc_dph;
        float proc_dph2;
        float cena_b_dph2;
        float sleva_proc2;
        int pocet_produkt2;
        float Cena_bez_dph_polozka;
        float Cena_polozky_s_dph_polozka;
        float Cena_bez_dph_polozka2;
        float Cena_polozky_s_dph_polozka2;

        public Form1()
        {
            InitializeComponent();
            Mnozstvi_UpDown.ValueChanged += Mnozstvi_UpDown_ValueChanged;
            Množství.TextChanged += Množství_TextChanged;
        }

        private void Panel_slev_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            Pen myp = new Pen(System.Drawing.Color.Red, 4);
            Font fy = new Font("Helvetica", 10, FontStyle.Bold);
            Brush br1 = new SolidBrush(System.Drawing.Color.Black);
            Brush br2 = new SolidBrush(System.Drawing.Color.Black);
            Brush br3 = new SolidBrush(System.Drawing.Color.Black);
            Brush br4 = new SolidBrush(System.Drawing.Color.Black);
            g.DrawString("Množství slevy", fy, br1, 0, 1);
            g.DrawString("Do 9tis.  0%", fy, br2, 0, Panel_slev.Height / 4);
            g.DrawString("10-50 tis.  5%", fy, br3, 0, Panel_slev.Height / 4 * 2);
            g.DrawString("Nad 50 tis.10%", fy, br4, 0, Panel_slev.Height / 4 * 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Zajištění vykreslení panelu slev při načítání formuláře
            Panel_slev.Paint += new PaintEventHandler(Panel_slev_Paint);
            Panel_slev.Refresh();
        }

        private void DPH_procenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Ověření, zda DPH procenta jsou správná
                float procenta_dph = Convert.ToInt32(DPH_procenta.Text);
                if ((procenta_dph == 12) || (procenta_dph == 21))
                {
                    DPH_spravne = true;
                    proc_dph = procenta_dph;
                    PorovnejBoolHodnoty(DPH_spravne, Sleva_spravne, Cena_spravne, Jmeno_polozky, Mnozstvi_polozek);
                }
            }
            catch
            {
                // Pokud je vstup neplatný, žádná akce
            }
        }

        private void Sleva_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float procenta_Sleva = Convert.ToSingle(Sleva.Text);
                if (procenta_Sleva >= 0 && procenta_Sleva <= 100)
                {
                    Sleva_spravne = true;
                    sleva_proc = procenta_Sleva;
                    PorovnejBoolHodnoty(DPH_spravne, Sleva_spravne, Cena_spravne, Jmeno_polozky, Mnozstvi_polozek);
                }
                else
                {
                    Sleva.Text = "0"; // Pokud je sleva mimo interval, nastaví se na 0
                }
            }
            catch
            {
                // Pokud není možné převést text na číslo, nic se neděje
            }
        }

        private void Mnozstvi_UpDown_ValueChanged(object sender, EventArgs e)
        {
            // Při změně hodnoty v numeric up-down přepíšeme hodnotu do textového pole
            Množství.Text = Mnozstvi_UpDown.Value.ToString();
        }

        private void Množství_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Ověření, zda zadané množství je celé číslo
                float pocet = Convert.ToInt32(Množství.Text);
                if (pocet >= 0 && pocet % 1 == 0)
                {
                    Mnozstvi_polozek = true;
                    pocet_produkt = pocet;
                    PorovnejBoolHodnoty(DPH_spravne, Sleva_spravne, Cena_spravne, Jmeno_polozky, Mnozstvi_polozek);
                }
            }
            catch
            {
                // Pokud není možné převést text na číslo, nic se neděje
            }
        }

        private void Cena_bez_dph_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Ověření, zda cena je kladné číslo
                float cena_spravne = Convert.ToSingle(Cena_bez_dph.Text);
                if (cena_spravne >= 0)
                {
                    Cena_spravne = true;
                    cena_b_dph = cena_spravne;
                    PorovnejBoolHodnoty(DPH_spravne, Sleva_spravne, Cena_spravne, Jmeno_polozky, Mnozstvi_polozek);
                }
            }
            catch
            {
                // Pokud není možné převést text na číslo, nic se neděje
            }
        }

        private void Jmeno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pokud jméno není prázdné nebo není "text", aktivujeme další výpočty
                if (Jmeno_polozky == false)
                {
                    if ((Jmeno.Text == "") || (Jmeno.Text == "text")) { Jmeno_polozky = false; }
                    else
                    {
                        Jmeno_polozky = true;
                        PorovnejBoolHodnoty(DPH_spravne, Sleva_spravne, Cena_spravne, Jmeno_polozky, Mnozstvi_polozek);
                    }
                }
            }
            catch
            {
                // Pokud není možné přečíst text, nic se neděje
            }
        }

        private void PorovnejBoolHodnoty(bool DPH_spravne, bool Sleva_spravne, bool Cena_spravne, bool Jmeno_polozky, bool Mnozstvi_polozek)
        {
            if (DPH_spravne && Sleva_spravne && Cena_spravne && Jmeno_polozky && Mnozstvi_polozek)
            {
                // Pokud jsou všechny vstupy správně vyplněny, aktivujeme výpočty a další ovládací prvky
                Jmeno2.Enabled = true;
                Cena_bez_dph2.Enabled = true;
                Množství2.Enabled = true;
                Sleva2.Enabled = true;
                DPH_procenta2.Enabled = true;
                Mnozstvi_UpDown2.Enabled = true;
                Cena_polozky_bez_dph.Enabled = true;
                Cena_polozky_s_dph.Enabled = true;
                Vypocti.Enabled = true;
                Nova_zakazka.Enabled = true;

                // Vypočítáme ceny
                Cena_polozky_s_dph_polozka = cena_b_dph * pocet_produkt * ((100 + proc_dph) / 100) * ((100 - sleva_proc) / 100);
                Cena_bez_dph_polozka = cena_b_dph * pocet_produkt * ((100 - sleva_proc) / 100);
                Cena_polozky_bez_dph.Text = Convert.ToString(Cena_bez_dph_polozka);
                Cena_polozky_s_dph.Text = Convert.ToString(Cena_polozky_s_dph_polozka);
            }
        }

        private void Vypocti_Click(object sender, EventArgs e)
        {
            // Výpočet celkové ceny
            Celkem_cena_bez_dph.Text = Convert.ToString(Cena_bez_dph_polozka2 + Cena_bez_dph_polozka);
            DPH_celkem.Text = Convert.ToString((Cena_bez_dph_polozka2 + Cena_bez_dph_polozka) - (Cena_polozky_s_dph_polozka2 + Cena_polozky_s_dph_polozka));
        }

        private void Nova_zakazka_Click(object sender, EventArgs e)
        {
            // Reset všech hodnot při nové zakázce
            DPH_spravne = false;
            Sleva_spravne = false;
            Cena_spravne = false;
            Jmeno_polozky = false;
            Mnozstvi_polozek = false;
            DPH_spravne2 = false;
            Sleva_spravne2 = false;
            Cena_spravne2 = false;
            Jmeno_polozky2 = false;
            Mnozstvi_polozek2 = false;

            // Reset všech textových polí a hodnot
            DPH_procenta.Text = "12/21";
            DPH_procenta2.Text = "12/21";
            Sleva.Text = "0-100";
            Sleva2.Text = "0-100";
            Mnozstvi_UpDown.Value = 0;
            Mnozstvi_UpDown2.Value = 0;
            Množství.Text = "Celé kladné";
            Množství2.Text = "Celé kladné";
            Cena_bez_dph.Text = "Cena_bez_dph";
            Cena_bez_dph2.Text = "Cena_bez_dph";
            Jmeno.Text = "text";
            Jmeno2.Text = "text";
            Cena_polozky_bez_dph.Text = " ";
            Cena_polozky_bez_dph2.Text = " ";
            Cena_polozky_s_dph.Text = " ";
            Cena_polozky_s_dph2.Text = " ";
            Celkem_cena_bez_dph.Text = " ";
            Sleva_celkem.Text = " ";
            Celkem_sleva_bez_DPH_po_sleve.Text = " ";
            DPH_celkem.Text = " ";
            Konecna_cena.Text = " ";
        }
    }
}
