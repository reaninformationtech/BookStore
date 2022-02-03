
namespace BookStore
{
    partial class frmdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdashboard));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this._menu = new System.Windows.Forms.MenuStrip();
            this._file_sub = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_customer_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_product_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_supply_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_purchaseorder = new System.Windows.Forms.ToolStripMenuItem();
            this._ss_stock_transfer = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_pos = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_exit = new System.Windows.Forms.ToolStripMenuItem();
            this._authorize_sub = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_auth_pos = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_auth_purchaseorder = new System.Windows.Forms.ToolStripMenuItem();
            this._tools_sub = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_product_line_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_author_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_publish_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_stock_setup = new System.Windows.Forms.ToolStripMenuItem();
            this._setting_sub = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_setup_user = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_currency = new System.Windows.Forms.ToolStripMenuItem();
            this._about_sub = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_auth_stocktransfer = new System.Windows.Forms.ToolStripMenuItem();
            this._menu.SuspendLayout();
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
            // _menu
            // 
            this._menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._file_sub,
            this._authorize_sub,
            this._tools_sub,
            this._setting_sub,
            this._about_sub});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(1184, 28);
            this._menu.TabIndex = 1;
            // 
            // _file_sub
            // 
            this._file_sub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_customer_info,
            this.ss_product_info,
            this.ss_supply_info,
            this.ss_purchaseorder,
            this._ss_stock_transfer,
            this.ss_pos,
            this.ss_reports,
            this.ss_logout,
            this.ss_exit});
            this._file_sub.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._file_sub.Image = ((System.Drawing.Image)(resources.GetObject("_file_sub.Image")));
            this._file_sub.Name = "_file_sub";
            this._file_sub.Size = new System.Drawing.Size(65, 24);
            this._file_sub.Text = "&File";
            // 
            // ss_customer_info
            // 
            this.ss_customer_info.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_customer_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ss_customer_info.Image = ((System.Drawing.Image)(resources.GetObject("ss_customer_info.Image")));
            this.ss_customer_info.Name = "ss_customer_info";
            this.ss_customer_info.Size = new System.Drawing.Size(175, 22);
            this.ss_customer_info.Text = "Customer info";
            this.ss_customer_info.Click += new System.EventHandler(this.ss_customer_info_Click);
            // 
            // ss_product_info
            // 
            this.ss_product_info.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_product_info.Image = ((System.Drawing.Image)(resources.GetObject("ss_product_info.Image")));
            this.ss_product_info.Name = "ss_product_info";
            this.ss_product_info.Size = new System.Drawing.Size(175, 22);
            this.ss_product_info.Text = "Product Info";
            this.ss_product_info.Click += new System.EventHandler(this.ss_product_info_Click);
            // 
            // ss_supply_info
            // 
            this.ss_supply_info.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_supply_info.Image = ((System.Drawing.Image)(resources.GetObject("ss_supply_info.Image")));
            this.ss_supply_info.Name = "ss_supply_info";
            this.ss_supply_info.Size = new System.Drawing.Size(175, 22);
            this.ss_supply_info.Text = "Supply info";
            this.ss_supply_info.Click += new System.EventHandler(this.ss_supply_info_Click);
            // 
            // ss_purchaseorder
            // 
            this.ss_purchaseorder.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_purchaseorder.Image = ((System.Drawing.Image)(resources.GetObject("ss_purchaseorder.Image")));
            this.ss_purchaseorder.Name = "ss_purchaseorder";
            this.ss_purchaseorder.Size = new System.Drawing.Size(175, 22);
            this.ss_purchaseorder.Text = "Purchase order";
            this.ss_purchaseorder.Click += new System.EventHandler(this.ss_purchaseorder_Click);
            // 
            // _ss_stock_transfer
            // 
            this._ss_stock_transfer.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this._ss_stock_transfer.Image = ((System.Drawing.Image)(resources.GetObject("_ss_stock_transfer.Image")));
            this._ss_stock_transfer.Name = "_ss_stock_transfer";
            this._ss_stock_transfer.Size = new System.Drawing.Size(175, 22);
            this._ss_stock_transfer.Text = "Stock transfer";
            this._ss_stock_transfer.Click += new System.EventHandler(this._ss_stock_transfer_Click);
            // 
            // ss_pos
            // 
            this.ss_pos.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_pos.Image = ((System.Drawing.Image)(resources.GetObject("ss_pos.Image")));
            this.ss_pos.Name = "ss_pos";
            this.ss_pos.Size = new System.Drawing.Size(175, 22);
            this.ss_pos.Text = "POS";
            this.ss_pos.Click += new System.EventHandler(this.ss_pos_Click);
            // 
            // ss_reports
            // 
            this.ss_reports.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_reports.Image = ((System.Drawing.Image)(resources.GetObject("ss_reports.Image")));
            this.ss_reports.Name = "ss_reports";
            this.ss_reports.Size = new System.Drawing.Size(175, 22);
            this.ss_reports.Text = "Reports";
            this.ss_reports.Click += new System.EventHandler(this.ss_reports_Click);
            // 
            // ss_logout
            // 
            this.ss_logout.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ss_logout.Image = ((System.Drawing.Image)(resources.GetObject("ss_logout.Image")));
            this.ss_logout.Name = "ss_logout";
            this.ss_logout.Size = new System.Drawing.Size(175, 22);
            this.ss_logout.Text = "Logout";
            this.ss_logout.Click += new System.EventHandler(this.ss_logout_Click);
            // 
            // ss_exit
            // 
            this.ss_exit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ss_exit.Image = ((System.Drawing.Image)(resources.GetObject("ss_exit.Image")));
            this.ss_exit.Name = "ss_exit";
            this.ss_exit.Size = new System.Drawing.Size(175, 22);
            this.ss_exit.Text = "Exit";
            this.ss_exit.Click += new System.EventHandler(this.ss_exit_Click);
            // 
            // _authorize_sub
            // 
            this._authorize_sub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_auth_pos,
            this.ss_auth_purchaseorder,
            this.ss_auth_stocktransfer});
            this._authorize_sub.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._authorize_sub.Image = ((System.Drawing.Image)(resources.GetObject("_authorize_sub.Image")));
            this._authorize_sub.Name = "_authorize_sub";
            this._authorize_sub.Size = new System.Drawing.Size(103, 24);
            this._authorize_sub.Text = "Authorize";
            // 
            // ss_auth_pos
            // 
            this.ss_auth_pos.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_auth_pos.Image = ((System.Drawing.Image)(resources.GetObject("ss_auth_pos.Image")));
            this.ss_auth_pos.Name = "ss_auth_pos";
            this.ss_auth_pos.Size = new System.Drawing.Size(184, 26);
            this.ss_auth_pos.Text = "POS ";
            this.ss_auth_pos.Click += new System.EventHandler(this.ss_auth_pos_Click);
            // 
            // ss_auth_purchaseorder
            // 
            this.ss_auth_purchaseorder.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_auth_purchaseorder.Image = ((System.Drawing.Image)(resources.GetObject("ss_auth_purchaseorder.Image")));
            this.ss_auth_purchaseorder.Name = "ss_auth_purchaseorder";
            this.ss_auth_purchaseorder.Size = new System.Drawing.Size(184, 26);
            this.ss_auth_purchaseorder.Text = "Purchase order";
            this.ss_auth_purchaseorder.Click += new System.EventHandler(this.ss_auth_purchaseorder_Click);
            // 
            // _tools_sub
            // 
            this._tools_sub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_product_line_info,
            this.ss_author_info,
            this.ss_publish_info,
            this.ss_stock_setup});
            this._tools_sub.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tools_sub.Image = ((System.Drawing.Image)(resources.GetObject("_tools_sub.Image")));
            this._tools_sub.Name = "_tools_sub";
            this._tools_sub.Size = new System.Drawing.Size(75, 24);
            this._tools_sub.Text = "Tools";
            // 
            // ss_product_line_info
            // 
            this.ss_product_line_info.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_product_line_info.Image = ((System.Drawing.Image)(resources.GetObject("ss_product_line_info.Image")));
            this.ss_product_line_info.Name = "ss_product_line_info";
            this.ss_product_line_info.Size = new System.Drawing.Size(159, 22);
            this.ss_product_line_info.Text = "Product line";
            this.ss_product_line_info.Click += new System.EventHandler(this.ss_product_line_info_Click);
            // 
            // ss_author_info
            // 
            this.ss_author_info.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_author_info.Image = ((System.Drawing.Image)(resources.GetObject("ss_author_info.Image")));
            this.ss_author_info.Name = "ss_author_info";
            this.ss_author_info.Size = new System.Drawing.Size(159, 22);
            this.ss_author_info.Text = "Author info";
            this.ss_author_info.Click += new System.EventHandler(this.ss_author_info_Click);
            // 
            // ss_publish_info
            // 
            this.ss_publish_info.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_publish_info.Image = ((System.Drawing.Image)(resources.GetObject("ss_publish_info.Image")));
            this.ss_publish_info.Name = "ss_publish_info";
            this.ss_publish_info.Size = new System.Drawing.Size(159, 22);
            this.ss_publish_info.Text = "Publish info";
            this.ss_publish_info.Click += new System.EventHandler(this.ss_publish_info_Click);
            // 
            // ss_stock_setup
            // 
            this.ss_stock_setup.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_stock_setup.Image = ((System.Drawing.Image)(resources.GetObject("ss_stock_setup.Image")));
            this.ss_stock_setup.Name = "ss_stock_setup";
            this.ss_stock_setup.Size = new System.Drawing.Size(159, 22);
            this.ss_stock_setup.Text = "Stock info";
            this.ss_stock_setup.Click += new System.EventHandler(this.ss_stock_setup_Click);
            // 
            // _setting_sub
            // 
            this._setting_sub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_setup_user,
            this.ss_currency});
            this._setting_sub.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._setting_sub.Image = ((System.Drawing.Image)(resources.GetObject("_setting_sub.Image")));
            this._setting_sub.Name = "_setting_sub";
            this._setting_sub.Size = new System.Drawing.Size(86, 24);
            this._setting_sub.Text = "Setting";
            // 
            // ss_setup_user
            // 
            this.ss_setup_user.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_setup_user.Image = ((System.Drawing.Image)(resources.GetObject("ss_setup_user.Image")));
            this.ss_setup_user.Name = "ss_setup_user";
            this.ss_setup_user.Size = new System.Drawing.Size(210, 22);
            this.ss_setup_user.Text = "Setup User Account";
            this.ss_setup_user.Click += new System.EventHandler(this.ss_setup_user_Click);
            // 
            // ss_currency
            // 
            this.ss_currency.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_currency.Image = ((System.Drawing.Image)(resources.GetObject("ss_currency.Image")));
            this.ss_currency.Name = "ss_currency";
            this.ss_currency.Size = new System.Drawing.Size(210, 22);
            this.ss_currency.Text = "POS && Currency";
            this.ss_currency.Click += new System.EventHandler(this.ss_currency_Click);
            // 
            // _about_sub
            // 
            this._about_sub.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._about_sub.Image = ((System.Drawing.Image)(resources.GetObject("_about_sub.Image")));
            this._about_sub.Name = "_about_sub";
            this._about_sub.Size = new System.Drawing.Size(79, 24);
            this._about_sub.Text = "About";
            // 
            // ss_auth_stocktransfer
            // 
            this.ss_auth_stocktransfer.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ss_auth_stocktransfer.Image = ((System.Drawing.Image)(resources.GetObject("ss_auth_stocktransfer.Image")));
            this.ss_auth_stocktransfer.Name = "ss_auth_stocktransfer";
            this.ss_auth_stocktransfer.Size = new System.Drawing.Size(184, 26);
            this.ss_auth_stocktransfer.Text = "Stock transfer";
            this.ss_auth_stocktransfer.Click += new System.EventHandler(this.ss_auth_stocktransfer_Click);
            // 
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this._menu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmdashboard";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmdashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmdashboard_Load);
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem _tools_sub;
        private System.Windows.Forms.ToolStripMenuItem _setting_sub;
        private System.Windows.Forms.ToolStripMenuItem _about_sub;
        public System.Windows.Forms.ToolStripMenuItem _file_sub;
        private System.Windows.Forms.ToolStripMenuItem ss_reports;
        private System.Windows.Forms.ToolStripMenuItem ss_product_info;
        private System.Windows.Forms.ToolStripMenuItem ss_supply_info;
        private System.Windows.Forms.ToolStripMenuItem ss_logout;
        private System.Windows.Forms.ToolStripMenuItem ss_purchaseorder;
        private System.Windows.Forms.ToolStripMenuItem _authorize_sub;
        private System.Windows.Forms.ToolStripMenuItem ss_auth_purchaseorder;
        private System.Windows.Forms.ToolStripMenuItem ss_pos;
        private System.Windows.Forms.ToolStripMenuItem ss_currency;
        private System.Windows.Forms.ToolStripMenuItem ss_customer_info;
        private System.Windows.Forms.ToolStripMenuItem ss_auth_pos;
        private System.Windows.Forms.ToolStripMenuItem ss_author_info;
        private System.Windows.Forms.ToolStripMenuItem ss_publish_info;
        private System.Windows.Forms.ToolStripMenuItem ss_product_line_info;
        private System.Windows.Forms.ToolStripMenuItem ss_stock_setup;
        private System.Windows.Forms.ToolStripMenuItem ss_setup_user;
        private System.Windows.Forms.ToolStripMenuItem ss_exit;
        private System.Windows.Forms.ToolStripMenuItem _ss_stock_transfer;
        private System.Windows.Forms.ToolStripMenuItem ss_auth_stocktransfer;
    }
}