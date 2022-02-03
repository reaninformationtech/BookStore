
namespace BookStore
{
    partial class frmregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregister));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btncreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbranchname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtbranchshort = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtbranchemail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbosystem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtbranchphone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltakenote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblusername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblpasswordshow = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblusershow = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.time_show_progressbar = new System.Windows.Forms.Timer(this.components);
            this.progressbarsetup = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.btllogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbosystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _styleform
            // 
            this._styleform.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._styleform.ButtonSpecs.FormClose.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this._styleform.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.Image")));
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImageNormal = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImageNormal")));
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this._styleform.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            this._styleform.ButtonSpecs.FormClose.ToolTipTitle = "Close";
            this._styleform.ButtonSpecs.FormMax.AllowInheritExtraText = false;
            this._styleform.ButtonSpecs.FormMax.AllowInheritImage = false;
            this._styleform.ButtonSpecs.FormMax.AllowInheritToolTipTitle = false;
            this._styleform.ButtonSpecs.FormMax.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this._styleform.ButtonSpecs.FormMax.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate;
            this._styleform.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormMin.Image")));
            this._styleform.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this._styleform.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
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
            // btncreate
            // 
            this.btncreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncreate.Location = new System.Drawing.Point(300, 307);
            this.btncreate.Name = "btncreate";
            this.btncreate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncreate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncreate.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btncreate.Size = new System.Drawing.Size(130, 40);
            this.btncreate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StateCommon.Back.ColorAngle = 45F;
            this.btncreate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StateCommon.Border.ColorAngle = 50F;
            this.btncreate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btncreate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btncreate.StateCommon.Border.Rounding = 20;
            this.btncreate.StateCommon.Border.Width = 1;
            this.btncreate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btncreate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btncreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btncreate.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btncreate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btncreate.StateNormal.Border.ColorAngle = 45F;
            this.btncreate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
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
            this.btncreate.StateTracking.Border.Rounding = 20;
            this.btncreate.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btncreate.TabIndex = 6;
            this.btncreate.Values.Text = "Create";
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // txtbranchname
            // 
            this.txtbranchname.Location = new System.Drawing.Point(155, 153);
            this.txtbranchname.Name = "txtbranchname";
            this.txtbranchname.Size = new System.Drawing.Size(275, 32);
            this.txtbranchname.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtbranchname.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchname.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbranchname.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtbranchname.StateCommon.Border.Rounding = 20;
            this.txtbranchname.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtbranchname.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranchname.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtbranchname.TabIndex = 8;
            this.txtbranchname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 154);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(139, 31);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Branch Name :";
            // 
            // txtbranchshort
            // 
            this.txtbranchshort.Location = new System.Drawing.Point(155, 191);
            this.txtbranchshort.Name = "txtbranchshort";
            this.txtbranchshort.Size = new System.Drawing.Size(275, 32);
            this.txtbranchshort.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtbranchshort.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchshort.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchshort.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbranchshort.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtbranchshort.StateCommon.Border.Rounding = 20;
            this.txtbranchshort.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtbranchshort.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranchshort.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtbranchshort.TabIndex = 8;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 192);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(134, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Branch Short :";
            // 
            // txtbranchemail
            // 
            this.txtbranchemail.Location = new System.Drawing.Point(155, 229);
            this.txtbranchemail.Name = "txtbranchemail";
            this.txtbranchemail.Size = new System.Drawing.Size(275, 32);
            this.txtbranchemail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtbranchemail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchemail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchemail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbranchemail.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtbranchemail.StateCommon.Border.Rounding = 20;
            this.txtbranchemail.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtbranchemail.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranchemail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtbranchemail.TabIndex = 8;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(11, 230);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(136, 31);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 10;
            this.kryptonLabel3.Values.Text = "Branch email :";
            // 
            // cbosystem
            // 
            this.cbosystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosystem.DropDownWidth = 263;
            this.cbosystem.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbosystem.Location = new System.Drawing.Point(155, 112);
            this.cbosystem.MaxDropDownItems = 15;
            this.cbosystem.Name = "cbosystem";
            this.cbosystem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbosystem.Size = new System.Drawing.Size(275, 35);
            this.cbosystem.StateActive.ComboBox.Border.ColorAngle = 20F;
            this.cbosystem.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosystem.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbosystem.StateActive.ComboBox.Border.Rounding = 20;
            this.cbosystem.StateActive.ComboBox.Border.Width = 1;
            this.cbosystem.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosystem.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbosystem.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cbosystem.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosystem.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cbosystem.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbosystem.StateCommon.ComboBox.Border.Width = 1;
            this.cbosystem.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cbosystem.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbosystem.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cbosystem.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosystem.StateNormal.ComboBox.Border.Rounding = 20;
            this.cbosystem.StateNormal.ComboBox.Border.Width = 1;
            this.cbosystem.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbosystem.TabIndex = 11;
            this.cbosystem.Text = "Choose System Control";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(-6, 114);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(153, 31);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "System Control :";
            // 
            // txtbranchphone
            // 
            this.txtbranchphone.Location = new System.Drawing.Point(155, 267);
            this.txtbranchphone.Name = "txtbranchphone";
            this.txtbranchphone.Size = new System.Drawing.Size(275, 32);
            this.txtbranchphone.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtbranchphone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchphone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbranchphone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbranchphone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtbranchphone.StateCommon.Border.Rounding = 20;
            this.txtbranchphone.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtbranchphone.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranchphone.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtbranchphone.TabIndex = 8;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 268);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(142, 31);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Branch Phone :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbltakenote
            // 
            this.lbltakenote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbltakenote.Location = new System.Drawing.Point(437, 115);
            this.lbltakenote.Name = "lbltakenote";
            this.lbltakenote.Size = new System.Drawing.Size(250, 31);
            this.lbltakenote.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbltakenote.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbltakenote.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltakenote.TabIndex = 14;
            this.lbltakenote.Values.Text = "Take note your information";
            // 
            // lblusername
            // 
            this.lblusername.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblusername.Location = new System.Drawing.Point(437, 153);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(104, 31);
            this.lblusername.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.TabIndex = 15;
            this.lblusername.Values.Text = "User name";
            // 
            // lblPassword
            // 
            this.lblPassword.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblPassword.Location = new System.Drawing.Point(437, 191);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(141, 31);
            this.lblPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Values.Text = "User password";
            // 
            // lblpasswordshow
            // 
            this.lblpasswordshow.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblpasswordshow.Location = new System.Drawing.Point(580, 192);
            this.lblpasswordshow.Name = "lblpasswordshow";
            this.lblpasswordshow.Size = new System.Drawing.Size(145, 31);
            this.lblpasswordshow.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblpasswordshow.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.lblpasswordshow.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswordshow.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.lblpasswordshow.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblpasswordshow.TabIndex = 18;
            this.lblpasswordshow.Values.Text = "login password";
            // 
            // lblusershow
            // 
            this.lblusershow.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblusershow.Location = new System.Drawing.Point(580, 154);
            this.lblusershow.Name = "lblusershow";
            this.lblusershow.Size = new System.Drawing.Size(151, 31);
            this.lblusershow.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblusershow.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.lblusershow.StateCommon.ShortText.Font = new System.Drawing.Font("Futura Now Headline Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusershow.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.lblusershow.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblusershow.TabIndex = 17;
            this.lblusershow.Values.Text = "login user name";
            // 
            // time_show_progressbar
            // 
            this.time_show_progressbar.Tick += new System.EventHandler(this.time_show_progressbar_Tick);
            // 
            // progressbarsetup
            // 
            this.progressbarsetup.AllowAnimations = false;
            this.progressbarsetup.Animation = 0;
            this.progressbarsetup.AnimationSpeed = 220;
            this.progressbarsetup.AnimationStep = 10;
            this.progressbarsetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbarsetup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbarsetup.BackgroundImage")));
            this.progressbarsetup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbarsetup.BorderRadius = 10;
            this.progressbarsetup.BorderThickness = 1;
            this.progressbarsetup.Location = new System.Drawing.Point(155, 93);
            this.progressbarsetup.Maximum = 100;
            this.progressbarsetup.MaximumValue = 100;
            this.progressbarsetup.Minimum = 0;
            this.progressbarsetup.MinimumValue = 0;
            this.progressbarsetup.Name = "progressbarsetup";
            this.progressbarsetup.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressbarsetup.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbarsetup.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progressbarsetup.ProgressColorRight = System.Drawing.Color.Magenta;
            this.progressbarsetup.Size = new System.Drawing.Size(276, 12);
            this.progressbarsetup.TabIndex = 19;
            this.progressbarsetup.Value = 10;
            this.progressbarsetup.ValueByTransition = 10;
            this.progressbarsetup.Visible = false;
            // 
            // btllogin
            // 
            this.btllogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btllogin.Location = new System.Drawing.Point(155, 307);
            this.btllogin.Name = "btllogin";
            this.btllogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btllogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btllogin.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btllogin.Size = new System.Drawing.Size(139, 40);
            this.btllogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StateCommon.Back.ColorAngle = 45F;
            this.btllogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StateCommon.Border.ColorAngle = 50F;
            this.btllogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btllogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btllogin.StateCommon.Border.Rounding = 20;
            this.btllogin.StateCommon.Border.Width = 1;
            this.btllogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btllogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btllogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btllogin.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StateNormal.Border.ColorAngle = 45F;
            this.btllogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btllogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btllogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StateTracking.Back.ColorAngle = 45F;
            this.btllogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btllogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btllogin.StateTracking.Border.ColorAngle = 45F;
            this.btllogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btllogin.StateTracking.Border.Rounding = 20;
            this.btllogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btllogin.TabIndex = 20;
            this.btllogin.Values.Text = "Back to login";
            this.btllogin.Click += new System.EventHandler(this.btllogin_Click);
            // 
            // frmregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(724, 371);
            this.Controls.Add(this.btllogin);
            this.Controls.Add(this.progressbarsetup);
            this.Controls.Add(this.lblpasswordshow);
            this.Controls.Add(this.lblusershow);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbltakenote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.cbosystem);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtbranchphone);
            this.Controls.Add(this.txtbranchemail);
            this.Controls.Add(this.txtbranchshort);
            this.Controls.Add(this.txtbranchname);
            this.Controls.Add(this.btncreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmregister";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmregister";
            this.Load += new System.EventHandler(this.frmregister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbosystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncreate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbranchname;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbranchshort;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbranchemail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbosystem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbranchphone;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltakenote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblusername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblpasswordshow;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblusershow;
        private System.Windows.Forms.Timer time_show_progressbar;
        private Bunifu.UI.WinForms.BunifuProgressBar progressbarsetup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btllogin;
    }
}