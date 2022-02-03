using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Control
{
    public partial class button_sm_product : UserControl
    {
        public button_sm_product()
        {
            InitializeComponent();
        }

        public event EventHandler Clicked;
        /// <summary>
        /// Called to signal to subscribers that UserControl Button Clicked
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnClicked(EventArgs e)
        {
            EventHandler eh = Clicked;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public void Items_Click(object sender, EventArgs e)
        {
            OnClicked(e);
        }
    }
}
