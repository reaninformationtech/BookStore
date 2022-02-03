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
    public partial class frmauthstocktransfer : KryptonForm
    {
        public frmauthstocktransfer()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vtran_id = string.Empty;
        string vbarcode = string.Empty;
        private void frmauthstocktransfer_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                stocktransfer();
            }
            catch { }
        }

        void stocktransfer()
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p =
                {
                    "stocktransfer",
                    variables.p_branchcode
                };
                dt = sql.proc_getdata("book_proc_get_sql", p);
                gData.Rows.Clear();
                if (dt.Rows.Count >0)
                {
                    for(int i =0; i < dt.Rows.Count; i++)
                    {
                        gData.Rows.Add(
                            dt.Rows[i]["st_id"].ToString(),
                            dt.Rows[i]["pro_name"].ToString(),
                            dt.Rows[i]["stock_from"].ToString(),
                            dt.Rows[i]["stock_to"].ToString(),
                            dt.Rows[i]["qty"].ToString()
                            );
                    }
                }
            }
            catch { }
        }

        
        private void gData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cmsUser_Opening(object sender, CancelEventArgs e)
        {
            if (vtran_id == string.Empty)
            {
                _approved.Enabled = false;
                _reject.Enabled = false;
            }
            else
            {
                _approved.Enabled = true;
                _reject.Enabled = true;
            }
        }

        private void _approved_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to authorize " + vtran_id + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "auth_stocktransfer",
                        variables.p_branchcode,
                        vtran_id,
                        variables.p_inputter
                    };

                    dt = sql.proc_getdata("book_proc_authorize", p);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record has been authorized ! ", variables.p_message_successful, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        stocktransfer();
                        vtran_id = string.Empty;
                    }
                }
            }
            catch { }
        }

        private void _reject_Click(object sender, EventArgs e)
        {
            try
            {
                if (vtran_id.Trim() == string.Empty)
                {
                    return;
                }
                if (MessageBox.Show("Do you want to reject " + vtran_id + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "reject_stock",
                        variables.p_branchcode,
                        vtran_id,
                        variables.p_inputter
                    };

                    dt = sql.proc_getdata("book_proc_authorize", p);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record has been rejected ! ", variables.p_message_successful, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        stocktransfer();
                        vtran_id = string.Empty;
                    }
                }
            }
            catch { }
        }

        private void gData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vtran_id = gData[0, e.RowIndex].Value.ToString();
            }
            catch { }
        }
    }
}
