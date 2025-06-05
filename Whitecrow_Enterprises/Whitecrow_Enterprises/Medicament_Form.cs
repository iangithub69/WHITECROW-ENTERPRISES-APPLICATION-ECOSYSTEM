using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Whitecrow_Enterprises
{
    public partial class Medicament_Form : Form
    {
        public Medicament_Form()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("MMMM dd, yyyy");
            string formattedTime = now.ToString("@ hh:mm tt");
            datetime_label.Text = formattedDate + " " + formattedTime;

            searchbox_panel.BackColor = Color.FromArgb(205, 153, 47);
            searchbox_textbox.BorderStyle = BorderStyle.None;
            searchbox_textbox.BackColor = Color.White;       // TextBox background
            searchbox_textbox.ForeColor = Color.Black;

            sell_button.FlatAppearance.BorderSize = 0;
            sell_button.FlatStyle = FlatStyle.Flat;
            sell_button.FlatAppearance.BorderColor = Color.FromArgb(205, 153, 47);
            sell_button.FlatAppearance.BorderSize = 2;

            panel1.BackColor = Color.FromArgb(205, 153, 47); // Border color
            panel1.Padding = new Padding(2); // Thickness
            dataGridView1.BorderStyle = BorderStyle.None;

            LoadDataToGrid();

            // Adjust columns to fit content
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Optional: Adjust rows to fit content (especially if you have multiline text)
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }


        private void LoadDataToGrid()
        {
            string connStr = "server=localhost;user=root;password=2020301243;database=whitecrow_test_server;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT generic_name AS 'GENERIC NAME', brand AS 'BRAND', dosage AS 'DOSAGE', 
                            expiry_date AS 'EXPIRY DATE', stock AS 'STOCK', selling_price AS 'SELLING PRICE', 
                            purchase_price AS 'PURCHASE PRICE', supplier AS 'SUPPLIER', manufacture_date AS 'MANUFACTURE DATE', 
                            barcode AS 'BARCODE' 
                            FROM medicaments_information
                            ORDER BY generic_name ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    dt.Clear();
                    adapter.Fill(dt);

                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void Medicament_Form_Load(object sender, EventArgs e)
        {

        }

        private void sell_button_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbox_textbox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchbox_textbox.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchText))
            {
                bs.RemoveFilter();

                // Remove highlights when filter cleared
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                return;
            }

            // Build filter for string columns to match search text (case-insensitive)
            List<string> filters = new List<string>();
            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType == typeof(string))
                {
                    filters.Add($"[{col.ColumnName}] LIKE '%{searchText}%'");
                }
            }

            string filterExpression = string.Join(" OR ", filters);
            bs.Filter = filterExpression;

            // Highlight matched cells/rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isMatch = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        isMatch = true;
                        break;
                    }
                }

                row.DefaultCellStyle.BackColor = isMatch ? Color.Yellow : Color.White;
            }
        }

        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();


        private void delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Assuming 'BARCODE' column is your unique identifier
            string generic_name = selectedRow.Cells["GENERIC NAME"].Value?.ToString();

            if (string.IsNullOrEmpty(generic_name))
            {
                MessageBox.Show("Cannot delete item: Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete: {generic_name}?",
                                                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string connStr = "server=localhost;user=root;password=2020301243;database=whitecrow_test_server;";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM medicaments_information WHERE generic_name = @generic_name";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@generic_name", generic_name);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataToGrid(); // Refresh the grid
                            }
                            else
                            {
                                MessageBox.Show("Item could not be found or deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Blurr_Form addForm = new Blurr_Form(); // Create instance
            addForm.Show(); // Use ShowDialog() if you want to block the current form

            Medicament_Add_Form addMedicamentForm = new Medicament_Add_Form(); // Create instance
            addMedicamentForm.ShowDialog(); // Use ShowDialog() if you want to block the current form
        }
    }
}
