using BookStore.Book;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Class;

namespace BookStore
{
    public partial class frmdashboard : KryptonForm
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        public void Open_Frm(string vFrmName)
        {
            try
            {
                Form FormShow;
                Assembly assembly = Assembly.LoadFile(Application.StartupPath + "\\BookStore.exe");
                System.Reflection.Assembly assembly1 = Assembly.LoadFile(Application.StartupPath + "\\BookStore.exe");
                FormShow = (Form)assembly1.CreateInstance("BookStore." + vFrmName);
                if (FormShow == null)
                {
                    FormShow = (Form)assembly1.CreateInstance("BookStore.Book." + vFrmName);
                }
                if (FormShow != null)
                {
                    this.AddOwnedForm(FormShow);
                    LoadChild(FormShow, FormShow.Name);
                }
            }
            catch { }
        }

        void LoadChild(Form vFrm, string FrmTag)
        {
            try
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                vFrm.Tag = FrmTag;
                vFrm.MdiParent = frmdashboard.ActiveForm;
                vFrm.Show();
                vFrm.Activate();
            }
            catch { }
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Book store " + variables.p_version ;
        }

        private void ss_user_account_Click(object sender, EventArgs e)
        {
            Open_Frm("frmbookreleased");
        }

        private void ss_supply_info_Click(object sender, EventArgs e)
        {
            Open_Frm("frmbooksupply");
        }

        private void ss_product_info_Click(object sender, EventArgs e)
        {
            Open_Frm("frmbookproducts");
        }

        private void ss_logout_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            this.Hide();
            login.ShowDialog();
        }

        private void frmdashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ss_purchaseorder_Click(object sender, EventArgs e)
        {
            Open_Frm("frmpurchaseorder");
        }

        private void ss_auth_purchaseorder_Click(object sender, EventArgs e)
        {
            Open_Frm("frmauthpurchaserorders");
        }

        private void ss_pos_Click(object sender, EventArgs e)
        {
            Open_Frm("frmbookpos");
        }

        private void ss_currency_Click(object sender, EventArgs e)
        {
            Open_Frm("frmcurrency");
        }

        private void ss_customer_info_Click(object sender, EventArgs e)
        {
            Open_Frm("frmcustomer");
        }

        private void ss_auth_pos_Click(object sender, EventArgs e)
        {
            Open_Frm("frmauthpos");
        }

        private void ss_reports_Click(object sender, EventArgs e)
        {
            Open_Frm("frmbookreports");
        }

        private void ss_product_line_Click(object sender, EventArgs e)
        {
            Open_Frm("frnbookline");
        }

        private void ss_author_Click(object sender, EventArgs e)
        {
            Open_Frm("frmauthor");
        }
        private void ss_publish_Click(object sender, EventArgs e)
        {
            Open_Frm("frmpublish");

        }

        private void ss_author_info_Click(object sender, EventArgs e)
        {
            Open_Frm("frmauthor");
        }

        private void ss_publish_info_Click(object sender, EventArgs e)
        {
            Open_Frm("frnbookline");
        }

        private void ss_product_line_info_Click(object sender, EventArgs e)
        {
            Open_Frm("frnbookline");
        }

        private void ss_stock_setup_Click(object sender, EventArgs e)
        {
            Open_Frm("frmbookstock");
        }

        private void ss_setup_user_Click(object sender, EventArgs e)
        {
            Open_Frm("frmuseraccount");
        }

        private void _ss_stock_transfer_Click(object sender, EventArgs e)
        {
            Open_Frm("frmbooktransfer");
        }

        private void ss_auth_stocktransfer_Click(object sender, EventArgs e)
        {
            Open_Frm("frmauthstocktransfer");
        }

        private void ss_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
