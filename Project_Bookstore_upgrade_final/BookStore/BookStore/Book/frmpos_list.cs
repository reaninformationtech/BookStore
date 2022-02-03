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
    public partial class frmpos_list : KryptonForm
    {
        public frmpos_list()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        public string PStatus = string.Empty;
        public string PCode = string.Empty;

        public string Code
        {
            get { return PCode; }
            set { PCode = value; }
        }

        public string Status
        {
            get { return PStatus; }
            set { PStatus = value; }
        }

        void FormateGride()
        {
            try
            {
                gData.MultiSelect = false;
                for (int i = 0; i < gData.Columns.Count; i++)
                {
                    gData.Columns[i].ReadOnly = true;
                    gData.Columns[i].DefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
                    gData.Columns[i].DefaultCellStyle.ForeColor = Color.Brown;
                }

 

                gData.Columns["vcode"].Width = 100;
                gData.Columns["vcustomer"].Width = 130;

                gData.Columns["vdate"].Width = 150;
                gData.Columns["vstatus"].Width = 90;

                gData.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            }
            catch { }
        }


        void add_to_list(string vstatus, string vcode)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p =
                {
                    vstatus,
                    variables.p_branchcode,
                    vcode
                };
                dt = sql.proc_getdata("book_proc_get_sql", p);

                gData.Rows.Clear();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        gData.Rows.Add(
                                       dt.Rows[i]["rcp_id"].ToString(),
                                       dt.Rows[i]["cus_name"].ToString(),
                                       dt.Rows[i]["create_at"].ToString(),
                                       dt.Rows[i]["inputter"].ToString(),
                                       dt.Rows[i]["status"].ToString()
                                       );
                    }
                }
                else
                {
                    PStatus = string.Empty;
                    PCode = string.Empty;
                    this.Close();
                }
            }
            catch { }
        }


        private void frmpos_list_Load(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = variables.p_EnableForm;
                this.TopMost = true;
                this.Text = variables.p_frm_pos_list;

                add_to_list(PStatus, PCode);
                FormateGride();
            }
            catch { }
        }

        private void gData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Code = gData["vcode", e.RowIndex].Value.ToString();
                this.Close();
            }
            catch { }
        }

        private void gData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Code = gData["vcode", e.RowIndex].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}
