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
using Excel = Microsoft.Office.Interop.Excel;

namespace BookStore.Book
{
    public partial class frmbookreports : KryptonForm
    {
        public frmbookreports()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        string vReportName = string.Empty;

        void report_list(string vstatus)
        {
            try
            {
                DataTable dblist = new DataTable();
                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    variables.p_sysstem_control
                };

                dblist = sql.proc_getdata("book_proc_get_sql", p);
                if (dblist.Rows.Count > 0)
                {
                    dgreport.Rows.Clear();
                    for (int i = 0; i < dblist.Rows.Count; i++)
                    {
                        dgreport.Rows.Add(
                            dblist.Rows[i]["rpt_id"].ToString(),
                            dblist.Rows[i]["rpt_name"].ToString(),
                            dblist.Rows[i]["rpt_title"].ToString()
                        );
                    }
                }
            }
            catch { }
        }

        void formatgridview()
        {
            try
            {
                dgreport.MultiSelect = false;
                for (int i = 0; i < dgreport.Columns.Count; i++)
                {
                    dgreport.Columns[i].ReadOnly = true;
                    dgreport.Columns[i].DefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
                    dgreport.Columns[i].DefaultCellStyle.ForeColor = Color.Brown;
                }

                dgreport.Columns["gcode"].Visible = false;
                dgreport.Columns["gname"].Visible = false;
                dgreport.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            }
            catch { }
        }


        private void frmbookreports_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                gb.Text = "Report information";

                report_list("load_reports");
                formatgridview();

