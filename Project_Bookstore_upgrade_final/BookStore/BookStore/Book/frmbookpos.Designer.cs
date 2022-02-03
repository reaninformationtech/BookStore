
namespace BookStore.Book
{
    partial class frmbookpos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbookpos));
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtinvoice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbocustomer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel_menu = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gaction = new System.Windows.Forms.DataGridViewImageColumn();
            this.gprocode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbltotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblexchange = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCustomer = new System.Windows.Forms.PictureBox();
            this.btnList = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtbarcode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this._table_product = new System.Windows.Forms.TableLayoutPanel();
            this.m_top5 = new BookStore.Control.top_menu();
            this.m_top4 = new BookStore.Control.top_menu();
            this.m_top3 = new BookStore.Control.top_menu();
            this.m_top2 = new BookStore.Control.top_menu();
            this.m_top1 = new BookStore.Control.top_menu();
            ((System.ComponentModel.ISupportInitialize)(this.cbocustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_menu)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnList)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(4, 6);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(69, 22);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 42;
            this.kryptonLabel3.Values.Text = "Invoice :";
            // 
            // txtinvoice
            // 
            this.txtinvoice.Location = new System.Drawing.Point(93, 4);
            this.txtinvoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(216, 27);
            this.txtinvoice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtinvoice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtinvoice.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtinvoice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtinvoice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtinvoice.StateCommon.Border.Rounding = 10;
            this.txtinvoice.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtinvoice.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtinvoice.TabIndex = 41;
            this.txtinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoice_KeyPress);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(4, 36);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(87, 22);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 40;
            this.kryptonLabel4.Values.Text = "Customer :";
            // 
            // cbocustomer
            // 
            this.cbocustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbocustomer.DropDownWidth = 263;
            this.cbocustomer.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbocustomer.Location = new System.Drawing.Point(93, 33);
            this.cbocustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbocustomer.MaxDropDownItems = 15;
            this.cbocustomer.Name = "cbocustomer";
            this.cbocustomer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbocustomer.Size = new System.Drawing.Size(216, 29);
            this.cbocustomer.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cbocustomer.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbocustomer.StateActive.ComboBox.Border.Rounding = 10;
            this.cbocustomer.StateActive.ComboBox.Border.Width = 1;
            this.cbocustomer.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocustomer.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbocustomer.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cbocustomer.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cbocustomer.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbocustomer.StateCommon.ComboBox.Border.Width = 1;
            this.cbocustomer.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateCommon.Item.Border.Rounding = 10;
            this.cbocustomer.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cbocustomer.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocustomer.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cbocustomer.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateNormal.ComboBox.Border.Rounding = 10;
            this.cbocustomer.StateNormal.ComboBox.Border.Width = 1;
            this.cbocustomer.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateNormal.Item.Border.Rounding = 10;
            this.cbocustomer.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateTracking.Item.Border.Rounding = 10;
            this.cbocustomer.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbocustomer.TabIndex = 39;
            this.cbocustomer.Text = "Choose System Control";
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.m_top5);
            this.panel_menu.Controls.Add(this.m_top4);
            this.panel_menu.Controls.Add(this.m_top3);
            this.panel_menu.Controls.Add(this.m_top2);
            this.panel_menu.Controls.Add(this.m_top1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(746, 70);
            this.panel_menu.StateCommon.Color1 = System.Drawing.Color.Teal;
            this.panel_menu.StateCommon.Color2 = System.Drawing.Color.Teal;
            this.panel_menu.TabIndex = 5;
            // 
            // gData
            // 
            this.gData.AllowUserToAddRows = false;
            this.gData.AllowUserToDeleteRows = false;
            this.gData.AllowUserToResizeColumns = false;
            this.gData.AllowUserToResizeRows = false;
            this.gData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gaction,
            this.gprocode,
            this.gbarcode,
            this.gname,
            this.gprice,
            this.gqty,
            this.gdiscount,
            this.gamount});
            this.gData.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.gData.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.gData.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.gData.Location = new System.Drawing.Point(2, 121);
            this.gData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gData.Name = "gData";
            this.gData.RowHeadersVisible = false;
            this.gData.RowHeadersWidth = 10;
            this.gData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gData.Size = new System.Drawing.Size(434, 532);
            this.gData.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gData.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gData.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gData.StateCommon.HeaderRow.Border.Rounding = 10;
            this.gData.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gData.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gData.TabIndex = 43;
            this.gData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellClick);
            this.gData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellEndEdit);
            this.gData.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellLeave);
            this.gData.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gData_EditingControlShowing);
            this.gData.DoubleClick += new System.EventHandler(this.gData_DoubleClick);
            // 
            // gaction
            // 
            this.gaction.HeaderText = "...";
            this.gaction.Name = "gaction";
            // 
            // gprocode
            // 
            this.gprocode.HeaderText = "Code";
            this.gprocode.Name = "gprocode";
            this.gprocode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gprocode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbarcode
            // 
            this.gbarcode.HeaderText = "barcode";
            this.gbarcode.Name = "gbarcode";
            this.gbarcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gbarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gname
            // 
            this.gname.HeaderText = "descripiton";
            this.gname.Name = "gname";
            // 
            // gprice
            // 
            this.gprice.HeaderText = "price";
            this.gprice.Name = "gprice";
            // 
            // gqty
            // 
            this.gqty.HeaderText = "qty";
            this.gqty.Name = "gqty";
            // 
            // gdiscount
            // 
            this.gdiscount.HeaderText = "dis";
            this.gdiscount.Name = "gdiscount";
            // 
            // gamount
            // 
            this.gamount.HeaderText = "amount";
            this.gamount.Name = "gamount";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lbltotal);
            this.kryptonPanel2.Controls.Add(this.lblexchange);
            this.kryptonPanel2.Controls.Add(this.btnCustomer);
            this.kryptonPanel2.Controls.Add(this.btnList);
            this.kryptonPanel2.Controls.Add(this.btnClear);
            this.kryptonPanel2.Controls.Add(this.btnModify);
            this.kryptonPanel2.Controls.Add(this.btnDiscount);
            this.kryptonPanel2.Controls.Add(this.btnOk);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.txtbarcode);
            this.kryptonPanel2.Controls.Add(this.gData);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.txtinvoice);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.cbocustomer);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel2.Location = new System.Drawing.Point(746, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(440, 697);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Snow;
            this.kryptonPanel2.TabIndex = 4;
            // 
            // lbltotal
            // 
            this.lbltotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lbltotal.Location = new System.Drawing.Point(287, 96);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(103, 23);
            this.lbltotal.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbltotal.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.TabIndex = 80;
            this.lbltotal.Values.Text = "total amount";
            this.lbltotal.TextChanged += new System.EventHandler(this.lbltotal_TextChanged);
            // 
            // lblexchange
            // 
            this.lblexchange.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblexchange.Location = new System.Drawing.Point(5, 96);
            this.lblexchange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblexchange.Name = "lblexchange";
            this.lblexchange.Size = new System.Drawing.Size(99, 19);
            this.lblexchange.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblexchange.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexchange.TabIndex = 79;
            this.lblexchange.Values.Text = "Exchange Rate";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ErrorImage")));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(311, 35);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(27, 28);
            this.btnCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCustomer.TabIndex = 78;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnList.ErrorImage")));
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(311, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(25, 27);
            this.btnList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnList.TabIndex = 77;
            this.btnList.TabStop = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(21, 659);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 35);
            this.btnClear.TabIndex = 76;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.Blue;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(223, 659);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(98, 35);
            this.btnModify.TabIndex = 75;
            this.btnModify.Text = "Modify (F8)";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.Blue;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(122, 659);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(98, 35);
            this.btnDiscount.TabIndex = 74;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Blue;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(324, 659);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 35);
            this.btnOk.TabIndex = 73;
            this.btnOk.Text = "Ok (F7)";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 67);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(77, 22);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 45;
            this.kryptonLabel1.Values.Text = "Barcode :";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(93, 65);
            this.txtbarcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(216, 27);
            this.txtbarcode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtbarcode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbarcode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbarcode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbarcode.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtbarcode.StateCommon.Border.Rounding = 10;
            this.txtbarcode.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtbarcode.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtbarcode.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtbarcode.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtbarcode.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbarcode.StateNormal.Border.ColorAngle = 10F;
            this.txtbarcode.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbarcode.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtbarcode.TabIndex = 44;
            this.txtbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_KeyPress);
            // 
            // _styleform
            // 
            this._styleform.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._styleform.ButtonSpecs.FormClose.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImageNormal = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImageNormal")));
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this._styleform.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            this._styleform.ButtonSpecs.FormClose.ToolTipTitle = "Close";
            this._styleform.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormMin.Image")));
            this._styleform.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this._styleform.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this._styleform.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this._styleform.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // _table_product
            // 
            this._table_product.BackColor = System.Drawing.Color.Teal;
            this._table_product.ColumnCount = 5;
            this._table_product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this._table_product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this._table_product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this._table_product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this._table_product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this._table_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this._table_product.Location = new System.Drawing.Point(0, 70);
            this._table_product.Name = "_table_product";
            this._table_product.RowCount = 1;
            this._table_product.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._table_product.Size = new System.Drawing.Size(746, 627);
            this._table_product.TabIndex = 6;
            // 
            // m_top5
            // 
            this.m_top5.cardcolor = System.Drawing.Color.Empty;
            this.m_top5.Icon = null;
            this.m_top5.Location = new System.Drawing.Point(579, 6);
            this.m_top5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_top5.Name = "m_top5";
            this.m_top5.Size = new System.Drawing.Size(140, 60);
            this.m_top5.TabIndex = 4;
            this.m_top5.Title = null;
            // 
            // m_top4
            // 
            this.m_top4.cardcolor = System.Drawing.Color.Empty;
            this.m_top4.Icon = null;
            this.m_top4.Location = new System.Drawing.Point(434, 6);
            this.m_top4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_top4.Name = "m_top4";
            this.m_top4.Size = new System.Drawing.Size(140, 60);
            this.m_top4.TabIndex = 3;
            this.m_top4.Title = null;
            // 
            // m_top3
            // 
            this.m_top3.cardcolor = System.Drawing.Color.Empty;
            this.m_top3.Icon = null;
            this.m_top3.Location = new System.Drawing.Point(290, 6);
            this.m_top3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_top3.Name = "m_top3";
            this.m_top3.Size = new System.Drawing.Size(140, 60);
            this.m_top3.TabIndex = 2;
            this.m_top3.Title = null;
            // 
            // m_top2
            // 
            this.m_top2.cardcolor = System.Drawing.Color.Empty;
            this.m_top2.Icon = null;
            this.m_top2.Location = new System.Drawing.Point(146, 6);
            this.m_top2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_top2.Name = "m_top2";
            this.m_top2.Size = new System.Drawing.Size(140, 60);
            this.m_top2.TabIndex = 1;
            this.m_top2.Title = null;
            // 
            // m_top1
            // 
            this.m_top1.cardcolor = System.Drawing.Color.Empty;
            this.m_top1.Icon = null;
            this.m_top1.Location = new System.Drawing.Point(2, 6);
            this.m_top1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_top1.Name = "m_top1";
            this.m_top1.Size = new System.Drawing.Size(140, 60);
            this.m_top1.TabIndex = 0;
            this.m_top1.Title = null;
            // 
            // frmbookpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1186, 697);
            this.Controls.Add(this._table_product);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.kryptonPanel2);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmbookpos";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbookpos";
            this.Load += new System.EventHandler(this.frmbookpos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbocustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_menu)).EndInit();
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtinvoice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbocustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_menu;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gData;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private System.Windows.Forms.TableLayoutPanel _table_product;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbarcode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDiscount;
        public System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox btnList;
        private System.Windows.Forms.PictureBox btnCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblexchange;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltotal;
        private System.Windows.Forms.DataGridViewImageColumn gaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn gprocode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamount;
        private Control.top_menu m_top1;
        private Control.top_menu m_top2;
        private Control.top_menu m_top3;
        private Control.top_menu m_top4;
        private Control.top_menu m_top5;
    }
}