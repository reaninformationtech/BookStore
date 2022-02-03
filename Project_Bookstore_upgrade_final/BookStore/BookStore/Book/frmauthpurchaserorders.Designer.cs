
namespace BookStore.Book
{
    partial class frmauthpurchaserorders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmauthpurchaserorders));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.gb = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnapproval = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnclear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnimage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtstock = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtsupply = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtinvoice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgdata = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitem = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.gbarcode = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.gcost = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.gqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamount = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dgSearch = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ginvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnreject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb.Panel)).BeginInit();
            this.gb.Panel.SuspendLayout();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
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
            this.gb.Location = new System.Drawing.Point(11, 20);
            this.gb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb.Name = "gb";
            // 
            // gb.Panel
            // 
            this.gb.Panel.Controls.Add(this.btnreject);
            this.gb.Panel.Controls.Add(this.btnapproval);
            this.gb.Panel.Controls.Add(this.btnclear);
            this.gb.Panel.Controls.Add(this.btnimage);
            this.gb.Panel.Controls.Add(this.txtstock);
            this.gb.Panel.Controls.Add(this.txtsupply);
            this.gb.Panel.Controls.Add(this.kryptonLabel2);
            this.gb.Panel.Controls.Add(this.kryptonLabel1);
            this.gb.Panel.Controls.Add(this.txtinvoice);
            this.gb.Panel.Controls.Add(this.kryptonLabel3);
            this.gb.Panel.Controls.Add(this.txtid);
            this.gb.Panel.Controls.Add(this.kryptonLabel4);
            this.gb.Size = new System.Drawing.Size(726, 189);
            this.gb.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.gb.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gb.StateCommon.Border.Rounding = 10;
            this.gb.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.TabIndex = 1;
            // 
            // btnapproval
            // 
            this.btnapproval.Location = new System.Drawing.Point(378, 59);
            this.btnapproval.Name = "btnapproval";
            this.btnapproval.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnapproval.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnapproval.OverrideDefault.Border.Rounding = 10;
            this.btnapproval.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnapproval.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnapproval.OverrideFocus.Border.Rounding = 10;
            this.btnapproval.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnapproval.Size = new System.Drawing.Size(130, 40);
            this.btnapproval.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnapproval.StateCommon.Back.ColorAngle = 45F;
            this.btnapproval.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnapproval.StateCommon.Back.Image")));
            this.btnapproval.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnapproval.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnapproval.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnapproval.StateCommon.Border.ColorAngle = 50F;
            this.btnapproval.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnapproval.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnapproval.StateCommon.Border.Rounding = 10;
            this.btnapproval.StateCommon.Border.Width = 1;
            this.btnapproval.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnapproval.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnapproval.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnapproval.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnapproval.StateDisabled.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnapproval.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnapproval.StateNormal.Border.ColorAngle = 45F;
            this.btnapproval.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnapproval.StateNormal.Border.Rounding = 10;
            this.btnapproval.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnapproval.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnapproval.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnapproval.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnapproval.StateTracking.Back.ColorAngle = 45F;
            this.btnapproval.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnapproval.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnapproval.StateTracking.Border.ColorAngle = 45F;
            this.btnapproval.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnapproval.StateTracking.Border.Rounding = 10;
            this.btnapproval.TabIndex = 70;
            this.btnapproval.Values.Text = "Authorize";
            this.btnapproval.Click += new System.EventHandler(this.btnapproval_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(378, 14);
            this.btnclear.Name = "btnclear";
            this.btnclear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnclear.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnclear.OverrideDefault.Border.Rounding = 10;
            this.btnclear.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnclear.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnclear.OverrideFocus.Border.Rounding = 10;
            this.btnclear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnclear.Size = new System.Drawing.Size(130, 40);
            this.btnclear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnclear.StateCommon.Back.ColorAngle = 45F;
            this.btnclear.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.StateCommon.Back.Image")));
            this.btnclear.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnclear.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnclear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnclear.StateCommon.Border.ColorAngle = 50F;
            this.btnclear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnclear.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnclear.StateCommon.Border.Rounding = 10;
            this.btnclear.StateCommon.Border.Width = 1;
            this.btnclear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnclear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnclear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnclear.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnclear.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnclear.StateNormal.Border.ColorAngle = 45F;
            this.btnclear.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnclear.StateNormal.Border.Rounding = 10;
            this.btnclear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnclear.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnclear.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnclear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnclear.StateTracking.Back.ColorAngle = 45F;
            this.btnclear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnclear.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnclear.StateTracking.Border.ColorAngle = 45F;
            this.btnclear.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnclear.StateTracking.Border.Rounding = 10;
            this.btnclear.TabIndex = 69;
            this.btnclear.Values.Text = "Clear";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnimage
            // 
            this.btnimage.AllowFocused = false;
            this.btnimage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnimage.AutoSizeHeight = true;
            this.btnimage.BorderRadius = 14;
            this.btnimage.Image = ((System.Drawing.Image)(resources.GetObject("btnimage.Image")));
            this.btnimage.IsCircle = true;
            this.btnimage.Location = new System.Drawing.Point(301, 10);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(28, 28);
            this.btnimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnimage.TabIndex = 48;
            this.btnimage.TabStop = false;
            this.btnimage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(81, 103);
            this.txtstock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(248, 27);
            this.txtstock.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtstock.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtstock.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtstock.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtstock.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtstock.StateCommon.Border.Rounding = 10;
            this.txtstock.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtstock.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtstock.TabIndex = 46;
            // 
            // txtsupply
            // 
            this.txtsupply.Location = new System.Drawing.Point(81, 72);
            this.txtsupply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsupply.Name = "txtsupply";
            this.txtsupply.Size = new System.Drawing.Size(248, 27);
            this.txtsupply.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtsupply.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsupply.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsupply.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtsupply.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtsupply.StateCommon.Border.Rounding = 10;
            this.txtsupply.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtsupply.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupply.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtsupply.TabIndex = 45;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(20, 105);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(57, 22);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 44;
            this.kryptonLabel2.Values.Text = "Stock :";
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
            this.txtinvoice.Size = new System.Drawing.Size(248, 27);
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
            this.gitem,
            this.gbarcode,
            this.gcost,
            this.gqty,
            this.gdiscount,
            this.gamount});
            this.dgdata.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgdata.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgdata.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dgdata.Location = new System.Drawing.Point(11, 215);
            this.dgdata.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgdata.Name = "dgdata";
            this.dgdata.RowHeadersVisible = false;
            this.dgdata.RowHeadersWidth = 10;
            this.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdata.Size = new System.Drawing.Size(726, 479);
            this.dgdata.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgdata.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgdata.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgdata.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgdata.StateCommon.HeaderRow.Border.Rounding = 10;
            this.dgdata.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgdata.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgdata.TabIndex = 2;
            // 
            // gnum
            // 
            this.gnum.HeaderText = "No";
            this.gnum.Name = "gnum";
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
            this.gcost.Width = 100;
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
            // dgSearch
            // 
            this.dgSearch.AllowUserToAddRows = false;
            this.dgSearch.AllowUserToDeleteRows = false;
            this.dgSearch.AllowUserToResizeColumns = false;
            this.dgSearch.AllowUserToResizeRows = false;
            this.dgSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gnumber,
            this.gcode,
            this.ginvoice});
            this.dgSearch.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgSearch.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgSearch.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dgSearch.Location = new System.Drawing.Point(741, 124);
            this.dgSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RowHeadersVisible = false;
            this.dgSearch.RowHeadersWidth = 10;
            this.dgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSearch.Size = new System.Drawing.Size(330, 200);
            this.dgSearch.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgSearch.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgSearch.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgSearch.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Red;
            this.dgSearch.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgSearch.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSearch.StateCommon.HeaderRow.Back.ColorAngle = 10F;
            this.dgSearch.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateCommon.HeaderRow.Border.Rounding = 10;
            this.dgSearch.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSearch.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateNormal.DataCell.Border.Rounding = 10;
            this.dgSearch.StateNormal.HeaderColumn.Border.ColorAngle = 10F;
            this.dgSearch.StateNormal.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgSearch.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateNormal.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dgSearch.StateNormal.HeaderColumn.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgSearch.StateNormal.HeaderColumn.Border.Rounding = 10;
            this.dgSearch.StateNormal.HeaderColumn.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgSearch.StateNormal.HeaderColumn.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dgSearch.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgSearch.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgSearch.StateTracking.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgSearch.StateTracking.HeaderColumn.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dgSearch.StateTracking.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateTracking.HeaderColumn.Border.Rounding = 10;
            this.dgSearch.StateTracking.HeaderRow.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgSearch.StateTracking.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateTracking.HeaderRow.Border.Rounding = 10;
            this.dgSearch.TabIndex = 3;
            this.dgSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellClick);
            this.dgSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellDoubleClick);
            // 
            // gnumber
            // 
            this.gnumber.HeaderText = "No";
            this.gnumber.Name = "gnumber";
            // 
            // gcode
            // 
            this.gcode.HeaderText = "trancode";
            this.gcode.Name = "gcode";
            // 
            // ginvoice
            // 
            this.ginvoice.HeaderText = "Invoice";
            this.ginvoice.Name = "ginvoice";
            // 
            // btnreject
            // 
            this.btnreject.Location = new System.Drawing.Point(378, 105);
            this.btnreject.Name = "btnreject";
            this.btnreject.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnreject.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreject.OverrideDefault.Border.Rounding = 10;
            this.btnreject.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnreject.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreject.OverrideFocus.Border.Rounding = 10;
            this.btnreject.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnreject.Size = new System.Drawing.Size(130, 40);
            this.btnreject.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnreject.StateCommon.Back.ColorAngle = 45F;
            this.btnreject.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.StateCommon.Back.Image")));
            this.btnreject.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnreject.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnreject.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnreject.StateCommon.Border.ColorAngle = 50F;
            this.btnreject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreject.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnreject.StateCommon.Border.Rounding = 10;
            this.btnreject.StateCommon.Border.Width = 1;
            this.btnreject.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnreject.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnreject.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnreject.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnreject.StateDisabled.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnreject.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnreject.StateNormal.Border.ColorAngle = 45F;
            this.btnreject.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreject.StateNormal.Border.Rounding = 10;
            this.btnreject.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnreject.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnreject.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreject.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnreject.StateTracking.Back.ColorAngle = 45F;
            this.btnreject.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnreject.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnreject.StateTracking.Border.ColorAngle = 45F;
            this.btnreject.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnreject.StateTracking.Border.Rounding = 10;
            this.btnreject.TabIndex = 71;
            this.btnreject.Values.Text = "Reject";
            this.btnreject.Click += new System.EventHandler(this.btnreject_Click);
            // 
            // frmauthpurchaserorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1059, 696);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.dgdata);
            this.Controls.Add(this.gb);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmauthpurchaserorders";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmauthpurchaserorders";
            this.Load += new System.EventHandler(this.frmauthpurchaserorders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb.Panel)).EndInit();
            this.gb.Panel.ResumeLayout(false);
            this.gb.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gb)).EndInit();
            this.gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtinvoice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtid;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgdata;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtstock;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtsupply;
        private Bunifu.UI.WinForms.BunifuPictureBox btnimage;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnum;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gitem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gbarcode;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn gqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn gamount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnapproval;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ginvoice;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnreject;
    }
}