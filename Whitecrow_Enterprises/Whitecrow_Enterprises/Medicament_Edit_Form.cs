using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whitecrow_Enterprises
{
    public partial class Medicament_Edit_Form : Form
    {
        // Default constructor (keep this)
        public Medicament_Edit_Form()
        {
            InitializeComponent();
        }

        // ✅ New constructor with parameters
        public Medicament_Edit_Form(
    int id,
    string quantity,
    string unit,
    string genericName,
    string dosage,
    string brandName,
    string barcode,
    string expiryDate,
    string unitPrice,
    string supplier)
        {
            InitializeComponent();

            // Assign values to controls
            id_tb.Text = id.ToString();
            quantity_tb.Text = quantity;
            unit_tb.Text = unit;
            genericname_tb.Text = genericName;
            dosageform_tb.Text = dosage;
            brandname_tb.Text = brandName;
            barcode_tb.Text = barcode;
            expirydate_tb.Text = expiryDate;
            unitprice_tb.Text = unitPrice;
            supplier_tb.Text = supplier;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            // Close the blur form if it's open
            foreach (Form f in Application.OpenForms)
            {
                if (f is Blurr_Form)
                {
                    f.Close();
                    break;
                }
            }

            // Close this form (Medicament_Add_Form)
            this.Close();

            // Bring main form back to front
            foreach (Form f in Application.OpenForms)
            {
                if (f is Home_Form) // Replace with your main form's class name
                {
                    f.WindowState = FormWindowState.Maximized; // Optional: restore if minimized
                    f.BringToFront(); // Bring it to top
                    f.Activate(); // Set focus
                    break;
                }
            }
        }

        private void dosageform_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=2020301243;database=whitecrow_test_server;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE medicaments_information SET 
                    quantity = @quantity,
                    unit = @unit,
                    generic_name = @generic_name,
                    dosage = @dosage,
                    brand_name = @brand_name,
                    barcode = @barcode,
                    expiry_date = @expiry_date,
                    unit_price = @unit_price,
                    supplier = @supplier
                    WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantity",
                            int.TryParse(quantity_tb.Text, out int qty) ? qty : 0);

                        cmd.Parameters.AddWithValue("@unit", unit_tb.Text);
                        cmd.Parameters.AddWithValue("@generic_name", genericname_tb.Text);
                        cmd.Parameters.AddWithValue("@dosage", dosageform_tb.Text);
                        cmd.Parameters.AddWithValue("@brand_name", brandname_tb.Text);
                        cmd.Parameters.AddWithValue("@barcode", barcode_tb.Text);

                        DateTime.TryParse(expirydate_tb.Text, out DateTime expDate);
                        cmd.Parameters.AddWithValue("@expiry_date", expDate);

                        cmd.Parameters.AddWithValue("@unit_price",
                            decimal.TryParse(unitprice_tb.Text, out decimal price) ? price : 0);

                        cmd.Parameters.AddWithValue("@supplier", supplier_tb.Text);

                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id_tb.Text));

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Updated successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }














    }
}
