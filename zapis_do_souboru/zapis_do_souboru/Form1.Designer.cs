namespace zapis_do_souboru
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
            this.Zapis = new System.Windows.Forms.Button();
            this.Jmeno_souboru = new System.Windows.Forms.TextBox();
            this.Win_CP_1250 = new System.Windows.Forms.RadioButton();
            this.Win_CP_852 = new System.Windows.Forms.RadioButton();
            this.Latin_2 = new System.Windows.Forms.RadioButton();
            this.UTF_8 = new System.Windows.Forms.RadioButton();
            this.UTF_16_L = new System.Windows.Forms.RadioButton();
            this.UTF_16_B = new System.Windows.Forms.RadioButton();
            this.Cti = new System.Windows.Forms.Button();
            this.Otevritsoubor = new System.Windows.Forms.Button();
            this.ZapisDoSouboru = new System.Windows.Forms.Button();
            this.poleobsah = new System.Windows.Forms.TextBox();
            this.Prochazet = new System.Windows.Forms.Button();
            this.Psani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Pozpat_text = new System.Windows.Forms.TextBox();
            this.Hledej = new System.Windows.Forms.Button();
            this.Hledej2 = new System.Windows.Forms.Button();
            this.Obrat_vysledek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Obrat = new System.Windows.Forms.Button();
            this.Hledej_list = new System.Windows.Forms.Button();
            this.Jmeno_list_souboru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nacti_list = new System.Windows.Forms.Button();
            this.Vloz_jmeno = new System.Windows.Forms.Button();
            this.Jmeno_do_list = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Vypis_nove_jmeno = new System.Windows.Forms.Button();
            this.Posun_nahoru = new System.Windows.Forms.Button();
            this.Posun_dolu = new System.Windows.Forms.Button();
            this.Smaz_jmeno = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zapis
            // 
            this.Zapis.Location = new System.Drawing.Point(300, 99);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(75, 23);
            this.Zapis.TabIndex = 0;
            this.Zapis.Text = "Zápis";
            this.Zapis.UseVisualStyleBackColor = true;
            this.Zapis.Click += new System.EventHandler(this.Zapis_Click);
            // 
            // Jmeno_souboru
            // 
            this.Jmeno_souboru.Location = new System.Drawing.Point(381, 50);
            this.Jmeno_souboru.Name = "Jmeno_souboru";
            this.Jmeno_souboru.Size = new System.Drawing.Size(100, 20);
            this.Jmeno_souboru.TabIndex = 1;
            // 
            // Win_CP_1250
            // 
            this.Win_CP_1250.AutoSize = true;
            this.Win_CP_1250.Location = new System.Drawing.Point(157, 75);
            this.Win_CP_1250.Name = "Win_CP_1250";
            this.Win_CP_1250.Size = new System.Drawing.Size(94, 17);
            this.Win_CP_1250.TabIndex = 2;
            this.Win_CP_1250.TabStop = true;
            this.Win_CP_1250.Text = "Win_CP_1250";
            this.Win_CP_1250.UseVisualStyleBackColor = true;
            // 
            // Win_CP_852
            // 
            this.Win_CP_852.AutoSize = true;
            this.Win_CP_852.Location = new System.Drawing.Point(157, 99);
            this.Win_CP_852.Name = "Win_CP_852";
            this.Win_CP_852.Size = new System.Drawing.Size(88, 17);
            this.Win_CP_852.TabIndex = 3;
            this.Win_CP_852.TabStop = true;
            this.Win_CP_852.Text = "Win_CP_852";
            this.Win_CP_852.UseVisualStyleBackColor = true;
            // 
            // Latin_2
            // 
            this.Latin_2.AutoSize = true;
            this.Latin_2.Location = new System.Drawing.Point(157, 123);
            this.Latin_2.Name = "Latin_2";
            this.Latin_2.Size = new System.Drawing.Size(60, 17);
            this.Latin_2.TabIndex = 4;
            this.Latin_2.TabStop = true;
            this.Latin_2.Text = "Latin_2";
            this.Latin_2.UseVisualStyleBackColor = true;
            // 
            // UTF_8
            // 
            this.UTF_8.AutoSize = true;
            this.UTF_8.Location = new System.Drawing.Point(157, 147);
            this.UTF_8.Name = "UTF_8";
            this.UTF_8.Size = new System.Drawing.Size(58, 17);
            this.UTF_8.TabIndex = 5;
            this.UTF_8.TabStop = true;
            this.UTF_8.Text = "UTF_8";
            this.UTF_8.UseVisualStyleBackColor = true;
            // 
            // UTF_16_L
            // 
            this.UTF_16_L.AutoSize = true;
            this.UTF_16_L.Location = new System.Drawing.Point(157, 171);
            this.UTF_16_L.Name = "UTF_16_L";
            this.UTF_16_L.Size = new System.Drawing.Size(76, 17);
            this.UTF_16_L.TabIndex = 6;
            this.UTF_16_L.TabStop = true;
            this.UTF_16_L.Text = "UTF_16_L";
            this.UTF_16_L.UseVisualStyleBackColor = true;
            // 
            // UTF_16_B
            // 
            this.UTF_16_B.AutoSize = true;
            this.UTF_16_B.Location = new System.Drawing.Point(157, 195);
            this.UTF_16_B.Name = "UTF_16_B";
            this.UTF_16_B.Size = new System.Drawing.Size(77, 17);
            this.UTF_16_B.TabIndex = 7;
            this.UTF_16_B.TabStop = true;
            this.UTF_16_B.Text = "UTF_16_B";
            this.UTF_16_B.UseVisualStyleBackColor = true;
            // 
            // Cti
            // 
            this.Cti.Location = new System.Drawing.Point(392, 99);
            this.Cti.Name = "Cti";
            this.Cti.Size = new System.Drawing.Size(75, 23);
            this.Cti.TabIndex = 8;
            this.Cti.Text = "Přečti";
            this.Cti.UseVisualStyleBackColor = true;
            this.Cti.Click += new System.EventHandler(this.Cti_Click);
            // 
            // Otevritsoubor
            // 
            this.Otevritsoubor.Location = new System.Drawing.Point(304, 208);
            this.Otevritsoubor.Name = "Otevritsoubor";
            this.Otevritsoubor.Size = new System.Drawing.Size(96, 23);
            this.Otevritsoubor.TabIndex = 9;
            this.Otevritsoubor.Text = "Otevřit soubor";
            this.Otevritsoubor.UseVisualStyleBackColor = true;
            this.Otevritsoubor.Click += new System.EventHandler(this.Otevritsoubor_Click);
            // 
            // ZapisDoSouboru
            // 
            this.ZapisDoSouboru.Location = new System.Drawing.Point(406, 208);
            this.ZapisDoSouboru.Name = "ZapisDoSouboru";
            this.ZapisDoSouboru.Size = new System.Drawing.Size(108, 23);
            this.ZapisDoSouboru.TabIndex = 10;
            this.ZapisDoSouboru.Text = "Zápis Do Souboru";
            this.ZapisDoSouboru.UseVisualStyleBackColor = true;
            this.ZapisDoSouboru.Click += new System.EventHandler(this.ZapisDoSouboru_Click);
            // 
            // poleobsah
            // 
            this.poleobsah.Location = new System.Drawing.Point(538, 44);
            this.poleobsah.Multiline = true;
            this.poleobsah.Name = "poleobsah";
            this.poleobsah.Size = new System.Drawing.Size(187, 171);
            this.poleobsah.TabIndex = 11;
            // 
            // Prochazet
            // 
            this.Prochazet.Location = new System.Drawing.Point(300, 47);
            this.Prochazet.Name = "Prochazet";
            this.Prochazet.Size = new System.Drawing.Size(75, 23);
            this.Prochazet.TabIndex = 12;
            this.Prochazet.Text = "Procházet";
            this.Prochazet.UseVisualStyleBackColor = true;
            this.Prochazet.Click += new System.EventHandler(this.Prochazet_Click);
            // 
            // Psani
            // 
            this.Psani.Location = new System.Drawing.Point(300, 260);
            this.Psani.Name = "Psani";
            this.Psani.Size = new System.Drawing.Size(214, 20);
            this.Psani.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Typ_kódování";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(138, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 189);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(107, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 292);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soubor který chcete vypsat pozpátku";
            // 
            // Pozpat_text
            // 
            this.Pozpat_text.Location = new System.Drawing.Point(123, 346);
            this.Pozpat_text.Name = "Pozpat_text";
            this.Pozpat_text.Size = new System.Drawing.Size(182, 20);
            this.Pozpat_text.TabIndex = 18;
            // 
            // Hledej
            // 
            this.Hledej.Location = new System.Drawing.Point(316, 346);
            this.Hledej.Name = "Hledej";
            this.Hledej.Size = new System.Drawing.Size(78, 23);
            this.Hledej.TabIndex = 19;
            this.Hledej.Text = "Hledej";
            this.Hledej.UseVisualStyleBackColor = true;
            this.Hledej.Click += new System.EventHandler(this.Hledej_Click);
            // 
            // Hledej2
            // 
            this.Hledej2.Location = new System.Drawing.Point(316, 396);
            this.Hledej2.Name = "Hledej2";
            this.Hledej2.Size = new System.Drawing.Size(78, 23);
            this.Hledej2.TabIndex = 22;
            this.Hledej2.Text = "Hledej";
            this.Hledej2.UseVisualStyleBackColor = true;
            this.Hledej2.Click += new System.EventHandler(this.Hledej2_Click);
            // 
            // Obrat_vysledek
            // 
            this.Obrat_vysledek.Location = new System.Drawing.Point(123, 396);
            this.Obrat_vysledek.Name = "Obrat_vysledek";
            this.Obrat_vysledek.Size = new System.Drawing.Size(182, 20);
            this.Obrat_vysledek.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soubor kam to chcete vypsat";
            // 
            // Obrat
            // 
            this.Obrat.Location = new System.Drawing.Point(197, 433);
            this.Obrat.Name = "Obrat";
            this.Obrat.Size = new System.Drawing.Size(75, 23);
            this.Obrat.TabIndex = 23;
            this.Obrat.Text = "Proveď";
            this.Obrat.UseVisualStyleBackColor = true;
            this.Obrat.Click += new System.EventHandler(this.Obrat_Click);
            // 
            // Hledej_list
            // 
            this.Hledej_list.Location = new System.Drawing.Point(612, 332);
            this.Hledej_list.Name = "Hledej_list";
            this.Hledej_list.Size = new System.Drawing.Size(75, 23);
            this.Hledej_list.TabIndex = 26;
            this.Hledej_list.Text = "Hledej";
            this.Hledej_list.UseVisualStyleBackColor = true;
            this.Hledej_list.Click += new System.EventHandler(this.Hledej_list_Click);
            // 
            // Jmeno_list_souboru
            // 
            this.Jmeno_list_souboru.Location = new System.Drawing.Point(419, 332);
            this.Jmeno_list_souboru.Name = "Jmeno_list_souboru";
            this.Jmeno_list_souboru.Size = new System.Drawing.Size(182, 20);
            this.Jmeno_list_souboru.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Soubor se kterým chcete pracovat";
            // 
            // Nacti_list
            // 
            this.Nacti_list.Location = new System.Drawing.Point(419, 363);
            this.Nacti_list.Name = "Nacti_list";
            this.Nacti_list.Size = new System.Drawing.Size(95, 23);
            this.Nacti_list.TabIndex = 27;
            this.Nacti_list.Text = "Načti seznam";
            this.Nacti_list.UseVisualStyleBackColor = true;
            this.Nacti_list.Click += new System.EventHandler(this.Nacti_list_Click);
            // 
            // Vloz_jmeno
            // 
            this.Vloz_jmeno.Location = new System.Drawing.Point(418, 442);
            this.Vloz_jmeno.Name = "Vloz_jmeno";
            this.Vloz_jmeno.Size = new System.Drawing.Size(121, 23);
            this.Vloz_jmeno.TabIndex = 30;
            this.Vloz_jmeno.Text = "Vlož nové jméno";
            this.Vloz_jmeno.UseVisualStyleBackColor = true;
            this.Vloz_jmeno.Click += new System.EventHandler(this.Vloz_jmeno_Click);
            // 
            // Jmeno_do_list
            // 
            this.Jmeno_do_list.Location = new System.Drawing.Point(419, 416);
            this.Jmeno_do_list.Name = "Jmeno_do_list";
            this.Jmeno_do_list.Size = new System.Drawing.Size(182, 20);
            this.Jmeno_do_list.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Vkládat jméno";
            // 
            // Vypis_nove_jmeno
            // 
            this.Vypis_nove_jmeno.Location = new System.Drawing.Point(418, 471);
            this.Vypis_nove_jmeno.Name = "Vypis_nove_jmeno";
            this.Vypis_nove_jmeno.Size = new System.Drawing.Size(121, 23);
            this.Vypis_nove_jmeno.TabIndex = 31;
            this.Vypis_nove_jmeno.Text = "Vypiš nové jméno";
            this.Vypis_nove_jmeno.UseVisualStyleBackColor = true;
            this.Vypis_nove_jmeno.Click += new System.EventHandler(this.Vypis_nove_jmeno_Click);
            // 
            // Posun_nahoru
            // 
            this.Posun_nahoru.Location = new System.Drawing.Point(565, 471);
            this.Posun_nahoru.Name = "Posun_nahoru";
            this.Posun_nahoru.Size = new System.Drawing.Size(106, 23);
            this.Posun_nahoru.TabIndex = 32;
            this.Posun_nahoru.Text = "Posuň nahoru";
            this.Posun_nahoru.UseVisualStyleBackColor = true;
            this.Posun_nahoru.Click += new System.EventHandler(this.Posun_nahoru_Click);
            // 
            // Posun_dolu
            // 
            this.Posun_dolu.Location = new System.Drawing.Point(565, 500);
            this.Posun_dolu.Name = "Posun_dolu";
            this.Posun_dolu.Size = new System.Drawing.Size(106, 23);
            this.Posun_dolu.TabIndex = 34;
            this.Posun_dolu.Text = "Posuň dolu";
            this.Posun_dolu.UseVisualStyleBackColor = true;
            this.Posun_dolu.Click += new System.EventHandler(this.Posun_dolu_Click);
            // 
            // Smaz_jmeno
            // 
            this.Smaz_jmeno.Enabled = false;
            this.Smaz_jmeno.Location = new System.Drawing.Point(418, 500);
            this.Smaz_jmeno.Name = "Smaz_jmeno";
            this.Smaz_jmeno.Size = new System.Drawing.Size(121, 23);
            this.Smaz_jmeno.TabIndex = 33;
            this.Smaz_jmeno.Text = "Smaž vybranné jméno";
            this.Smaz_jmeno.UseVisualStyleBackColor = true;
            this.Smaz_jmeno.Click += new System.EventHandler(this.Smaz_jmeno_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(107, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 150);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(406, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 246);
            this.panel4.TabIndex = 36;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(335, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 640);
            this.Controls.Add(this.Posun_dolu);
            this.Controls.Add(this.Smaz_jmeno);
            this.Controls.Add(this.Posun_nahoru);
            this.Controls.Add(this.Vypis_nove_jmeno);
            this.Controls.Add(this.Vloz_jmeno);
            this.Controls.Add(this.Jmeno_do_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nacti_list);
            this.Controls.Add(this.Hledej_list);
            this.Controls.Add(this.Jmeno_list_souboru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Obrat);
            this.Controls.Add(this.Hledej2);
            this.Controls.Add(this.Obrat_vysledek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hledej);
            this.Controls.Add(this.Pozpat_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Psani);
            this.Controls.Add(this.Prochazet);
            this.Controls.Add(this.poleobsah);
            this.Controls.Add(this.ZapisDoSouboru);
            this.Controls.Add(this.Otevritsoubor);
            this.Controls.Add(this.Cti);
            this.Controls.Add(this.UTF_16_B);
            this.Controls.Add(this.UTF_16_L);
            this.Controls.Add(this.UTF_8);
            this.Controls.Add(this.Latin_2);
            this.Controls.Add(this.Win_CP_852);
            this.Controls.Add(this.Win_CP_1250);
            this.Controls.Add(this.Jmeno_souboru);
            this.Controls.Add(this.Zapis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Hraní si se soubory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.TextBox Jmeno_souboru;
        private System.Windows.Forms.RadioButton Win_CP_1250;
        private System.Windows.Forms.RadioButton Win_CP_852;
        private System.Windows.Forms.RadioButton Latin_2;
        private System.Windows.Forms.RadioButton UTF_8;
        private System.Windows.Forms.RadioButton UTF_16_L;
        private System.Windows.Forms.RadioButton UTF_16_B;
        private System.Windows.Forms.Button Cti;
        private System.Windows.Forms.Button Otevritsoubor;
        private System.Windows.Forms.Button ZapisDoSouboru;
        private System.Windows.Forms.TextBox poleobsah;
        private System.Windows.Forms.Button Prochazet;
        private System.Windows.Forms.TextBox Psani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pozpat_text;
        private System.Windows.Forms.Button Hledej;
        private System.Windows.Forms.Button Hledej2;
        private System.Windows.Forms.TextBox Obrat_vysledek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Obrat;
        private System.Windows.Forms.Button Hledej_list;
        private System.Windows.Forms.TextBox Jmeno_list_souboru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Nacti_list;
        private System.Windows.Forms.Button Vloz_jmeno;
        private System.Windows.Forms.TextBox Jmeno_do_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Vypis_nove_jmeno;
        private System.Windows.Forms.Button Posun_nahoru;
        private System.Windows.Forms.Button Posun_dolu;
        private System.Windows.Forms.Button Smaz_jmeno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

