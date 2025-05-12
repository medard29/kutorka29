namespace Převody_mezi_soustavama
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
            this.label2 = new System.Windows.Forms.Label();
            this.Desitkova = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Binarni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Preved = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Hexadecimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Převodník";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desítková";
            // 
            // Desitkova
            // 
            this.Desitkova.Location = new System.Drawing.Point(124, 39);
            this.Desitkova.Name = "Desitkova";
            this.Desitkova.Size = new System.Drawing.Size(100, 20);
            this.Desitkova.TabIndex = 2;
            this.Desitkova.TextChanged += new System.EventHandler(this.Desitkova_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "0 - 65 535";
            // 
            // Binarni
            // 
            this.Binarni.Location = new System.Drawing.Point(124, 65);
            this.Binarni.Name = "Binarni";
            this.Binarni.Size = new System.Drawing.Size(100, 20);
            this.Binarni.TabIndex = 5;
            this.Binarni.TextChanged += new System.EventHandler(this.Binarni_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Binární";
            // 
            // Preved
            // 
            this.Preved.Location = new System.Drawing.Point(233, 65);
            this.Preved.Name = "Preved";
            this.Preved.Size = new System.Drawing.Size(75, 23);
            this.Preved.TabIndex = 6;
            this.Preved.Text = "Clear";
            this.Preved.UseVisualStyleBackColor = true;
            this.Preved.Click += new System.EventHandler(this.Preved_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "0 - F";
            // 
            // Hexadecimal
            // 
            this.Hexadecimal.Location = new System.Drawing.Point(124, 91);
            this.Hexadecimal.Name = "Hexadecimal";
            this.Hexadecimal.Size = new System.Drawing.Size(100, 20);
            this.Hexadecimal.TabIndex = 8;
            this.Hexadecimal.TextChanged += new System.EventHandler(this.Hexadecimal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hexa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 146);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hexadecimal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Preved);
            this.Controls.Add(this.Binarni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Desitkova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Desitkova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Binarni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Preved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Hexadecimal;
        private System.Windows.Forms.Label label6;
    }
}

