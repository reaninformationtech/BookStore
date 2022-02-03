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
    public partial class frmbookpayments : KryptonForm
    {
        public frmbookpayments()
        {
            InitializeComponent();
        }
        public string PStatus = string.Empty;
        public string PCode = string.Empty;

        public double vGrandAmount = 0;
        public double vExGrandAmount = 0;
        public double vexchange = 0;
        sqlexcute sql = new sqlexcute();
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

        void EnableText()
        {
            txtinvoice.ReadOnly = true;
            txttotal.ReadOnly = true;

            txtamount1.ReadOnly = false;
            txtamount2.ReadOnly = false;
            txtamount1.Enabled = true;
            txtamount2.Enabled = true;

            txtchange1.ReadOnly = true;
            txtchange2.ReadOnly = true;

            lblpaid1.Text= "Paid amount(" + variables.p_bestcurrencysymbol + ")";
            lblpaid2.Text= "Paid amount(" + variables.p_secondcurrencysymbol + ")";

            lblchange1.Text = "Change amount (" + variables.p_bestcurrencysymbol + ")";
            lblchange2.Text = "Change amount (" + variables.p_secondcurrencysymbol + ")";

            txtamount1.Focus();
            txtamount1.SelectAll();

        }

        void Load_data()
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                    PStatus,
                    variables.p_branchcode,
                    PCode
                    };

                dt = sql.proc_getdata("book_proc_get_sql", p);

                if (dt.Rows.Count > 0)
                {
                    txtinvoice.Text = dt.Rows[0]["rcp_id"].ToString();
                    txttotal.Text = dt.Rows[0]["exchange_info"].ToString();
                    double.TryParse(dt.Rows[0]["total_amount"].ToString(), out vGrandAmount);
                    double.TryParse(dt.Rows[0]["t_exchange"].ToString(), out vExGrandAmount);
                    double.TryParse(dt.Rows[0]["exchange"].ToString(), out vexchange);

                }
            }
            catch { }
        }
        private void frmbookpayments_Load(object sender, EventArgs e)
        {
            try
            {
                Load_data();
                EnableText();
            }
            catch { }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                double vchange1 = 0;
                double.TryParse(txtchange1.Text.Trim(), out vchange1);
                if (vchange1 < 0)
                {
                    MessageBox.Show("Something went wrong payments !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = new DataTable();
                    string[] p =
                    {
                        "pay_invoice",
                        variables.p_branchcode,
                        PCode,
                        vGrandAmount.ToString(),
                        txtamount1.Text.Trim(),
                        txtamount2.Text.Trim(),
                        txtchange1.Text.Trim(),
                        txtchange2.Text.Trim(),
                        variables.p_inputter
                    };

                    dt = sql.proc_getdata("book_proc_pos_payments", p);
                    if (dt.Rows.Count > 0)
                    {

                        if (MessageBox.Show("Do you to print invoice ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PrintMyExcelFile("print_invoice", PCode);
                        };
                        this.Close();
                        MessageBox.Show("Payment completed ! ", variables.p_message_successful, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch { }
        }

        void PrintMyExcelFile(string vStatus, string vCode)
        {

            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                            vStatus,
                            variables.p_branchcode,
                            vCode
                        };
                dt = sql.proc_getdata("book_proc_get_sql", p);


                if (dt.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    // Open the Workbook:
                    Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(Application.StartupPath + @"\Reports\RPT_PRINT.xlsx",
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                    Int16 vRowStart = 11;
                    Microsoft.Office.Interop.Excel.Range line = (Microsoft.Office.Interop.Excel.Range)ws.Rows[12];

                    Boolean vCH = false;
                    int vRowTotal = 14;
                    int vRowAdd = 14;


                    if (dt.Rows.Count > 3)
                    {
                        try
                        {
                            for (int i = 0; i < dt.Rows.Count - 2; i++)
                            {
                                line.Insert();

                                Microsoft.Office.Interop.Excel.Range sourceRange = ws.get_Range("A12:H12");
                                sourceRange.Copy();
                                Microsoft.Office.Interop.Excel.Range last = ws.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                                Microsoft.Office.Interop.Excel.Range destinationRange = ws.get_Range("A" + (vRowStart + i + 1) + ":H" + (vRowStart + i + 1));
                                destinationRange.PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteFormats);
                                vRowAdd = i + 1;
                            }
                            vCH = true;
                            if (vCH == true)
                            {
                                vRowTotal = vRowTotal + vRowAdd;
                            }
                        }
                        catch { }
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ws.Cells[vRowStart + i, "B"] = (i + 1).ToString();
                        ws.Cells[vRowStart + i, "C"] = dt.Rows[i]["pro_name"].ToString();
                        ws.Cells[vRowStart + i, "E"] = dt.Rows[i]["symbol"].ToString() + string.Format("{0:0,0}", dt.Rows[i]["unitprice"]);
                        ws.Cells[vRowStart + i, "F"] = dt.Rows[i]["qty"].ToString();
                        ws.Cells[vRowStart + i, "G"] = dt.Rows[i]["symbol"].ToString() + string.Format("{0:0,0}", dt.Rows[i]["amount"]);
                    }
           

                    if (dt.Rows.Count > 0)
                    {

                        //ws.Cells[6, "B"] = dttotal.Rows[0]["Waiting"].ToString();
                        ws.Cells[7, "B"] = dt.Rows[0]["inputter"].ToString();
                        ws.Cells[8, "B"] = "Invoice : " + dt.Rows[0]["rcp_id"].ToString();

                        ws.Cells[7, "E"] = dt.Rows[0]["cus_name"].ToString();
                        ws.Cells[8, "E"] = dt.Rows[0]["printdate"].ToString();


                        ws.Cells[vRowTotal + 1, "D"] = "Sub Total(" + variables.p_bestcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 1, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_no_dis_amount"]);


                        ws.Cells[vRowTotal + 2, "D"] = "Sub Total(" + variables.p_secondcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 2, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_ex_no_dis_amount"]);

                        ws.Cells[vRowTotal + 3, "D"] = "Discount (" + variables.p_bestcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 3, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_discount"]);


                        ws.Cells[vRowTotal + 4, "D"] = "Grand Total(" + variables.p_bestcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 4, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_amount"]);

                        ws.Cells[vRowTotal + 5, "D"] = "Grand Total(" + variables.p_secondcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 5, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["t_ex_amount"]);


                        ws.Cells[vRowTotal + 6, "D"] = "Paid Amount(" + variables.p_bestcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 6, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["paid1"]);

                        ws.Cells[vRowTotal + 7, "D"] = "Paid Amount(" +  variables.p_secondcurrencysymbol   + ")   :";
                        ws.Cells[vRowTotal + 7, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["paid2"]);


                        ws.Cells[vRowTotal + 8, "D"] = "Change Amount(" + variables.p_bestcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 8, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["change1"]);


                        ws.Cells[vRowTotal + 9, "D"] = "Change Amount(" + variables.p_secondcurrencysymbol + ")   :";
                        ws.Cells[vRowTotal + 9, "E"] = string.Format("{0:0,0.00}", dt.Rows[0]["change2"]);

                    }

                    excelApp.Visible = true;
                    //ws.PrintOut(
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    //    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    //// Cleanup:
                    //GC.Collect();
                    //GC.WaitForPendingFinalizers();
                    //wb.Close(false, Type.Missing, Type.Missing);
                    //excelApp.Quit();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

        }

        private void txtamount1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch { }
        }

        private void txtamount1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double vPaidamount1 = 0;
                double vPaidamount2 = 0;
                double.TryParse(txtamount1.Text.Trim(), out vPaidamount1);
                if(vPaidamount1< vGrandAmount)
                {
                    vPaidamount2 = (vGrandAmount - vPaidamount1) * vexchange;
                    txtamount2.Text =  string.Format("{0:0.00}", vPaidamount2);
                    txtchange1.Text = "0.00";
                    txtchange2.Text = "0.00";
                }
                else if (vPaidamount1 > vGrandAmount)
                {
                    txtamount2.Text = "0.00";
                    txtchange1.Text = string.Format("{0:0.00}", (vPaidamount1 - vGrandAmount));
                    txtchange2.Text = string.Format("{0:0.00}", (vPaidamount1 - vGrandAmount)* vexchange);

                }

            }
            catch { }
        }

        private void txtamount2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double vPaidamount1 = 0;
                double vPaidamount2 = 0;
                double vamount1 = 0;
                double vamount2 = 0;
                double.TryParse(txtamount1.Text.Trim(), out vPaidamount1);
                double.TryParse(txtamount2.Text.Trim(), out vPaidamount2);

                if (vPaidamount1 <= 0)
                {
                    txtamount1.Text = "0.00";
                }

                if ((vPaidamount2 / vexchange) + vPaidamount1 != vGrandAmount)
                {
                    vamount1 = ((vPaidamount2 / vexchange) + vPaidamount1)-vGrandAmount;
                    vamount2 = (vamount1 * vexchange);

                    txtchange1.Text = string.Format("{0:0.00}", vamount1);
                    txtchange2.Text = string.Format("{0:0.00}", vamount2);
                }
                else
                {
                    txtchange1.Text = "0.00";
                    txtchange2.Text = "0.00";
                }

            }
            catch { }
        }
    }
}
