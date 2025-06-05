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
    public partial class Medicament_Add_Form : Form
    {

        public Medicament_Add_Form()
        {
            InitializeComponent();


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
    }
}
