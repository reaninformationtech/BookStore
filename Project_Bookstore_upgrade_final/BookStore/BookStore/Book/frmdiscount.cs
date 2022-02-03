using BookStore.Class;
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
    public partial class frmdiscount : KryptonForm
    {
        public frmdiscount()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        public string PStatus = string.Empty;
        public string PCode = string.Empty;

        public string Code
        {
            get { return PCode; }
            set { PCode = value; }
        }

        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }

        private void frmdiscount_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                double gdis = 0;
                if (sql.Rights(txtchange.Text.Trim(), 1) == "%")
                {
                    double.TryParse(sql.Left(txtchange.Text.Trim(), txtchange.Text.Trim().Length - 1), out gdis);
                }
                else
                {
                    double.TryParse(txtchange.Text.Trim(), out gdis);
                }
                if (gdis > 100)
                {
                    MessageBox.Show("Discount must be lower then 100 !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] p =
                {
                    Status,
                    variables.p_branchcode,
                    Code,
                    gdis.ToString(),
                    variables.p_inputter
                };

                dt = sql.proc_getdata("book_proc_edit_discount", p);
                if (dt.Rows.Count > 0)
                {
                    this.Close();
                }
            }
            catch { }
        }

        private void textchange_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch { }
        }

        private void textchange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtchange.Text.Trim()== "0%")
                {
                    txtchange.Text = string.Empty;
                }
            }
            catch { }
        }
    }
}
