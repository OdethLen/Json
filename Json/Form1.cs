using System.Data;
using System.Text;
using System.Text.Json;

namespace Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open JSON file";
            openFileDialog.Filter = "JSON files (*.json)|*.json";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;

            try
            {
                // ✅ Leer el JSON con codificación por defecto (UTF-8)
                string jsonContent = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var data = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonContent, options);

                if (data != null)
                {
                    DataTable table = new DataTable();

                    foreach (var key in data[0].Keys)
                    {
                        table.Columns.Add(key);
                    }

                    foreach (var row in data)
                    {
                        var values = row.Values.Select(v => v?.ToString()).ToArray();
                        table.Rows.Add(values);
                    }

                    dgvData.DataSource = table;

                    if (table.Columns.Contains("Country"))
                    {
                        var paises = table.AsEnumerable()
                                          .Select(row => row.Field<string>("Country"))
                                          .Where(p => !string.IsNullOrWhiteSpace(p))
                                          .Distinct()
                                          .OrderBy(p => p)
                                          .ToList();

                        cbFilter.DataSource = paises;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una columna llamada 'Country'.");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo leer el contenido del archivo JSON.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo JSON:\n{ex.Message}");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double suma = 0;

            foreach (DataGridViewCell cell in dgvData.SelectedCells)
            {
                // Solo sumar si es la columna 16 (índice 16)
                if (cell.ColumnIndex == 16)
                {
                    if (double.TryParse(cell.Value?.ToString(), out double valor))
                    {
                        suma += valor;
                    }
                }
            }

            lblSales.Text = "Total Sales: " + suma;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource is DataTable dt && cbFilter.SelectedItem != null)
            {
                string paisSeleccionado = cbFilter.SelectedItem.ToString();
                dt.DefaultView.RowFilter = $"Country = '{paisSeleccionado.Replace("'", "''")}'";
            }
        }
    }
}
