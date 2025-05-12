namespace Test02
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
            this.label1 = new System.Windows.Forms.Label();
            this.Vstupní_soubor = new System.Windows.Forms.TextBox();
            this.Hledat_soubor1 = new System.Windows.Forms.Button();
            this.Hledat_soubor2 = new System.Windows.Forms.Button();
            this.Vystupni_soubor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minuty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Hodiny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cas_mezi_zavodniky = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Vytvor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soubor přihlášek (vstupní):";
            // 
            // Vstupní_soubor
            // 
            this.Vstupní_soubor.Location = new System.Drawing.Point(14, 34);
            this.Vstupní_soubor.Name = "Vstupní_soubor";
            this.Vstupní_soubor.Size = new System.Drawing.Size(100, 20);
            this.Vstupní_soubor.TabIndex = 1;
            this.Vstupní_soubor.TextChanged += new System.EventHandler(this.Vstupní_soubor_TextChanged);
            // 
            // Hledat_soubor1
            // 
            this.Hledat_soubor1.Location = new System.Drawing.Point(137, 34);
            this.Hledat_soubor1.Name = "Hledat_soubor1";
            this.Hledat_soubor1.Size = new System.Drawing.Size(75, 23);
            this.Hledat_soubor1.TabIndex = 2;
            this.Hledat_soubor1.Text = "Procházet";
            this.Hledat_soubor1.UseVisualStyleBackColor = true;
            this.Hledat_soubor1.Click += new System.EventHandler(this.Hledat_soubor1_Click);
            // 
            // Hledat_soubor2
            // 
            this.Hledat_soubor2.Location = new System.Drawing.Point(136, 104);
            this.Hledat_soubor2.Name = "Hledat_soubor2";
            this.Hledat_soubor2.Size = new System.Drawing.Size(75, 23);
            this.Hledat_soubor2.TabIndex = 5;
            this.Hledat_soubor2.Text = "Procházet";
            this.Hledat_soubor2.UseVisualStyleBackColor = true;
            this.Hledat_soubor2.Click += new System.EventHandler(this.Hledat_soubor2_Click);
            // 
            // Vystupni_soubor
            // 
            this.Vystupni_soubor.Location = new System.Drawing.Point(13, 104);
            this.Vystupni_soubor.Name = "Vystupni_soubor";
            this.Vystupni_soubor.Size = new System.Drawing.Size(100, 20);
            this.Vystupni_soubor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soubor startovní listiny (vytvářený)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minuty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Hodiny);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 88);
            this.panel1.TabIndex = 6;
            // 
            // Minuty
            // 
            this.Minuty.Location = new System.Drawing.Point(81, 43);
            this.Minuty.Name = "Minuty";
            this.Minuty.Size = new System.Drawing.Size(38, 20);
            this.Minuty.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minuta:";
            // 
            // Hodiny
            // 
            this.Hodiny.Location = new System.Drawing.Point(81, 17);
            this.Hodiny.Name = "Hodiny";
            this.Hodiny.Size = new System.Drawing.Size(38, 20);
            this.Hodiny.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hodina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "První startuje";
            // 
            // cas_mezi_zavodniky
            // 
            this.cas_mezi_zavodniky.Location = new System.Drawing.Point(173, 280);
            this.cas_mezi_zavodniky.Name = "cas_mezi_zavodniky";
            this.cas_mezi_zavodniky.Size = new System.Drawing.Size(38, 20);
            this.cas_mezi_zavodniky.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "interval mezi závodníky (minut):";
            // 
            // Vytvor
            // 
            this.Vytvor.Location = new System.Drawing.Point(34, 338);
            this.Vytvor.Name = "Vytvor";
            this.Vytvor.Size = new System.Drawing.Size(163, 100);
            this.Vytvor.TabIndex = 12;
            this.Vytvor.Text = "Vytvoř listinu";
            this.Vytvor.UseVisualStyleBackColor = true;
            this.Vytvor.Click += new System.EventHandler(this.Vytvor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 450);
            this.Controls.Add(this.Vytvor);
            this.Controls.Add(this.cas_mezi_zavodniky);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hledat_soubor2);
            this.Controls.Add(this.Vystupni_soubor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hledat_soubor1);
            this.Controls.Add(this.Vstupní_soubor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vstupní_soubor;
        private System.Windows.Forms.Button Hledat_soubor1;
        private System.Windows.Forms.Button Hledat_soubor2;
        private System.Windows.Forms.TextBox Vystupni_soubor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Minuty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Hodiny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cas_mezi_zavodniky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Vytvor;
    }
}

