using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IOCL
{
    public partial class Graph : Form
    {
        private MySqlConnection connection;
        private string server = "127.0.0.1";
        private string database = "desktop_iocl";
        private string uid = "root";
        private string password = "";
        private ChartValues<double> chartValues;
        private ChartValues<double> chartValues1;


        private void InitializeDatabase()
        {
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public Graph()
        {
            InitializeComponent();
            InitializeDatabase();
            label5.Visible = false;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            this.StartPosition = FormStartPosition.CenterScreen;

            chartValues = new ChartValues<double>();
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "ToF1",
                Values = chartValues
            });
            chartValues1 = new ChartValues<double>();
            cartesianChart2.Series.Add(new LineSeries
            {
                Title = "ToF2",
                Values = chartValues1
            });
        }

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool labelVisible = false;

        private void popup()
        {
            try
            {
                connection.Open();
                string query = "SELECT status FROM calibration ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                if (dt.Rows.Count > 0)
                {
                    int status = Convert.ToInt32(dt.Rows[0]["status"]);
                    if (status == 1)
                    {

                        label5.Visible = true;
                        labelVisible = true;


                        timer.Interval = 50000; // 1 minute
                        timer.Tick += (sender, e) =>
                        {
                            // Hide the label and stop the timer
                            label5.Visible = false;
                            labelVisible = false;
                            timer.Stop();
                        };
                        timer.Start();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private double lastFof1Value = double.NaN;

        private void FetchAndDisplayData()
        {
            try
            {
                connection.Open();
                string query = "SELECT tof1 FROM calibration ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                if (dt.Rows.Count > 0)
                {
                    string tof1ValueAsString = dt.Rows[0]["tof1"].ToString();
                    if (!string.IsNullOrEmpty(tof1ValueAsString))
                    {
                        if (double.TryParse(tof1ValueAsString, out double tof1Value))
                        {
                            if (!double.IsNaN(lastFof1Value) && tof1Value != lastFof1Value)
                            {
                                // tof1Value = Math.Round(tof1Value, 2);
                                chartValues.Add(tof1Value);
                                lastFof1Value = tof1Value;
                            }
                            else if (double.IsNaN(lastFof1Value))
                            {
                                lastFof1Value = tof1Value;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Could not convert 'tof1' value to double.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: 'tof1' value is empty or null.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        /*private double lastFof1Value = double.NaN;
        private void FetchAndDisplayData()
        {
            try
            {
                connection.Open();
                string query = "SELECT tof1 FROM calibration ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                if (dt.Rows.Count > 0)
                {
                    double fof1Value = Convert.ToDouble(dt.Rows[0]["tof1"]);
                    //int status = Convert.ToInt32(dt.Rows[0]["status"]);
                    if (!double.IsNaN(lastFof1Value) && fof1Value != lastFof1Value)
                    {
                        //fof1Value = Math.Round(fof1Value, 2);
                        chartValues.Add(fof1Value);
                        lastFof1Value = fof1Value;
                    }
                    else if (double.IsNaN(lastFof1Value))
                    {
                        lastFof1Value = fof1Value;
                    }
             

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }*/

        private double lastFof1Value1 = double.NaN;

        private void FetchAndDisplayData1()
        {
            try
            {
                connection.Open();
                string query = "SELECT tof2 FROM calibration ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                if (dt.Rows.Count > 0)
                {
                    string stringValue = dt.Rows[0]["tof2"].ToString();

                    // Attempt to convert the string value to a double
                    if (double.TryParse(stringValue, out double value))
                    {
                        if (!double.IsNaN(lastFof1Value1) && value != lastFof1Value1)
                        {
                            // Format the value to display only two decimal places
                            // value = Math.Round(value, 2);
                            chartValues1.Add(value);
                            lastFof1Value1 = value;
                        }
                        else if (double.IsNaN(lastFof1Value1))
                        {
                            lastFof1Value1 = value;
                        }
                    }
                    else
                    {
                        // Handle the case where the conversion from string to double fails
                        MessageBox.Show("Error: Could not convert 'tof2' value to double.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /*  private double lastFof1Value1 = double.NaN;
          private void FetchAndDisplayData1()
          {
              try
              {
                  connection.Open();
                  string query = "SELECT tof2 FROM calibration ORDER BY id DESC LIMIT 1";
                  MySqlCommand cmd = new MySqlCommand(query, connection);
                  DataTable dt = new DataTable();
                  using (MySqlDataReader reader = cmd.ExecuteReader())
                  {
                      dt.Load(reader);
                  }
                  if (dt.Rows.Count > 0)
                  {
                      double value = Convert.ToDouble(dt.Rows[0]["tof2"]);
                      if (!double.IsNaN(lastFof1Value1) && value != lastFof1Value1)
                      {
                          // Format the value to display only two decimal places
                          //value = Math.Round(value, 2);
                          chartValues1.Add(value);
                          lastFof1Value1 = value;
                      }
                      else if (double.IsNaN(lastFof1Value1))
                      {
                          lastFof1Value1 = value;
                      }
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error: " + ex.Message);
              }
              finally
              {
                  if (connection.State == ConnectionState.Open)
                  {
                      connection.Close();
                  }
              }
          }*/

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Waveguide_Calibration secondForm = new Waveguide_Calibration();
            secondForm.Show();
            this.Hide();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Graph_Load(object sender, EventArgs e)
        {
            FetchAndDisplayData();
            FetchAndDisplayData1();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FetchAndDisplayData();
            FetchAndDisplayData1();
            popup();

        }
        private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {


            string exeFileName = "iocl_demo.exe";
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(exeFileName));

            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                if (!process.WaitForExit(500))
                {
                    process.Kill();
                    MessageBox.Show("Process stoped");
                }
            }

            /*string exeFilePath = @"D:\xyma\Results_iocl\exe\dist\iocl_demo.exe";
            Process[] processes = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(exeFilePath));

            foreach (Process process in processes)
            {
                if (process.MainModule.FileName.Equals(exeFilePath, StringComparison.OrdinalIgnoreCase))
                {
                    process.Kill();
                    MessageBox.Show("Process terminated successfully.");
                    //return;
                    break;
                }
            }

            MessageBox.Show("Process not found.");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter your Temperature:", "Input Dialog", "");

            if (!string.IsNullOrEmpty(userInput))
            {
                string filePath = @"D:\xyma\Results_iocl\Code\sgri.ini";
                string[] lines = File.ReadAllLines(filePath);
                int sectionStartIndex = Array.IndexOf(lines, "[CALIBRATION PARAMETERS]");

                if (sectionStartIndex >= 0)
                {
                    // Find the line with "Temp_nos" and update its value
                    for (int i = sectionStartIndex + 1; i < lines.Length; i++)
                    {
                        if (lines[i].Trim().StartsWith("temp_nos"))
                        {
                            lines[i] = "temp_nos = " + userInput;
                            break;
                        }
                    }
                    File.WriteAllLines(filePath, lines);
                }
                else
                {
                    lines = lines.Concat(new[]
                    {
                "[CALIBRATION PARAMETERS]",

                "Temp_nos = " + userInput  // Add the new line for Temp_nos
            }).ToArray();
                    File.WriteAllLines(filePath, lines);
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            popup();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
