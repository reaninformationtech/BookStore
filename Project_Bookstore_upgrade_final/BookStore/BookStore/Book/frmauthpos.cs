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
    public partial class frmauthpos : KryptonForm
    {
        public frmauthpos()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vinvoice = string.Empty;

        void formatgridview()
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

                gData.Columns["gdiscount"].Visible = false;
                gData.Columns["gprocode"].Width = 35;
                gData.Columns["gdiscount"].Width = 40;

                gData.Columns["gname"].Width = 170;
                gData.Columns["gprice"].Width = 45;
                gData.Columns["gqty"].Width = 30;
                gData.Columns["gamount"].Width = 60;

                gData.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            }
            catch { }
        }

        void unauthorize_list(string vstatus, string vtrancode)
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
                            (i + 1).ToString(),
                            dblist.Rows[i]["rcp_id"].ToString(),
                            dblist.Rows[i]["cus_name"].ToString()
                        );

                        dgSearch.Visible = true;
                    }
                }
            }
            catch { }
        }

        void dg_views(string vstatus, string vrcp_id)
        {
            try
            {
                if (gData.Rows.Count > 0)
                {
                    gData.Rows.Clear();
                }
            }
            catch { }
            DataTable dts = new DataTable();
            string[] p = {
                            vstatus,
                            variables.p_branchcode,
                            vrcp_id,
                        };
            dts = sql.proc_getdata("book_proc_get_sql", p);
            if (dts.Rows.Count > 0)
            {
                dgSearch.Visible = false;

                txtcustomer.Text = dts.Rows[0]["cus_name"].ToString();
                lbltotal.Text = "Total : " + string.Format("{0:0.00}", Convert.ToDouble(dts.Rows[0]["t_amount"])) + variables.p_bestcurrencysymbol + " = " + string.Format("{0:0.00}", Convert.ToDouble(dts.Rows[0]["t_ex_amount"])) + variables.p_secondcurrencysymbol ;
                txtinputter.Text= dts.Rows[0]["inputter"].ToString() + "  " + dts.Rows[0]["create_at"].ToString();

                lblsubtotal1.Text = "Sub Total(" + variables.p_bestcurrencysymbol + ")   : " + string.Format("{0:0,0.00}", dts.Rows[0]["t_no_dis_amount"]);
                lblsubtotal2.Text = "Sub Total(" + variables.p_secondcurrencysymbol + ")   : " + string.Format("{0:0,0.00}", dts.Rows[0]["t_ex_no_dis_amount"]);
                lbldiscount.Text = "Discount (" + variables.p_bestcurrencysymbol + ")   : " + string.Format("{0:0,0.00}", dts.Rows[0]["t_discount"]);  

                lblgrand1.Text = "Grand Total(" + variables.p_bestcurrencysymbol + ")   : "+ string.Format("{0:0,0.00}", dts.Rows[0]["t_amount"]);
                lblgrand2.Text = "Grand Total(" + variables.p_secondcurrencysymbol + ")   : " + string.Format("{0:0,0.00}", dts.Rows[0]["t_ex_amount"]);

                lblpaid1.Text = "Paid Amount(" + variables.p_bestcurrencysymbol + ")   : "+ string.Format("{0:0,0.00}", dts.Rows[0]["paid1"]);
                lblpaid2.Text = "Paid Amount(" + variables.p_secondcurrencysymbol + ")   : "+ string.Format("{0:0,0.00}", dts.Rows[0]["paid2"]);

               lblreturn1.Text = "Change Amount(" + variables.p_bestcurrencysymbol + ")   : "+ string.Format("{0:0,0.00}", dts.Rows[0]["change1"]);
               lblreturn2.Text = "Change Amount(" + variables.p_secondcurrencysymbol + ")   : "+ string.Format("{0:0,0.00}", dts.Rows[0]["change2"]);

                for (int i = 0; i < dts.Rows.Count; i++)
                {

                    if (Convert.ToDouble(dts.Rows[i]["discount"]) > 0)
                    {
                        gData.Columns["gdiscount"].Visible = true;
                    }
                    gData.Rows.Add(
                                            (i+1).ToString(),
                                            dts.Rows[i]["pro_name"].ToString(),
                                            string.Format("{0:0.00}", Convert.ToDouble(dts.Rows[i]["unitprice"])),
                                            string.Format("{0:0}", Convert.ToDouble(dts.Rows[i]["qty"])),
                                            string.Format("{0:0}", Convert.ToDouble(dts.Rows[i]["discount"])) + "%",
                                            string.Format("{0:0.00}", Convert.ToDouble(dts.Rows[i]["amount"]))
                                          );
                }
            }
        }

        void cleartext()
        {
            sql.exchangerate("exchangerate");
            vinvoice = string.Empty;
            txtinvoice.Text = string.Empty;
            lblexchange.Text = variables.p_exchangerateinfo;
            lbltotal.Text = "Total amount : 0.00 ";
            txtcustomer.Text = string.Empty;
            txtinputter.Text = string.Empty;

            lblsubtotal1.Text = string.Empty;
            lblsubtotal2.Text = string.Empty;
            lbldiscount.Text = string.Empty;
            lblgrand1.Text = string.Empty;
            lblgrand2.Text = string.Empty;
            lblpaid1.Text = string.Empty;
            lblpaid2.Text = string.Empty;
            lblreturn1.Text = string.Empty;
            lblreturn2.Text = string.Empty;

            txtcustomer.ReadOnly = true;
            txtinputter.ReadOnly = true;

            gData.Rows.Clear();
            dgSearch.Visible = false;

        }

        private void frmauthpos_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                formatgridview();
                cleartext();
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
                if (txtinvoice.Text.Trim() == string.Empty)
                {
                    return;
                }

                if (MessageBox.Show("Do you want to authorize " +vinvoice + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "auth_pos",
                        variables.p_branchcode,
                        vinvoice,
                        variables.p_inputter
                    };

                    dt = sql.proc_getdata("book_proc_authorize", p);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record has been authorized ! ", variables.p_message_successful, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtinvoice.Text.Trim() == string.Empty)
                {
                    return;
                }
                if (MessageBox.Show("Do you want to reject " + vinvoice + " now ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "reject_pos",
                        variables.p_branchcode,
                        vinvoice,
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

        private void btnList_Click(object sender, EventArgs e)
        {
            if (dgSearch.Visible == true)
            {
                dgSearch.Visible = false;
            }
            else
            {
                dgSearch.Visible = true;
                dgSearch.Location = new Point(90, 35);
                dgSearch.Size = new Size(330, 200);

                unauthorize_list("load_una_invoice", txtinvoice.Text.Trim());
            }
        }

        private void dgSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtinvoice.Text = dgSearch[1, e.RowIndex].Value.ToString();
                vinvoice = dgSearch[1, e.RowIndex].Value.ToString();
                dgSearch.Visible = false;

                dg_views("print_invoice", vinvoice);
            }
            catch { }
        }

        private void txtinvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                dg_views("print_invoice", txtinvoice.Text.Trim());
                txtinvoice.Focus();
                txtinvoice.Select();
            }
        }
    }
}
