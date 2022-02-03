using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Book
{
    public partial class frmbookreleased : KryptonForm
    {
        public frmbookreleased()
        {
            InitializeComponent();

        }


        private void frmbookreleased_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                time_show_progressbar.Enabled = true;
                progressbarsetup.Visible = true;
                progressbarsetup.Value = 0;
            }
            catch { }
        }

        private void time_show_progressbar_Tick(object sender, EventArgs e)
        {
            try
            {
                progressbarsetup.Value += 2;
                if (progressbarsetup.Value >= 100)
                {
                    this.Close();
                }
            }
            catch { }
        }
    }
}
