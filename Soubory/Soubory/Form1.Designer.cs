namespace Soubory
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
            this.txtJmena = new System.Windows.Forms.TextBox();
            this.txtAdresy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hledej_Jmen = new System.Windows.Forms.Button();
            this.Hledej_soub = new System.Windows.Forms.Button();
            this.Proved = new System.Windows.Forms.Button();
            this.Misto_soub = new System.Windows.Forms.Button();
            this.txtVystup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Umístění souboru s jmény";
            // 
            // txtJmena
            // 
            this.txtJmena.Location = new System.Drawing.Point(150, 13);
            this.txtJmena.Name = "txtJmena";
            this.txtJmena.Size = new System.Drawing.Size(100, 20);
            this.txtJmena.TabIndex = 1;
            // 
            // txtAdresy
            // 
            this.txtAdresy.Location = new System.Drawing.Point(150, 39);
            this.txtAdresy.Name = "txtAdresy";
            this.txtAdresy.Size = new System.Drawing.Size(100, 20);
            this.txtAdresy.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Umístění souboru s adresy";
            // 
            // Hledej_Jmen
            // 
            this.Hledej_Jmen.Location = new System.Drawing.Point(267, 8);
            this.Hledej_Jmen.Name = "Hledej_Jmen";
            this.Hledej_Jmen.Size = new System.Drawing.Size(89, 23);
            this.Hledej_Jmen.TabIndex = 3;
            this.Hledej_Jmen.Text = "Hledej jména";
            this.Hledej_Jmen.UseVisualStyleBackColor = true;
            this.Hledej_Jmen.Click += new System.EventHandler(this.Hledej_Jmen_Click);
            // 
            // Hledej_soub
            // 
            this.Hledej_soub.Location = new System.Drawing.Point(267, 39);
            this.Hledej_soub.Name = "Hledej_soub";
            this.Hledej_soub.Size = new System.Drawing.Size(89, 23);
            this.Hledej_soub.TabIndex = 6;
            this.Hledej_soub.Text = "Hledej adresy";
            this.Hledej_soub.UseVisualStyleBackColor = true;
            this.Hledej_soub.Click += new System.EventHandler(this.Hledej_soub_Click);
            // 
            // Proved
            // 
            this.Proved.Location = new System.Drawing.Point(159, 110);
            this.Proved.Name = "Proved";
            this.Proved.Size = new System.Drawing.Size(75, 23);
            this.Proved.TabIndex = 10;
            this.Proved.Text = "Proveď";
            this.Proved.UseVisualStyleBackColor = true;
            this.Proved.Click += new System.EventHandler(this.Proved_Click);
            // 
            // Misto_soub
            // 
            this.Misto_soub.Location = new System.Drawing.Point(267, 75);
            this.Misto_soub.Name = "Misto_soub";
            this.Misto_soub.Size = new System.Drawing.Size(89, 23);
            this.Misto_soub.TabIndex = 9;
            this.Misto_soub.Text = "Zadej místo";
            this.Misto_soub.UseVisualStyleBackColor = true;
            this.Misto_soub.Click += new System.EventHandler(this.Misto_soub_Click);
            // 
            // txtVystup
            // 
            this.txtVystup.Location = new System.Drawing.Point(150, 75);
            this.txtVystup.Name = "txtVystup";
            this.txtVystup.Size = new System.Drawing.Size(100, 20);
            this.txtVystup.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Umístění Výstup souboru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 161);
            this.Controls.Add(this.Misto_soub);
            this.Controls.Add(this.txtVystup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Proved);
            this.Controls.Add(this.Hledej_soub);
            this.Controls.Add(this.Hledej_Jmen);
            this.Controls.Add(this.txtAdresy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJmena);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJmena;
        private System.Windows.Forms.TextBox txtAdresy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Hledej_Jmen;
        private System.Windows.Forms.Button Hledej_soub;
        private System.Windows.Forms.Button Proved;
        private System.Windows.Forms.Button Misto_soub;
        private System.Windows.Forms.TextBox txtVystup;
        private System.Windows.Forms.Label label3;
    }
}

