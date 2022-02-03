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
    public partial class top_menu : UserControl
    {
        public top_menu()
        {
            InitializeComponent();
        }
        private string _title;
        private Image _icon;
        private Color _cardcolor;

        [Category("Custom Props")]
        public Color cardcolor
        {
            get { return _cardcolor; }
            set { _cardcolor = value; _Cards_Item.color = value; }
        }


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; _Pic.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
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
            _Cards_Item.color = Color.Red;
            OnClicked(e);
        }
    }
}
