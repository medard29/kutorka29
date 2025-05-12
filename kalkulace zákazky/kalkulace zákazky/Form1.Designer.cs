namespace kalkulace_zákazky
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nadpis = new System.Windows.Forms.Label();
            this.Mnozstvi_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Jmeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cena_bez_dph = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Množství = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Sleva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DPH_procenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cena_polozky_bez_dph = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Cena_polozky_s_dph = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cena_polozky_bez_dph2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DPH_procenta2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Množství2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Jmeno2 = new System.Windows.Forms.TextBox();
            this.Mnozstvi_UpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cena_polozky_s_dph2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Sleva2 = new System.Windows.Forms.TextBox();
            this.Cena_bez_dph2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Celkem_cena_bez_dph = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Sleva_celkem = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Celkem_sleva_bez_DPH_po_sleve = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.DPH_celkem = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.Konecna_cena = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Nova_zakazka = new System.Windows.Forms.Button();
            this.Vypocti = new System.Windows.Forms.Button();
            this.Panel_slev = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Mnozstvi_UpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mnozstvi_UpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nadpis
            // 
            this.Nadpis.AutoSize = true;
            this.Nadpis.Location = new System.Drawing.Point(13, 13);
            this.Nadpis.Name = "Nadpis";
            this.Nadpis.Size = new System.Drawing.Size(121, 13);
            this.Nadpis.TabIndex = 0;
            this.Nadpis.Text = "KALKULACE ZAKÁZKY";
            // 
            // Mnozstvi_UpDown
            // 
            this.Mnozstvi_UpDown.Location = new System.Drawing.Point(324, 33);
            this.Mnozstvi_UpDown.Name = "Mnozstvi_UpDown";
            this.Mnozstvi_UpDown.Size = new System.Drawing.Size(63, 20);
            this.Mnozstvi_UpDown.TabIndex = 1;
            this.Mnozstvi_UpDown.ValueChanged += new System.EventHandler(this.Mnozstvi_UpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název";
            // 
            // Jmeno
            // 
            this.Jmeno.Location = new System.Drawing.Point(54, 70);
            this.Jmeno.Name = "Jmeno";
            this.Jmeno.Size = new System.Drawing.Size(39, 20);
            this.Jmeno.TabIndex = 3;
            this.Jmeno.Text = "text";
            this.Jmeno.TextChanged += new System.EventHandler(this.Jmeno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "cena/ks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kč";
            // 
            // Cena_bez_dph
            // 
            this.Cena_bez_dph.Location = new System.Drawing.Point(150, 44);
            this.Cena_bez_dph.Name = "Cena_bez_dph";
            this.Cena_bez_dph.Size = new System.Drawing.Size(76, 20);
            this.Cena_bez_dph.TabIndex = 6;
            this.Cena_bez_dph.Text = "Reálné kladné";
            this.Cena_bez_dph.TextChanged += new System.EventHandler(this.Cena_bez_dph_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ks";
            // 
            // Množství
            // 
            this.Množství.Location = new System.Drawing.Point(322, 73);
            this.Množství.Name = "Množství";
            this.Množství.Size = new System.Drawing.Size(65, 20);
            this.Množství.TabIndex = 9;
            this.Množství.Text = "Celé kladné";
            this.Množství.TextChanged += new System.EventHandler(this.Množství_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Množství";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "%";
            // 
            // Sleva
            // 
            this.Sleva.Location = new System.Drawing.Point(473, 44);
            this.Sleva.Name = "Sleva";
            this.Sleva.Size = new System.Drawing.Size(39, 20);
            this.Sleva.TabIndex = 12;
            this.Sleva.Text = "0-100";
            this.Sleva.TextChanged += new System.EventHandler(this.Sleva_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sleva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "%";
            // 
            // DPH_procenta
            // 
            this.DPH_procenta.Location = new System.Drawing.Point(638, 73);
            this.DPH_procenta.Name = "DPH_procenta";
            this.DPH_procenta.Size = new System.Drawing.Size(39, 20);
            this.DPH_procenta.TabIndex = 15;
            this.DPH_procenta.Text = "12/21";
            this.DPH_procenta.TextChanged += new System.EventHandler(this.DPH_procenta_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "DPH";
            // 
            // Cena_polozky_bez_dph
            // 
            this.Cena_polozky_bez_dph.Location = new System.Drawing.Point(273, 133);
            this.Cena_polozky_bez_dph.Name = "Cena_polozky_bez_dph";
            this.Cena_polozky_bez_dph.ReadOnly = true;
            this.Cena_polozky_bez_dph.Size = new System.Drawing.Size(39, 20);
            this.Cena_polozky_bez_dph.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cena celkem bez DPH";
            // 
            // Cena_polozky_s_dph
            // 
            this.Cena_polozky_s_dph.Location = new System.Drawing.Point(417, 104);
            this.Cena_polozky_s_dph.Name = "Cena_polozky_s_dph";
            this.Cena_polozky_s_dph.ReadOnly = true;
            this.Cena_polozky_s_dph.Size = new System.Drawing.Size(39, 20);
            this.Cena_polozky_s_dph.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cena celkem s DPH";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Cena_polozky_s_dph);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Sleva);
            this.panel1.Controls.Add(this.Cena_bez_dph);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 195);
            this.panel1.TabIndex = 21;
            // 
            // Cena_polozky_bez_dph2
            // 
            this.Cena_polozky_bez_dph2.Enabled = false;
            this.Cena_polozky_bez_dph2.Location = new System.Drawing.Point(273, 334);
            this.Cena_polozky_bez_dph2.Name = "Cena_polozky_bez_dph2";
            this.Cena_polozky_bez_dph2.ReadOnly = true;
            this.Cena_polozky_bez_dph2.Size = new System.Drawing.Size(39, 20);
            this.Cena_polozky_bez_dph2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "%";
            // 
            // DPH_procenta2
            // 
            this.DPH_procenta2.Enabled = false;
            this.DPH_procenta2.Location = new System.Drawing.Point(638, 274);
            this.DPH_procenta2.Name = "DPH_procenta2";
            this.DPH_procenta2.Size = new System.Drawing.Size(39, 20);
            this.DPH_procenta2.TabIndex = 29;
            this.DPH_procenta2.TextChanged += new System.EventHandler(this.DPH_procenta2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(597, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "DPH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Ks";
            // 
            // Množství2
            // 
            this.Množství2.Enabled = false;
            this.Množství2.Location = new System.Drawing.Point(322, 274);
            this.Množství2.Name = "Množství2";
            this.Množství2.Size = new System.Drawing.Size(65, 20);
            this.Množství2.TabIndex = 26;
            this.Množství2.TextChanged += new System.EventHandler(this.Množství2_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Kč";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(105, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "cena/ks";
            // 
            // Jmeno2
            // 
            this.Jmeno2.Enabled = false;
            this.Jmeno2.Location = new System.Drawing.Point(47, 43);
            this.Jmeno2.Name = "Jmeno2";
            this.Jmeno2.Size = new System.Drawing.Size(39, 20);
            this.Jmeno2.TabIndex = 23;
            this.Jmeno2.TextChanged += new System.EventHandler(this.Jmeno2_TextChanged);
            // 
            // Mnozstvi_UpDown2
            // 
            this.Mnozstvi_UpDown2.Enabled = false;
            this.Mnozstvi_UpDown2.Location = new System.Drawing.Point(322, 234);
            this.Mnozstvi_UpDown2.Name = "Mnozstvi_UpDown2";
            this.Mnozstvi_UpDown2.Size = new System.Drawing.Size(65, 20);
            this.Mnozstvi_UpDown2.TabIndex = 22;
            this.Mnozstvi_UpDown2.ValueChanged += new System.EventHandler(this.Mnozstvi_UpDown2_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Cena_polozky_s_dph2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.Sleva2);
            this.panel2.Controls.Add(this.Cena_bez_dph2);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.Jmeno2);
            this.panel2.Location = new System.Drawing.Point(12, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 195);
            this.panel2.TabIndex = 32;
            // 
            // Cena_polozky_s_dph2
            // 
            this.Cena_polozky_s_dph2.Enabled = false;
            this.Cena_polozky_s_dph2.Location = new System.Drawing.Point(417, 104);
            this.Cena_polozky_s_dph2.Name = "Cena_polozky_s_dph2";
            this.Cena_polozky_s_dph2.ReadOnly = true;
            this.Cena_polozky_s_dph2.Size = new System.Drawing.Size(39, 20);
            this.Cena_polozky_s_dph2.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Název";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(308, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Cena celkem s DPH";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(258, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Množství";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(433, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Sleva";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(140, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Cena celkem bez DPH";
            // 
            // Sleva2
            // 
            this.Sleva2.Enabled = false;
            this.Sleva2.Location = new System.Drawing.Point(473, 44);
            this.Sleva2.Name = "Sleva2";
            this.Sleva2.Size = new System.Drawing.Size(39, 20);
            this.Sleva2.TabIndex = 12;
            this.Sleva2.TextChanged += new System.EventHandler(this.Sleva2_TextChanged);
            // 
            // Cena_bez_dph2
            // 
            this.Cena_bez_dph2.Enabled = false;
            this.Cena_bez_dph2.Location = new System.Drawing.Point(150, 44);
            this.Cena_bez_dph2.Name = "Cena_bez_dph2";
            this.Cena_bez_dph2.Size = new System.Drawing.Size(76, 20);
            this.Cena_bez_dph2.TabIndex = 6;
            this.Cena_bez_dph2.TextChanged += new System.EventHandler(this.Cena_bez_dph2_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(518, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "%";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(50, 458);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Celkem cena bez DPH";
            // 
            // Celkem_cena_bez_dph
            // 
            this.Celkem_cena_bez_dph.Location = new System.Drawing.Point(202, 22);
            this.Celkem_cena_bez_dph.Name = "Celkem_cena_bez_dph";
            this.Celkem_cena_bez_dph.ReadOnly = true;
            this.Celkem_cena_bez_dph.Size = new System.Drawing.Size(64, 20);
            this.Celkem_cena_bez_dph.TabIndex = 34;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(272, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Kč";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(272, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 13);
            this.label25.TabIndex = 38;
            this.label25.Text = "%";
            // 
            // Sleva_celkem
            // 
            this.Sleva_celkem.Location = new System.Drawing.Point(202, 48);
            this.Sleva_celkem.Name = "Sleva_celkem";
            this.Sleva_celkem.ReadOnly = true;
            this.Sleva_celkem.Size = new System.Drawing.Size(64, 20);
            this.Sleva_celkem.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(50, 484);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "Množství sleva";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(272, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "Kč";
            // 
            // Celkem_sleva_bez_DPH_po_sleve
            // 
            this.Celkem_sleva_bez_DPH_po_sleve.Location = new System.Drawing.Point(202, 74);
            this.Celkem_sleva_bez_DPH_po_sleve.Name = "Celkem_sleva_bez_DPH_po_sleve";
            this.Celkem_sleva_bez_DPH_po_sleve.ReadOnly = true;
            this.Celkem_sleva_bez_DPH_po_sleve.Size = new System.Drawing.Size(64, 20);
            this.Celkem_sleva_bez_DPH_po_sleve.TabIndex = 40;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(50, 510);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 13);
            this.label28.TabIndex = 39;
            this.label28.Text = "Celkem sleva bez DPH po slevě";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(272, 103);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 13);
            this.label29.TabIndex = 44;
            this.label29.Text = "Kč";
            // 
            // DPH_celkem
            // 
            this.DPH_celkem.Location = new System.Drawing.Point(202, 100);
            this.DPH_celkem.Name = "DPH_celkem";
            this.DPH_celkem.ReadOnly = true;
            this.DPH_celkem.Size = new System.Drawing.Size(64, 20);
            this.DPH_celkem.TabIndex = 43;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(50, 536);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 42;
            this.label30.Text = "DPH";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(272, 129);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 13);
            this.label31.TabIndex = 47;
            this.label31.Text = "Kč";
            // 
            // Konecna_cena
            // 
            this.Konecna_cena.Location = new System.Drawing.Point(202, 126);
            this.Konecna_cena.Name = "Konecna_cena";
            this.Konecna_cena.ReadOnly = true;
            this.Konecna_cena.Size = new System.Drawing.Size(64, 20);
            this.Konecna_cena.TabIndex = 46;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(50, 562);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(77, 13);
            this.label32.TabIndex = 45;
            this.label32.Text = "Konečná cena";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.Nova_zakazka);
            this.panel3.Controls.Add(this.Konecna_cena);
            this.panel3.Controls.Add(this.Vypocti);
            this.panel3.Controls.Add(this.Panel_slev);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.Sleva_celkem);
            this.panel3.Controls.Add(this.DPH_celkem);
            this.panel3.Controls.Add(this.Celkem_cena_bez_dph);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.Celkem_sleva_bez_DPH_po_sleve);
            this.panel3.Location = new System.Drawing.Point(12, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 168);
            this.panel3.TabIndex = 48;
            // 
            // Nova_zakazka
            // 
            this.Nova_zakazka.Enabled = false;
            this.Nova_zakazka.Location = new System.Drawing.Point(437, 126);
            this.Nova_zakazka.Name = "Nova_zakazka";
            this.Nova_zakazka.Size = new System.Drawing.Size(96, 23);
            this.Nova_zakazka.TabIndex = 2;
            this.Nova_zakazka.Text = "Nová zakázka";
            this.Nova_zakazka.UseVisualStyleBackColor = true;
            this.Nova_zakazka.Click += new System.EventHandler(this.Nova_zakazka_Click);
            // 
            // Vypocti
            // 
            this.Vypocti.Enabled = false;
            this.Vypocti.Location = new System.Drawing.Point(336, 126);
            this.Vypocti.Name = "Vypocti";
            this.Vypocti.Size = new System.Drawing.Size(75, 23);
            this.Vypocti.TabIndex = 1;
            this.Vypocti.Text = "Vypočti";
            this.Vypocti.UseVisualStyleBackColor = true;
            this.Vypocti.Click += new System.EventHandler(this.Vypocti_Click);
            // 
            // Panel_slev
            // 
            this.Panel_slev.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Panel_slev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_slev.Location = new System.Drawing.Point(553, 16);
            this.Panel_slev.Name = "Panel_slev";
            this.Panel_slev.Size = new System.Drawing.Size(210, 130);
            this.Panel_slev.TabIndex = 0;
            this.Panel_slev.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_slev_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Cena_polozky_bez_dph2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DPH_procenta2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Množství2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Mnozstvi_UpDown2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Cena_polozky_bez_dph);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DPH_procenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Množství);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Jmeno);
            this.Controls.Add(this.Mnozstvi_UpDown);
            this.Controls.Add(this.Nadpis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mnozstvi_UpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mnozstvi_UpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nadpis;
        private System.Windows.Forms.NumericUpDown Mnozstvi_UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Jmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cena_bez_dph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Množství;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Sleva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DPH_procenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Cena_polozky_bez_dph;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Cena_polozky_s_dph;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Cena_polozky_bez_dph2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DPH_procenta2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Množství2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Jmeno2;
        private System.Windows.Forms.NumericUpDown Mnozstvi_UpDown2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Cena_polozky_s_dph2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Sleva2;
        private System.Windows.Forms.TextBox Cena_bez_dph2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Celkem_cena_bez_dph;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Sleva_celkem;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox Celkem_sleva_bez_DPH_po_sleve;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox DPH_celkem;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox Konecna_cena;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Nova_zakazka;
        private System.Windows.Forms.Button Vypocti;
        private System.Windows.Forms.Panel Panel_slev;
    }
}