                sql.Filter_ComboBox(cbostock, "exec book_proc_get_sql  'rpt_cbo_stock','" + variables.p_branchcode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboproduct, "exec book_proc_get_sql  'rpt_cbo_product','" + variables.p_branchcode + "','%'", "name", "code");
                sql.Filter_ComboBox(cboauthor, "exec book_proc_get_sql  'rpt_cbo_authors','" + variables.p_branchcode + "','%'", "name", "code");

            }
            catch { }
        }

        void rpt_stock()
        {
            try
            {
                DataTable rpt = new DataTable();
                string[] p = {
                    variables.p_branchcode,
                    cbostock.SelectedValue.ToString(),
                    cboproduct.SelectedValue.ToString(),
                    dgFrom.Value.ToString("yyyy/MM/dd"),
                    dgTo.Value.ToString("yyyy/MM/dd")
                };

                rpt = sql.proc_getdata("book_rpt_stock", p);
                if (rpt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;

                    excelApplication = new Excel.Application();
                    excelApplication.SheetsInNewWorkbook = 1;
                    excelApplication.DisplayAlerts = false;
                    // Open the template
                    workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\book_rpt_stock.xlsx");
                    workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                    workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);

                    ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                    int start = 4;

                    for (int i = 0; i < rpt.Rows.Count; i++)
                    {
                        ws.Cells[start + i, "B"] = (i + 1).ToString();
                        ws.Cells[start + i, "C"] = rpt.Rows[i]["sto_name"].ToString();
                        ws.Cells[start + i, "D"] = rpt.Rows[i]["pro_name"].ToString();
                        ws.Cells[start + i, "E"] = rpt.Rows[i]["barcode"].ToString();
                        ws.Cells[start + i, "F"] = rpt.Rows[i]["qty"].ToString();
                    }

                    ws.Application.CutCopyMode = (Microsoft.Office.Interop.Excel.XlCutCopyMode)0;
                    workbookTemplate.Close();
                    ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                    excelApplication.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch  
            {
                MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void rpt_pos()
        {
            try
            {
                DataTable rpt = new DataTable();
                string[] p = {
                    variables.p_branchcode,
                    cbostock.SelectedValue.ToString(),
                    cboproduct.SelectedValue.ToString(),
                    cboauthor.SelectedValue.ToString(),
                    dgFrom.Value.ToString("yyyy/MM/dd"),
                    dgTo.Value.ToString("yyyy/MM/dd")
                };

                rpt = sql.proc_getdata("book_rpt_pos", p);
                if (rpt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;

                    excelApplication = new Excel.Application();
                    excelApplication.SheetsInNewWorkbook = 1;
                    excelApplication.DisplayAlerts = false;
                    // Open the template
                    workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\book_rpt_pos.xlsx");
                    workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                    workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);

                    ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                    int start = 4;

                    for (int i = 0; i < rpt.Rows.Count; i++)
                    {
                        ws.Cells[start + i, "B"] = (i + 1).ToString();
                        ws.Cells[start + i, "C"] = rpt.Rows[i]["pro_name"].ToString();
                        ws.Cells[start + i, "D"] = rpt.Rows[i]["barcode"].ToString();
                        ws.Cells[start + i, "E"] = rpt.Rows[i]["sto_name"].ToString();
                        ws.Cells[start + i, "F"] = rpt.Rows[i]["unitprice"].ToString();
                        ws.Cells[start + i, "G"] = rpt.Rows[i]["discount"].ToString()+"%";
                        ws.Cells[start + i, "H"] = rpt.Rows[i]["qty"].ToString();
                        ws.Cells[start + i, "I"] = rpt.Rows[i]["amount"].ToString();
                        ws.Cells[start + i, "J"] = rpt.Rows[i]["inputter"].ToString();
                    }

                    ws.Application.CutCopyMode = (Microsoft.Office.Interop.Excel.XlCutCopyMode)0;
                    workbookTemplate.Close();
                    ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                    excelApplication.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void rpt_pos_una()
        {
            try
            {
                DataTable rpt = new DataTable();
                string[] p = {
                    variables.p_branchcode,
                    cbostock.SelectedValue.ToString(),
                    cboproduct.SelectedValue.ToString(),
                    cboauthor.SelectedValue.ToString(),
                    dgFrom.Value.ToString("yyyy/MM/dd"),
                    dgTo.Value.ToString("yyyy/MM/dd")
                };

                rpt = sql.proc_getdata("book_rpt_pos_una", p);
                if (rpt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;

                    excelApplication = new Excel.Application();
                    excelApplication.SheetsInNewWorkbook = 1;
                    excelApplication.DisplayAlerts = false;
                    // Open the template
                    workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\book_rpt_pos_una.xlsx");
                    workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                    workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);

                    ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                    int start = 4;

                    for (int i = 0; i < rpt.Rows.Count; i++)
                    {
                        ws.Cells[start + i, "B"] = (i + 1).ToString();
                        ws.Cells[start + i, "C"] = rpt.Rows[i]["pro_name"].ToString();
                        ws.Cells[start + i, "D"] = rpt.Rows[i]["barcode"].ToString();
                        ws.Cells[start + i, "E"] = rpt.Rows[i]["sto_name"].ToString();
                        ws.Cells[start + i, "F"] = rpt.Rows[i]["unitprice"].ToString();
                        ws.Cells[start + i, "G"] = rpt.Rows[i]["discount"].ToString() + "%";
                        ws.Cells[start + i, "H"] = rpt.Rows[i]["qty"].ToString();
                        ws.Cells[start + i, "I"] = rpt.Rows[i]["amount"].ToString();
                        ws.Cells[start + i, "J"] = rpt.Rows[i]["inputter"].ToString();
                    }

                    ws.Application.CutCopyMode = (Microsoft.Office.Interop.Excel.XlCutCopyMode)0;
                    workbookTemplate.Close();
                    ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                    excelApplication.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void book_rpt_stock_transfer()
        {
            try
            {
                DataTable rpt = new DataTable();
                string[] p = {
                    variables.p_branchcode,
                    cbostock.SelectedValue.ToString(),
                    cboproduct.SelectedValue.ToString(),
                    cboauthor.SelectedValue.ToString(),
                    dgFrom.Value.ToString("yyyy/MM/dd"),
                    dgTo.Value.ToString("yyyy/MM/dd")
                };

                rpt = sql.proc_getdata("book_rpt_stock_transfer", p);
                if (rpt.Rows.Count > 0)
                {
                    Excel.Application excelApplication = null;
                    Excel.Workbook workbookTemplate = null;
                    Excel.Workbook workbookReport = null;
                    Microsoft.Office.Interop.Excel.Worksheet ws;

                    excelApplication = new Excel.Application();
                    excelApplication.SheetsInNewWorkbook = 1;
                    excelApplication.DisplayAlerts = false;
                    // Open the template
                    workbookTemplate = excelApplication.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\Reports\book_rpt_stock_transfer.xlsx");
                    workbookReport = excelApplication.Workbooks.Add(Type.Missing);
                    workbookTemplate.Sheets[1].Copy(workbookReport.Worksheets[1]);

                    ws = (Microsoft.Office.Interop.Excel.Worksheet)workbookReport.Worksheets[1];

                    int start = 4;

                    for (int i = 0; i < rpt.Rows.Count; i++)
                    {
                        ws.Cells[start + i, "B"] = (i + 1).ToString();
                        ws.Cells[start + i, "C"] = rpt.Rows[i]["pro_name"].ToString();
                        ws.Cells[start + i, "D"] = rpt.Rows[i]["barcode"].ToString();
                        ws.Cells[start + i, "E"] = rpt.Rows[i]["stock_from"].ToString();
                        ws.Cells[start + i, "F"] = rpt.Rows[i]["stock_to"].ToString();
                        ws.Cells[start + i, "G"] = rpt.Rows[i]["qty"].ToString();
                        ws.Cells[start + i, "H"] = rpt.Rows[i]["inputter"].ToString();
                    }

                    ws.Application.CutCopyMode = (Microsoft.Office.Interop.Excel.XlCutCopyMode)0;
                    workbookTemplate.Close();
                    ((Excel.Worksheet)excelApplication.ActiveWorkbook.Sheets[1]).Select(Type.Missing);
                    excelApplication.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No data display !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                if (vReportName == string.Empty)
                {
                    MessageBox.Show("Pleae choose report !!! ", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (vReportName == "rpt_stock")
                {
                    rpt_stock();
                }
                else if (vReportName == "rpt_pos")
                {
                    rpt_pos();
                }
                else if (vReportName == "rpt_pos_una")
                {
                    rpt_pos_una();
                }
                else if (vReportName == "book_rpt_stock_transfer")
                {
                    book_rpt_stock_transfer();
                }
            }
            catch { }
        }

        private void dgreport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vReportName = dgreport[1, e.RowIndex].Value.ToString();
            }
            catch {
                vReportName = string.Empty;
            }
        }
    }
}
