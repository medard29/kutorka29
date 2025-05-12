using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Získání_informací_o_operačního_systému // Opravený název namespace (bez mezer, diakritiky)
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Proměnná pro sběr výstupu – opakovaně využívaná metoda pro různé sekce
        StringBuilder vypisText = new StringBuilder();

        // Vypíše všechny běžící procesy
        private void Procesy_Click(object sender, EventArgs e)
        {
            VypisTextBox.Text = "";

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                // Každý proces zobrazí jméno a ID
                vypisText.AppendLine($"Název: {process.ProcessName}, ID: {process.Id}");
            }

            VypisTextBox.Text = vypisText.ToString();
            vypisText.Clear();
        }

        // Vypíše informace o všech připojených discích
        private void Disky_Click(object sender, EventArgs e)
        {
            VypisTextBox.Text = "";

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady) // Pokud je disk připraven (vložený, dostupný)
                {
                    string driveType = drive.DriveType == DriveType.Network ? "Síťový" : "Pevný";
                    vypisText.AppendLine(
                        $"Název disku: {drive.Name}, Typ: {driveType}, Celková velikost: {FormatBytes(drive.TotalSize)}, Volné místo: {FormatBytes(drive.AvailableFreeSpace)}\n"
                    );
                }
            }

            VypisTextBox.Text = vypisText.ToString();
            vypisText.Clear();
        }

        // Zobrazí paměťové informace pouze o disku C
        private void Pamet_Click(object sender, EventArgs e)
        {
            VypisTextBox.Text = "";

            try
            {
                DriveInfo driveInfo = new DriveInfo("C"); // Pevně nastaveno na disk C

                long totalSize = driveInfo.TotalSize;
                long usedSpace = totalSize - driveInfo.AvailableFreeSpace;
                long freeSpace = driveInfo.AvailableFreeSpace;

                vypisText.AppendLine($"Celkové místo na disku C: {FormatBytes(totalSize)}");
                vypisText.AppendLine($"Zabrané místo: {FormatBytes(usedSpace)}");
                vypisText.AppendLine($"Volné místo: {FormatBytes(freeSpace)}");
            }
            catch (Exception ex)
            {
                // Ošetření chyb, např. pokud disk C neexistuje
                vypisText.AppendLine("Chyba při čtení disku: " + ex.Message);
            }

            VypisTextBox.Text = vypisText.ToString();
            vypisText.Clear();
        }

        // Pomocná metoda pro formátování velikostí (např. bajty -> MB, GB...)
        private string FormatBytes(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int i = 0;
            double doubleBytes = bytes;

            while (i < suffixes.Length - 1 && doubleBytes >= 1024)
            {
                doubleBytes /= 1024;
                i++;
            }

            return $"{doubleBytes:0.##} {suffixes[i]}";
        }

        // Získání informací o OS pomocí WMI
        private void Informace_Click(object sender, EventArgs e)
        {
            VypisTextBox.Text = "";

            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject managementObject in mos.Get())
                {
                    // Výpis různých vlastností, pokud existují
                    if (managementObject["Caption"] != null)
                        vypisText.AppendLine($"Název OS : {managementObject["Caption"]}");

                    if (managementObject["OSArchitecture"] != null)
                        vypisText.AppendLine($"Architektura : {managementObject["OSArchitecture"]}");

                    if (managementObject["CSDVersion"] != null)
                        vypisText.AppendLine($"Service Pack : {managementObject["CSDVersion"]}");

                    if (managementObject["Version"] != null)
                        vypisText.AppendLine($"Verze OS : {managementObject["Version"]}");

                    if (managementObject["BuildNumber"] != null)
                        vypisText.AppendLine($"Číslo buildu : {managementObject["BuildNumber"]}");

                    if (managementObject["Manufacturer"] != null)
                        vypisText.AppendLine($"Výrobce : {managementObject["Manufacturer"]}");

                    if (managementObject["LastBootUpTime"] != null)
                        vypisText.AppendLine($"Poslední spuštění : {managementObject["LastBootUpTime"]}");
                }
            }
            catch (Exception ex)
            {
                // Výpis chyby, pokud dotaz WMI selže
                vypisText.AppendLine("Chyba při získávání informací o OS: " + ex.Message);
            }

            VypisTextBox.Text = vypisText.ToString();
            vypisText.Clear();
        }

        // Zavře aplikaci
        private void Zavrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
