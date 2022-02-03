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
    public partial class frmchangepassword : KryptonForm
    {
        public frmchangepassword()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        public string puser_id = string.Empty;


        public string userid
        {
            set { puser_id = value; }
            get { return puser_id; }
        }
        private void frmchangepassword_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Text = "Change new password ";
            }
            catch { }
        }


        Boolean isok()
        {
            try
            {
                if (txtpassword.Text.Trim() == string.Empty)
                {
                    txtpassword.Select();
                    txtpassword.Focus();
                    MessageBox.Show("Password has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (txtconpassword.Text.Trim() == string.Empty)
                {
                    txtconpassword.Select();
                    txtconpassword.Focus();
                    MessageBox.Show("Confirm Password has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (txtpassword.Text.Trim() == string.Empty || (txtpassword.Text.Trim() != txtconpassword.Text.Trim()))
                {
                    txtpassword.Select();
                    txtpassword.Focus();
                    MessageBox.Show("Password & password confirm must be the same !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isok() == true)
                {
                    DataTable dt = new DataTable();
                    string engcryp_pwd = string.Empty;
                    engcryp_pwd = xml_security.GenerateKeyHash(txtpassword.Text.Trim());
                    string[] p =
                    {
                        "Resetpwd",
                        variables.p_branchcode,
                        userid,
                        engcryp_pwd,
                        variables.p_inputter

                    };
                    dt = sql.proc_getdata("proc_userlogin_reset_passowrd", p);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("User password has been reset !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch{ }
        }
    }
}
