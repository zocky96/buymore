namespace BuyMore
{
    partial class Rapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapport));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.theDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bunifuHScrollBar1 = new Bunifu.UI.WinForms.BunifuHScrollBar();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.imprimer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // theDate
            // 
            this.theDate.BackColor = System.Drawing.Color.SeaGreen;
            this.theDate.BorderRadius = 0;
            this.theDate.ForeColor = System.Drawing.Color.White;
            this.theDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.theDate.FormatCustom = "yyyy/MM/dd";
            this.theDate.Location = new System.Drawing.Point(12, 26);
            this.theDate.Name = "theDate";
            this.theDate.Size = new System.Drawing.Size(303, 36);
            this.theDate.TabIndex = 0;
            this.theDate.Value = new System.DateTime(2022, 5, 26, 4, 27, 4, 71);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // bunifuHScrollBar1
            // 
            this.bunifuHScrollBar1.AllowCursorChanges = true;
            this.bunifuHScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuHScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuHScrollBar1.AllowMouseDownEffects = true;
            this.bunifuHScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuHScrollBar1.AllowScrollingAnimations = true;
            this.bunifuHScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuHScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuHScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuHScrollBar1.BackgoundColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHScrollBar1.BackgroundImage")));
            this.bunifuHScrollBar1.BindingContainer = null;
            this.bunifuHScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.BorderRadius = 14;
            this.bunifuHScrollBar1.BorderThickness = 1;
            this.bunifuHScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuHScrollBar1.LargeChange = 10;
            this.bunifuHScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuHScrollBar1.Maximum = 100;
            this.bunifuHScrollBar1.Minimum = 0;
            this.bunifuHScrollBar1.MinimumThumbLength = 18;
            this.bunifuHScrollBar1.Name = "bunifuHScrollBar1";
            this.bunifuHScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.ScrollBarColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuHScrollBar1.Size = new System.Drawing.Size(200, 17);
            this.bunifuHScrollBar1.SmallChange = 1;
            this.bunifuHScrollBar1.TabIndex = 0;
            this.bunifuHScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuHScrollBar1.ThumbLength = 19;
            this.bunifuHScrollBar1.ThumbMargin = 1;
            this.bunifuHScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuHScrollBar.ThumbStyles.Inset;
            this.bunifuHScrollBar1.Value = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load);
            // 
            // imprimer
            // 
            this.imprimer.AllowToggling = false;
            this.imprimer.AnimationSpeed = 200;
            this.imprimer.AutoGenerateColors = false;
            this.imprimer.BackColor = System.Drawing.Color.Transparent;
            this.imprimer.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.imprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imprimer.BackgroundImage")));
            this.imprimer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.imprimer.ButtonText = "Imprimer";
            this.imprimer.ButtonTextMarginLeft = 0;
            this.imprimer.ColorContrastOnClick = 45;
            this.imprimer.ColorContrastOnHover = 45;
            this.imprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.imprimer.CustomizableEdges = borderEdges1;
            this.imprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imprimer.DisabledBorderColor = System.Drawing.Color.Empty;
            this.imprimer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.imprimer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.imprimer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.imprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.imprimer.ForeColor = System.Drawing.Color.White;
            this.imprimer.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.imprimer.IconMarginLeft = 11;
            this.imprimer.IconPadding = 10;
            this.imprimer.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.imprimer.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.imprimer.IdleBorderRadius = 3;
            this.imprimer.IdleBorderThickness = 1;
            this.imprimer.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.imprimer.IdleIconLeftImage = null;
            this.imprimer.IdleIconRightImage = null;
            this.imprimer.IndicateFocus = false;
            this.imprimer.Location = new System.Drawing.Point(369, 26);
            this.imprimer.Name = "imprimer";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.imprimer.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.imprimer.OnPressedState = stateProperties2;
            this.imprimer.Size = new System.Drawing.Size(123, 36);
            this.imprimer.TabIndex = 2;
            this.imprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imprimer.TextMarginLeft = 0;
            this.imprimer.UseDefaultRadiusAndThickness = true;
            this.imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imprimer);
            this.Controls.Add(this.theDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapport";
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.Rapport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDatepicker theDate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Bunifu.UI.WinForms.BunifuHScrollBar bunifuHScrollBar1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton imprimer;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}