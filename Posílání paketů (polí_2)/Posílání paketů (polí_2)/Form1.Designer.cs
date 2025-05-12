namespace Posílání_paketů__polí_2_
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
            this.Data = new System.Windows.Forms.TextBox();
            this.Velikost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Vypis_poli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cislo = new System.Windows.Forms.TextBox();
            this.Jeden_paket = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Obracene = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(39, 4);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(533, 20);
            this.Data.TabIndex = 1;
            // 
            // Velikost
            // 
            this.Velikost.Location = new System.Drawing.Point(89, 30);
            this.Velikost.Name = "Velikost";
            this.Velikost.Size = new System.Drawing.Size(143, 20);
            this.Velikost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velikost paketů:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fragmentuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vypis_poli
            // 
            this.Vypis_poli.Location = new System.Drawing.Point(12, 108);
            this.Vypis_poli.Multiline = true;
            this.Vypis_poli.Name = "Vypis_poli";
            this.Vypis_poli.ReadOnly = true;
            this.Vypis_poli.Size = new System.Drawing.Size(305, 330);
            this.Vypis_poli.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Najdi paket:";
            // 
            // cislo
            // 
            this.cislo.Location = new System.Drawing.Point(688, 33);
            this.cislo.Name = "cislo";
            this.cislo.Size = new System.Drawing.Size(100, 20);
            this.cislo.TabIndex = 7;
            // 
            // Jeden_paket
            // 
            this.Jeden_paket.Location = new System.Drawing.Point(621, 68);
            this.Jeden_paket.Name = "Jeden_paket";
            this.Jeden_paket.ReadOnly = true;
            this.Jeden_paket.Size = new System.Drawing.Size(167, 20);
            this.Jeden_paket.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Najdi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(814, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Defragmentace";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Obracene
            // 
            this.Obracene.Location = new System.Drawing.Point(945, 9);
            this.Obracene.Name = "Obracene";
            this.Obracene.ReadOnly = true;
            this.Obracene.Size = new System.Drawing.Size(569, 20);
            this.Obracene.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Obracene);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Jeden_paket);
            this.Controls.Add(this.cislo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Vypis_poli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Velikost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.TextBox Velikost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Vypis_poli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cislo;
        private System.Windows.Forms.TextBox Jeden_paket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Obracene;
    }
}

