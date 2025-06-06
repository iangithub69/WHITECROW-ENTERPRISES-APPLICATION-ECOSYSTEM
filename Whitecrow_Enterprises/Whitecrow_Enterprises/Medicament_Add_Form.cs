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

namespace Whitecrow_Enterprises
{
    public partial class Medicament_Add_Form : Form
    {

        public Medicament_Add_Form()
        {
            InitializeComponent();

            // Add handlers only to specific TextBoxes
            generic_name_tb.TextChanged += CapitalizeEachWord;

            expiry_datepicker.Format = DateTimePickerFormat.Custom;
            expiry_datepicker.CustomFormat = "MMMM, yyyy";
            manufacture_datepicker.Format = DateTimePickerFormat.Custom;
            manufacture_datepicker.CustomFormat = "MMMM, yyyy";
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void expiry_datepicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
