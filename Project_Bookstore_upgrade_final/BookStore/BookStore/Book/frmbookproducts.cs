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
    public partial class frmbookproducts : KryptonForm
    {
        public frmbookproducts()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();

        void cleartext()
        {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtbarcode.Text = string.Empty;
            txtcost.Text = "0.00";
            txtunitprice.Text = "0.00";
            txtdiscount.Text = "0";
            cboactive.SelectedValue = string.Empty;
            cboline.SelectedValue = string.Empty;
            cboauthor.SelectedValue = string.Empty;
            cbopublish.SelectedValue = string.Empty;

            dgSearch.Visible = false;

        }
        void btn_save_record()
        {
            btnnew.Enabled = true;
            btncreate.Enabled = true;
            btnedit.Enabled = false;
        }

        void btn_edit_record()
        {
            btnnew.Enabled = true;
            btncreate.Enabled = false;
            btnedit.Enabled = true;
        }

        private void frmbookproducts_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                gb_action.Text = string.Empty;
                btn_save_record();

                sql.Filter_ComboBox(cboactive, "exec proc_get_constants  'active'", "name", "code");
                sql.Filter_ComboBox(cboline, "exec book_proc_get_sql  'cbo_line','" + variables.p_branchcode +"','%'", "name", "code");
                sql.Filter_ComboBox(cboauthor, "exec book_proc_get_sql  'cbo_author','" + variables.p_branchcode +"','%'", "name", "code");
                sql.Filter_ComboBox(cbopublish, "exec book_proc_get_sql  'cbo_publisher','" + variables.p_branchcode +"','%'", "name", "code");
                cleartext();
            }
            catch { }
        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch { }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btn_save_record();
            cleartext();
        }

        bool isok()
        {

            if (txtname.Text == string.Empty)
            {
                txtname.Select();
                txtname.Focus();
                MessageBox.Show("item name required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtbarcode.Text == string.Empty)
            {
                txtbarcode.Select();
                txtbarcode.Focus();
                MessageBox.Show("item barcode required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (txtbarcode.Text == string.Empty)
            {
                txtbarcode.Select();
                txtbarcode.Focus();
                MessageBox.Show("item barcode required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.IsNumeric(txtcost.Text.Trim())==false)
            {
                txtcost.Select();
                txtcost.Focus();
                MessageBox.Show("Cost required number only !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.IsNumeric(txtunitprice.Text.Trim()) == false)
            {
                txtunitprice.Select();
                txtunitprice.Focus();
                MessageBox.Show("Unit price required number only !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (sql.IsNumeric(txtdiscount.Text.Trim()) == false)
            {
                txtdiscount.Select();
                txtdiscount.Focus();
                MessageBox.Show("Unit price required number only !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (sql.cbo_empty(cboline) == false)
            {
                cboline.Select();
                cboline.Focus();
                MessageBox.Show("item line has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (sql.cbo_empty(cboauthor) == false)
            {
                cboauthor.Select();
                cboauthor.Focus();
                MessageBox.Show("Author has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            else if (sql.cbo_empty(cbopublish) == false)
            {
                cbopublish.Select();
                cbopublish.Focus();
                MessageBox.Show("Publish has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.cbo_empty(cboactive) == false)
            {
                cboactive.Select();
                cboactive.Focus();
                MessageBox.Show("Active has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        void save_record(string vstatus , string recordid , string vmsg)
        {
            DataTable dt = new DataTable();
            string[] p =
               {
                   vstatus,
                    variables.p_branchcode,
                    recordid,
                    txtname.Text.Trim(),
                    txtbarcode.Text.Trim(),
                    cboline.SelectedValue.ToString(),
                    cboauthor.SelectedValue.ToString(),
                    cbopublish.SelectedValue.ToString(),
                    cboactive.SelectedValue.ToString(),
                    txtcost.Text.Trim(),
                    txtunitprice.Text.Trim(),
                    txtdiscount.Text.Trim(),
                    variables.p_inputter
                };

            dt=sql.proc_getdata("book_proc_register_items", p);
            if (dt.Rows.Count > 0)
            {
                txtid.Text = dt.Rows[0]["trancode"].ToString();
                MessageBox.Show(vmsg, variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleartext();
            }
        }
        private void btncreate_Click(object sender, EventArgs e)
        {
            if (isok() == true)
            {
                save_record("i", "",variables.p_message_insert);
            }
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
                    txtcost.Text = string.Format("{0:0,0.00}", dt.Rows[0]["cost"]); 
                    txtunitprice.Text = string.Format("{0:0,0.00}", dt.Rows[0]["unitprice"]);
                    txtdiscount.Text = dt.Rows[0]["discount"].ToString();

                    cboactive.SelectedValue= dt.Rows[0]["active"].ToString();
                    cboauthor.SelectedValue= dt.Rows[0]["aut_id"].ToString();
                    cboline.SelectedValue= dt.Rows[0]["pro_type"].ToString();
                    cbopublish.SelectedValue= dt.Rows[0]["ver_id"].ToString();

                    btn_edit_record();
                }
                else
                {
                    MessageBox.Show("Record id does not exist !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GetInfor("show_items", txtid.Text.Trim());
            }
        }


        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblbarcode.Text = txtbarcode.Text.Trim();
            if (e.KeyChar == '\r')
            {
                GetInfor("show_items", txtbarcode.Text.Trim());
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (isok() == true)
            {
                if (MessageBox.Show("Do you want to update " + txtid.Text.Trim() + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    save_record("u", txtid.Text.Trim(),variables.p_message_updated);
                }
            }
        }

        private void lblbarcode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnimage_Click(object sender, EventArgs e)
        {

            if (dgSearch.Visible == true)
            {
                dgSearch.Visible = false;
                cleartext();
            }
            else
            {
                dgSearch.Location = new Point(100, 80);
                dgSearch.Size = new Size(330, 200);
                product_list("load_product", txtid.Text.Trim());
            }
        }

        void product_list(string vstatus, string vtrancode)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    vtrancode
                };

                dblist = sql.proc_getdata("book_proc_get_sql", p);
                if (dblist.Rows.Count > 0)
                {
                    dgSearch.Rows.Clear();
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgSearch.Rows.Add(
                            dblist.Rows[i]["code"].ToString(),
                            dblist.Rows[i]["name"].ToString(),
                            dblist.Rows[i]["barcode"].ToString()
                        );

                        dgSearch.Visible = true;
                    }
                }
            }
            catch { }
        }

        private void dgSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = dgSearch[0, e.RowIndex].Value.ToString();
                GetInfor("show_items", txtid.Text.Trim());
                dgSearch.Visible = false;
            }
            catch { }
        }
    }
}
