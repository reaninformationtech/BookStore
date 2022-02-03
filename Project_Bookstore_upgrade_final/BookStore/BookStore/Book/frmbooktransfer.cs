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
    public partial class frmbooktransfer : KryptonForm
    {
        public frmbooktransfer()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vpro_id = string.Empty;
        string vbarcode = string.Empty;
        private void frmbooktransfer_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                sql.exchangerate("exchangerate");
                sql.Filter_ComboBox(cbostockfrom, "exec book_proc_get_sql  'cbo_stock','" + variables.p_branchcode + "','%'", "name", "code");

                cleartext();

            }
            catch { }
        }

        void cleartext()
        {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtbarcode.Text = string.Empty;
            txtqty.Text = "0.00";
            cbostockfrom.SelectedValue = string.Empty;
            cbostockto.SelectedValue = string.Empty;

            lblbarcode.Text = string.Empty;


            gb.Text = "Stock transfer";
            gb_action.Text = "Click action";

        }
        void btn_save_record()
        {
            btnnew.Enabled = true;
            btncreate.Enabled = true;
        }

        void GetInfor(string vstatus, string vcode)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    vcode
                };
                dt = sql.proc_getdata("book_proc_get_sql", p);
                if (dt.Rows.Count > 0)
                {
                    txtid.Text = dt.Rows[0]["pro_id"].ToString();
                    txtname.Text = dt.Rows[0]["pro_name"].ToString();
                    txtbarcode.Text = dt.Rows[0]["barcode"].ToString();

                    vbarcode = dt.Rows[0]["barcode"].ToString();
                    vpro_id = dt.Rows[0]["pro_id"].ToString();
                }
                else
                {
                    MessageBox.Show("Record id does not exist !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }

        bool isok()
        {
            if (txtbarcode.Text == string.Empty || vbarcode==string.Empty)
            {
                txtbarcode.Select();
                txtbarcode.Focus();
                MessageBox.Show("item barcode required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.cbo_empty(cbostockfrom) == false)
            {
                cbostockfrom.Select();
                cbostockfrom.Focus();
                MessageBox.Show("Publish has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.cbo_empty(cbostockto) == false)
            {
                cbostockto.Select();
                cbostockto.Focus();
                MessageBox.Show("Active has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtqty.Text.Trim()==string.Empty || sql.IsNumeric(txtqty.Text.Trim())==false)
            {
                txtqty.Select();
                txtqty.Focus();
                MessageBox.Show("Quality has been required number only !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {

                if (isok() == true)
                {

                    DataTable dt = new DataTable();
                    string[] p =
                       {
                            "ST",
                            variables.p_branchcode,
                            vpro_id,
                            vbarcode,
                            cbostockfrom.SelectedValue.ToString(),
                            cbostockto.SelectedValue.ToString(),
                            txtqty.Text.Trim(),
                            variables.p_inputter
                        };

                    dt = sql.proc_getdata("book_proc_pos_stocktransfer", p);
                    if (dt.Rows.Count > 0)
                    {
                        txtid.Text = dt.Rows[0]["trancode"].ToString();
                        MessageBox.Show("Stock transfer has been successfully !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleartext();
                    }
                }
            }
            catch { }
        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblbarcode.Text = txtbarcode.Text.Trim();
            vbarcode = string.Empty;
            vpro_id = string.Empty;
            if (e.KeyChar == '\r')
            {
                GetInfor("show_items", txtbarcode.Text.Trim());
            }
        }

        private void cbostockfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sql.cbo_empty(cbostockfrom) == true)
                {
                    sql.Filter_ComboBox(cbostockto, "exec book_proc_get_sql  'cbo_stockto','" + variables.p_branchcode + "','"+ cbostockfrom.SelectedValue.ToString() +"'", "name", "code");
                }
            }
            catch { }
        }
    }
}
