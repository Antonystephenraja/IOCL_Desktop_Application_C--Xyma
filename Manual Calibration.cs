using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IOCL
{
    public partial class Manual_Calibration : Form
    {
        private List<string> fluidValues = new List<string>();
        private List<string> trailValues = new List<string>();
        private List<string> temperatureValues = new List<string>();
        private List<string> densityValues = new List<string>();
        private List<string> viscosityValues = new List<string>();
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
        public Manual_Calibration()
        {
            InitializeComponent();
            InitializeDatabase();
            this.StartPosition = FormStartPosition.CenterScreen;
            Fluid_textBox.ReadOnly = false;
        }
        private void hide(object sender, EventArgs e)
        {
            Fluid_textBox.ReadOnly = true;
        }
        private void Manual_Calibration_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Trial", "Trial");
            dataGridView1.Columns.Add("Fluid", "Fluid");
            dataGridView1.Columns.Add("Temperature", "Temperature");
            dataGridView1.Columns.Add("Density", "Density");
            dataGridView1.Columns.Add("Viscosity", "Viscosity");
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < fluidValues.Count; i++)
            {
                dataGridView1.Rows.Add(
                    fluidValues[i],
                    float.Parse(trailValues[i]),
                    float.Parse(temperatureValues[i]),
                    float.Parse(densityValues[i]),
                    float.Parse(viscosityValues[i])
                );
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Main secondForm = new Main();
            secondForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                string fluid = fluidValues[e.RowIndex];
                string trail = trailValues[e.RowIndex];
                string temperature = temperatureValues[e.RowIndex];
                string density = densityValues[e.RowIndex];
                string viscosity = viscosityValues[e.RowIndex];

                MessageBox.Show($"Fluid:{fluid}\nTrail:{trail}\n Temperature: {temperature}\nDensity: {density}\nViscosity: {viscosity}");
            }
        }
        private void AutoCalibration_Load(object sender, EventArgs e)
        {
        }

        private string fluid = "";


        private void add_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string fluidValue = Fluid_textBox.Text;

            // Check if the value already exists in the 'fluid' column
            string selectQuery = $"SELECT COUNT(*) FROM fluids WHERE fluid = @fluidValue";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@fluidValue", fluidValue);

            int count = Convert.ToInt32(selectCommand.ExecuteScalar());

            if (count == 0)
            {
                // The value doesn't exist, so insert it
                string insertQuery = $"INSERT INTO fluids (fluid) VALUES (@fluidValue)";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@fluidValue", fluidValue);
                insertCommand.ExecuteNonQuery();
            }

            connection.Close();

            string storedFluidValue = Fluid_textBox.Text;
            string trail = textBox2.Text;
            string temperature = tmpText.Text;
            string density = density_textbox.Text;
            string viscosity = viscosity_textbox.Text;
            fluid = storedFluidValue;
            textBox2.ReadOnly = true;

            hide(sender, e);
            temperatureValues.Add(temperature);
            trailValues.Add(trail);
            densityValues.Add(density);
            viscosityValues.Add(viscosity);
            Fluid_textBox.ReadOnly = true;

            textBox2.Text = String.Empty;
            tmpText.Text = String.Empty;
            density_textbox.Text = String.Empty;
            viscosity_textbox.Text = String.Empty;
            dataGridView1.Rows.Add(trail, fluid, temperature, density, viscosity);

        }


        private void Submit_Click(object sender, EventArgs e)
        {


            try
            {


                string fluid = Fluid_textBox.Text;
                string filepath = @"D:\xyma\Results_iocl\Code\sgri.ini";
                string[] lines = File.ReadAllLines(filepath);
                int sectionStartIndex = Array.IndexOf(lines, "[CALIBRATION PARAMETERS]");


                if (sectionStartIndex >= 0)
                {
                    lines[sectionStartIndex + 1] = "Fluid_Name = " + fluid;
                    File.WriteAllLines(filepath, lines);
                }
                else
                {
                    lines = lines.Concat(new[]
                    {
                    "[CALIBRATION PARAMETERS]",
                    "Fluid_Name = " + fluid,

                }).ToArray();
                    File.WriteAllLines(filepath, lines);
                }


                Fluid_textBox.Text = String.Empty;
                Fluid_textBox.ReadOnly = false;
                textBox2.ReadOnly = false;
                string fluidName = fluid;
                string currentDate = DateTime.Now.ToString("dd/MM/yyyy//HH-mm");
                string expectedFileName = $"{fluidName}.xlsx";
                string filePath = $"D:\\xyma\\Results_iocl\\Manual_Testing_results\\{expectedFileName}";

                if (File.Exists(filePath))
                {

                    LoadAndAppendData(filePath);
                }
                else
                {
                    ExportToExcel(filePath);
                }

                fluidValues.Clear();
                trailValues.Clear();
                temperatureValues.Clear();
                densityValues.Clear();
                viscosityValues.Clear();
                fluid = "";

                dataGridView1.Rows.Clear();
                textBox2.Text = String.Empty;
                density_textbox.Text = String.Empty;
                viscosity_textbox.Text = String.Empty;

                // Re-enable input fields
                Fluid_textBox.ReadOnly = false;
                textBox2.ReadOnly = false;

                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Successfully saved ");
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadAndAppendData(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);

                    int lastUsedRow = worksheet.LastRowUsed().RowNumber();
                    Console.WriteLine($"Last Used Row: {lastUsedRow}");

                    for (int i = 0; i < 2; i++)
                    {
                        lastUsedRow++;
                        worksheet.Row(lastUsedRow).InsertRowsBelow(1);
                    }
                    int newRow = lastUsedRow + 1;
                    Console.WriteLine($"New Row: {newRow}");

                    for (int row = newRow; row < newRow + dataGridView1.Rows.Count; row++)
                    {
                        int dataIndex = row - newRow;
                        if (dataIndex >= 0 && dataIndex < trailValues.Count && dataIndex < temperatureValues.Count
                            && dataIndex < densityValues.Count && dataIndex < viscosityValues.Count)
                        {
                            string trail = trailValues[dataIndex];
                            string temperature = temperatureValues[dataIndex];
                            string density = densityValues[dataIndex];
                            string viscosity = viscosityValues[dataIndex];

                            int temperatureInt = (int)float.Parse(temperature);
                            int densityInt = (int)float.Parse(density);
                            int viscosityInt = (int)float.Parse(viscosity);

                            worksheet.Cell(row, 1).Value = trail;
                            worksheet.Cell(row, 2).Value = temperatureInt;
                            worksheet.Cell(row, 3).Value = densityInt;
                            worksheet.Cell(row, 4).Value = viscosityInt;
                        }
                        else
                        {
                            Console.WriteLine($"Index out of bounds: {dataIndex}");
                        }
                    }
                    workbook.SaveAs(filePath);

                    LoadDataIntoDataGridView();
                    MessageBox.Show("successfuly saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading and appending data: " + ex.Message);

            }
        }
        private void ExportToExcel(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Data");

                    int colCount = 1; // Counter for the column index in the worksheet

                    // Loop through the columns in the DataGridView
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        if (dataGridView1.Columns[col].HeaderText != "Fluid")
                        {
                            // Exclude the "Fluid" column
                            worksheet.Cell(1, colCount).Value = dataGridView1.Columns[col].HeaderText;
                            colCount++;
                        }
                    }

                    // Loop through the rows and columns in the DataGridView
                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {
                        colCount = 1; // Reset the column counter for each row
                        for (int col = 0; col < dataGridView1.Columns.Count; col++)
                        {
                            if (dataGridView1.Columns[col].HeaderText != "Fluid")
                            {
                                var cellValue = dataGridView1.Rows[row].Cells[col].Value;
                                if (cellValue != null)
                                {
                                    if (cellValue is float)
                                    {
                                        worksheet.Cell(row + 2, colCount).Value = (float)cellValue;
                                    }
                                    else
                                    {
                                        float floatValue;
                                        if (float.TryParse(cellValue.ToString(), out floatValue))
                                        {
                                            worksheet.Cell(row + 2, colCount).Value = floatValue;
                                        }
                                        else
                                        {
                                            worksheet.Cell(row + 2, colCount).Value = cellValue.ToString();
                                        }
                                    }
                                }
                                colCount++;
                            }
                        }
                    }
                    workbook.SaveAs(filePath);
                    MessageBox.Show("successfuly saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to Excel: " + ex.Message);
            }
        }

        private void Fluid_textBox_TextChanged(object sender, EventArgs e)
        {

            string newName = Fluid_textBox.Text;
            string filePath = @"D:\xyma\Results_iocl\sgri.ini";
            string[] lines = File.ReadAllLines(filePath);
            int sectionStartIndex = Array.IndexOf(lines, "[Fluidname]");
            if (sectionStartIndex >= 0)
            {

                int nameLineIndex = Array.FindIndex(lines, sectionStartIndex, line => line.StartsWith("Name = "));
                if (nameLineIndex >= 0)
                {
                    lines[nameLineIndex] = "Name = " + newName;

                    File.WriteAllLines(filePath, lines);
                }
                else
                {
                    lines = lines.Take(sectionStartIndex + 1)
                        .Concat(new[] { "Name = " + newName })
                        .Concat(lines.Skip(sectionStartIndex + 1))
                        .ToArray();
                    File.WriteAllLines(filePath, lines);
                }
            }
            else
            {
                lines = lines.Concat(new[] { "[Fluidname]", "Name = " + newName }).ToArray();
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}
