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
                    string query = "SELECT generic_name AS 'GENERIC NAME', brand AS 'BRAND', dosage AS 'DOSAGE', unit AS 'UNIT', expiry_date AS 'EXPIRY DATE', stock AS 'STOCK', selling_price AS 'SELLING PRICE', purchase_price AS 'PURCHASE PRICE', supplier AS 'SUPPLIER', manufacture_date AS 'MANUFACTURE DATE', barcode AS 'BARCODE' FROM medicaments_information";


                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
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
            
        }


     






    }
}
