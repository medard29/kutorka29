using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Převody_mezi_soustavama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();              // Inicializace základních komponent formuláře
            InitializeCustomComponents();       // Místo pro vlastní inicializační logiku (není využito)
        }

        private void InitializeCustomComponents()
        {
            // Zde můžeš např. přidat logiku pro stylování nebo jinou přípravu komponent
        }

        private void Preved_Click(object sender, EventArgs e)
        {
            vymaz(); // Tlačítko "Převést" zatím jen maže všechny vstupy
        }

        // Validace a převod z desítkové soustavy
        private void ValidateAndConvertDecimal()
        {
            string decimalPattern = "^\\d{1,5}$";  // Desítkové číslo: 1 až 5 číslic

            // Kontrola pomocí regulárního výrazu + parsování
            if (Regex.IsMatch(Desitkova.Text, decimalPattern) &&
                int.TryParse(Desitkova.Text, out int decimalValue) &&
                decimalValue <= 65535)
            {
                Binarni.Text = Convert.ToString(decimalValue, 2);             // Desítkové → Binární
                Hexadecimal.Text = Convert.ToString(decimalValue, 16).ToUpper(); // Desítkové → Hex
            }
            else
            {
                // Pokud vstup není prázdný, zobraz chybovou hlášku
                if (!string.IsNullOrEmpty(Desitkova.Text))
                {
                    vymaz();
                    MessageBox.Show("Zadejte platné celé číslo v rozsahu 0 až 65 535.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validace a převod z binární soustavy
        private void ValidateAndConvertBinary()
        {
            string binaryPattern = "^[01]+$"; // Binární číslo: pouze 0 a 1

            if (Regex.IsMatch(Binarni.Text, binaryPattern))
            {
                try
                {
                    int decimalValue = Convert.ToInt32(Binarni.Text, 2); // Binární → Desítkové

                    if (decimalValue <= 65535)
                    {
                        Desitkova.Text = decimalValue.ToString();                 // Do desítkové
                        Hexadecimal.Text = Convert.ToString(decimalValue, 16).ToUpper(); // Do hex
                    }
                    else
                    {
                        throw new Exception(); // Číslo mimo rozsah
                    }
                }
                catch
                {
                    vymaz();
                    MessageBox.Show("Zadejte platné binární číslo v rozsahu 0 až 65 535.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(Binarni.Text))
                {
                    vymaz();
                    MessageBox.Show("Zadejte platné binární číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validace a převod z šestnáctkové soustavy
        private void ValidateAndConvertHexadecimal()
        {
            string hexPattern = "^[0-9A-Fa-f]+$"; // Hexadecimální číslo: číslice a písmena A–F (malá i velká)

            if (Regex.IsMatch(Hexadecimal.Text, hexPattern))
            {
                try
                {
                    int decimalValue = Convert.ToInt32(Hexadecimal.Text, 16); // Hex → Desítkové

                    if (decimalValue <= 65535)
                    {
                        Desitkova.Text = decimalValue.ToString();     // Do desítkové
                        Binarni.Text = Convert.ToString(decimalValue, 2); // Do binární
                    }
                    else
                    {
                        throw new Exception(); // Číslo mimo rozsah
                    }
                }
                catch
                {
                    vymaz();
                    MessageBox.Show("Zadejte platné šestnáctkové číslo v rozsahu 0 až 65 535.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(Hexadecimal.Text))
                {
                    vymaz();
                    MessageBox.Show("Zadejte platné šestnáctkové číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Vymaže všechna pole
        private void vymaz()
        {
            Desitkova.Text = "";
            Hexadecimal.Text = "";
            Binarni.Text = "";
        }

        // Událost při změně hodnoty v desítkovém poli
        private void Desitkova_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValidateAndConvertDecimal();
            }
            catch
            {
                // Nezobrazujeme chybu – validace se postará
            }
        }

        // Událost při změně hodnoty v binárním poli
        private void Binarni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValidateAndConvertBinary();
            }
            catch
            {
                // Nezobrazujeme chybu – validace se postará
            }
        }

        // Událost při změně hodnoty v hexadecimálním poli
        private void Hexadecimal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValidateAndConvertHexadecimal();
            }
            catch
            {
                // Nezobrazujeme chybu – validace se postará
            }
        }
    }
}
