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
using System.Runtime.InteropServices;

namespace BookStore
{
    public partial class frmregister : KryptonForm
    {

        public frmregister()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        void enable_label()
        {
            lbltakenote.Visible = true;
            lblusername.Visible = true;
            lblusershow.Visible = true;
            lblPassword.Visible = true;
            lblpasswordshow.Visible = true;
        }
        void disable_label()
        {
            lbltakenote.Visible = false;
            lblusername.Visible = false;
            lblusershow.Visible = false;
            lblPassword.Visible = false;
            lblpasswordshow.Visible = false;
        }


        private void frmregister_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Text = variables.p_frm_register;
                this.Size = new Size(470, 410);
                disable_label();
                sql.Filter_ComboBox(cbosystem, "select sys_id as code , sys_name as name  from syssystemcontrols where active='1';", "name", "code");
            }
            catch { }
        }

        string[] para = new string[5];
        private void btncreate_Click(object sender, EventArgs e)
        {
            if (cbosystem.Text.Trim() == string.Empty || cbosystem.SelectedIndex==-1)
            {
                MessageBox.Show("Please choose system control .", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = cbosystem;
                cbosystem.Focus();
            }
            else if(txtbranchname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please input branch name .", variables.p_message_titil,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.ActiveControl = txtbranchname;
                txtbranchname.Focus();
            }
            else if (txtbranchshort.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please input branch short .", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = txtbranchshort;
                txtbranchshort.Focus();
            }
            else if (txtbranchemail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please input branch email .", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = txtbranchemail;
                txtbranchemail.Focus();
            }
            else
            {
                para[0] = cbosystem.SelectedValue.ToString();
                para[1] = txtbranchname.Text.Trim();
                para[2] = txtbranchshort.Text.Trim();
                para[3] = txtbranchemail.Text.Trim();
                para[4] = txtbranchphone.Text.Trim();

                time_show_progressbar.Enabled = true;
                progressbarsetup.Visible = true;
                progressbarsetup.Value = 0;
            }
        }

        private void time_show_progressbar_Tick(object sender, EventArgs e)
        {
            try
            {
                progressbarsetup.Value += 2;
                if (progressbarsetup.Value >= 100)
                {
                    DataTable dt = new DataTable();
                    dt = sql.proc_getdata("book_proc_registerbranch", para);
                    if (dt.Rows.Count > 0)
                    {
                        this.Size = new Size(740, 440);
                        lblusername.Text = variables.p_msg_username;
                        lblusershow.Text = dt.Rows[0]["loginame"].ToString();
                        lblPassword.Text = variables.p_msg_password;
                        lblpasswordshow.Text = dt.Rows[0]["loginpwd"].ToString();
                        enable_label();

                        time_show_progressbar.Enabled = false;
                        progressbarsetup.Visible = false;

                        // Engl
                        DataTable user = new DataTable();
                        string vpassword = xml_security.GenerateKeyHash(dt.Rows[0]["loginpwd"].ToString());
                        string[] p = { dt.Rows[0]["loginame"].ToString() };
                        user = sql.proc_getdata("proc_userlogins", p);

                        string[] p_user = {
                                user.Rows[0]["user_id"].ToString(),
                                user.Rows[0]["loginname"].ToString(),
                                vpassword,
                            };
                        sql.proc_getdata("proc_userlogin_ch_passowrd", p_user);

                        MessageBox.Show("New branch has been register .", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch { }
        }

        private void btllogin_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            this.Hide();
            frmlogin.ShowDialog();
        }
    }
}
