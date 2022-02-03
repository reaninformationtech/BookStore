
namespace BookStore.Book
{
    partial class frmpurchaseorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpurchaseorder));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.gb = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbostock = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtinvoice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbosupplier = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dgdata = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtbarcode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblbarcode = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gb_action = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btncreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnnew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbltotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitem = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.gbarcode = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.gcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamount = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb.Panel)).BeginInit();
            this.gb.Panel.SuspendLayout();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbostock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_action)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_action.Panel)).BeginInit();
            this.gb_action.Panel.SuspendLayout();
            this.gb_action.SuspendLayout();
            this.SuspendLayout();
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
            // gb
            // 
            this.gb.Location = new System.Drawing.Point(3, 10);
            this.gb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb.Name = "gb";
            // 
            // gb.Panel
            // 
            this.gb.Panel.Controls.Add(this.kryptonLabel2);
            this.gb.Panel.Controls.Add(this.cbostock);
            this.gb.Panel.Controls.Add(this.kryptonLabel1);
            this.gb.Panel.Controls.Add(this.txtinvoice);
            this.gb.Panel.Controls.Add(this.kryptonLabel3);
            this.gb.Panel.Controls.Add(this.txtid);
            this.gb.Panel.Controls.Add(this.kryptonLabel4);
            this.gb.Panel.Controls.Add(this.cbosupplier);
            this.gb.Size = new System.Drawing.Size(316, 189);
            this.gb.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.gb.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gb.StateCommon.Border.Rounding = 10;
            this.gb.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(20, 107);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(57, 22);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 44;
            this.kryptonLabel2.Values.Text = "Stock :";
            // 
            // cbostock
            // 
            this.cbostock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbostock.DropDownWidth = 263;
            this.cbostock.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbostock.Location = new System.Drawing.Point(81, 105);
            this.cbostock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbostock.MaxDropDownItems = 15;
            this.cbostock.Name = "cbostock";
            this.cbostock.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbostock.Size = new System.Drawing.Size(215, 29);
            this.cbostock.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cbostock.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbostock.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbostock.StateActive.ComboBox.Border.Rounding = 10;
            this.cbostock.StateActive.ComboBox.Border.Width = 1;
            this.cbostock.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostock.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbostock.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cbostock.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbostock.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cbostock.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbostock.StateCommon.ComboBox.Border.Width = 1;
            this.cbostock.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbostock.StateCommon.Item.Border.Rounding = 10;
            this.cbostock.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cbostock.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostock.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cbostock.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbostock.StateNormal.ComboBox.Border.Rounding = 10;
            this.cbostock.StateNormal.ComboBox.Border.Width = 1;
            this.cbostock.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbostock.StateNormal.Item.Border.Rounding = 10;
            this.cbostock.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbostock.StateTracking.Item.Border.Rounding = 10;
            this.cbostock.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbostock.TabIndex = 43;
            this.cbostock.Text = "Choose System Control";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 47);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 22);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 42;
            this.kryptonLabel1.Values.Text = "Invoice :";
            // 
            // txtinvoice
            // 
            this.txtinvoice.Location = new System.Drawing.Point(81, 42);
            this.txtinvoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(215, 27);
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
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(42, 16);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(35, 22);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 40;
            this.kryptonLabel3.Values.Text = "ID :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(81, 11);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(215, 27);
            this.txtid.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtid.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtid.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtid.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtid.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtid.StateCommon.Border.Rounding = 10;
            this.txtid.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtid.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtid.TabIndex = 39;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(10, 74);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(67, 22);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 38;
            this.kryptonLabel4.Values.Text = "Supply :";
            // 
            // cbosupplier
            // 
            this.cbosupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosupplier.DropDownWidth = 263;
            this.cbosupplier.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbosupplier.Location = new System.Drawing.Point(81, 72);
            this.cbosupplier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbosupplier.MaxDropDownItems = 15;
            this.cbosupplier.Name = "cbosupplier";
            this.cbosupplier.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbosupplier.Size = new System.Drawing.Size(215, 29);
            this.cbosupplier.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cbosupplier.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupplier.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbosupplier.StateActive.ComboBox.Border.Rounding = 10;
            this.cbosupplier.StateActive.ComboBox.Border.Width = 1;
            this.cbosupplier.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosupplier.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbosupplier.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cbosupplier.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupplier.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cbosupplier.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbosupplier.StateCommon.ComboBox.Border.Width = 1;
            this.cbosupplier.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupplier.StateCommon.Item.Border.Rounding = 10;
            this.cbosupplier.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cbosupplier.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosupplier.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cbosupplier.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupplier.StateNormal.ComboBox.Border.Rounding = 10;
            this.cbosupplier.StateNormal.ComboBox.Border.Width = 1;
            this.cbosupplier.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupplier.StateNormal.Item.Border.Rounding = 10;
            this.cbosupplier.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupplier.StateTracking.Item.Border.Rounding = 10;
            this.cbosupplier.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbosupplier.TabIndex = 37;
            this.cbosupplier.Text = "Choose System Control";
            // 
            // dgdata
            // 
            this.dgdata.AllowUserToAddRows = false;
            this.dgdata.AllowUserToDeleteRows = false;
            this.dgdata.AllowUserToResizeColumns = false;
            this.dgdata.AllowUserToResizeRows = false;
            this.dgdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gnum,
            this.gpro_id,
            this.gitem,
            this.gbarcode,
            this.gcost,
            this.gqty,
            this.gdiscount,
            this.gamount});
            this.dgdata.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgdata.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgdata.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dgdata.Location = new System.Drawing.Point(335, 43);
            this.dgdata.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgdata.Name = "dgdata";
            this.dgdata.RowHeadersVisible = false;
            this.dgdata.RowHeadersWidth = 10;
            this.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdata.Size = new System.Drawing.Size(754, 559);
            this.dgdata.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgdata.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgdata.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgdata.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgdata.StateCommon.HeaderRow.Border.Rounding = 10;
            this.dgdata.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgdata.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgdata.TabIndex = 1;
            this.dgdata.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdata_CellEndEdit);
            this.dgdata.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdata_CellEnter);
            this.dgdata.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgdata_EditingControlShowing);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(334, 12);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(81, 22);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 42;
            this.kryptonLabel5.Values.Text = "Barcode :";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(415, 10);
            this.txtbarcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(261, 27);
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
            this.txtbarcode.TabIndex = 41;
            this.txtbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_KeyPress);
            // 
            // lblbarcode
            // 
            this.lblbarcode.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblbarcode.Location = new System.Drawing.Point(680, 10);
            this.lblbarcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(43, 30);
            this.lblbarcode.StateCommon.ShortText.ColorAngle = 10F;
            this.lblbarcode.StateCommon.ShortText.Font = new System.Drawing.Font("barcode font", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.TabIndex = 65;
            this.lblbarcode.Values.Text = "barcode";
            // 
            // gb_action
            // 
            this.gb_action.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.gb_action.CaptionOverlap = 0.1D;
            this.gb_action.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.gb_action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gb_action.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabDock;
            this.gb_action.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary;
            this.gb_action.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gb_action.Location = new System.Drawing.Point(3, 199);
            this.gb_action.Margin = new System.Windows.Forms.Padding(30);
            this.gb_action.Name = "gb_action";
            // 
            // gb_action.Panel
            // 
            this.gb_action.Panel.Controls.Add(this.btncreate);
            this.gb_action.Panel.Controls.Add(this.btnnew);
            this.gb_action.Size = new System.Drawing.Size(300, 96);
            this.gb_action.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb_action.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb_action.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.gb_action.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.gb_action.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopRight;
            this.gb_action.StateCommon.Border.ColorAngle = 10F;
            this.gb_action.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.gb_action.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.gb_action.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gb_action.StateCommon.Border.Rounding = 10;
            this.gb_action.StateCommon.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.gb_action.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.gb_action.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_action.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.gb_action.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.gb_action.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gb_action.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gb_action.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.gb_action.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gb_action.StateNormal.Border.Rounding = 10;
            this.gb_action.StateNormal.Content.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.gb_action.TabIndex = 67;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(149, 15);
            this.btncreate.Name = "btncreate";
            this.btncreate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btncreate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btncreate.OverrideDefault.Border.Rounding = 10;
            this.btncreate.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btncreate.OverrideFocus.Border.Rounding = 10;
            this.btncreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btncreate.Size = new System.Drawing.Size(121, 37);
            this.btncreate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncreate.StateCommon.Back.ColorAngle = 45F;
            this.btncreate.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btncreate.StateCommon.Back.Image")));
            this.btncreate.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btncreate.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btncreate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StateCommon.Border.ColorAngle = 50F;
            this.btncreate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btncreate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btncreate.StateCommon.Border.Rounding = 10;
            this.btncreate.StateCommon.Border.Width = 1;
            this.btncreate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btncreate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btncreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btncreate.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btncreate.StateDisabled.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btncreate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncreate.StateNormal.Border.ColorAngle = 45F;
            this.btncreate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btncreate.StateNormal.Border.Rounding = 10;
            this.btncreate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btncreate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StateTracking.Back.ColorAngle = 45F;
            this.btncreate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StateTracking.Border.ColorAngle = 45F;
            this.btncreate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btncreate.StateTracking.Border.Rounding = 10;
            this.btncreate.TabIndex = 68;
            this.btncreate.Values.Text = "Save";
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(22, 15);
            this.btnnew.Name = "btnnew";
            this.btnnew.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnnew.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnew.OverrideDefault.Border.Rounding = 10;
            this.btnnew.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnnew.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnew.OverrideFocus.Border.Rounding = 10;
            this.btnnew.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnnew.Size = new System.Drawing.Size(121, 37);
            this.btnnew.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnnew.StateCommon.Back.ColorAngle = 45F;
            this.btnnew.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.StateCommon.Back.Image")));
            this.btnnew.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnnew.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnnew.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnnew.StateCommon.Border.ColorAngle = 50F;
            this.btnnew.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnew.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnnew.StateCommon.Border.Rounding = 10;
            this.btnnew.StateCommon.Border.Width = 1;
            this.btnnew.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnnew.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnnew.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnnew.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnnew.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnnew.StateNormal.Border.ColorAngle = 45F;
            this.btnnew.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnew.StateNormal.Border.Rounding = 10;
            this.btnnew.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnnew.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnnew.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnew.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnnew.StateTracking.Back.ColorAngle = 45F;
            this.btnnew.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnnew.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnnew.StateTracking.Border.ColorAngle = 45F;
            this.btnnew.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnnew.StateTracking.Border.Rounding = 10;
            this.btnnew.TabIndex = 67;
            this.btnnew.Values.Text = "New";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbltotal.Location = new System.Drawing.Point(935, 12);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(51, 27);
            this.lbltotal.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbltotal.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.TabIndex = 68;
            this.lbltotal.Values.Text = "total";
            // 
            // gnum
            // 
            this.gnum.HeaderText = "No";
            this.gnum.Name = "gnum";
            // 
            // gpro_id
            // 
            this.gpro_id.HeaderText = "product id";
            this.gpro_id.Name = "gpro_id";
            this.gpro_id.Visible = false;
            // 
            // gitem
            // 
            this.gitem.HeaderText = "items";
            this.gitem.Name = "gitem";
            this.gitem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gitem.Width = 100;
            // 
            // gbarcode
            // 
            this.gbarcode.HeaderText = "barcode";
            this.gbarcode.Name = "gbarcode";
            this.gbarcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gbarcode.Width = 100;
            // 
            // gcost
            // 
            this.gcost.HeaderText = "cost";
            this.gcost.Name = "gcost";
            this.gcost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gqty
            // 
            this.gqty.HeaderText = "qty";
            this.gqty.Name = "gqty";
            this.gqty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gdiscount
            // 
            this.gdiscount.HeaderText = "discount";
            this.gdiscount.Name = "gdiscount";
            this.gdiscount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gamount
            // 
            this.gamount.HeaderText = "amount";
            this.gamount.Name = "gamount";
            this.gamount.Width = 100;
            // 
            // frmpurchaseorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1139, 607);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.gb_action);
            this.Controls.Add(this.lblbarcode);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.dgdata);
            this.Controls.Add(this.gb);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmpurchaseorder";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmpurchaseorder";
            this.Load += new System.EventHandler(this.frmpurchaseorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb.Panel)).EndInit();
            this.gb.Panel.ResumeLayout(false);
            this.gb.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gb)).EndInit();
            this.gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbostock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_action.Panel)).EndInit();
            this.gb_action.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gb_action)).EndInit();
            this.gb_action.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gb;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgdata;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbosupplier;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtid;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtinvoice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbostock;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbarcode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblbarcode;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gb_action;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncreate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnnew;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpro_id;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gitem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn gqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gamount;
    }
}