﻿
namespace BookStore.Book
{
    partial class frmcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomer));
            this.time_show_progressbar = new System.Windows.Forms.Timer(this.components);
            this.gb_action = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnedit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btncreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnnew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgSearch = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbogender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cboactive = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtphone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblreturn2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblreturn1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblpaid2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblpaid1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblgrand2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblgrand1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbldiscount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblsubtotal2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblsubtotal1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnList = new System.Windows.Forms.PictureBox();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gb_action)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_action.Panel)).BeginInit();
            this.gb_action.Panel.SuspendLayout();
            this.gb_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbogender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnList)).BeginInit();
            this.SuspendLayout();
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
            this.gb_action.Location = new System.Drawing.Point(408, 0);
            this.gb_action.Margin = new System.Windows.Forms.Padding(30);
            this.gb_action.Name = "gb_action";
            // 
            // gb_action.Panel
            // 
            this.gb_action.Panel.Controls.Add(this.btnedit);
            this.gb_action.Panel.Controls.Add(this.btncreate);
            this.gb_action.Panel.Controls.Add(this.btnnew);
            this.gb_action.Size = new System.Drawing.Size(167, 213);
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
            this.gb_action.TabIndex = 95;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(15, 108);
            this.btnedit.Name = "btnedit";
            this.btnedit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnedit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnedit.OverrideDefault.Border.Rounding = 10;
            this.btnedit.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnedit.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnedit.OverrideFocus.Border.Rounding = 10;
            this.btnedit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnedit.Size = new System.Drawing.Size(130, 40);
            this.btnedit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnedit.StateCommon.Back.ColorAngle = 45F;
            this.btnedit.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.StateCommon.Back.Image")));
            this.btnedit.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnedit.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnedit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnedit.StateCommon.Border.ColorAngle = 50F;
            this.btnedit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnedit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnedit.StateCommon.Border.Rounding = 10;
            this.btnedit.StateCommon.Border.Width = 1;
            this.btnedit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnedit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnedit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnedit.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnedit.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnedit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnedit.StateNormal.Border.ColorAngle = 45F;
            this.btnedit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnedit.StateNormal.Border.Rounding = 10;
            this.btnedit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnedit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnedit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnedit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnedit.StateTracking.Back.ColorAngle = 45F;
            this.btnedit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnedit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnedit.StateTracking.Border.ColorAngle = 45F;
            this.btnedit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnedit.StateTracking.Border.Rounding = 10;
            this.btnedit.TabIndex = 68;
            this.btnedit.Values.Text = "Edit";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(15, 62);
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
            this.btncreate.Size = new System.Drawing.Size(130, 40);
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
            this.btncreate.Values.Text = "Create";
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(15, 17);
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
            this.btnnew.Size = new System.Drawing.Size(130, 40);
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
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.dgSearch);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.txtid);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.cbogender);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.cboactive);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.txtphone);
            this.kryptonPanel2.Controls.Add(this.txtname);
            this.kryptonPanel2.Controls.Add(this.lblreturn2);
            this.kryptonPanel2.Controls.Add(this.lblreturn1);
            this.kryptonPanel2.Controls.Add(this.lblpaid2);
            this.kryptonPanel2.Controls.Add(this.lblpaid1);
            this.kryptonPanel2.Controls.Add(this.lblgrand2);
            this.kryptonPanel2.Controls.Add(this.lblgrand1);
            this.kryptonPanel2.Controls.Add(this.lbldiscount);
            this.kryptonPanel2.Controls.Add(this.lblsubtotal2);
            this.kryptonPanel2.Controls.Add(this.lblsubtotal1);
            this.kryptonPanel2.Controls.Add(this.btnList);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(403, 299);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel2.TabIndex = 96;
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
            this.gcode,
            this.gname,
            this.gphone});
            this.dgSearch.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgSearch.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgSearch.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dgSearch.Location = new System.Drawing.Point(21, 277);
            this.dgSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RowHeadersVisible = false;
            this.dgSearch.RowHeadersWidth = 10;
            this.dgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSearch.Size = new System.Drawing.Size(364, 19);
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
            this.dgSearch.TabIndex = 106;
            this.dgSearch.Visible = false;
            this.dgSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellClick);
            // 
            // gcode
            // 
            this.gcode.HeaderText = "code";
            this.gcode.Name = "gcode";
            // 
            // gname
            // 
            this.gname.HeaderText = "customer";
            this.gname.Name = "gname";
            // 
            // gphone
            // 
            this.gphone.HeaderText = "phone";
            this.gphone.Name = "gphone";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(21, 13);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(30, 22);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel3.TabIndex = 105;
            this.kryptonLabel3.Values.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 8);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(213, 32);
            this.txtid.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtid.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtid.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtid.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtid.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtid.StateCommon.Border.Rounding = 20;
            this.txtid.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtid.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtid.TabIndex = 104;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(21, 82);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(55, 22);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel6.TabIndex = 103;
            this.kryptonLabel6.Values.Text = "Gender ";
            // 
            // cbogender
            // 
            this.cbogender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbogender.DropDownWidth = 263;
            this.cbogender.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbogender.Location = new System.Drawing.Point(100, 79);
            this.cbogender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbogender.MaxDropDownItems = 15;
            this.cbogender.Name = "cbogender";
            this.cbogender.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbogender.Size = new System.Drawing.Size(148, 29);
            this.cbogender.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cbogender.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbogender.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbogender.StateActive.ComboBox.Border.Rounding = 10;
            this.cbogender.StateActive.ComboBox.Border.Width = 1;
            this.cbogender.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogender.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbogender.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cbogender.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbogender.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cbogender.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbogender.StateCommon.ComboBox.Border.Width = 1;
            this.cbogender.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbogender.StateCommon.Item.Border.Rounding = 10;
            this.cbogender.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cbogender.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogender.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cbogender.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbogender.StateNormal.ComboBox.Border.Rounding = 10;
            this.cbogender.StateNormal.ComboBox.Border.Width = 1;
            this.cbogender.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbogender.StateNormal.Item.Border.Rounding = 10;
            this.cbogender.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbogender.StateTracking.Item.Border.Rounding = 10;
            this.cbogender.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbogender.TabIndex = 102;
            this.cbogender.Text = "Choose System Control";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(21, 117);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(52, 22);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel4.TabIndex = 101;
            this.kryptonLabel4.Values.Text = "Active ";
            // 
            // cboactive
            // 
            this.cboactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboactive.DropDownWidth = 263;
            this.cboactive.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboactive.Location = new System.Drawing.Point(100, 114);
            this.cboactive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboactive.MaxDropDownItems = 15;
            this.cboactive.Name = "cboactive";
            this.cboactive.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cboactive.Size = new System.Drawing.Size(148, 29);
            this.cboactive.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboactive.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboactive.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboactive.StateActive.ComboBox.Border.Rounding = 10;
            this.cboactive.StateActive.ComboBox.Border.Width = 1;
            this.cboactive.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboactive.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboactive.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboactive.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboactive.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboactive.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboactive.StateCommon.ComboBox.Border.Width = 1;
            this.cboactive.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboactive.StateCommon.Item.Border.Rounding = 10;
            this.cboactive.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboactive.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboactive.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboactive.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboactive.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboactive.StateNormal.ComboBox.Border.Width = 1;
            this.cboactive.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboactive.StateNormal.Item.Border.Rounding = 10;
            this.cboactive.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboactive.StateTracking.Item.Border.Rounding = 10;
            this.cboactive.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboactive.TabIndex = 100;
            this.cboactive.Text = "Choose System Control";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(21, 150);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(49, 22);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel2.TabIndex = 98;
            this.kryptonLabel2.Values.Text = "Phone ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(21, 48);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(47, 22);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel1.TabIndex = 99;
            this.kryptonLabel1.Values.Text = "Name ";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(100, 145);
            this.txtphone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(243, 32);
            this.txtphone.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtphone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtphone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtphone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtphone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtphone.StateCommon.Border.Rounding = 20;
            this.txtphone.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtphone.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtphone.TabIndex = 96;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 43);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(243, 32);
            this.txtname.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtname.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtname.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtname.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtname.StateCommon.Border.Rounding = 20;
            this.txtname.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtname.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtname.TabIndex = 97;
            // 
            // lblreturn2
            // 
            this.lblreturn2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblreturn2.Location = new System.Drawing.Point(259, 673);
            this.lblreturn2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblreturn2.Name = "lblreturn2";
            this.lblreturn2.Size = new System.Drawing.Size(126, 22);
            this.lblreturn2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblreturn2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblreturn2.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturn2.TabIndex = 95;
            this.lblreturn2.Values.Text = "change amount :";
            // 
            // lblreturn1
            // 
            this.lblreturn1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblreturn1.Location = new System.Drawing.Point(259, 645);
            this.lblreturn1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblreturn1.Name = "lblreturn1";
            this.lblreturn1.Size = new System.Drawing.Size(126, 22);
            this.lblreturn1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblreturn1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblreturn1.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturn1.TabIndex = 94;
            this.lblreturn1.Values.Text = "change amount :";
            // 
            // lblpaid2
            // 
            this.lblpaid2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblpaid2.Location = new System.Drawing.Point(259, 617);
            this.lblpaid2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblpaid2.Name = "lblpaid2";
            this.lblpaid2.Size = new System.Drawing.Size(50, 22);
            this.lblpaid2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblpaid2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblpaid2.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid2.TabIndex = 93;
            this.lblpaid2.Values.Text = "Paid :";
            // 
            // lblpaid1
            // 
            this.lblpaid1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblpaid1.Location = new System.Drawing.Point(259, 589);
            this.lblpaid1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblpaid1.Name = "lblpaid1";
            this.lblpaid1.Size = new System.Drawing.Size(50, 22);
            this.lblpaid1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblpaid1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblpaid1.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid1.TabIndex = 92;
            this.lblpaid1.Values.Text = "Paid :";
            // 
            // lblgrand2
            // 
            this.lblgrand2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblgrand2.Location = new System.Drawing.Point(11, 701);
            this.lblgrand2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblgrand2.Name = "lblgrand2";
            this.lblgrand2.Size = new System.Drawing.Size(98, 22);
            this.lblgrand2.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblgrand2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblgrand2.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrand2.TabIndex = 91;
            this.lblgrand2.Values.Text = "Grand total :";
            // 
            // lblgrand1
            // 
            this.lblgrand1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblgrand1.Location = new System.Drawing.Point(11, 673);
            this.lblgrand1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblgrand1.Name = "lblgrand1";
            this.lblgrand1.Size = new System.Drawing.Size(98, 22);
            this.lblgrand1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblgrand1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblgrand1.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrand1.TabIndex = 90;
            this.lblgrand1.Values.Text = "Grand total :";
            // 
            // lbldiscount
            // 
            this.lbldiscount.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbldiscount.Location = new System.Drawing.Point(11, 645);
            this.lbldiscount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(80, 22);
            this.lbldiscount.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbldiscount.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lbldiscount.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.TabIndex = 89;
            this.lbldiscount.Values.Text = "Discount :";
            // 
            // lblsubtotal2
            // 
            this.lblsubtotal2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblsubtotal2.Location = new System.Drawing.Point(11, 617);
            this.lblsubtotal2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblsubtotal2.Name = "lblsubtotal2";
            this.lblsubtotal2.Size = new System.Drawing.Size(80, 22);
            this.lblsubtotal2.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblsubtotal2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblsubtotal2.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal2.TabIndex = 88;
            this.lblsubtotal2.Values.Text = "Sub total : ";
            // 
            // lblsubtotal1
            // 
            this.lblsubtotal1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblsubtotal1.Location = new System.Drawing.Point(11, 589);
            this.lblsubtotal1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblsubtotal1.Name = "lblsubtotal1";
            this.lblsubtotal1.Size = new System.Drawing.Size(80, 22);
            this.lblsubtotal1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblsubtotal1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblsubtotal1.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal1.TabIndex = 87;
            this.lblsubtotal1.Values.Text = "Sub total : ";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnList.ErrorImage")));
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(318, 11);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(25, 27);
            this.btnList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnList.TabIndex = 77;
            this.btnList.TabStop = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
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
            // frmcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(579, 299);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.gb_action);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcustomer";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcustomer";
            this.Load += new System.EventHandler(this.frmcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb_action.Panel)).EndInit();
            this.gb_action.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gb_action)).EndInit();
            this.gb_action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbogender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer time_show_progressbar;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gb_action;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnedit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncreate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnnew;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtid;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbogender;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboactive;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtphone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtname;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblreturn2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblreturn1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblpaid2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblpaid1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblgrand2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblgrand1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbldiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblsubtotal2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblsubtotal1;
        private System.Windows.Forms.PictureBox btnList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gphone;
    }
}