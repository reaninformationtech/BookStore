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

namespace BookStore
{
    public partial class frmregisteruser : KryptonForm
    {
        public frmregisteruser()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        public string puser_profile = string.Empty;
        public string puser_id = string.Empty;

        public string profile
        {
            set { puser_profile= value; }
            get { return puser_profile; }
        }

        public string userid
        {
            set { puser_id = value; }
            get { return puser_id; }
        }

        Boolean isok()
        {
            try
            {
                if (txtusername.Text.Trim() == string.Empty)
                {
                    txtusername.Select();
                    txtusername.Focus();
                    MessageBox.Show("Usernam has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (txtlogin.Text.Trim() == string.Empty)
                {
                    txtlogin.Select();
                    txtlogin.Focus();
                    MessageBox.Show("user login has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (txtpassword.Text.Trim() == string.Empty || (txtpassword.Text.Trim()!=txtconpassword.Text.Trim()))
                {
                    txtpassword.Select();
                    txtpassword.Focus();
                    MessageBox.Show("Password & password confirm must be the same !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (sql.cbo_empty(cboactive)==false)
                {
                    cboactive.Select();
                    cboactive.Focus();
                    MessageBox.Show("Status account has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (sql.IsValidEmail(txtlogin.Text.Trim())==false)
                {
                    txtlogin.Select();
                    txtlogin.Focus();
                    MessageBox.Show("Login name must be email !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                DataTable dt = new DataTable();
                string[] p = { txtlogin.Text.Trim() };
                dt = sql.proc_getdata("proc_userlogins", p);
                if (dt.Rows.Count > 0)
                {
                    txtlogin.Select();
                    txtlogin.Focus();
                    MessageBox.Show("User login already exists  !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;        
        }
        void registeruser(string vstatus , string vcode , string vmsg)
        {
            try
            {
                DataTable dt = new DataTable();
                string engcryp_pwd = string.Empty;
                engcryp_pwd= xml_security.GenerateKeyHash(txtpassword.Text.Trim());
                string[] p =
                {
                    vstatus,
                    vcode,
                    variables.p_branchcode,
                    txtusername.Text.Trim(),
                    txtlogin.Text.Trim(),
                    engcryp_pwd,
                    puser_profile,
                    cboactive.SelectedValue.ToString(),
                    txtidcard.Text.Trim(),
                    "",
                    "",
                    variables.p_inputter

                };
                dt = sql.proc_getdata("proc_userlogin_register", p);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("User has been register !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch { }
        }

        private void frmregisteruser_Load(object sender, EventArgs e)
        {
            try
            {
                sql.Filter_ComboBox(cboactive, "exec proc_get_constants  'active'", "name", "code");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            }
            catch { }
        }
 

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (isok() == true)
            {
                registeruser("I", "", "");
            }
        }
    }
}
