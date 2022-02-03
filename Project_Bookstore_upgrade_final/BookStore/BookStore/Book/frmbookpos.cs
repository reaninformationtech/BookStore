using BookStore.Class;
using BookStore.Control;
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
    public partial class frmbookpos : KryptonForm
    {
        public frmbookpos()
        {
            InitializeComponent();
        }
        sqlexcute sql = new sqlexcute();
        private Color _CardShow = Color.Red;
        private Color _CardOver = Color.LightSalmon;
        Boolean vUser_Editing = false;
        string pCode = string.Empty;
        string gsys_num = string.Empty;

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
                gData.Columns["gprocode"].Visible = false;

                gData.Columns["gaction"].Width = 25;
                gData.Columns["gprocode"].Width = 35;
                gData.Columns["gdiscount"].Width = 40;

                gData.Columns["gbarcode"].Width = 90;
                gData.Columns["gname"].Width = 170;
                gData.Columns["gprice"].Width = 45;
                gData.Columns["gqty"].Width = 30;
                gData.Columns["gamount"].Width = 60;

                gData.Columns["gqty"].ReadOnly = false;
                gData.Columns["gdiscount"].ReadOnly = false;
                gData.Columns["gaction"].ReadOnly = false;
                gData.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            }
            catch { }
        }
        
        void cleartext()
        {
            
            formatgridview();

            pCode = string.Empty;
            gsys_num = string.Empty;
            vUser_Editing = true;

            gData.Rows.Clear();
            txtbarcode.Text = string.Empty;
            txtinvoice.Text = string.Empty;
            cbocustomer.SelectedIndex = 1;
            lblexchange.Text = variables.p_exchangerateinfo;
            lbltotal.Text = "Total amount : 0.00 ";
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


        Boolean IsOk()
        {
            if (sql.cbo_empty(cbocustomer)==false)
            {
                MessageBox.Show("Please input customer infor !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbocustomer.Focus();
                cbocustomer.Select();
                return false;
            }
            return true;
        }
        private void top_product_Click(object sender, EventArgs e)
        {
            try
            {
                string vMenuID = sql.control_name(sender, e);
                GetControl(panel_menu, vMenuID, sender);
                show_product("load_top_item", vMenuID);
            }
            catch { }
        }

        private void Action_product_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOk() == true)
                {
                    string vMenuID = sql.control_name(sender, e);
                    add_to_list("invoice", vMenuID);
                }
            }
            catch { }
        }
        
        private void show_product(string vstatus, string vcode)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    vcode,
                    "0"
                };

                dt = sql.proc_getdata("book_proc_get_sql", p);
                int vNum = dt.Rows.Count;
                _table_product.Controls.Clear();
                _table_product.RowCount = 0;
                _table_product.RowStyles.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    button_sm_product obj = new button_sm_product();
                    obj.Name = dt.Rows[i]["pro_id"].ToString();
                    obj.btn.Name = dt.Rows[i]["pro_id"].ToString();
                    obj.btn.Text = dt.Rows[i]["pro_name"].ToString();
                    _table_product.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    _table_product.Controls.Add(obj);
                    obj.Click += new System.EventHandler(this.Action_product_Click);
                    obj.btn.Click += new System.EventHandler(this.Action_product_Click);

                }

                int v = _table_product.RowCount;
                TableLayoutRowStyleCollection styles = this._table_product.RowStyles;
                foreach (RowStyle style in styles)
                {
                    if (style.SizeType == SizeType.Absolute)
                    {
                        style.SizeType = SizeType.AutoSize;
                        style.Height = 50;
                    }
                    else if (style.SizeType == SizeType.AutoSize)
                    {
                        style.SizeType = SizeType.Percent;
                        style.Height = 50;
                    }
                    else
                    {
                        style.SizeType = SizeType.AutoSize;
                        style.Height = 50;
                    }
                }
            }
            catch { }
        }

        public System.Windows.Forms.Control GetControl(System.Windows.Forms.Control ParentCntl, string NameToSearch, object sender)
        {
            try
            {
                if (ParentCntl.Name == NameToSearch && ParentCntl is Bunifu.Framework.UI.BunifuCards)
                {
                    Bunifu.Framework.UI.BunifuCards obj = (Bunifu.Framework.UI.BunifuCards)ParentCntl;
                    obj.color = _CardShow;
                } 
                else if (ParentCntl is Bunifu.Framework.UI.BunifuCards)
                {
                    Bunifu.Framework.UI.BunifuCards obj = (Bunifu.Framework.UI.BunifuCards)ParentCntl;
                    obj.color = _CardOver;
                }
                foreach (System.Windows.Forms.Control ChildCntl in ParentCntl.Controls)
                {
                    System.Windows.Forms.Control ResultCntl = GetControl(ChildCntl, NameToSearch, sender);
                }
            }
            catch { return null; }
            return null;
        }

        void dg_views(string vstatus , string vrcp_id)
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
                if (dts.Rows[0]["status"].ToString() == "yes")
                {
                    vUser_Editing = false;
                }
                else
                {
                    vUser_Editing = true;
                }
                    cbocustomer.SelectedValue = dts.Rows[0]["cus_id"].ToString();
                    DataGridViewImageColumn img = new DataGridViewImageColumn();
                    Image image = Image.FromFile(Application.StartupPath + @"\Resource\Small\delete_b.png");
                    img.Image = image;
                    img.HeaderText = "Image";
                    img.Name = "img";
                    pCode = dts.Rows[0]["rcp_id"].ToString();
                    txtinvoice.Text = pCode;
                    lbltotal.Text = "Total : " + string.Format("{0:0.00}", Convert.ToDouble(dts.Rows[0]["total_amount"])) + dts.Rows[0]["bestsymbol"].ToString();

                    for (int i = 0; i < dts.Rows.Count; i++){

                        if (Convert.ToDouble(dts.Rows[i]["discount"]) > 0)
                        {
                            gData.Columns["gdiscount"].Visible = true;
                        }
                        gData.Rows.Add(image,
                                                dts.Rows[i]["sysdocnum"].ToString(),
                                                dts.Rows[i]["barcode"].ToString(),
                                                dts.Rows[i]["pro_name"].ToString(),
                                                string.Format("{0:0.00}", Convert.ToDouble(dts.Rows[i]["unitprice"])),
                                                string.Format("{0:0}", Convert.ToDouble(dts.Rows[i]["qty"])),
                                                string.Format("{0:0}", Convert.ToDouble(dts.Rows[i]["discount"])) + "%",
                                                string.Format("{0:0.00}", Convert.ToDouble(dts.Rows[i]["amount"]))
                                              );
                    }
                }
        }

        void add_to_list(string vstatus, string vpro_id)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    pCode,
                    cbocustomer.SelectedValue.ToString(),
                    vpro_id,
                    variables.p_inputter
                };

                if (vUser_Editing == true)
                {
                    dt = sql.proc_getdata("book_proc_pos_invoice", p);
                    if (dt.Rows.Count > 0)
                    {
                        txtbarcode.Focus();
                        txtbarcode.Select();
                        dg_views("un_stockout", dt.Rows[0]["trancode"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("This record required to edit first !", "This record required to edit first !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void edit_info(string vstatus, string vsysdonum, string vqty , string vdis)
        {
            DataTable dt = new DataTable();
            string[] p = {
                    vstatus,
                    variables.p_branchcode,
                    pCode,
                    vsysdonum,
                    cbocustomer.SelectedValue.ToString(),
                    vqty,
                    vdis,
                    variables.p_inputter
                };

            dt = sql.proc_getdata("book_proc_pos_edit_info", p);
            if (dt.Rows.Count > 0)
            {
                lbltotal.Text = "Total : " + string.Format("{0:0.00}", Convert.ToDouble(dt.Rows[0]["total_amount"])) + dt.Rows[0]["bestsymbol"].ToString();
                lbltotal.Refresh();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < gData.Rows.Count; j++)
                    {
                        if(gData["gprocode", j].Value.ToString()== dt.Rows[i]["sysdocnum"].ToString())
                        {
                            gData["gamount", j].Value = String.Format("{0:0.00}", dt.Rows[i]["amount"]).ToString();
                            gData["gdiscount", j].Value = String.Format("{0:0}", dt.Rows[i]["discount"]).ToString()+"%";
                        }
                    }
                }
            }
        }

        void load_top_product()
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p = {
                    "load_top_product",
                    variables.p_branchcode,
                    "%"
                };
                dt = sql.proc_getdata("book_proc_get_sql", p);
                
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string btn_name = "m_top"+(i+1).ToString();
                        TopControl(panel_menu, btn_name, dt.Rows[i]["code"].ToString(), dt.Rows[i]["name"].ToString());
                    }
                }
            }
            catch { }
        }

        public button_menu TopControl(System.Windows.Forms.Control ParentCntl, string name,string code_name,string vtitle)
        {
            try
            {
                if (ParentCntl is top_menu)
                {
                    if (ParentCntl.Name == name)
                    {
                        Image newImage = null;
                        try
                        {
                            newImage = Image.FromFile(Application.StartupPath + @"\Resource\Category\" + name + ".png");
                        }
                        catch { }

                        top_menu btn = (top_menu)ParentCntl;
                        btn.Name = code_name;
                        btn.lblTitle.Name = code_name;
                        btn._Pic.Name = code_name;
                        btn._Cards_Item.Name = code_name;
                        btn.Title = vtitle;

                        btn.lblTitle.Font = new Font("Arial", 10.5F, FontStyle.Bold);
                        btn.lblTitle.ForeColor = Color.Red;
                        btn.cardcolor = _CardShow;
                        btn.Icon = newImage;

                        btn.Click += new System.EventHandler(this.top_product_Click);
                        btn._Pic.Click += new System.EventHandler(this.top_product_Click);
                        btn.lblTitle.Click += new System.EventHandler(this.top_product_Click);
                        btn._Cards_Item.Click += new System.EventHandler(this.top_product_Click);


                        btn.Visible = true;
                        ParentCntl.Visible = true;



                    }
                }
                foreach (System.Windows.Forms.Control ChildCntl in ParentCntl.Controls)
                {
                    System.Windows.Forms.Control ResultCntl = TopControl(ChildCntl, name, code_name, vtitle);
                }

            }
            catch { return null; }
            return null;
        }

        bool isok_edit()
        {
            if (vUser_Editing == false)
            {
                MessageBox.Show("This invoice required to modify first !!!", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
      
        bool isok_exchange()
        {
            if (variables.p_exchange == false)
            {
                MessageBox.Show("Please verify your Exchange setting !!!", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }
            return true;
        }
        private void frmbookpos_Load(object sender, EventArgs e)
        {
            try
            {
                sql.exchangerate("exchangerate");
                if (isok_exchange() == true)
                {
                    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    load_top_product();
                    sql.Filter_ComboBox(cbocustomer, "exec book_proc_get_sql  'cbo_customer','" + variables.p_branchcode + "','%'", "name", "code");
                    cleartext();
                }
                else
                {
                    this.Enabled = false;
                }

            }
            catch { }
        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                add_to_list("barcode", txtbarcode.Text.Trim());
                txtbarcode.Text = string.Empty;
            }
        }

        private void gData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String columnName = this.gData.Columns[e.ColumnIndex].Name;
                if (columnName != "gaction")
                {
                    gsys_num = gData["gprocode", e.RowIndex].Value.ToString();
                    return;
                }

                if (isok_edit() == true)
                {
                    if (MessageBox.Show("Are you sure remove this item ? ", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gsys_num = gData["gprocode", e.RowIndex].Value.ToString();
                        DataTable dts = new DataTable();
                        string[] p = {
                            "num_stockout",
                            variables.p_branchcode,
                            pCode,
                            gsys_num
                        };
                        dts = sql.proc_getdata("book_proc_delete", p);
                        if (dts.Rows.Count > 0)
                        {
                            dg_views("un_stockout", dts.Rows[0]["trancode"].ToString());
                        }
                    }
                }
            }
            catch { }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                frmpos_list FRM_SEARCH = new frmpos_list();
                FRM_SEARCH.Status = "load_invoice";
                FRM_SEARCH.Code = variables.p_inputter;
                FRM_SEARCH.ShowDialog();

                if (FRM_SEARCH.Code != string.Empty && FRM_SEARCH.Code!= variables.p_inputter)
                {
                    pCode = FRM_SEARCH.Code;
                    txtinvoice.Text = pCode;

                    txtbarcode.Focus();
                    txtbarcode.Select();
                    dg_views("un_stockout", pCode);
                }
            }
            catch { }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (isok_edit() == true)
                {
                    if (pCode != string.Empty)
                    {
                        frmdiscount FRM_SEARCH = new frmdiscount();
                        FRM_SEARCH.Status = "pos_invoice";
                        FRM_SEARCH.Code = pCode;
                        FRM_SEARCH.ShowDialog();

                        txtbarcode.Focus();
                        txtbarcode.Select();
                        dg_views("un_stockout", pCode);
                    }
                }
            }
            catch { }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to modify this invoice ?", variables.p_message_titil, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dts = new DataTable();
                    string[] p = {
                            "una_payment",
                            variables.p_branchcode,
                            pCode,
                            ""
                        };
                    dts = sql.proc_getdata("book_proc_delete", p);
                    if (dts.Rows.Count > 0)
                    {
                        dg_views("un_stockout", pCode);
                    }
                }
            }
            catch { }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (pCode == string.Empty)
                {
                    MessageBox.Show("Please verify invoice for pay !", variables.p_message_titil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                frmbookpayments FRM_SEARCH = new frmbookpayments();
                FRM_SEARCH.Status = "load_pay_invoice";
                FRM_SEARCH.Code = pCode;
                FRM_SEARCH.ShowDialog();

                dg_views("un_stockout", pCode);
            }
            catch { }
        }

        private void txtinvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                pCode = txtinvoice.Text.Trim();
                dg_views("un_stockout", pCode);
                txtinvoice.Focus();
                txtinvoice.Select();
            }
        }

        private void gData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (gData.CurrentCell.ColumnIndex == 5 || gData.CurrentCell.ColumnIndex == 6) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void gData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string vsys_num = gData["gprocode", e.RowIndex].Value.ToString();
                Int32 gqty = 0;
                double gdis = 0;
                Int32.TryParse(gData["gqty", e.RowIndex].Value.ToString(), out gqty);

                if (sql.Rights(gData["gdiscount", e.RowIndex].Value.ToString(), 1) == "%")
                {
                    double.TryParse(sql.Left(gData["gdiscount", e.RowIndex].Value.ToString(), gData["gdiscount", e.RowIndex].Value.ToString().Length - 1), out gdis);
                }
                else
                {
                    double.TryParse(gData["gdiscount", e.RowIndex].Value.ToString(), out gdis);
                }

                if (isok_edit() == true)
                {
                    edit_info("pos_edit", vsys_num, gqty.ToString(), gdis.ToString());
                }
            }
            catch { }
        }

        private void gData_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gData_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gsys_num != string.Empty)
                {
                    frmdiscount FRM_SEARCH = new frmdiscount();
                    FRM_SEARCH.Status = "pos_sysdocnum";
                    FRM_SEARCH.Code = gsys_num;
                    FRM_SEARCH.ShowDialog();

                    txtbarcode.Focus();
                    txtbarcode.Select();
                    dg_views("un_stockout", pCode);
                }
            }
            catch { }
        }

        private void lbltotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
