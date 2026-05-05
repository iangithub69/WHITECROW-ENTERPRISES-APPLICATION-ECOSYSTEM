using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;


namespace Whitecrow_Enterprises
{
    public partial class Medicament_Add_Form : Form
    {

        public Medicament_Add_Form()
        {
            InitializeComponent();

            // Add handlers only to specific TextBoxes
            quantity_tb.TextChanged += CapitalizeEachWord;

            genericname_tb.TextChanged += CapitalizeEachWord;

            expiry_datepicker.Format = DateTimePickerFormat.Custom;
            expiry_datepicker.CustomFormat = "MMMM, yyyy";


            LoadDosageFormValues(); // ✅ Call here
            LoadUnitValues();
            ComputeTotal();
            quantity_tb.TextChanged += quantity_tb_TextChanged;
            unitprice_tb.TextChanged += unitprice_tb_TextChanged;

            SetupBrandAutoComplete();
            SetupGenericNameAutoComplete();

            unitprice_tb.KeyPress += selling_price_tb_KeyPress;



            ClearHighlightOnInput(quantity_tb);

            ClearHighlightOnInput(dosage_form_cb);

            ClearHighlightOnInput(unitprice_tb);

            ClearHighlightOnInput(genericname_tb);
            ClearHighlightOnInput(barcode_tb);
        }

        private void LoadDosageFormValues()
        {
            string connStr = "server=localhost;user=root;password=2020301243;database=whitecrow_test_server;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT dosage_name FROM dosage_forms ORDER BY dosage_name ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dosage_form_cb.Items.Clear(); // Clear existing items first

                        while (reader.Read())
                        {
                            string name = reader["dosage_name"]?.ToString() ?? "";
                            if (!string.IsNullOrWhiteSpace(name))
                            {
                                dosage_form_cb.Items.Add(name);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dosage forms: " + ex.Message);
                }
            }
        }

        private void LoadUnitValues()
        {
            string connStr = "server=localhost;user=root;password=2020301243;database=whitecrow_test_server;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT unit_name FROM units ORDER BY unit_name ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        unit_cb.Items.Clear(); // Clear existing items first

                        while (reader.Read())
                        {
                            string name = reader["unit_name"]?.ToString() ?? "";
                            if (!string.IsNullOrWhiteSpace(name))
                            {
                                unit_cb.Items.Add(name);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dosage forms: " + ex.Message);
                }
            }
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

        private void CapitalizeEachWord(object? sender, EventArgs e)
        {
            if (sender is not TextBox tb || string.IsNullOrEmpty(tb.Text))
                return;

            int selStart = tb.SelectionStart;

            string converted = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                .ToTitleCase(tb.Text.ToLower());

            if (tb.Text != converted)
            {
                tb.Text = converted;
                tb.SelectionStart = selStart;
            }
        }


        private void expiry_datepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dosage_form_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupBrandAutoComplete()
        {
            var brandList = new AutoCompleteStringCollection();
            brandList.AddRange(new string[]
            {
        "Arbloc", "Biogesic", "Godex", "Fenoflex", "Medicol", "Ponstan", "Amoxil",
        "Unasyn", "Zithromax", "Norvasc", "Aldomet", "Solmux", "Zyrtec", "Claritin",
        "Zantac", "Enervon", "Glumet", "Canesten", "Ventolin", "Diovan", "Robitussin",
        "Bonamine", "Diatabs", "Kenalog", "Zyprexa", "Skelan", "Allegra", "Benadryl",
        "Mycocide", "Clovix", "Lyrica", "Livolin", "Nebilet", "Avarin", "Keltican",
        "Flixotide", "Lexapro", "Diflucan"
            });


        }


        private void SetupGenericNameAutoComplete()
        {
            var genericList = new AutoCompleteStringCollection();
            genericList.AddRange(new string[]
            {
        "Losartan", "Paracetamol", "Vitamins", "Amino Acids", "Carnitine Iodine", "Fenofibrate",
        "Ibuprofen", "Mefenamic Acid", "Amoxicillin", "Ampicillin-Sulbactam", "Azithromycin",
        "Amlodipine", "Methyldopa", "Carbocisteine", "Cetirizine", "Loratadine", "Ranitidine",
        "Multivitamins", "Metformin", "Clotrimazole", "Salbutamol", "Valsartan", "Guaifenesin",
        "Meclizine", "Loperamide", "Triamcinolone", "Olanzapine", "Naproxen Acid", "Fexofenadine",
        "Diphenhydramine", "Miconazole", "Clopidogrel", "Pregabalin", "Vitamin B1", "Vitamin B2",
        "Nebivolol Hydrochloride", "Simethicone Alverine Citrate", "Folic Acid", "Fluticasone",
        "Escitalopram", "Fluconazole"
            });

            quantity_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            quantity_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            quantity_tb.AutoCompleteCustomSource = genericList;
        }

        private void stock_quantity_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void selling_price_tb_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.' && !((sender as TextBox)?.Text.Contains('.') ?? true))
                return;

            e.Handled = true;
        }



