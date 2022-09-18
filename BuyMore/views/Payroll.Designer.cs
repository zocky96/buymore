namespace BuyMore
{
    partial class Payroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.tablePayroll = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.short_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paiement = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.surplus = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.shortt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // date2
            // 
            this.date2.CustomFormat = "yyyy/MM/dd";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(455, 40);
            this.date2.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(131, 20);
            this.date2.TabIndex = 4;
            this.date2.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            // 
            // tablePayroll
            // 
            this.tablePayroll.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tablePayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePayroll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePayroll.ColumnHeadersHeight = 40;
            this.tablePayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.employer,
            this.salaire,
            this.short_,
            this.suplu});
            this.tablePayroll.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tablePayroll.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tablePayroll.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tablePayroll.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tablePayroll.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tablePayroll.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tablePayroll.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tablePayroll.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tablePayroll.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tablePayroll.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablePayroll.CurrentTheme.Name = null;
            this.tablePayroll.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePayroll.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tablePayroll.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tablePayroll.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tablePayroll.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePayroll.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePayroll.EnableHeadersVisualStyles = false;
            this.tablePayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tablePayroll.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tablePayroll.HeaderBgColor = System.Drawing.Color.Empty;
            this.tablePayroll.HeaderForeColor = System.Drawing.Color.White;
            this.tablePayroll.Location = new System.Drawing.Point(12, 255);
            this.tablePayroll.Name = "tablePayroll";
            this.tablePayroll.RowHeadersVisible = false;
            this.tablePayroll.RowTemplate.Height = 40;
            this.tablePayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePayroll.Size = new System.Drawing.Size(639, 279);
            this.tablePayroll.TabIndex = 30;
            this.tablePayroll.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // employer
            // 
            this.employer.HeaderText = "Employer";
            this.employer.Name = "employer";
            // 
            // salaire
            // 
            this.salaire.HeaderText = "Salaire";
            this.salaire.Name = "salaire";
            // 
            // short_
            // 
            this.short_.HeaderText = "Short";
            this.short_.Name = "short_";
            // 
            // suplu
            // 
            this.suplu.HeaderText = "Suplu";
            this.suplu.Name = "suplu";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // paiement
            // 
            this.paiement.AllowToggling = false;
            this.paiement.AnimationSpeed = 200;
            this.paiement.AutoGenerateColors = false;
            this.paiement.BackColor = System.Drawing.Color.Transparent;
            this.paiement.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.paiement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paiement.BackgroundImage")));
            this.paiement.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.paiement.ButtonText = "Gestion paiement";
            this.paiement.ButtonTextMarginLeft = 0;
            this.paiement.ColorContrastOnClick = 45;
            this.paiement.ColorContrastOnHover = 45;
            this.paiement.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.paiement.CustomizableEdges = borderEdges1;
            this.paiement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.paiement.DisabledBorderColor = System.Drawing.Color.Empty;
            this.paiement.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.paiement.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.paiement.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.paiement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.paiement.ForeColor = System.Drawing.Color.White;
            this.paiement.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.paiement.IconMarginLeft = 11;
            this.paiement.IconPadding = 10;
            this.paiement.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.paiement.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.paiement.IdleBorderRadius = 3;
            this.paiement.IdleBorderThickness = 1;
            this.paiement.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.paiement.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("paiement.IdleIconLeftImage")));
            this.paiement.IdleIconRightImage = null;
            this.paiement.IndicateFocus = false;
            this.paiement.Location = new System.Drawing.Point(244, 40);
            this.paiement.Name = "paiement";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.paiement.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.paiement.OnPressedState = stateProperties2;
            this.paiement.Size = new System.Drawing.Size(185, 45);
            this.paiement.TabIndex = 3;
            this.paiement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paiement.TextMarginLeft = 0;
            this.paiement.UseDefaultRadiusAndThickness = true;
            this.paiement.Click += new System.EventHandler(this.BunifuButton3_Click);
            // 
            // surplus
            // 
            this.surplus.AllowToggling = false;
            this.surplus.AnimationSpeed = 200;
            this.surplus.AutoGenerateColors = false;
            this.surplus.BackColor = System.Drawing.Color.Transparent;
            this.surplus.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.surplus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("surplus.BackgroundImage")));
            this.surplus.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.surplus.ButtonText = "Surplus";
            this.surplus.ButtonTextMarginLeft = 0;
            this.surplus.ColorContrastOnClick = 45;
            this.surplus.ColorContrastOnHover = 45;
            this.surplus.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.surplus.CustomizableEdges = borderEdges2;
            this.surplus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.surplus.DisabledBorderColor = System.Drawing.Color.Empty;
            this.surplus.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.surplus.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.surplus.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.surplus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.surplus.ForeColor = System.Drawing.Color.White;
            this.surplus.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.surplus.IconMarginLeft = 3;
            this.surplus.IconPadding = 10;
            this.surplus.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.surplus.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.surplus.IdleBorderRadius = 3;
            this.surplus.IdleBorderThickness = 1;
            this.surplus.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.surplus.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("surplus.IdleIconLeftImage")));
            this.surplus.IdleIconRightImage = null;
            this.surplus.IndicateFocus = false;
            this.surplus.Location = new System.Drawing.Point(12, 40);
            this.surplus.Name = "surplus";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.surplus.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.surplus.OnPressedState = stateProperties4;
            this.surplus.Size = new System.Drawing.Size(110, 45);
            this.surplus.TabIndex = 2;
            this.surplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.surplus.TextMarginLeft = 0;
            this.surplus.UseDefaultRadiusAndThickness = true;
            this.surplus.Click += new System.EventHandler(this.BunifuButton2_Click);
            // 
            // shortt
            // 
            this.shortt.AllowToggling = false;
            this.shortt.AnimationSpeed = 200;
            this.shortt.AutoGenerateColors = false;
            this.shortt.BackColor = System.Drawing.Color.Transparent;
            this.shortt.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.shortt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shortt.BackgroundImage")));
            this.shortt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.shortt.ButtonText = "short";
            this.shortt.ButtonTextMarginLeft = 0;
            this.shortt.ColorContrastOnClick = 45;
            this.shortt.ColorContrastOnHover = 45;
            this.shortt.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.shortt.CustomizableEdges = borderEdges3;
            this.shortt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.shortt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.shortt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.shortt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.shortt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.shortt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.shortt.ForeColor = System.Drawing.Color.White;
            this.shortt.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.shortt.IconMarginLeft = 11;
            this.shortt.IconPadding = 10;
            this.shortt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.shortt.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.shortt.IdleBorderRadius = 3;
            this.shortt.IdleBorderThickness = 1;
            this.shortt.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.shortt.IdleIconLeftImage = null;
            this.shortt.IdleIconRightImage = null;
            this.shortt.IndicateFocus = false;
            this.shortt.Location = new System.Drawing.Point(128, 40);
            this.shortt.Name = "shortt";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.shortt.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.shortt.OnPressedState = stateProperties6;
            this.shortt.Size = new System.Drawing.Size(110, 45);
            this.shortt.TabIndex = 1;
            this.shortt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shortt.TextMarginLeft = 0;
            this.shortt.UseDefaultRadiusAndThickness = true;
            this.shortt.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablePayroll);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.paiement);
            this.Controls.Add(this.surplus);
            this.Controls.Add(this.shortt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePayroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DateTimePicker date2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton paiement;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton surplus;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton shortt;
        private Bunifu.UI.WinForms.BunifuDataGridView tablePayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employer;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}