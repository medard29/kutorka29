using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sportka
{
    public partial class Form1 : Form
    {
        OpenFileDialog oknosouboruopen = new OpenFileDialog();
        int[] cisla;
        int[] vybrat;
        int ym;
        int xm;
        int pocet=0;
        int pomoc2 = 6;
        const int MaxNumbers = 6;
        const int MaxRange = 49;

        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int ctvercevel = panel1.Width / 7;
            int pocet_v_radku = 7;
            int aktualni = 1;

            for (int i = 0; i < MaxRange; i++)
            {
                int x = (i % pocet_v_radku) * ctvercevel;
                int y = (i / pocet_v_radku) * ctvercevel;

                
                bool jeShoda = cisla != null && cisla.Contains(aktualni);
                bool jeShoda2 = vybrat != null && vybrat.Contains(aktualni);
                
                Color fillColor2 = jeShoda2 ? Color.LightGreen : Color.White;
                using (Brush brush = new SolidBrush(fillColor2))
                {
                    e.Graphics.FillRectangle(brush, x, y, ctvercevel, ctvercevel);
                }

                Color fillColor = jeShoda ? Color.LightGreen : Color.White;
                using (Brush brush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillRectangle(brush, x, y, ctvercevel, ctvercevel);
                }

                
                e.Graphics.DrawRectangle(new Pen(Color.Orange, 2), x, y, ctvercevel, ctvercevel);

                
                string number = aktualni.ToString();
                SizeF textSize = e.Graphics.MeasureString(number, this.Font);
                float textX = x + (ctvercevel - textSize.Width) / 2;
                float textY = y + (ctvercevel - textSize.Height) / 2;
                e.Graphics.DrawString(number, this.Font, Brushes.Black, textX, textY);

                aktualni++;
            }
        }

        private void Nacti_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = oknosouboruopen.ShowDialog();
            if (odpoved == DialogResult.OK)
            {
                string Jmeno_souboru = oknosouboruopen.FileName;

                try
                {
                    string obsah = File.ReadAllText(Jmeno_souboru);
                    var strCisla = obsah.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(c => c.Trim())
                                        .ToArray();

                    if (strCisla.Length != MaxNumbers)
                    {
                        MessageBox.Show("Čísel musí být 6");
                        return;
                    }

                    
                    cisla = strCisla.Select(c => int.Parse(c)).ToArray();

                    
                    foreach (int pomoc in cisla)
                    {
                        if (pomoc <= 0 || pomoc > MaxRange)
                        {
                            MessageBox.Show("Čísla musí být od 1 do 49");
                            return;
                        }
                    }

                    
                    for (int i = 0; i < cisla.Length; i++)
                    {
                        Controls["textBox" + (i + 1)].Text = cisla[i].ToString();
                    }

                    
                    panel1.Invalidate();
                }
                catch 
                {
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oknosouboruopen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        private string Porovnat(string pocet)
        {

            return string.Empty;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                Porovnat(textBox1.Text);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                Porovnat(textBox2.Text);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                Porovnat(textBox3.Text);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                Porovnat(textBox4.Text);
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                Porovnat(textBox5.Text);
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                Porovnat(textBox6.Text);
            }
        }

        private void Vybrat_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ym = e.Y; 
            xm = e.X; 
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int ctverceVel = panel1.Width / 7;
            int poleY = e.Y / ctverceVel;  
            int poleX = e.X / ctverceVel;  

            int cisloVPoli = poleY * 7 + poleX + 1;

            if (pocet < 6)  
            {
                if (cisloVPoli > 0 && cisloVPoli <= MaxRange)
                {
                    
                    Controls["textBox" + (pomoc2 + 1)].Text = cisloVPoli.ToString();
                    vybrat[pocet]= cisloVPoli;
                    pomoc2++;  
                    pocet++;
                    op
                    
                }
            }
            else
            {
                MessageBox.Show("Můžeš vybrat max 6 čísel");
                panel1.Invalidate();
            }
        }
    }
}
