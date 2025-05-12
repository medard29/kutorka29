namespace Filtr_csv
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
            this.textBoxcsv = new System.Windows.Forms.TextBox();
            this.Prochazet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Jindy = new System.Windows.Forms.RadioButton();
            this.Zitrek = new System.Windows.Forms.RadioButton();
            this.Dnesek = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Vypsat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Kalendar = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soubor CSV ";
            // 
            // textBoxcsv
            // 
            this.textBoxcsv.Location = new System.Drawing.Point(3, 26);
            this.textBoxcsv.Name = "textBoxcsv";
            this.textBoxcsv.Size = new System.Drawing.Size(165, 20);
            this.textBoxcsv.TabIndex = 1;
            // 
            // Prochazet
            // 
            this.Prochazet.Location = new System.Drawing.Point(174, 26);
            this.Prochazet.Name = "Prochazet";
            this.Prochazet.Size = new System.Drawing.Size(112, 23);
            this.Prochazet.TabIndex = 2;
            this.Prochazet.Text = "Procházet";
            this.Prochazet.UseVisualStyleBackColor = true;
            this.Prochazet.Click += new System.EventHandler(this.Prochazet_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Kalendar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Jindy);
            this.panel1.Controls.Add(this.Zitrek);
            this.panel1.Controls.Add(this.Dnesek);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 148);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(62, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Zadat sem";
            // 
            // Jindy
            // 
            this.Jindy.AutoSize = true;
            this.Jindy.Location = new System.Drawing.Point(6, 63);
            this.Jindy.Name = "Jindy";
            this.Jindy.Size = new System.Drawing.Size(49, 17);
            this.Jindy.TabIndex = 3;
            this.Jindy.TabStop = true;
            this.Jindy.Text = "Jindy";
            this.Jindy.UseVisualStyleBackColor = true;
            // 
            // Zitrek
            // 
            this.Zitrek.AutoSize = true;
            this.Zitrek.Location = new System.Drawing.Point(6, 40);
            this.Zitrek.Name = "Zitrek";
            this.Zitrek.Size = new System.Drawing.Size(55, 17);
            this.Zitrek.TabIndex = 2;
            this.Zitrek.TabStop = true;
            this.Zitrek.Text = "Zítřek";
            this.Zitrek.UseVisualStyleBackColor = true;
            // 
            // Dnesek
            // 
            this.Dnesek.AutoSize = true;
            this.Dnesek.Checked = true;
            this.Dnesek.Location = new System.Drawing.Point(6, 17);
            this.Dnesek.Name = "Dnesek";
            this.Dnesek.Size = new System.Drawing.Size(62, 17);
            this.Dnesek.TabIndex = 1;
            this.Dnesek.TabStop = true;
            this.Dnesek.Text = "Dnešek";
            this.Dnesek.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Narozeniny";
            // 
            // Vypsat
            // 
            this.Vypsat.Location = new System.Drawing.Point(174, 64);
            this.Vypsat.Name = "Vypsat";
            this.Vypsat.Size = new System.Drawing.Size(112, 148);
            this.Vypsat.TabIndex = 5;
            this.Vypsat.Text = "Vypis";
            this.Vypsat.UseVisualStyleBackColor = true;
            this.Vypsat.Click += new System.EventHandler(this.Vypsat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(5, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(283, 121);
            this.listBox1.TabIndex = 6;
            // 
            // Kalendar
            // 
            this.Kalendar.AutoSize = true;
            this.Kalendar.Location = new System.Drawing.Point(4, 87);
            this.Kalendar.Name = "Kalendar";
            this.Kalendar.Size = new System.Drawing.Size(68, 17);
            this.Kalendar.TabIndex = 5;
            this.Kalendar.TabStop = true;
            this.Kalendar.Text = "Kalendář";
            this.Kalendar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 376);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Vypsat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Prochazet);
            this.Controls.Add(this.textBoxcsv);
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
        private System.Windows.Forms.TextBox textBoxcsv;
        private System.Windows.Forms.Button Prochazet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Jindy;
        private System.Windows.Forms.RadioButton Zitrek;
        private System.Windows.Forms.RadioButton Dnesek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Vypsat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Kalendar;
    }
}

