using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Class;
using ComponentFactory.Krypton.Toolkit;
namespace BookStore
{
    public partial class frmlogin : KryptonForm
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        xml_security sec = new xml_security();
        private void OnFocus(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() == variables.p_username_focus)
            {
                txtusername.Text = string.Empty;
            }
        }
        private void OnDefocus(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() == string.Empty)
            {
                txtusername.Text = variables.p_username_focus;
            }
        }

        private void OnDefocusPwd(object sender, EventArgs e)
        {
            if (txtpassword.Text.Trim() == string.Empty)
            {
                txtpassword.Text = variables.p_userpassword_focus;
            }
        }
        private void OnFocusPwd(object sender, EventArgs e)
        {
            if (txtpassword.Text.Trim() == variables.p_userpassword_focus)
            {
                txtpassword.Text = string.Empty;
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtusername.Text = "admin.0085";
                txtpassword.Text = "love";
                string vpwd = xml_security.GenerateKeyHash("love");
                //txtusername.Select();
                //this.ActiveControl = txtusername;
                //txtusername.Focus();
                this.Text = variables.p_frm_register;



                this.txtusername.GotFocus += OnFocus;
                this.txtusername.LostFocus += OnDefocus;
                this.txtpassword.GotFocus += OnFocusPwd;
                this.txtpassword.LostFocus += OnDefocusPwd;
            }
            catch { }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = { txtusername.Text.Trim()};
                dt = sql.proc_getdata("proc_userlogins", p);
                if (dt.Rows.Count > 0)
                {
                    variables.p_branchcode = dt.Rows[0]["branchcode"].ToString();
                    variables.p_subofbranchcode = dt.Rows[0]["subofbranch"].ToString();
                    variables.p_profile_id = dt.Rows[0]["profile_id"].ToString();
                    variables.p_user_id = dt.Rows[0]["user_id"].ToString();
                    variables.p_profile_name = dt.Rows[0]["profile"].ToString();
                    variables.p_inputter = dt.Rows[0]["loginname"].ToString();
                    variables.p_sysstem_control = dt.Rows[0]["sys_id"].ToString();

                    bool vpwd = xml_security.ComparePasswords(dt.Rows[0]["loginpwd"].ToString(), txtpassword.Text.Trim());
                    if (vpwd == true)
                    {
                        frmdashboard dashboard = new frmdashboard();
                        this.Hide();
                        dashboard.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(variables.p_msg_user_Invalid, variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(variables.p_msg_user_Invalid, variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            frmregister frmregister = new frmregister();
            this.Hide();
            frmregister.ShowDialog();
        }
    }
}
