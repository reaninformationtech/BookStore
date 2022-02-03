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
    public partial class frmuseraccount : KryptonForm
    {
        public frmuseraccount()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vuserid = string.Empty;
        string vprofile = string.Empty;

        void LoadProfile()
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                    "load_profile",
                    variables.p_branchcode
                };
                dt = sql.proc_getdata("book_proc_get_sql", p);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tvProfile.Nodes[0].Nodes.Add(dt.Rows[i]["profile"].ToString());
                        tvProfile.Nodes[0].Nodes[i].Tag = dt.Rows[i]["profile_id"].ToString();
                    }
                }
            }
            catch { }

        }

        ListViewItem lv;
        void load_user(string vprofile)
        {
            try
            {
                DataTable user = new DataTable();
                string[] p = {
                    "load_user_by_profile",
                    variables.p_branchcode,
                    vprofile
                };
                user = sql.proc_getdata("book_proc_get_sql", p);
                lvUser.Items.Clear();
                if (user.Rows.Count > 0)
                {
                    for( int i=0; i < user.Rows.Count; i++)
                    {
                        lv = lvUser.Items.Add(user.Rows[i]["user_id"].ToString());
                        lv.SubItems.Add(user.Rows[i]["idcard"].ToString());
                        lv.SubItems.Add(user.Rows[i]["user_name"].ToString());
                        lv.SubItems.Add(user.Rows[i]["loginname"].ToString());
                        lv.SubItems.Add(user.Rows[i]["profile"].ToString());
                        lv.SubItems.Add(user.Rows[i]["status"].ToString());
                    }
                }
            }
            catch { }
        }
        private void frmuseraccount_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                LoadProfile();
            }
            catch { }
        }

        private void tvProfile_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                vprofile = string.Empty;
                if(e.Node.Text!= "User Profile")
                {
                    vprofile = e.Node.Tag.ToString();
                    if (vprofile != string.Empty)
                    {
                        load_user(vprofile);
                    }
                }
                else
                {
                    lvUser.Items.Clear();
                }
            }
            catch { }
        }

        private void cmsUser_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (vuserid == string.Empty && vprofile !=string.Empty)
                {
                    _NewUser.Enabled = true;
                    _SetNewPassword.Enabled = false;
                    _ChangeProfile.Enabled = false;
                    _Disable.Enabled = false;
                    _Active.Enabled = false;
                }
                else if (vuserid != string.Empty && vprofile != string.Empty)
                {
                    _NewUser.Enabled = true;
                    _SetNewPassword.Enabled = true;
                    _ChangeProfile.Enabled = true;
                    _Disable.Enabled = true;
                    _Active.Enabled = true;
                }
                else
                {
                    _NewUser.Enabled = false;
                    _SetNewPassword.Enabled = false;
                    _ChangeProfile.Enabled = false;
                    _Disable.Enabled = false;
                    _Active.Enabled = false;
                }

            }
            catch { }
        }

        private void _NewUser_Click(object sender, EventArgs e)
        {
            frmregisteruser user = new frmregisteruser();
            user.puser_profile = vprofile;
            user.ShowDialog();

            load_user(vprofile);
        }

        private void lvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvUser.SelectedItems.Count == 0)
                {
                    vuserid = string.Empty;
                    return;
                }
                else
                {
                    ListViewItem item = lvUser.SelectedItems[0];
                    vuserid = item.SubItems[0].Text;
                }
            }
            catch { }
        }

        private void _SetNewPassword_Click(object sender, EventArgs e)
        {
            frmchangepassword user = new frmchangepassword();
            user.puser_id = vuserid;
            user.ShowDialog();
            load_user(vprofile);

        }

        private void _ChangeProfile_Click(object sender, EventArgs e)
        {
            frmchangeprofile user = new frmchangeprofile();
            user.puser_id = vuserid;
            user.ShowDialog();
            load_user(vprofile);
        }

        private void _Disable_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string[] p =
            {
                        "active",
                        variables.p_branchcode,
                        vuserid,
                        "0",
                        variables.p_inputter
                    };
            dt = sql.proc_getdata("proc_userlogin_reset_passowrd", p);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("User has been disabled !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_user(vprofile);
            }
        }

        private void _Active_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string[] p =
            {
                        "active",
                        variables.p_branchcode,
                        vuserid,
                        "1",
                        variables.p_inputter
                    };
            dt = sql.proc_getdata("proc_userlogin_reset_passowrd", p);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("User has been active !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_user(vprofile);
            }
        }
    }
}
