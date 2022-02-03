using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmtesting : Form
    {
        public frmtesting()
        {
            InitializeComponent();
        }

        private void frmtesting_Load(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value = 1;
            time_show_progressbar.Enabled = true;
            if (bunifuProgressBar1.Value >= 100)
            {
                time_show_progressbar.Enabled = false;
            }
        }

        private void time_show_progressbar_Tick(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value = +1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
