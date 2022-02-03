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
    public partial class frmchangeprofile : KryptonForm
    {
        public frmchangeprofile()
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
        private void frmchangeprofile_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Text = "Change user profile ";
                sql.Filter_ComboBox(cboprofile, "exec book_proc_get_sql  'cbo_profile','" + variables.p_branchcode + "','%'", "name", "code");
            }
            catch { }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql.cbo_empty(cboprofile) == false)
                {
                    cboprofile.Select();
                    cboprofile.Focus();
                    MessageBox.Show("Please choose new profile !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "Resetprofile",
                        variables.p_branchcode,
                        userid,
                        cboprofile.SelectedValue.ToString(),
                        variables.p_inputter

                    };
                    dt = sql.proc_getdata("proc_userlogin_reset_passowrd", p);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("User profile has been changed !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch { }
        }
    }
}
