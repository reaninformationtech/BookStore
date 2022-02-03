
namespace BookStore.Book
{
    partial class frmauthstocktransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmauthstocktransfer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.gData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._approved = new System.Windows.Forms.ToolStripMenuItem();
            this._reject = new System.Windows.Forms.ToolStripMenuItem();
            this.gcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gfstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
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
            // gData
            // 
            this.gData.AllowUserToAddRows = false;
            this.gData.AllowUserToDeleteRows = false;
            this.gData.AllowUserToResizeColumns = false;
            this.gData.AllowUserToResizeRows = false;
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcode,
            this.gproduct,
            this.gfstock,
            this.gtstock,
            this.gqty});
            this.gData.ContextMenuStrip = this.cmsUser;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.gData.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.gData.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.gData.Location = new System.Drawing.Point(0, 0);
            this.gData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gData.Name = "gData";
            this.gData.ReadOnly = true;
            this.gData.RowHeadersVisible = false;
            this.gData.RowHeadersWidth = 15;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gData.Size = new System.Drawing.Size(619, 450);
            this.gData.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gData.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gData.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.gData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gData.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gData.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gData.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gData.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gData.StateCommon.DataCell.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.gData.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gData.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.gData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Navy;
            this.gData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gData.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.gData.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.gData.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gData.StateCommon.HeaderRow.Border.Rounding = 10;
            this.gData.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.gData.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.gData.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gData.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gData.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gData.TabIndex = 44;
            this.gData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellClick);
            this.gData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gData_CellContentClick);
            // 
            // cmsUser
            // 
            this.cmsUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._approved,
            this._reject});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(120, 48);
            this.cmsUser.Opening += new System.ComponentModel.CancelEventHandler(this.cmsUser_Opening);
            // 
            // _approved
            // 
            this._approved.Image = ((System.Drawing.Image)(resources.GetObject("_approved.Image")));
            this._approved.Name = "_approved";
            this._approved.Size = new System.Drawing.Size(119, 22);
            this._approved.Text = "Approve";
            this._approved.Click += new System.EventHandler(this._approved_Click);
            // 
            // _reject
            // 
            this._reject.Image = ((System.Drawing.Image)(resources.GetObject("_reject.Image")));
            this._reject.Name = "_reject";
            this._reject.Size = new System.Drawing.Size(119, 22);
            this._reject.Text = "Reject";
            this._reject.Click += new System.EventHandler(this._reject_Click);
            // 
            // gcode
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcode.DefaultCellStyle = dataGridViewCellStyle1;
            this.gcode.HeaderText = "No";
            this.gcode.Name = "gcode";
            this.gcode.ReadOnly = true;
            this.gcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gproduct
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gproduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.gproduct.HeaderText = "product";
            this.gproduct.Name = "gproduct";
            this.gproduct.ReadOnly = true;
            // 
            // gfstock
            // 
            this.gfstock.HeaderText = "F-Stock ";
            this.gfstock.Name = "gfstock";
            this.gfstock.ReadOnly = true;
            // 
            // gtstock
            // 
            this.gtstock.HeaderText = "to stock";
            this.gtstock.Name = "gtstock";
            this.gtstock.ReadOnly = true;
            // 
            // gqty
            // 
            this.gqty.HeaderText = "Qty";
            this.gqty.Name = "gqty";
            this.gqty.ReadOnly = true;
            // 
            // frmauthstocktransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.gData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmauthstocktransfer";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmauthstocktransfer";
            this.Load += new System.EventHandler(this.frmauthstocktransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.cmsUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gData;
        internal System.Windows.Forms.ContextMenuStrip cmsUser;
        internal System.Windows.Forms.ToolStripMenuItem _approved;
        internal System.Windows.Forms.ToolStripMenuItem _reject;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn gfstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn gqty;
    }
}