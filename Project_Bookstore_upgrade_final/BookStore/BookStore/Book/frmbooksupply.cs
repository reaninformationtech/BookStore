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
    public partial class frmbooksupply : KryptonForm
    {
        public frmbooksupply()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();
        string vcode = string.Empty;

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

        void cleartext()
        {
            dgSearch.Rows.Clear();
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtwebsite.Text = string.Empty;
            txtaddress.Text = string.Empty;

            cboactive.SelectedValue = string.Empty;
            cbotype.SelectedValue = string.Empty;

            dgSearch.Visible = false;
        }

        bool isok()
        {
            if (txtname.Text.Trim() == string.Empty)
            {
                txtname.Select();
                txtname.Focus();
                MessageBox.Show("item name required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.cbo_empty(cbotype) == false)
            {
                cbotype.Select();
                cbotype.Focus();
                MessageBox.Show("customer gender has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (sql.cbo_empty(cboactive) == false)
            {
                cboactive.Select();
                cboactive.Focus();
                MessageBox.Show("Status has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }
        void save_record(string vstatus, string recordid , string vmsg)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p =
                   {
                   vstatus,
                    variables.p_branchcode,
                    recordid,
                    txtname.Text.Trim(),
                    cbotype.SelectedValue.ToString(),
                    cboactive.SelectedValue.ToString(),
                    txtphone.Text.Trim(),
                    txtemail.Text.Trim(),
                    txtwebsite.Text.Trim(),
                    txtaddress.Text.Trim(),
                    variables.p_inputter
                };

                dt = sql.proc_getdata("book_proc_supply", p);
                if (dt.Rows.Count > 0)
                {
                    txtid.Text = dt.Rows[0]["trancode"].ToString();
                    MessageBox.Show(vmsg, variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartext();
                }
            }
            catch { }
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
                    txtid.Text = dt.Rows[0]["sup_id"].ToString();
                    txtname.Text = dt.Rows[0]["sup_name"].ToString();
                    cboactive.SelectedValue = dt.Rows[0]["active"].ToString();
                    cbotype.SelectedValue = dt.Rows[0]["sup_type"].ToString();
                    txtphone.Text = dt.Rows[0]["phone"].ToString();
                    txtemail.Text = dt.Rows[0]["email"].ToString();
                    txtwebsite.Text = dt.Rows[0]["web"].ToString();
                    txtaddress.Text = dt.Rows[0]["sup_address"].ToString();

                    btn_edit_record();
                }
                else
                {
                    MessageBox.Show("Record id does not exist !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }
        void formatgridview()
        {
            try
            {
                dgSearch.MultiSelect = false;
                for (int i = 0; i < dgSearch.Columns.Count; i++)
                {
                    dgSearch.Columns[i].ReadOnly = true;
                    dgSearch.Columns[i].DefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
                    dgSearch.Columns[i].DefaultCellStyle.ForeColor = Color.Brown;
                }

                dgSearch.Columns["gcode"].Width = 80;
                dgSearch.Columns["gname"].Width = 140;
                dgSearch.Columns["gphone"].Width = 90;

                dgSearch.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            }
            catch { }
        }

        void supply_list(string vstatus, string vtrancode)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    vtrancode
                };
                dgSearch.Rows.Clear();

                dblist = sql.proc_getdata("book_proc_get_sql", p);
                if (dblist.Rows.Count > 0)
                {
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgSearch.Rows.Add(
                            dblist.Rows[i]["sup_id"].ToString(),
                            dblist.Rows[i]["sup_name"].ToString(),
                            dblist.Rows[i]["phone"].ToString()
                        );

                        dgSearch.Visible = true;
                    }
                }
            }
            catch { }
        }


        private void frmbooksupply_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.p_frm_supply;
                gb_action.Text = "Action";
                formatgridview();
                cleartext();
                sql.Filter_ComboBox(cboactive, "exec proc_get_constants  'active'", "name", "code");
                sql.Filter_ComboBox(cbotype, "exec proc_get_constants  'supplytype'", "name", "code");
                btn_save_record();
            }
            catch { }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btn_save_record();
            cleartext();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (isok() == true)
            {
                save_record("i", "",variables.p_message_insert);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (isok() == true)
            {
                save_record("u", txtid.Text.Trim(),variables.p_message_updated);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (dgSearch.Visible == true)
            {
                dgSearch.Visible = false;
            }
            else
            {
                dgSearch.Visible = true;
                dgSearch.Location = new Point(84, 44);
                dgSearch.Size = new Size(390, 200);
                supply_list("load_supply", txtid.Text.Trim());
            }
        }

        private void dgSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = dgSearch[0, e.RowIndex].Value.ToString();
                vcode = dgSearch[1, e.RowIndex].Value.ToString();
                dgSearch.Visible = false;
                GetInfor("show_supply", txtid.Text.Trim());
            }
            catch { }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GetInfor("show_supply", txtid.Text.Trim());
            }
        }
    }
}
