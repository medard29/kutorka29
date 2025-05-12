namespace Krapniky
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
            this.Horni_krap = new System.Windows.Forms.TextBox();
            this.Dolni_Krap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rust_horni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rust_dolni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Proved = new System.Windows.Forms.Button();
            this.Vychozi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(119, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRAFIKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horní řada";
            // 
            // Horni_krap
            // 
            this.Horni_krap.Location = new System.Drawing.Point(92, 87);
            this.Horni_krap.Name = "Horni_krap";
            this.Horni_krap.Size = new System.Drawing.Size(179, 20);
            this.Horni_krap.TabIndex = 2;
            this.Horni_krap.Text = "10, 15, 20, 25, 30";
            this.Horni_krap.TextChanged += new System.EventHandler(this.Horni_krap_TextChanged);
            // 
            // Dolni_Krap
            // 
            this.Dolni_Krap.Location = new System.Drawing.Point(92, 113);
            this.Dolni_Krap.Name = "Dolni_Krap";
            this.Dolni_Krap.Size = new System.Drawing.Size(179, 20);
            this.Dolni_Krap.TabIndex = 4;
            this.Dolni_Krap.Text = "10, 15, 20, 25, 30";
            this.Dolni_Krap.TextChanged += new System.EventHandler(this.Dolni_Krap_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dolní řada";
            // 
            // Rust_horni
            // 
            this.Rust_horni.Location = new System.Drawing.Point(92, 139);
            this.Rust_horni.Name = "Rust_horni";
            this.Rust_horni.Size = new System.Drawing.Size(48, 20);
            this.Rust_horni.TabIndex = 6;
            this.Rust_horni.Text = "0";
            this.Rust_horni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Růst horní";
            // 
            // Rust_dolni
            // 
            this.Rust_dolni.Location = new System.Drawing.Point(92, 165);
            this.Rust_dolni.Name = "Rust_dolni";
            this.Rust_dolni.Size = new System.Drawing.Size(48, 20);
            this.Rust_dolni.TabIndex = 8;
            this.Rust_dolni.Text = "0";
            this.Rust_dolni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Růst dolní";
            // 
            // Proved
            // 
            this.Proved.Location = new System.Drawing.Point(179, 135);
            this.Proved.Name = "Proved";
            this.Proved.Size = new System.Drawing.Size(92, 50);
            this.Proved.TabIndex = 9;
            this.Proved.Text = "Proveď";
            this.Proved.UseVisualStyleBackColor = true;
            this.Proved.Click += new System.EventHandler(this.Proved_Click);
            // 
            // Vychozi
            // 
            this.Vychozi.Location = new System.Drawing.Point(55, 191);
            this.Vychozi.Name = "Vychozi";
            this.Vychozi.Size = new System.Drawing.Size(189, 23);
            this.Vychozi.TabIndex = 10;
            this.Vychozi.Text = "Výchozí stav";
            this.Vychozi.UseVisualStyleBackColor = true;
            this.Vychozi.Click += new System.EventHandler(this.Vychozi_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(289, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 200);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pokud jakýkoli obdélník dosáhne středu, jeho výška se změní na 0.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Vychozi);
            this.Controls.Add(this.Proved);
            this.Controls.Add(this.Rust_dolni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rust_horni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dolni_Krap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Horni_krap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grafika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Horni_krap;
        private System.Windows.Forms.TextBox Dolni_Krap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Rust_horni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rust_dolni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Proved;
        private System.Windows.Forms.Button Vychozi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}

