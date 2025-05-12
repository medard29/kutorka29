namespace Získání_informací_o_operačního_systému
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
            this.Disky = new System.Windows.Forms.Button();
            this.Procesy = new System.Windows.Forms.Button();
            this.Pamet = new System.Windows.Forms.Button();
            this.Informace = new System.Windows.Forms.Button();
            this.Zavrit = new System.Windows.Forms.Button();
            this.VypisTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Disky
            // 
            this.Disky.Location = new System.Drawing.Point(13, 13);
            this.Disky.Name = "Disky";
            this.Disky.Size = new System.Drawing.Size(105, 23);
            this.Disky.TabIndex = 0;
            this.Disky.Text = "Diskové jednotky";
            this.Disky.UseVisualStyleBackColor = true;
            this.Disky.Click += new System.EventHandler(this.Disky_Click);
            // 
            // Procesy
            // 
            this.Procesy.Location = new System.Drawing.Point(13, 70);
            this.Procesy.Name = "Procesy";
            this.Procesy.Size = new System.Drawing.Size(75, 23);
            this.Procesy.TabIndex = 1;
            this.Procesy.Text = "Procesy";
            this.Procesy.UseVisualStyleBackColor = true;
            this.Procesy.Click += new System.EventHandler(this.Procesy_Click);
            // 
            // Pamet
            // 
            this.Pamet.Location = new System.Drawing.Point(12, 133);
            this.Pamet.Name = "Pamet";
            this.Pamet.Size = new System.Drawing.Size(75, 23);
            this.Pamet.TabIndex = 2;
            this.Pamet.Text = "Paměť";
            this.Pamet.UseVisualStyleBackColor = true;
            this.Pamet.Click += new System.EventHandler(this.Pamet_Click);
            // 
            // Informace
            // 
            this.Informace.Location = new System.Drawing.Point(13, 198);
            this.Informace.Name = "Informace";
            this.Informace.Size = new System.Drawing.Size(75, 23);
            this.Informace.TabIndex = 3;
            this.Informace.Text = "informace";
            this.Informace.UseVisualStyleBackColor = true;
            this.Informace.Click += new System.EventHandler(this.Informace_Click);
            // 
            // Zavrit
            // 
            this.Zavrit.Location = new System.Drawing.Point(13, 272);
            this.Zavrit.Name = "Zavrit";
            this.Zavrit.Size = new System.Drawing.Size(75, 23);
            this.Zavrit.TabIndex = 4;
            this.Zavrit.Text = "Zavřít";
            this.Zavrit.UseVisualStyleBackColor = true;
            this.Zavrit.Click += new System.EventHandler(this.Zavrit_Click);
            // 
            // VypisTextBox
            // 
            this.VypisTextBox.Location = new System.Drawing.Point(147, 13);
            this.VypisTextBox.Multiline = true;
            this.VypisTextBox.Name = "VypisTextBox";
            this.VypisTextBox.ReadOnly = true;
            this.VypisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VypisTextBox.Size = new System.Drawing.Size(641, 282);
            this.VypisTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.VypisTextBox);
            this.Controls.Add(this.Zavrit);
            this.Controls.Add(this.Informace);
            this.Controls.Add(this.Pamet);
            this.Controls.Add(this.Procesy);
            this.Controls.Add(this.Disky);
            this.Name = "Form1";
            this.Text = "Ovládací panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Disky;
        private System.Windows.Forms.Button Procesy;
        private System.Windows.Forms.Button Pamet;
        private System.Windows.Forms.Button Informace;
        private System.Windows.Forms.Button Zavrit;
        private System.Windows.Forms.TextBox VypisTextBox;
    }
}

