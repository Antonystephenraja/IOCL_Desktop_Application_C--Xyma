using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
namespace IOCL
{
    public partial class testing : Form
    {
        private bool hasDataLoaded = false;

        private MySqlConnection connection;
        private string server = "127.0.0.1";
        private string database = "desktop_iocl";
        private string uid = "root";
        private string password = "";
        private void InitializeDatabase()
        {
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }
        public testing()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            InitializeDatabase();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            Loaddropdown();
            SetInitialLabelValues();

        }
        private void SetInitialLabelValues()
        {
            temp_data.Text = "N/A";
            density_data.Text = "N/A";
            viscosity_data.Text = "N/A";
        }
        private void Loaddropdown()
        {
            try
            {
                string jsonFilePath = @"D:\xyma\Results_iocl\Waveguide_Calibration_results\fluid_parameters.json";
                string json = File.ReadAllText(jsonFilePath);
                JObject jsonObject = JObject.Parse(json);
                var keys = jsonObject.Properties().Select(p => p.Name).ToList();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(keys.ToArray());
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

                /*connection.Open();
                string query = "SELECT fluid FROM data ";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["fluid"].ToString());
                }
                reader.Close();*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private bool dataDisplayed = false;
        private void UpdateLabelsData()
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM data ORDER BY id DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    String temperature = reader["temperature"].ToString();
                    String density = reader["density"].ToString();
                    String viscosity = reader["viscosity"].ToString();
                    temp_data.Text = temperature + "° C";
                    density_data.Text = density + " kg/m³";
                    viscosity_data.Text = viscosity + " cSt";
                    comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void testing_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabelsData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFluid = comboBox1.SelectedItem.ToString();
            //UpdateLabelsData(selectedFluid);
            UpdateIniFile(selectedFluid);
        }
        private void UpdateIniFile(string selectedFluid)
        {
            try
            {
                string iniFilePath = @"D:\xyma\Results_iocl\exe\testing\IOCL_TESTING.ini";

                var iniLines = File.ReadAllLines(iniFilePath);
                for (int i = 0; i < iniLines.Length; i++)
                {
                    if (iniLines[i].StartsWith("Fluid_Name"))
                    {
                        iniLines[i] = "Fluid_Name = " + selectedFluid;
                    }
                }

                File.WriteAllLines(iniFilePath, iniLines);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating INI file: " + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string exeFilePath = @"D:\xyma\Results_iocl\exe\testing\smaple.exe";
            Process.Start(exeFilePath);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exeFileName = "smaple.exe";
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(exeFileName));

            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                if (!process.WaitForExit(500))
                {
                    process.Kill();
                    MessageBox.Show("Procced Ended");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
