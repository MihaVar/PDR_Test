using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDR_test
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            tm = new Timer();
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000;
        }

        Timer tm = null;
        int startValue = 0;

        int numericUpDownHour = 0;
        int numericUpDownMin = 0;
        int numericUpDownSec = 3;
        private string Int2StringTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }



        void tm_Tick(object sender, EventArgs e)
        {
            if (startValue != 0)
            {
                timer.Text = Int2StringTime(startValue);
                startValue--;
            }
            else
            {
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
                MessageBox.Show("Ви вичерпали весь свій час", "Час вичерпано!", MessageBoxButtons.OK);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Visible = true;
            pnlStart.Visible = false;
            startValue = 60 * 60 * (int)numericUpDownHour + 60 * (int)numericUpDownMin + (int)numericUpDownSec;
            tm.Start();
        }
    }
}
