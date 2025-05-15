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
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();

            close_button.FlatAppearance.BorderSize = 0;
            medicament_button.FlatAppearance.BorderSize = 0;
            agriculture_button.FlatAppearance.BorderSize = 0;

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void medicament_button_Click(object sender, EventArgs e)
        {
            // set medicament button to specified color
            medicament_button.BackColor = Color.FromArgb(240, 240, 240);
            medicament_button.ForeColor = Color.FromArgb(28, 29, 30);

            // set agriculture button to default color
            agriculture_button.BackColor = Color.FromArgb(205, 153, 47);
            agriculture_button.ForeColor = Color.FromArgb(240, 240, 240);

            LoadFormInPanel(new Medicament_Form());
        }

        private void agriculture_button_Click(object sender, EventArgs e)
        {
            //set agirculture button to specified color
            agriculture_button.BackColor = Color.FromArgb(240, 240, 240);
            agriculture_button.ForeColor = Color.FromArgb(28, 29, 30);

            // set medicament button to default color
            medicament_button.BackColor = Color.FromArgb(205, 153, 47);
            medicament_button.ForeColor = Color.FromArgb(240, 240, 240);



        }

        private void formloader_panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadFormInPanel(Form formToLoad)
        {
            formloader_panel.Controls.Clear();

            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;

            formloader_panel.Controls.Add(formToLoad);
            formToLoad.Show();
        }




    }
}
