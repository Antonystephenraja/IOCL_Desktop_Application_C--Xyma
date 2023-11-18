using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Diagnostics;
namespace IOCL
{
    public partial class Waveguide_Calibration : Form
    {
        public Waveguide_Calibration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void Waveguide_Calibration_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Main secondForm = new Main();
            secondForm.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string exeFilePath = @"D:\xyma\Results_iocl\exe\form_calibration\iocl_demo_fluid.exe";
            if (!IsProcessRunning("smaple.exe") && demoProcess == null)
            {
                if (File.Exists(exeFilePath))
                {
                    demoProcess = Process.Start(exeFilePath);
                    MessageBox.Show("Calibrated");
                }
                else
                {
                    MessageBox.Show("The executable file does not exist at the specified path.");
                }
            }
            else
            {
                MessageBox.Show("The executable is already running.");
            }


        }
        private bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }



        private Process demoProcess;
        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a file from the list.");
            }
            else if (string.IsNullOrWhiteSpace(trial_txt.Text))
            {
                MessageBox.Show("Please enter a trial number.");
            }
            else
            {
                string exeFilePath = @"D:\xyma\Results_iocl\exe\dist\iocl_demo.exe";
                Process.Start(exeFilePath);

                Graph secondForm = new Graph();
                secondForm.Show();
                this.Hide();
                string newName = fileName;
                string trialNumber = trial_txt.Text;
                string filePath = @"D:\xyma\Results_iocl\Code\sgri.ini";
                string[] lines = File.ReadAllLines(filePath);
                int sectionStartIndex = Array.IndexOf(lines, "[CALIBRATION PARAMETERS]");

                if (sectionStartIndex >= 0)
                {
                    lines[sectionStartIndex + 1] = "fluid_Name = " + newName;
                    lines[sectionStartIndex + 2] = "trial_number = " + trialNumber;
                    File.WriteAllLines(filePath, lines);
                }
                else
                {
                    lines = lines.Concat(new[]
                    {
                "[CALIBRATION PARAMETERS]",
                "fluid_Name = " + newName,
                "trial_number = " + trialNumber,
            }).ToArray();
                    File.WriteAllLines(filePath, lines);
                }
                trial_txt.Clear();
            }
        }
        private void temp_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private string selectedFolderPath = "D:\\xyma\\Results_iocl\\Manual_Testing_results";
        private void ok_Click(object sender, EventArgs e)
        {
            var files = System.IO.Directory.GetFiles(selectedFolderPath, "*.xlsx*", System.IO.SearchOption.AllDirectories);
            var fileNamesWithExtensions = files.Select(filePath => Path.GetFileName(filePath)).ToArray();
            listBox.DataSource = fileNamesWithExtensions;
        }
        private string fileName;
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                string selectedFile = listBox.SelectedItem.ToString();
                fileName = Path.GetFileNameWithoutExtension(selectedFile);
            }
        }
    }
}
