namespace Animace
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sloup1 = new System.Windows.Forms.NumericUpDown();
            this.Sloup2 = new System.Windows.Forms.NumericUpDown();
            this.Sloup3 = new System.Windows.Forms.NumericUpDown();
            this.Sloup4 = new System.Windows.Forms.NumericUpDown();
            this.Sloup5 = new System.Windows.Forms.NumericUpDown();
            this.Sloup10 = new System.Windows.Forms.NumericUpDown();
            this.Sloup9 = new System.Windows.Forms.NumericUpDown();
            this.Sloup8 = new System.Windows.Forms.NumericUpDown();
            this.Sloup7 = new System.Windows.Forms.NumericUpDown();
            this.Sloup6 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Rychlost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sloup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rychlost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafický ekvalizer";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 300);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Sloup1
            // 
            this.Sloup1.Location = new System.Drawing.Point(11, 347);
            this.Sloup1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup1.Name = "Sloup1";
            this.Sloup1.Size = new System.Drawing.Size(63, 20);
            this.Sloup1.TabIndex = 0;
            // 
            // Sloup2
            // 
            this.Sloup2.Location = new System.Drawing.Point(80, 347);
            this.Sloup2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup2.Name = "Sloup2";
            this.Sloup2.Size = new System.Drawing.Size(58, 20);
            this.Sloup2.TabIndex = 2;
            // 
            // Sloup3
            // 
            this.Sloup3.Location = new System.Drawing.Point(144, 347);
            this.Sloup3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup3.Name = "Sloup3";
            this.Sloup3.Size = new System.Drawing.Size(52, 20);
            this.Sloup3.TabIndex = 3;
            // 
            // Sloup4
            // 
            this.Sloup4.Location = new System.Drawing.Point(202, 347);
            this.Sloup4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup4.Name = "Sloup4";
            this.Sloup4.Size = new System.Drawing.Size(60, 20);
            this.Sloup4.TabIndex = 4;
            // 
            // Sloup5
            // 
            this.Sloup5.Location = new System.Drawing.Point(268, 347);
            this.Sloup5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup5.Name = "Sloup5";
            this.Sloup5.Size = new System.Drawing.Size(57, 20);
            this.Sloup5.TabIndex = 5;
            // 
            // Sloup10
            // 
            this.Sloup10.Location = new System.Drawing.Point(562, 347);
            this.Sloup10.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup10.Name = "Sloup10";
            this.Sloup10.Size = new System.Drawing.Size(49, 20);
            this.Sloup10.TabIndex = 10;
            // 
            // Sloup9
            // 
            this.Sloup9.Location = new System.Drawing.Point(506, 347);
            this.Sloup9.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup9.Name = "Sloup9";
            this.Sloup9.Size = new System.Drawing.Size(50, 20);
            this.Sloup9.TabIndex = 9;
            // 
            // Sloup8
            // 
            this.Sloup8.Location = new System.Drawing.Point(449, 347);
            this.Sloup8.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup8.Name = "Sloup8";
            this.Sloup8.Size = new System.Drawing.Size(51, 20);
            this.Sloup8.TabIndex = 8;
            // 
            // Sloup7
            // 
            this.Sloup7.Location = new System.Drawing.Point(393, 347);
            this.Sloup7.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup7.Name = "Sloup7";
            this.Sloup7.Size = new System.Drawing.Size(50, 20);
            this.Sloup7.TabIndex = 7;
            // 
            // Sloup6
            // 
            this.Sloup6.Location = new System.Drawing.Point(331, 347);
            this.Sloup6.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sloup6.Name = "Sloup6";
            this.Sloup6.Size = new System.Drawing.Size(56, 20);
            this.Sloup6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rychlost";
            // 
            // Rychlost
            // 
            this.Rychlost.Location = new System.Drawing.Point(63, 401);
            this.Rychlost.Name = "Rychlost";
            this.Rychlost.Size = new System.Drawing.Size(57, 20);
            this.Rychlost.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Počet za minutu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rychlost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sloup10);
            this.Controls.Add(this.Sloup9);
            this.Controls.Add(this.Sloup8);
            this.Controls.Add(this.Sloup7);
            this.Controls.Add(this.Sloup6);
            this.Controls.Add(this.Sloup5);
            this.Controls.Add(this.Sloup4);
            this.Controls.Add(this.Sloup3);
            this.Controls.Add(this.Sloup2);
            this.Controls.Add(this.Sloup1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Sloup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rychlost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Sloup1;
        private System.Windows.Forms.NumericUpDown Sloup2;
        private System.Windows.Forms.NumericUpDown Sloup3;
        private System.Windows.Forms.NumericUpDown Sloup4;
        private System.Windows.Forms.NumericUpDown Sloup5;
        private System.Windows.Forms.NumericUpDown Sloup10;
        private System.Windows.Forms.NumericUpDown Sloup9;
        private System.Windows.Forms.NumericUpDown Sloup8;
        private System.Windows.Forms.NumericUpDown Sloup7;
        private System.Windows.Forms.NumericUpDown Sloup6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Rychlost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

