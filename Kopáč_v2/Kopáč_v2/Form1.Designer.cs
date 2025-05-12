namespace Kopáč_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Kopac_hodnota = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 209);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Kopáč:";
            // 
            // Kopac_hodnota
            // 
            Kopac_hodnota.Location = new Point(67, 206);
            Kopac_hodnota.Name = "Kopac_hodnota";
            Kopac_hodnota.Size = new Size(100, 23);
            Kopac_hodnota.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(186, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 420);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(67, 258);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Zobraz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(Kopac_hodnota);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Kopac_hodnota;
        private Panel panel1;
        private Button button1;
    }
}
