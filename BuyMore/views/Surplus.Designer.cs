namespace BuyMore
{
    partial class Surplus
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Surplus));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.caissier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.montant = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.tableSurplus = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.code = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableSurplus)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // caissier
            // 
            this.caissier.FormattingEnabled = true;
            this.caissier.Location = new System.Drawing.Point(12, 57);
            this.caissier.Name = "caissier";
            this.caissier.Size = new System.Drawing.Size(247, 21);
            this.caissier.TabIndex = 0;
            this.caissier.SelectedIndexChanged += new System.EventHandler(this.Caissier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surplus";
            // 
            // save
            // 
            this.save.AllowToggling = false;
            this.save.AnimationSpeed = 200;
            this.save.AutoGenerateColors = false;
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.save.ButtonText = "Enregistrer";
            this.save.ButtonTextMarginLeft = 0;
            this.save.ColorContrastOnClick = 45;
            this.save.ColorContrastOnHover = 45;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.save.CustomizableEdges = borderEdges2;
            this.save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.save.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.save.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.save.IconMarginLeft = 11;
            this.save.IconPadding = 10;
            this.save.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.save.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.save.IdleBorderRadius = 3;
            this.save.IdleBorderThickness = 1;
            this.save.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.save.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("save.IdleIconLeftImage")));
            this.save.IdleIconRightImage = null;
            this.save.IndicateFocus = false;
            this.save.Location = new System.Drawing.Point(12, 398);
            this.save.Name = "save";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.BorderRadius = 3;
            stateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.save.onHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 3;
            stateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.save.OnPressedState = stateProperties8;
            this.save.Size = new System.Drawing.Size(150, 45);
            this.save.TabIndex = 2;
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.TextMarginLeft = 0;
            this.save.UseDefaultRadiusAndThickness = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // montant
            // 
            this.montant.AcceptsReturn = false;
            this.montant.AcceptsTab = false;
            this.montant.AnimationSpeed = 200;
            this.montant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.montant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.montant.BackColor = System.Drawing.Color.Transparent;
            this.montant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("montant.BackgroundImage")));
            this.montant.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.montant.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.montant.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.montant.BorderColorIdle = System.Drawing.Color.Silver;
            this.montant.BorderRadius = 1;
            this.montant.BorderThickness = 1;
            this.montant.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.montant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.montant.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.montant.DefaultText = "";
            this.montant.FillColor = System.Drawing.Color.White;
            this.montant.HideSelection = true;
            this.montant.IconLeft = null;
            this.montant.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.montant.IconPadding = 10;
            this.montant.IconRight = null;
            this.montant.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.montant.Lines = new string[0];
            this.montant.Location = new System.Drawing.Point(317, 57);
            this.montant.MaxLength = 32767;
            this.montant.MinimumSize = new System.Drawing.Size(100, 35);
            this.montant.Modified = false;
            this.montant.Multiline = false;
            this.montant.Name = "montant";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.montant.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.montant.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.montant.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.montant.OnIdleState = stateProperties12;
            this.montant.PasswordChar = '\0';
            this.montant.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.montant.PlaceholderText = "montant";
            this.montant.ReadOnly = false;
            this.montant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.montant.SelectedText = "";
            this.montant.SelectionLength = 0;
            this.montant.SelectionStart = 0;
            this.montant.ShortcutsEnabled = true;
            this.montant.Size = new System.Drawing.Size(247, 35);
            this.montant.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.montant.TabIndex = 1;
            this.montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.montant.TextMarginBottom = 0;
            this.montant.TextMarginLeft = 5;
            this.montant.TextMarginTop = 0;
            this.montant.TextPlaceholder = "montant";
            this.montant.UseSystemPasswordChar = false;
            this.montant.WordWrap = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(10, 10);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(676, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // tableSurplus
            // 
            this.tableSurplus.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableSurplus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableSurplus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableSurplus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableSurplus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableSurplus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableSurplus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableSurplus.ColumnHeadersHeight = 40;
            this.tableSurplus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.prix,
            this.quantiteT,
            this.dateT});
            this.tableSurplus.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tableSurplus.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableSurplus.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableSurplus.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableSurplus.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableSurplus.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tableSurplus.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableSurplus.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableSurplus.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableSurplus.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableSurplus.CurrentTheme.Name = null;
            this.tableSurplus.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableSurplus.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableSurplus.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableSurplus.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableSurplus.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableSurplus.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableSurplus.EnableHeadersVisualStyles = false;
            this.tableSurplus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableSurplus.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableSurplus.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableSurplus.HeaderForeColor = System.Drawing.Color.White;
            this.tableSurplus.Location = new System.Drawing.Point(12, 155);
            this.tableSurplus.Name = "tableSurplus";
            this.tableSurplus.RowHeadersVisible = false;
            this.tableSurplus.RowTemplate.Height = 40;
            this.tableSurplus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableSurplus.Size = new System.Drawing.Size(622, 223);
            this.tableSurplus.TabIndex = 39;
            this.tableSurplus.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Nom";
            this.name.Name = "name";
            // 
            // prix
            // 
            this.prix.HeaderText = "Montant";
            this.prix.Name = "prix";
            // 
            // quantiteT
            // 
            this.quantiteT.HeaderText = "Code";
            this.quantiteT.Name = "quantiteT";
            // 
            // dateT
            // 
            this.dateT.HeaderText = "Date";
            this.dateT.Name = "dateT";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Ajout";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.IdleIconLeftImage")));
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(202, 398);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties6;
            this.bunifuButton1.Size = new System.Drawing.Size(115, 45);
            this.bunifuButton1.TabIndex = 40;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // code
            // 
            this.code.AcceptsReturn = false;
            this.code.AcceptsTab = false;
            this.code.AnimationSpeed = 200;
            this.code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.code.BackColor = System.Drawing.Color.Transparent;
            this.code.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("code.BackgroundImage")));
            this.code.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.code.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.code.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.code.BorderColorIdle = System.Drawing.Color.Silver;
            this.code.BorderRadius = 1;
            this.code.BorderThickness = 1;
            this.code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.code.DefaultText = "";
            this.code.FillColor = System.Drawing.Color.White;
            this.code.HideSelection = true;
            this.code.IconLeft = null;
            this.code.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.code.IconPadding = 10;
            this.code.IconRight = null;
            this.code.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.code.Lines = new string[0];
            this.code.Location = new System.Drawing.Point(12, 100);
            this.code.MaxLength = 32767;
            this.code.MinimumSize = new System.Drawing.Size(100, 35);
            this.code.Modified = false;
            this.code.Multiline = false;
            this.code.Name = "code";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.code.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.code.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.code.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.code.OnIdleState = stateProperties4;
            this.code.PasswordChar = '\0';
            this.code.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.code.PlaceholderText = "code";
            this.code.ReadOnly = false;
            this.code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.code.SelectedText = "";
            this.code.SelectionLength = 0;
            this.code.SelectionStart = 0;
            this.code.ShortcutsEnabled = true;
            this.code.Size = new System.Drawing.Size(247, 35);
            this.code.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.code.TabIndex = 41;
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.code.TextMarginBottom = 0;
            this.code.TextMarginLeft = 5;
            this.code.TextMarginTop = 0;
            this.code.TextPlaceholder = "code";
            this.code.UseSystemPasswordChar = false;
            this.code.WordWrap = true;
            // 
            // Surplus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.code);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.tableSurplus);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.caissier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Surplus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surplus";
            this.Load += new System.EventHandler(this.Surplus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableSurplus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton save;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox montant;
        private System.Windows.Forms.ComboBox caissier;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuDataGridView tableSurplus;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateT;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox code;
    }
}