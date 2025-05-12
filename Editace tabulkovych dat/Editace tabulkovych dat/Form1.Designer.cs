namespace Editace_tabulkovych_dat
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
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zákazníkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstranitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vyhledavaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualniZaznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pocetJmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatDoSeznamuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odebratZeSeznamuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDoSouborutxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chybějícíEmailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportEmailůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxMesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Adresa_email = new System.Windows.Forms.TextBox();
            this.Domena_emailu = new System.Windows.Forms.TextBox();
            this.listBoxSeznam = new System.Windows.Forms.ListBox();
            this.Jmeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emaily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.zákazníkToolStripMenuItem,
            this.vyhledavaniToolStripMenuItem,
            this.seznamToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítCtrlOToolStripMenuItem,
            this.uložitCtrlSToolStripMenuItem,
            this.uložitJakoToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // otevřítCtrlOToolStripMenuItem
            // 
            this.otevřítCtrlOToolStripMenuItem.Name = "otevřítCtrlOToolStripMenuItem";
            this.otevřítCtrlOToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.otevřítCtrlOToolStripMenuItem.Text = "&Otevřít";
            this.otevřítCtrlOToolStripMenuItem.Click += new System.EventHandler(this.otevřítCtrlOToolStripMenuItem_Click);
            // 
            // uložitCtrlSToolStripMenuItem
            // 
            this.uložitCtrlSToolStripMenuItem.Name = "uložitCtrlSToolStripMenuItem";
            this.uložitCtrlSToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uložitCtrlSToolStripMenuItem.Text = "Uložit";
            this.uložitCtrlSToolStripMenuItem.Click += new System.EventHandler(this.uložitCtrlSToolStripMenuItem_Click);
            // 
            // uložitJakoToolStripMenuItem
            // 
            this.uložitJakoToolStripMenuItem.Name = "uložitJakoToolStripMenuItem";
            this.uložitJakoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uložitJakoToolStripMenuItem.Text = "Uložit jako";
            this.uložitJakoToolStripMenuItem.Click += new System.EventHandler(this.uložitJakoToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // zákazníkToolStripMenuItem
            // 
            this.zákazníkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.odstranitToolStripMenuItem});
            this.zákazníkToolStripMenuItem.Name = "zákazníkToolStripMenuItem";
            this.zákazníkToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.zákazníkToolStripMenuItem.Text = "Zákazník";
            // 
            // novýToolStripMenuItem
            // 
            this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.novýToolStripMenuItem.Text = "Nový";
            this.novýToolStripMenuItem.Click += new System.EventHandler(this.novýToolStripMenuItem_Click);
            // 
            // odstranitToolStripMenuItem
            // 
            this.odstranitToolStripMenuItem.Name = "odstranitToolStripMenuItem";
            this.odstranitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.odstranitToolStripMenuItem.Text = "Odstranit";
            this.odstranitToolStripMenuItem.Click += new System.EventHandler(this.odstranitToolStripMenuItem_Click);
            // 
            // vyhledavaniToolStripMenuItem
            // 
            this.vyhledavaniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualniZaznamToolStripMenuItem,
            this.pocetJmenToolStripMenuItem,
            this.mestaToolStripMenuItem});
            this.vyhledavaniToolStripMenuItem.Name = "vyhledavaniToolStripMenuItem";
            this.vyhledavaniToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.vyhledavaniToolStripMenuItem.Text = "Vyhledavani";
            // 
            // aktualniZaznamToolStripMenuItem
            // 
            this.aktualniZaznamToolStripMenuItem.Name = "aktualniZaznamToolStripMenuItem";
            this.aktualniZaznamToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aktualniZaznamToolStripMenuItem.Text = "Aktualni zaznam";
            this.aktualniZaznamToolStripMenuItem.Click += new System.EventHandler(this.aktualniZaznamToolStripMenuItem_Click);
            // 
            // pocetJmenToolStripMenuItem
            // 
            this.pocetJmenToolStripMenuItem.Name = "pocetJmenToolStripMenuItem";
            this.pocetJmenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pocetJmenToolStripMenuItem.Text = "Pocet jmen";
            this.pocetJmenToolStripMenuItem.Click += new System.EventHandler(this.pocetJmenToolStripMenuItem_Click);
            // 
            // mestaToolStripMenuItem
            // 
            this.mestaToolStripMenuItem.Name = "mestaToolStripMenuItem";
            this.mestaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mestaToolStripMenuItem.Text = "Mesta";
            this.mestaToolStripMenuItem.Click += new System.EventHandler(this.mestaToolStripMenuItem_Click);
            // 
            // seznamToolStripMenuItem
            // 
            this.seznamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatDoSeznamuToolStripMenuItem,
            this.odebratZeSeznamuToolStripMenuItem,
            this.exportDoSouborutxtToolStripMenuItem});
            this.seznamToolStripMenuItem.Name = "seznamToolStripMenuItem";
            this.seznamToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.seznamToolStripMenuItem.Text = "Seznam";
            // 
            // přidatDoSeznamuToolStripMenuItem
            // 
            this.přidatDoSeznamuToolStripMenuItem.Name = "přidatDoSeznamuToolStripMenuItem";
            this.přidatDoSeznamuToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.přidatDoSeznamuToolStripMenuItem.Text = "Přidat do seznamu";
            this.přidatDoSeznamuToolStripMenuItem.Click += new System.EventHandler(this.přidatDoSeznamuToolStripMenuItem_Click);
            // 
            // odebratZeSeznamuToolStripMenuItem
            // 
            this.odebratZeSeznamuToolStripMenuItem.Name = "odebratZeSeznamuToolStripMenuItem";
            this.odebratZeSeznamuToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.odebratZeSeznamuToolStripMenuItem.Text = "Odebrat ze seznamu";
            this.odebratZeSeznamuToolStripMenuItem.Click += new System.EventHandler(this.odebratZeSeznamuToolStripMenuItem_Click);
            // 
            // exportDoSouborutxtToolStripMenuItem
            // 
            this.exportDoSouborutxtToolStripMenuItem.Name = "exportDoSouborutxtToolStripMenuItem";
            this.exportDoSouborutxtToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exportDoSouborutxtToolStripMenuItem.Text = "Export do souboru .txt";
            this.exportDoSouborutxtToolStripMenuItem.Click += new System.EventHandler(this.exportDoSouborutxtToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vložitToolStripMenuItem,
            this.smazatToolStripMenuItem,
            this.chybějícíEmailyToolStripMenuItem,
            this.exportEmailůToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // vložitToolStripMenuItem
            // 
            this.vložitToolStripMenuItem.Name = "vložitToolStripMenuItem";
            this.vložitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.vložitToolStripMenuItem.Text = "Vložit";
            this.vložitToolStripMenuItem.Click += new System.EventHandler(this.vložitToolStripMenuItem_Click);
            // 
            // smazatToolStripMenuItem
            // 
            this.smazatToolStripMenuItem.Name = "smazatToolStripMenuItem";
            this.smazatToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.smazatToolStripMenuItem.Text = "Smazat";
            this.smazatToolStripMenuItem.Click += new System.EventHandler(this.smazatToolStripMenuItem_Click);
            // 
            // chybějícíEmailyToolStripMenuItem
            // 
            this.chybějícíEmailyToolStripMenuItem.Name = "chybějícíEmailyToolStripMenuItem";
            this.chybějícíEmailyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.chybějícíEmailyToolStripMenuItem.Text = "Chybějící emaily";
            this.chybějícíEmailyToolStripMenuItem.Click += new System.EventHandler(this.chybějícíEmailyToolStripMenuItem_Click);
            // 
            // exportEmailůToolStripMenuItem
            // 
            this.exportEmailůToolStripMenuItem.Name = "exportEmailůToolStripMenuItem";
            this.exportEmailůToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exportEmailůToolStripMenuItem.Text = "Export emailů";
            this.exportEmailůToolStripMenuItem.Click += new System.EventHandler(this.exportEmailůToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jmeno,
            this.Prijmeni,
            this.Ulice,
            this.cp,
            this.psc,
            this.mesto,
            this.Emaily});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 488);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxMesto
            // 
            this.textBoxMesto.Location = new System.Drawing.Point(809, 37);
            this.textBoxMesto.Name = "textBoxMesto";
            this.textBoxMesto.Size = new System.Drawing.Size(121, 20);
            this.textBoxMesto.TabIndex = 2;
            this.textBoxMesto.TextChanged += new System.EventHandler(this.textBoxMesto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oslovení";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(809, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seznam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(759, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doména:";
            // 
            // Adresa_email
            // 
            this.Adresa_email.Location = new System.Drawing.Point(815, 334);
            this.Adresa_email.Name = "Adresa_email";
            this.Adresa_email.Size = new System.Drawing.Size(421, 20);
            this.Adresa_email.TabIndex = 10;
            // 
            // Domena_emailu
            // 
            this.Domena_emailu.Location = new System.Drawing.Point(815, 364);
            this.Domena_emailu.Name = "Domena_emailu";
            this.Domena_emailu.Size = new System.Drawing.Size(421, 20);
            this.Domena_emailu.TabIndex = 11;
            // 
            // listBoxSeznam
            // 
            this.listBoxSeznam.FormattingEnabled = true;
            this.listBoxSeznam.Location = new System.Drawing.Point(815, 103);
            this.listBoxSeznam.Name = "listBoxSeznam";
            this.listBoxSeznam.Size = new System.Drawing.Size(421, 225);
            this.listBoxSeznam.TabIndex = 12;
            // 
            // Jmeno
            // 
            this.Jmeno.HeaderText = "jmeno";
            this.Jmeno.Name = "Jmeno";
            // 
            // Prijmeni
            // 
            this.Prijmeni.HeaderText = "prijmeni";
            this.Prijmeni.Name = "Prijmeni";
            // 
            // Ulice
            // 
            this.Ulice.HeaderText = "bydliste";
            this.Ulice.Name = "Ulice";
            // 
            // cp
            // 
            this.cp.HeaderText = "č.p.";
            this.cp.Name = "cp";
            // 
            // psc
            // 
            this.psc.HeaderText = "PSČ";
            this.psc.Name = "psc";
            // 
            // mesto
            // 
            this.mesto.HeaderText = "Město";
            this.mesto.Name = "mesto";
            // 
            // Emaily
            // 
            this.Emaily.HeaderText = "Emaily";
            this.Emaily.Name = "Emaily";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 543);
            this.Controls.Add(this.listBoxSeznam);
            this.Controls.Add(this.Domena_emailu);
            this.Controls.Add(this.Adresa_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMesto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zákazníkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstranitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem vyhledavaniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualniZaznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pocetJmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mestaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxMesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem seznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatDoSeznamuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odebratZeSeznamuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDoSouborutxtToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Adresa_email;
        private System.Windows.Forms.TextBox Domena_emailu;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smazatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chybějícíEmailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportEmailůToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSeznam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jmeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijmeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn psc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emaily;
    }
}

