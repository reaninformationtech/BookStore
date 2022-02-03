
namespace BookStore.Book
{
    partial class frmpos_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpos_list));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.gData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinputter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
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
            // gData
            // 
            this.gData.AllowUserToAddRows = false;
            this.gData.AllowUserToDeleteRows = false;
            this.gData.AllowUserToResizeColumns = false;
            this.gData.AllowUserToResizeRows = false;
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vcode,
            this.vcustomer,
            this.vdate,
            this.vinputter,
            this.vstatus});
            this.gData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.gData.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.gData.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.gData.Location = new System.Drawing.Point(0, 0);
            this.gData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gData.Name = "gData";
            this.gData.RowHeadersVisible = false;
            this.gData.RowHeadersWidth = 10;
            this.gData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gData.Size = new System.Drawing.Size(584, 461);
            this.gData.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gData.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gData.StateCommon.Background.ColorAngle = 10F;
            this.gData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gData.StateCommon.HeaderColumn.Border.ColorAngle = 10F;
            this.gData.StateCommon.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.gData.StateCommon.HeaderColumn.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.gData.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gData.StateCommon.HeaderColumn.Border.Rounding = 10;
            this.gData.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gData.StateCommon.HeaderRow.Border.Rounding = 10;
            this.gData.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gData.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gData.StateSelected.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gData.StateSelected.HeaderColumn.Border.Rounding = 10;
            this.gData.TabIndex = 44;
            this.gData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellClick);
            this.gData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellContentClick);
            // 
            // vcode
            // 
            this.vcode.HeaderText = "code";
            this.vcode.Name = "vcode";
            // 
            // vcustomer
            // 
            this.vcustomer.HeaderText = "customer";
            this.vcustomer.Name = "vcustomer";
            // 
            // vdate
            // 
            this.vdate.HeaderText = "date";
            this.vdate.Name = "vdate";
            // 
            // vinputter
            // 
            this.vinputter.HeaderText = "inputter";
            this.vinputter.Name = "vinputter";
            // 
            // vstatus
            // 
            this.vstatus.HeaderText = "status";
            this.vstatus.Name = "vstatus";
            // 
            // frmpos_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.gData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpos_list";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmpos_list";
            this.Load += new System.EventHandler(this.frmpos_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gData;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinputter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vstatus;
    }
}