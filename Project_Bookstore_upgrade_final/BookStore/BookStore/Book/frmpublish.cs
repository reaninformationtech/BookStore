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
    public partial class frmpublish : KryptonForm
    {
        public frmpublish()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vinvoice = string.Empty;
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

                dgSearch.Columns["gcode"].Width = 60;
                dgSearch.Columns["gname"].Width = 140;
                dgSearch.Columns["gphone"].Width = 80;

                dgSearch.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            }
            catch { }
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

        void cleartext()
        {
            dgSearch.Rows.Clear();
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtremark.Text = string.Empty;
            txtpage.Text = string.Empty;

            pDate.Value = Convert.ToDateTime(DateTime.Now);

            cboactive.SelectedValue = string.Empty;
            dgSearch.Visible = false;
        }

        bool isok()
        {
            if (txtname.Text.Trim() == string.Empty)
            {
                txtname.Select();
                txtname.Focus();
                MessageBox.Show("Author name required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        void save_record(string vstatus, string recordid, string vmsg)
        {
            DataTable dt = new DataTable();
            string[] p =
               {
                   vstatus,
                    variables.p_branchcode,
                    recordid,
                    txtname.Text.Trim(),
                    cboactive.SelectedValue.ToString(),
                    pDate.Value.ToString("yyyy/MM/dd"),
                    txtpage.Text.Trim(),
                    txtremark.Text.Trim(),
                    variables.p_inputter
                };

            dt = sql.proc_getdata("book_proc_publish", p);
            if (dt.Rows.Count > 0)
            {
                txtid.Text = dt.Rows[0]["trancode"].ToString();
                MessageBox.Show(vmsg, variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleartext();
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
                    txtid.Text = dt.Rows[0]["pub_id"].ToString();
                    txtname.Text = dt.Rows[0]["pub_name"].ToString();
                    txtpage.Text = dt.Rows[0]["pages"].ToString();
                    txtremark.Text = dt.Rows[0]["remark"].ToString();
                    cboactive.SelectedValue = dt.Rows[0]["active"].ToString();
                    pDate.Value = Convert.ToDateTime(dt.Rows[0]["pub_date"]);
                    btn_edit_record();
                }
                else
                {
                    MessageBox.Show("Record id does not exist !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }

        void load_publish(string vstatus, string vtrancode)
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
                            dblist.Rows[i]["pub_id"].ToString(),
                            dblist.Rows[i]["pub_name"].ToString(),
                            dblist.Rows[i]["pages"].ToString()
                        );

                        dgSearch.Visible = true;
                    }
                }
            }
            catch { }
        }

        private void frmpublish_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = variables.p_frm_publish;
                formatgridview();
                cleartext();
                sql.Filter_ComboBox(cboactive, "exec proc_get_constants  'active'", "name", "code");
                btn_save_record();
                gb_action.Text = "";

            }
            catch { }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (isok() == true)
            {
                save_record("i", "", variables.p_message_insert);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btn_save_record();
            cleartext();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (isok() == true)
            {
                if (MessageBox.Show("Do you want to update " + txtid.Text.Trim() + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    save_record("u", txtid.Text.Trim(), variables.p_message_updated);
                }
            }
        }

        private void gb_action_Paint(object sender, PaintEventArgs e)
        {

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
                dgSearch.Location = new Point(64, 43);
                dgSearch.Size = new Size(330, 160);

                load_publish("load_publish", txtid.Text.Trim());
            }
        }

        private void dgSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = dgSearch[0, e.RowIndex].Value.ToString();
                dgSearch.Visible = false;
                GetInfor("show_publish", txtid.Text.Trim());
            }
            catch { }
        }
    }
}
