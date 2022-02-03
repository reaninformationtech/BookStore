namespace BookStore
{
    partial class frmuseraccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuseraccount));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Profile");
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tvProfile = new System.Windows.Forms.TreeView();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._NewUser = new System.Windows.Forms.ToolStripMenuItem();
            this._SetNewPassword = new System.Windows.Forms.ToolStripMenuItem();
            this._ChangeProfile = new System.Windows.Forms.ToolStripMenuItem();
            this._Disable = new System.Windows.Forms.ToolStripMenuItem();
            this._Active = new System.Windows.Forms.ToolStripMenuItem();
            this.lvUser = new System.Windows.Forms.ListView();
            this.userid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_card = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.cmsUser.SuspendLayout();
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tvProfile);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(206, 655);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tvProfile
            // 
            this.tvProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvProfile.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvProfile.ForeColor = System.Drawing.Color.Red;
            this.tvProfile.Location = new System.Drawing.Point(0, 0);
            this.tvProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvProfile.Name = "tvProfile";
            treeNode2.Name = "Node0";
            treeNode2.Text = "User Profile";
            this.tvProfile.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvProfile.Size = new System.Drawing.Size(206, 655);
            this.tvProfile.TabIndex = 2;
            this.tvProfile.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProfile_AfterSelect);
            // 
            // cmsUser
            // 
            this.cmsUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NewUser,
            this._SetNewPassword,
            this._ChangeProfile,
            this._Disable,
            this._Active});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(181, 136);
            this.cmsUser.Opening += new System.ComponentModel.CancelEventHandler(this.cmsUser_Opening);
            // 
            // _NewUser
            // 
            this._NewUser.Name = "_NewUser";
            this._NewUser.Size = new System.Drawing.Size(180, 22);
            this._NewUser.Text = "New user";
            this._NewUser.Click += new System.EventHandler(this._NewUser_Click);
            // 
            // _SetNewPassword
            // 
            this._SetNewPassword.Name = "_SetNewPassword";
            this._SetNewPassword.Size = new System.Drawing.Size(180, 22);
            this._SetNewPassword.Text = "Set new password";
            this._SetNewPassword.Click += new System.EventHandler(this._SetNewPassword_Click);
            // 
            // _ChangeProfile
            // 
            this._ChangeProfile.Name = "_ChangeProfile";
            this._ChangeProfile.Size = new System.Drawing.Size(180, 22);
            this._ChangeProfile.Text = "Change profile";
            this._ChangeProfile.Click += new System.EventHandler(this._ChangeProfile_Click);
            // 
            // _Disable
            // 
            this._Disable.Name = "_Disable";
            this._Disable.Size = new System.Drawing.Size(180, 22);
            this._Disable.Text = "Disable";
            this._Disable.Click += new System.EventHandler(this._Disable_Click);
            // 
            // _Active
            // 
            this._Active.Name = "_Active";
            this._Active.Size = new System.Drawing.Size(180, 22);
            this._Active.Text = "Active";
            this._Active.Click += new System.EventHandler(this._Active_Click);
            // 
            // lvUser
            // 
            this.lvUser.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userid,
            this.id_card,
            this.username,
            this.login,
            this.profile,
            this.status});
            this.lvUser.ContextMenuStrip = this.cmsUser;
            this.lvUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUser.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUser.ForeColor = System.Drawing.Color.Navy;
            this.lvUser.FullRowSelect = true;
            this.lvUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUser.HideSelection = false;
            this.lvUser.HoverSelection = true;
            this.lvUser.Location = new System.Drawing.Point(206, 0);
            this.lvUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvUser.Name = "lvUser";
            this.lvUser.Size = new System.Drawing.Size(867, 655);
            this.lvUser.TabIndex = 14;
            this.lvUser.UseCompatibleStateImageBehavior = false;
            this.lvUser.View = System.Windows.Forms.View.Details;
            this.lvUser.SelectedIndexChanged += new System.EventHandler(this.lvUser_SelectedIndexChanged);
            // 
            // userid
            // 
            this.userid.Text = "user id";
            this.userid.Width = 77;
            // 
            // id_card
            // 
            this.id_card.Text = "id card";
            // 
            // username
            // 
            this.username.Text = "user name";
            this.username.Width = 150;
            // 
            // login
            // 
            this.login.Text = "login";
            this.login.Width = 120;
            // 
            // profile
            // 
            this.profile.Text = "profile";
            this.profile.Width = 100;
            // 
            // status
            // 
            this.status.Text = "active";
            // 
            // frmuseraccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1073, 655);
            this.Controls.Add(this.lvUser);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmuseraccount";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmuseraccount";
            this.Load += new System.EventHandler(this.frmuseraccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.cmsUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        internal System.Windows.Forms.TreeView tvProfile;
        internal System.Windows.Forms.ContextMenuStrip cmsUser;
        internal System.Windows.Forms.ToolStripMenuItem _NewUser;
        internal System.Windows.Forms.ToolStripMenuItem _SetNewPassword;
        internal System.Windows.Forms.ToolStripMenuItem _ChangeProfile;
        internal System.Windows.Forms.ToolStripMenuItem _Disable;
        internal System.Windows.Forms.ToolStripMenuItem _Active;
        internal System.Windows.Forms.ListView lvUser;
        internal System.Windows.Forms.ColumnHeader userid;
        internal System.Windows.Forms.ColumnHeader id_card;
        internal System.Windows.Forms.ColumnHeader username;
        internal System.Windows.Forms.ColumnHeader login;
        internal System.Windows.Forms.ColumnHeader profile;
        private System.Windows.Forms.ColumnHeader status;
    }
}