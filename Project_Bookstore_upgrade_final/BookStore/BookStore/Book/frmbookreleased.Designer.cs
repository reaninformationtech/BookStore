
namespace BookStore.Book
{
    partial class frmbookreleased
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbookreleased));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.time_show_progressbar = new System.Windows.Forms.Timer(this.components);
            this.lbltakenote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.progressbarsetup = new Bunifu.UI.WinForms.BunifuProgressBar();
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
            // time_show_progressbar
            // 
            this.time_show_progressbar.Tick += new System.EventHandler(this.time_show_progressbar_Tick);
            // 
            // lbltakenote
            // 
            this.lbltakenote.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbltakenote.Location = new System.Drawing.Point(23, 99);
            this.lbltakenote.Name = "lbltakenote";
            this.lbltakenote.Size = new System.Drawing.Size(449, 35);
            this.lbltakenote.StateCommon.ShortText.Color1 = System.Drawing.Color.OrangeRed;
            this.lbltakenote.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbltakenote.StateCommon.ShortText.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbltakenote.TabIndex = 15;
            this.lbltakenote.Values.Text = "Sorry ! this function will released soon";
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
            this.progressbarsetup.Location = new System.Drawing.Point(2, 228);
            this.progressbarsetup.Maximum = 100;
            this.progressbarsetup.MaximumValue = 100;
            this.progressbarsetup.Minimum = 0;
            this.progressbarsetup.MinimumValue = 0;
            this.progressbarsetup.Name = "progressbarsetup";
            this.progressbarsetup.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressbarsetup.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbarsetup.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progressbarsetup.ProgressColorRight = System.Drawing.Color.Magenta;
            this.progressbarsetup.Size = new System.Drawing.Size(497, 10);
            this.progressbarsetup.TabIndex = 20;
            this.progressbarsetup.Value = 10;
            this.progressbarsetup.ValueByTransition = 10;
            this.progressbarsetup.Visible = false;
            // 
            // frmbookreleased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.progressbarsetup);
            this.Controls.Add(this.lbltakenote);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbookreleased";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbookreleased";
            this.Load += new System.EventHandler(this.frmbookreleased_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private System.Windows.Forms.Timer time_show_progressbar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltakenote;
        private Bunifu.UI.WinForms.BunifuProgressBar progressbarsetup;
    }
}