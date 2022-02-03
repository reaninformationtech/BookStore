
namespace BookStore.Control
{
    partial class button_menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(button_menu));
            this._Cards_Item = new Bunifu.Framework.UI.BunifuCards();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanBox = new System.Windows.Forms.Panel();
            this._Pic = new System.Windows.Forms.PictureBox();
            this._menu_item = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this._Cards_Item.SuspendLayout();
            this.PanBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // _Cards_Item
            // 
            this._Cards_Item.BackColor = System.Drawing.Color.Transparent;
            this._Cards_Item.BorderRadius = 5;
            this._Cards_Item.BottomSahddow = true;
            this._Cards_Item.color = System.Drawing.Color.LightSalmon;
            this._Cards_Item.Controls.Add(this.lblTitle);
            this._Cards_Item.Controls.Add(this.PanBox);
            this._Cards_Item.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Cards_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Cards_Item.LeftSahddow = false;
            this._Cards_Item.Location = new System.Drawing.Point(0, 0);
            this._Cards_Item.Name = "_Cards_Item";
            this._Cards_Item.RightSahddow = true;
            this._Cards_Item.ShadowDepth = 20;
            this._Cards_Item.Size = new System.Drawing.Size(170, 50);
            this._Cards_Item.TabIndex = 1;
            this._Cards_Item.Click += new System.EventHandler(this.Items_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Khmer OS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(24, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 27);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Full Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.Items_Click);
            // 
            // PanBox
            // 
            this.PanBox.BackColor = System.Drawing.Color.Transparent;
            this.PanBox.Controls.Add(this._Pic);
            this.PanBox.Location = new System.Drawing.Point(0, 12);
            this.PanBox.Name = "PanBox";
            this.PanBox.Size = new System.Drawing.Size(22, 19);
            this.PanBox.TabIndex = 10;
            // 
            // _Pic
            // 
            this._Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Pic.Image = ((System.Drawing.Image)(resources.GetObject("_Pic.Image")));
            this._Pic.Location = new System.Drawing.Point(0, 0);
            this._Pic.Name = "_Pic";
            this._Pic.Size = new System.Drawing.Size(22, 19);
            this._Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Pic.TabIndex = 1;
            this._Pic.TabStop = false;
            this._Pic.Click += new System.EventHandler(this.Items_Click);
            // 
            // _menu_item
            // 
            this._menu_item.ElipseRadius = 15;
            this._menu_item.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 4;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._Cards_Item);
            this.Name = "button_menu";
            this.Size = new System.Drawing.Size(170, 50);
            this._Cards_Item.ResumeLayout(false);
            this._Cards_Item.PerformLayout();
            this.PanBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCards _Cards_Item;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel PanBox;
        public System.Windows.Forms.PictureBox _Pic;
        public Bunifu.Framework.UI.BunifuElipse _menu_item;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
