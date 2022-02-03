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
    public partial class frmpurchaseorder : KryptonForm
    {
        public frmpurchaseorder()
        {
            InitializeComponent();
        }
        string vpro_id = string.Empty;
        sqlexcute sql = new sqlexcute();
        double g_totalAmount = 0;

        void cleartext()
        {
            txtinvoice.Text = string.Empty;
            cbosupplier.SelectedValue = string.Empty;
            cbostock.SelectedValue = string.Empty;
            lblbarcode.Text = string.Empty;

            txtbarcode.Select();
            txtbarcode.Focus();
            dgdata.Rows.Clear();

            g_totalAmount = 0;
        }

        void FormateDataGridview()
        {
            try
            {
                for (int i = 0; i < dgdata.Columns.Count; i++)
                {
                    dgdata.Columns[i].ReadOnly = true;
                }

                dgdata.Columns["gqty"].ReadOnly = false;
                dgdata.Columns["gdiscount"].ReadOnly = false;
                dgdata.Columns["gcost"].ReadOnly = false;

                dgdata.Columns["gnum"].HeaderText = "Nº";
                dgdata.Columns["gnum"].Width = 30;
                dgdata.Columns["gbarcode"].Width = 130;
                dgdata.Columns["gitem"].Width = 200;
                dgdata.Columns["gqty"].Width = 50;

                //txtTypeCode cost

                this.dgdata.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
                dgdata.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                this.dgdata.DefaultCellStyle.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Pixel);
                this.dgdata.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch { }
        }

        void calculator()
        {
            try
            {
                if (dgdata.Rows.Count > 0)
                {
                    int qty = 0;
                    double cost = 0;
                    double discount = 0;
                    double amount = 0;
                    double totalAmount = 0;
                    double Dis = 0;

                    g_totalAmount = 0;

                    for (int i = 0; i < dgdata.Rows.Count; i++)
                    {
                        if (sql.Rights(dgdata["gdiscount", i].Value.ToString(), 1) == "%")
                        {
                            Dis = Convert.ToDouble(sql.Left(dgdata["gdiscount", i].Value.ToString(), dgdata["gdiscount", i].Value.ToString().Length - 1));
                        }
                        else
                        {
                            Dis = Convert.ToDouble(dgdata["gdiscount", i].Value);
                            dgdata["gdiscount", i].Value = dgdata["gdiscount", i].Value + "%";
                        }

                        int.TryParse(dgdata["gqty", i].Value.ToString(), out qty);
                        double.TryParse(dgdata["gcost", i].Value.ToString(), out cost);
                        double.TryParse(Dis.ToString(), out discount);
                        amount = (qty * cost);

                        totalAmount = amount - (amount * discount / 100);
                        g_totalAmount = g_totalAmount + totalAmount;

                        dgdata["gamount", i].Value = String.Format("{0:0.00}", totalAmount).ToString();
                        dgdata["gnum", i].Value = (i + 1).ToString();

                    }

                    lbltotal.Text ="Total : "+ String.Format("{0:0.00}", g_totalAmount).ToString();
                }
            }
            catch
            {
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        void add_to_list(string vstatus, string vcode)
        {
            try
            {
                lblbarcode.Text = vcode;
                DataTable dt = new DataTable();

                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    vcode
                };
                dt = sql.proc_getdata("book_proc_get_sql", p);
                if (dt.Rows.Count > 0)
                {
                    vpro_id = dt.Rows[0]["pro_id"].ToString();

                    if (dgdata.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgdata.Rows.Count; i++)
                        {
                            if (dgdata["gpro_id", i].Value.ToString() == dt.Rows[0]["pro_id"].ToString())
                            {
                                dgdata["gqty", i].Value = Convert.ToInt32(dgdata["gqty", i].Value) + 1;
                                txtbarcode.Text = string.Empty;
                                calculator();
                                return;
                            }
                        }
                    }

                    dgdata.Rows.Add(1,
                            dt.Rows[0]["pro_id"].ToString(), 
                            dt.Rows[0]["pro_name"].ToString(),
                            dt.Rows[0]["barcode"].ToString(),
                            String.Format("{0:0.00}", dt.Rows[0]["cost"]).ToString(),
                            "1",
                            "0"
                            );
                    calculator();
                    txtbarcode.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("items does not exist !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch { }
        }

        private void frmpurchaseorder_Load(object sender, EventArgs e)
        {
            try
            {
                gb.Text = "Information ";
                gb_action.Text = string.Empty;
                cleartext();
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                sql.Filter_ComboBox(cbosupplier, "exec book_proc_get_sql  'cbo_supplier','" + variables.p_branchcode + "','%'", "name", "code");
                sql.Filter_ComboBox(cbostock, "exec book_proc_get_sql  'cbo_stock','" + variables.p_branchcode + "','%'", "name", "code");
                FormateDataGridview();
            }
            catch { }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cleartext();
        }



        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                add_to_list("barcode", txtbarcode.Text.Trim());
            }
        }

        private void dgdata_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                calculator();
            }
            catch { }
        }

        private void dgdata_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgdata.CurrentCell.ColumnIndex == 5 || dgdata.CurrentCell.ColumnIndex == 6 ) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void dgdata_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                calculator();
            }
            catch { }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtinvoice.Text.Trim() == string.Empty)
                {
                    txtinvoice.Select();
                    txtinvoice.Focus();
                    MessageBox.Show("Invoice number has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return ;
                }
                else if (sql.cbo_empty(cbosupplier)==false)
                {
                    cbosupplier.Select();
                    cbosupplier.Focus();
                    MessageBox.Show("Supply has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (sql.cbo_empty(cbostock) == false)
                {
                    cbostock.Select();
                    cbostock.Focus();
                    MessageBox.Show("Stock has been required !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    DataTable dtsave = new DataTable();
                    string[] p =
                    {
                        "i",
                        variables.p_branchcode,
                        "code",
                        txtinvoice.Text.Trim(),
                        cbosupplier.SelectedValue.ToString(),
                        cbostock.SelectedValue.ToString(),
                        g_totalAmount.ToString(),
                        variables.p_inputter
                    };

                    dtsave = sql.proc_getdata("book_proc_purchaseorder", p);
                    if (dtsave.Rows.Count > 0)
                    {
                        save_record_items(dtsave.Rows[0]["trancode"].ToString());
                    }
                }
            }
            catch { }
        }
        void save_record_items(string vtrancode )
        {
            DataTable dtitems = new DataTable();
            string[] p = new string[8];
            double discount = 0;
            for (int i = 0; i < dgdata.Rows.Count; i++)
            {
                if (sql.Rights(dgdata["gdiscount", i].Value.ToString(), 1) == "%")
                {
                    discount = Convert.ToDouble(sql.Left(dgdata["gdiscount", i].Value.ToString(), dgdata["gdiscount", i].Value.ToString().Length - 1));
                }
                else
                {
                    discount = Convert.ToDouble(dgdata["gdiscount", i].Value);
                }

                p[0] = vtrancode;
                p[1] = variables.p_branchcode;
                p[2] = dgdata["gpro_id", i].Value.ToString();
                p[3] = dgdata["gbarcode", i].Value.ToString();
                p[4] = dgdata["gcost", i].Value.ToString();
                p[5] = dgdata["gqty", i].Value.ToString();
                p[6] = discount.ToString();
                p[7] = dgdata["gamount", i].Value.ToString();

                dtitems = sql.proc_getdata("book_proc_purchaserecord", p);
            }

            if (dtitems.Rows.Count > 0)
            {
                txtid.Text = vtrancode;
                MessageBox.Show(variables.p_message_purchase, variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleartext();
            }
        }

    }
}