        private void stock_quantity_tb_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow digits and control keys (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                    tb.Clear();

                if (c is ComboBox cb)
                    cb.SelectedIndex = -1;
            }

            // If your controls are inside containers like panels or group boxes
            ClearControlsRecursive(this);
        }

        private void ClearControlsRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                    tb.Clear();

                else if (c is ComboBox cb)
                    cb.SelectedIndex = -1;

                // Recursively clear nested controls
                if (c.HasChildren)
                    ClearControlsRecursive(c);
            }
        }

        private void ClearHighlightOnInput(Control ctrl)
        {
            if (ctrl is TextBox tb)
            {
                tb.TextChanged += (s, e) =>
                {
                    if (tb.BackColor == Color.LightPink)
                        tb.BackColor = Color.White;
                };
            }
            else if (ctrl is ComboBox cb)
            {
                cb.SelectedIndexChanged += (s, e) =>
                {
                    if (cb.BackColor == Color.LightPink)
                        cb.BackColor = Color.White;
                };
                cb.TextChanged += (s, e) =>
                {
                    if (cb.BackColor == Color.LightPink)
                        cb.BackColor = Color.White;
                };
            }
        }


        private void save_button_Click(object sender, EventArgs e)
        {
            bool hasError = false;

            // Helper method to check a Control (TextBox or ComboBox)
            void CheckRequired(Control ctrl)
            {
                if (string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    ctrl.BackColor = Color.LightPink;
                    hasError = true;
                }
                else
                {
                    ctrl.BackColor = Color.White;
                }
            }

            // Check required fields and highlight empty ones
            CheckRequired(quantity_tb);
            CheckRequired(unit_cb);
            CheckRequired(genericname_tb);
            CheckRequired(dosage_form_cb);
            CheckRequired(brandname_tb);
            CheckRequired(barcode_tb);
            CheckRequired(expiry_datepicker);
            CheckRequired(unitprice_tb);
            CheckRequired(supplier_tb);

            if (hasError)
            {
                MessageBox.Show("Please fill in all required fields (highlighted in pink).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop saving
            }



            string connStr = "server=localhost;user=root;password=2020301243;database=whitecrow_test_server;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO medicaments_information 
        (quantity, unit, generic_name, dosage, brand_name, barcode, expiry_date, unit_price, supplier) 
        VALUES 
        (@quantity, @unit, @generic_name, @dosage, @brand_name, @barcode, @expiry_date, @unit_price, @supplier)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(quantity_tb.Text));
                        cmd.Parameters.AddWithValue("@unit", unit_cb.Text);
                        cmd.Parameters.AddWithValue("@generic_name", genericname_tb.Text);
                        cmd.Parameters.AddWithValue("@dosage", dosage_form_cb.Text);
                        cmd.Parameters.AddWithValue("@brand_name", brandname_tb.Text);
                        cmd.Parameters.AddWithValue("@barcode", barcode_tb.Text);
                        cmd.Parameters.AddWithValue("@expiry_date", expiry_datepicker.Value.ToString("yyyy-MMMM-dd"));
                        cmd.Parameters.AddWithValue("@unit_price", Convert.ToDecimal(unitprice_tb.Text));
                        cmd.Parameters.AddWithValue("@supplier", supplier_tb.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Medicament saved successfully!");
                        else
                            MessageBox.Show("Failed to save medicament.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
            }

            ClearForm();

        }

        private void barcode_tb_TextChanged(object sender, EventArgs e)
        {

        }


        private void selling_price_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComputeTotal()
        {
            decimal quantity = 0;
            decimal unitPrice = 0;

            decimal.TryParse(quantity_tb.Text, out quantity);
            decimal.TryParse(unitprice_tb.Text, out unitPrice);

            decimal total = quantity * unitPrice;

            total_lbl.Text = total.ToString("N2"); // formatted (e.g., 1,234.00)
        }

        private void quantity_tb_TextChanged(object? sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void unitprice_tb_TextChanged(object? sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void quantity_tb_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quantity_tb.Text))
            {
                quantity_tb.Text = "0";
            }
        }

        private void ClearForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                    tb.Clear();

                if (c is ComboBox cb)
                    cb.SelectedIndex = -1;
            }

            ClearControlsRecursive(this);
        }
















    }
}
