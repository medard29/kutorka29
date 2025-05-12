namespace menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nabídkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtevritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakaznikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Jméno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Přimení = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bydliště = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstranitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nabídkaToolStripMenuItem,
            this.zakaznikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nabídkaToolStripMenuItem
            // 
            this.nabídkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OtevritToolStripMenuItem,
            this.uložitToolStripMenuItem,
            this.uložitJakoToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.nabídkaToolStripMenuItem.Name = "nabídkaToolStripMenuItem";
            this.nabídkaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.nabídkaToolStripMenuItem.Text = "Soubor";
            // 
            // OtevritToolStripMenuItem
            // 
            this.OtevritToolStripMenuItem.Name = "OtevritToolStripMenuItem";
            this.OtevritToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.OtevritToolStripMenuItem.Text = "Otevřít";
            this.OtevritToolStripMenuItem.Click += new System.EventHandler(this.OtevritToolStripMenuItem_Click);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uložitToolStripMenuItem.Text = "Uložit";
 
            // 
            // uložitJakoToolStripMenuItem
            // 
            this.uložitJakoToolStripMenuItem.Name = "uložitJakoToolStripMenuItem";
            this.uložitJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uložitJakoToolStripMenuItem.Text = "Uložit jako";

            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.konecToolStripMenuItem.Text = "Konec";
 
            // 
            // zakaznikToolStripMenuItem
            // 
            this.zakaznikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.odstranitToolStripMenuItem});
            this.zakaznikToolStripMenuItem.Name = "zakaznikToolStripMenuItem";
            this.zakaznikToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.zakaznikToolStripMenuItem.Text = "Zákazník";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jméno,
            this.Přimení,
            this.Bydliště});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Jméno
            // 
            this.Jméno.HeaderText = "Jméno";
            this.Jméno.Name = "Jméno";
            this.Jméno.ReadOnly = true;
            // 
            // Přimení
            // 
            this.Přimení.HeaderText = "Přimení";
            this.Přimení.Name = "Přimení";
            this.Přimení.ReadOnly = true;
            // 
            // Bydliště
            // 
            this.Bydliště.HeaderText = "Bydliště";
            this.Bydliště.Name = "Bydliště";
            this.Bydliště.ReadOnly = true;
            // 
            // novýToolStripMenuItem
            // 
            this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novýToolStripMenuItem.Text = "Nový";

            // 
            // odstranitToolStripMenuItem
            // 
            this.odstranitToolStripMenuItem.Name = "odstranitToolStripMenuItem";
            this.odstranitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odstranitToolStripMenuItem.Text = "Odstranit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editace_tabulkových dat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nabídkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakaznikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OtevritToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jméno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Přimení;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bydliště;
        private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstranitToolStripMenuItem;
    }
}

