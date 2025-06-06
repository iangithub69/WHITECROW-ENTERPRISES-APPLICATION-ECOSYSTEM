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
    public partial class Blurr_Form : Form
    {
        private bool isFadingIn = true;

        public Blurr_Form()
        {
            InitializeComponent();
            this.Opacity = 0; // Start fully transparent

            // Setup timer1 (add timer1 from designer)
            timer1.Interval = 40;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            isFadingIn = true;
            timer1.Start();  // Start fade-in
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.Opacity > 0)
            {
                e.Cancel = true;  // Cancel the default close
                isFadingIn = false;
                timer1.Start();  // Start fade-out
            }
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            if (isFadingIn)
            {
                if (this.Opacity < 0.8)
                    this.Opacity += 0.08;
                else
                    timer1.Stop();
            }
            else
            {
                if (this.Opacity > 0)
                    this.Opacity -= 0.08;
                else
                {
                    timer1.Stop();
                    this.Close();  // Now close the form after fade-out
                }
            }
        }

        private void Blurr_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
