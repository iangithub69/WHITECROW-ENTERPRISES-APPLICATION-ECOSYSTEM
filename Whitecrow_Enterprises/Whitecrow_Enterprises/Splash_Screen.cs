using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Whitecrow_Enterprises
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Start(); // Start the timer when the form loads
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10; // Increase progress
            }
            else
            {
                timer1.Stop(); // Stop when complete
                Home_Form newForm = new Home_Form(); // Create an instance of Form2
                newForm.Show(); // Open Form2 non-modally (you can still interact with the current form)
                this.Hide();
                //MessageBox.Show("Done!");
            }
        }
    }
}
