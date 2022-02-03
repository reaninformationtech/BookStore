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
    public partial class frmauthpurchaserorders : KryptonForm
    {
        public frmauthpurchaserorders()
        {
            InitializeComponent();
        }

        sqlexcute sql = new sqlexcute();
        void cleartext()
        {
            txtid.Text = string.Empty;
            txtinvoice.Text = string.Empty;
            txtstock.Text = string.Empty;
            txtsupply.Text = string.Empty;
            dgdata.Rows.Clear();
            dgSearch.Visible = false;

            txtinvoice.Enabled = false;
            txtstock.Enabled = false;
            txtsupply.Enabled = false;
        }
        void unauthorize_list(string vstatus,string vtrancode)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = { 
                    vstatus,
                    variables.p_branchcode,
                    vtrancode
                };

                dblist = sql.proc_getdata("book_proc_get_sql", p);
                if (dblist.Rows.Count > 0)
                {
                    dgSearch.Rows.Clear();
                    for (int i=0; i < dblist.Rows.Count; i++)
                    {
                        dgSearch.Rows.Add(
                            (i+1).ToString(),
                            dblist.Rows[i]["pur_id"].ToString(),
                            dblist.Rows[i]["invoice"].ToString()
                        );

                        dgSearch.Visible = true;
                    }
                }
            }
            catch { }
        }


        void unauthorize_detial(string vstatus, string vtrancode)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    vtrancode
                };

                dblist = sql.proc_getdata("book_proc_get_sql", p);
                if (dblist.Rows.Count > 0)
                {
                    txtinvoice.Text = dblist.Rows[0]["invoice"].ToString();
                    txtsupply.Text = dblist.Rows[0]["sup_name"].ToString();
                    txtstock.Text = dblist.Rows[0]["sto_name"].ToString();

                    dgdata.Rows.Clear();
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgdata.Rows.Add(
                            (i + 1).ToString(),
                            dblist.Rows[i]["pro_name"].ToString(),
                            dblist.Rows[i]["barcode"].ToString(),
                            String.Format("{0:0.00}", dblist.Rows[i]["cost"]).ToString(),
                            String.Format("{0:0.00}", dblist.Rows[i]["qty"]).ToString(),
                            dblist.Rows[i]["discount"].ToString(),
                            String.Format("{0:0.00}", dblist.Rows[i]["amount"]).ToString()
                        );
                    }
                }
            }
            catch { }
        }

        void FormateDataGridview()
        {
            try
            {
                for (int i = 0; i < dgSearch.Columns.Count; i++)
                {
                    dgSearch.Columns[i].ReadOnly = true;
                }

                dgSearch.Columns["gnumber"].Width = 30;


                for (int i = 0; i < dgdata.Columns.Count; i++)
                {
                    dgdata.Columns[i].ReadOnly = true;
                }


                dgdata.Columns["gnum"].HeaderText = "Nº";
                dgdata.Columns["gnum"].Width = 30;
                dgdata.Columns["gbarcode"].Width = 130;
                dgdata.Columns["gitem"].Width = 200;
                dgdata.Columns["gqty"].Width = 50;

                //txtTypeCode
                this.dgSearch.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgdata.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgdata.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgdata.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgdata.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }
        private void frmauthpurchaserorders_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                this.gb.Text = "Purchase order information";
                dgSearch.Visible = false;
                FormateDataGridview();
                cleartext();
            }
            catch { }
        }

        


        private void btnimage_Click(object sender, EventArgs e)
        {
            if (dgSearch.Visible == true)
            {
                dgSearch.Visible = false;
                cleartext();
            }
            else
            {
                dgSearch.Location = new Point(90, 80);
                dgSearch.Size = new Size(330, 185);

                unauthorize_list("un_purchaseorder", txtid.Text.Trim());
            }
        }

        private void dgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSearch.Visible = false;
            unauthorize_detial("un_purchase_detail", txtid.Text.Trim());
        }

        private void dgSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = dgSearch[1, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btnapproval_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() == string.Empty)
                {
                    return;
                }

                if (MessageBox.Show("Do you want to authorize " + txtid.Text.Trim() + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "auth_purchase",
                        variables.p_branchcode,
                        txtid.Text.Trim(),
                        variables.p_inputter
                    };

                    dt = sql.proc_getdata("book_proc_authorize", p);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record has been authorized ! ",variables.p_message_successful,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cleartext();
                    }
                }
            }
            catch { }
        }

        private void btnreject_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() == string.Empty)
                {
                    return;
                }
                if (MessageBox.Show("Do you want to reject " + txtid.Text.Trim() + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "reject_purchase",
                        variables.p_branchcode,
                        txtid.Text.Trim(),
                        variables.p_inputter
                    };

                    dt = sql.proc_getdata("book_proc_authorize", p);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record has been rejected ! ", variables.p_message_successful, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleartext();
                    }
                }
            }
            catch { }
        }
    }
}
