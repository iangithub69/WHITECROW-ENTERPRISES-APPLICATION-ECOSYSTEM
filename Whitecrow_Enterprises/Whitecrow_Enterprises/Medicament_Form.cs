using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void Medicament_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
