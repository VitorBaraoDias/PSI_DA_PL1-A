namespace iCantina.Views
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.comboPrato = new System.Windows.Forms.ComboBox();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnRemoveExtra = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.comboExtrasSelect = new System.Windows.Forms.ComboBox();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.comboExtras = new System.Windows.Forms.ComboBox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnInserir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSaldo = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPrecoCliente = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddExtras = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 104);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(18, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(66, 32);
            this.bunifuLabel1.TabIndex = 38;
            this.bunifuLabel1.Text = "Home";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(18, 67);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(154, 25);
            this.bunifuLabel2.TabIndex = 39;
            this.bunifuLabel2.Text = "Caléndario menus";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // comboPrato
            // 
            this.comboPrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrato.FormattingEnabled = true;
            this.comboPrato.Location = new System.Drawing.Point(25, 149);
            this.comboPrato.Name = "comboPrato";
            this.comboPrato.Size = new System.Drawing.Size(261, 21);
            this.comboPrato.TabIndex = 58;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bunifuLabel8.Location = new System.Drawing.Point(25, 118);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(154, 25);
            this.bunifuLabel8.TabIndex = 57;
            this.bunifuLabel8.Text = "*Prato Disponíveis";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Items.AddRange(new object[] {
            "Professor",
            "Estudante"});
            this.comboTipoCliente.Location = new System.Drawing.Point(25, 328);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(189, 21);
            this.comboTipoCliente.TabIndex = 60;
            this.comboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboTipoCliente_SelectedIndexChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bunifuLabel3.Location = new System.Drawing.Point(25, 297);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(135, 25);
            this.bunifuLabel3.TabIndex = 59;
            this.bunifuLabel3.Text = "*Tipo de Cliente";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(25, 386);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(254, 21);
            this.comboClientes.TabIndex = 62;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bunifuLabel4.Location = new System.Drawing.Point(25, 355);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(67, 25);
            this.bunifuLabel4.TabIndex = 61;
            this.bunifuLabel4.Text = "*Cliente";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 22;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(264, 12);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(44, 44);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 64;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnRemoveExtra
            // 
            this.btnRemoveExtra.AllowAnimations = true;
            this.btnRemoveExtra.AllowMouseEffects = true;
            this.btnRemoveExtra.AllowToggling = false;
            this.btnRemoveExtra.AnimationSpeed = 200;
            this.btnRemoveExtra.AutoGenerateColors = false;
            this.btnRemoveExtra.AutoRoundBorders = false;
            this.btnRemoveExtra.AutoSizeLeftIcon = true;
            this.btnRemoveExtra.AutoSizeRightIcon = true;
            this.btnRemoveExtra.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveExtra.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnRemoveExtra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveExtra.BackgroundImage")));
            this.btnRemoveExtra.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemoveExtra.ButtonText = "-";
            this.btnRemoveExtra.ButtonTextMarginLeft = 0;
            this.btnRemoveExtra.ColorContrastOnClick = 45;
            this.btnRemoveExtra.ColorContrastOnHover = 45;
            this.btnRemoveExtra.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnRemoveExtra.CustomizableEdges = borderEdges4;
            this.btnRemoveExtra.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoveExtra.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRemoveExtra.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRemoveExtra.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRemoveExtra.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRemoveExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveExtra.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExtra.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveExtra.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveExtra.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRemoveExtra.IconMarginLeft = 11;
            this.btnRemoveExtra.IconPadding = 10;
            this.btnRemoveExtra.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveExtra.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveExtra.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRemoveExtra.IconSize = 25;
            this.btnRemoveExtra.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveExtra.IdleBorderRadius = 25;
            this.btnRemoveExtra.IdleBorderThickness = 1;
            this.btnRemoveExtra.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveExtra.IdleIconLeftImage = null;
            this.btnRemoveExtra.IdleIconRightImage = null;
            this.btnRemoveExtra.IndicateFocus = false;
            this.btnRemoveExtra.Location = new System.Drawing.Point(255, 251);
            this.btnRemoveExtra.Name = "btnRemoveExtra";
            this.btnRemoveExtra.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRemoveExtra.OnDisabledState.BorderRadius = 25;
            this.btnRemoveExtra.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemoveExtra.OnDisabledState.BorderThickness = 1;
            this.btnRemoveExtra.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRemoveExtra.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRemoveExtra.OnDisabledState.IconLeftImage = null;
            this.btnRemoveExtra.OnDisabledState.IconRightImage = null;
            this.btnRemoveExtra.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRemoveExtra.onHoverState.BorderRadius = 25;
            this.btnRemoveExtra.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemoveExtra.onHoverState.BorderThickness = 1;
            this.btnRemoveExtra.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRemoveExtra.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExtra.onHoverState.IconLeftImage = null;
            this.btnRemoveExtra.onHoverState.IconRightImage = null;
            this.btnRemoveExtra.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveExtra.OnIdleState.BorderRadius = 25;
            this.btnRemoveExtra.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemoveExtra.OnIdleState.BorderThickness = 1;
            this.btnRemoveExtra.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveExtra.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExtra.OnIdleState.IconLeftImage = null;
            this.btnRemoveExtra.OnIdleState.IconRightImage = null;
            this.btnRemoveExtra.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRemoveExtra.OnPressedState.BorderRadius = 25;
            this.btnRemoveExtra.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemoveExtra.OnPressedState.BorderThickness = 1;
            this.btnRemoveExtra.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRemoveExtra.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExtra.OnPressedState.IconLeftImage = null;
            this.btnRemoveExtra.OnPressedState.IconRightImage = null;
            this.btnRemoveExtra.Size = new System.Drawing.Size(31, 28);
            this.btnRemoveExtra.TabIndex = 82;
            this.btnRemoveExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveExtra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemoveExtra.TextMarginLeft = 0;
            this.btnRemoveExtra.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRemoveExtra.UseDefaultRadiusAndThickness = true;
            this.btnRemoveExtra.Click += new System.EventHandler(this.btnRemoveExtra_Click);
            // 
            // comboExtrasSelect
            // 
            this.comboExtrasSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExtrasSelect.FormattingEnabled = true;
            this.comboExtrasSelect.Location = new System.Drawing.Point(25, 258);
            this.comboExtrasSelect.Name = "comboExtrasSelect";
            this.comboExtrasSelect.Size = new System.Drawing.Size(224, 21);
            this.comboExtrasSelect.TabIndex = 81;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.CursorType = null;
            this.bunifuLabel13.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bunifuLabel13.Location = new System.Drawing.Point(25, 176);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(50, 25);
            this.bunifuLabel13.TabIndex = 77;
            this.bunifuLabel13.Text = "Extras";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // comboExtras
            // 
            this.comboExtras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExtras.FormattingEnabled = true;
            this.comboExtras.Location = new System.Drawing.Point(25, 207);
            this.comboExtras.Name = "comboExtras";
            this.comboExtras.Size = new System.Drawing.Size(224, 21);
            this.comboExtras.TabIndex = 76;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuLabel6.Location = new System.Drawing.Point(25, 239);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(100, 13);
            this.bunifuLabel6.TabIndex = 83;
            this.bunifuLabel6.Text = "Extras selecionados";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnInserir
            // 
            this.btnInserir.AllowAnimations = true;
            this.btnInserir.AllowMouseEffects = true;
            this.btnInserir.AllowToggling = false;
            this.btnInserir.AnimationSpeed = 200;
            this.btnInserir.AutoGenerateColors = false;
            this.btnInserir.AutoRoundBorders = false;
            this.btnInserir.AutoSizeLeftIcon = true;
            this.btnInserir.AutoSizeRightIcon = true;
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnInserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInserir.BackgroundImage")));
            this.btnInserir.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInserir.ButtonText = "Inserir";
            this.btnInserir.ButtonTextMarginLeft = 0;
            this.btnInserir.ColorContrastOnClick = 45;
            this.btnInserir.ColorContrastOnHover = 45;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnInserir.CustomizableEdges = borderEdges5;
            this.btnInserir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInserir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInserir.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInserir.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInserir.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInserir.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInserir.IconMarginLeft = 11;
            this.btnInserir.IconPadding = 10;
            this.btnInserir.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInserir.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInserir.IconSize = 25;
            this.btnInserir.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnInserir.IdleBorderRadius = 25;
            this.btnInserir.IdleBorderThickness = 1;
            this.btnInserir.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnInserir.IdleIconLeftImage = null;
            this.btnInserir.IdleIconRightImage = null;
            this.btnInserir.IndicateFocus = false;
            this.btnInserir.Location = new System.Drawing.Point(25, 450);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInserir.OnDisabledState.BorderRadius = 25;
            this.btnInserir.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInserir.OnDisabledState.BorderThickness = 1;
            this.btnInserir.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInserir.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInserir.OnDisabledState.IconLeftImage = null;
            this.btnInserir.OnDisabledState.IconRightImage = null;
            this.btnInserir.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnInserir.onHoverState.BorderRadius = 25;
            this.btnInserir.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInserir.onHoverState.BorderThickness = 1;
            this.btnInserir.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnInserir.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInserir.onHoverState.IconLeftImage = null;
            this.btnInserir.onHoverState.IconRightImage = null;
            this.btnInserir.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnInserir.OnIdleState.BorderRadius = 25;
            this.btnInserir.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInserir.OnIdleState.BorderThickness = 1;
            this.btnInserir.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnInserir.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInserir.OnIdleState.IconLeftImage = null;
            this.btnInserir.OnIdleState.IconRightImage = null;
            this.btnInserir.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInserir.OnPressedState.BorderRadius = 25;
            this.btnInserir.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInserir.OnPressedState.BorderThickness = 1;
            this.btnInserir.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInserir.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInserir.OnPressedState.IconLeftImage = null;
            this.btnInserir.OnPressedState.IconRightImage = null;
            this.btnInserir.Size = new System.Drawing.Size(254, 39);
            this.btnInserir.TabIndex = 84;
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInserir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInserir.TextMarginLeft = 0;
            this.btnInserir.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInserir.UseDefaultRadiusAndThickness = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuLabel5);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.txtPrecoCliente);
            this.groupBox1.Controls.Add(this.bunifuLabel7);
            this.groupBox1.Controls.Add(this.bunifuLabel8);
            this.groupBox1.Controls.Add(this.bunifuPictureBox2);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.bunifuLabel6);
            this.groupBox1.Controls.Add(this.comboPrato);
            this.groupBox1.Controls.Add(this.btnRemoveExtra);
            this.groupBox1.Controls.Add(this.bunifuLabel3);
            this.groupBox1.Controls.Add(this.comboExtrasSelect);
            this.groupBox1.Controls.Add(this.comboTipoCliente);
            this.groupBox1.Controls.Add(this.btnAddExtras);
            this.groupBox1.Controls.Add(this.bunifuLabel4);
            this.groupBox1.Controls.Add(this.comboClientes);
            this.groupBox1.Controls.Add(this.comboExtras);
            this.groupBox1.Controls.Add(this.bunifuLabel13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(491, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 598);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bunifuLabel5.Location = new System.Drawing.Point(269, 324);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(10, 25);
            this.bunifuLabel5.TabIndex = 88;
            this.bunifuLabel5.Text = "€";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AllowParentOverrides = false;
            this.lblSaldo.AutoEllipsis = false;
            this.lblSaldo.CursorType = null;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSaldo.Location = new System.Drawing.Point(153, 31);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSaldo.Size = new System.Drawing.Size(86, 13);
            this.lblSaldo.TabIndex = 87;
            this.lblSaldo.Text = "Saldo do cliente:";
            this.lblSaldo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSaldo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblSaldo.Visible = false;
            // 
            // txtPrecoCliente
            // 
            this.txtPrecoCliente.AcceptsReturn = false;
            this.txtPrecoCliente.AcceptsTab = false;
            this.txtPrecoCliente.AnimationSpeed = 200;
            this.txtPrecoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrecoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrecoCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrecoCliente.BackgroundImage")));
            this.txtPrecoCliente.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPrecoCliente.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPrecoCliente.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPrecoCliente.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPrecoCliente.BorderRadius = 10;
            this.txtPrecoCliente.BorderThickness = 1;
            this.txtPrecoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoCliente.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPrecoCliente.DefaultText = "";
            this.txtPrecoCliente.Enabled = false;
            this.txtPrecoCliente.FillColor = System.Drawing.Color.White;
            this.txtPrecoCliente.HideSelection = true;
            this.txtPrecoCliente.IconLeft = null;
            this.txtPrecoCliente.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoCliente.IconPadding = 10;
            this.txtPrecoCliente.IconRight = null;
            this.txtPrecoCliente.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoCliente.Lines = new string[0];
            this.txtPrecoCliente.Location = new System.Drawing.Point(220, 328);
            this.txtPrecoCliente.MaxLength = 50;
            this.txtPrecoCliente.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPrecoCliente.Modified = false;
            this.txtPrecoCliente.Multiline = false;
            this.txtPrecoCliente.Name = "txtPrecoCliente";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrecoCliente.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPrecoCliente.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrecoCliente.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrecoCliente.OnIdleState = stateProperties8;
            this.txtPrecoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.txtPrecoCliente.PasswordChar = '\0';
            this.txtPrecoCliente.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPrecoCliente.PlaceholderText = "";
            this.txtPrecoCliente.ReadOnly = false;
            this.txtPrecoCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecoCliente.SelectedText = "";
            this.txtPrecoCliente.SelectionLength = 0;
            this.txtPrecoCliente.SelectionStart = 0;
            this.txtPrecoCliente.ShortcutsEnabled = true;
            this.txtPrecoCliente.Size = new System.Drawing.Size(45, 21);
            this.txtPrecoCliente.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPrecoCliente.TabIndex = 86;
            this.txtPrecoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecoCliente.TextMarginBottom = 0;
            this.txtPrecoCliente.TextMarginLeft = 3;
            this.txtPrecoCliente.TextMarginTop = 0;
            this.txtPrecoCliente.TextPlaceholder = "";
            this.txtPrecoCliente.UseSystemPasswordChar = false;
            this.txtPrecoCliente.WordWrap = true;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.bunifuLabel7.Location = new System.Drawing.Point(220, 310);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(59, 12);
            this.bunifuLabel7.TabIndex = 85;
            this.bunifuLabel7.Text = "Preço do menu";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddExtras
            // 
            this.btnAddExtras.AllowAnimations = true;
            this.btnAddExtras.AllowMouseEffects = true;
            this.btnAddExtras.AllowToggling = false;
            this.btnAddExtras.AnimationSpeed = 200;
            this.btnAddExtras.AutoGenerateColors = false;
            this.btnAddExtras.AutoRoundBorders = false;
            this.btnAddExtras.AutoSizeLeftIcon = true;
            this.btnAddExtras.AutoSizeRightIcon = true;
            this.btnAddExtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAddExtras.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAddExtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddExtras.BackgroundImage")));
            this.btnAddExtras.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddExtras.ButtonText = "+";
            this.btnAddExtras.ButtonTextMarginLeft = 0;
            this.btnAddExtras.ColorContrastOnClick = 45;
            this.btnAddExtras.ColorContrastOnHover = 45;
            this.btnAddExtras.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnAddExtras.CustomizableEdges = borderEdges6;
            this.btnAddExtras.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddExtras.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddExtras.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddExtras.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddExtras.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddExtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddExtras.ForeColor = System.Drawing.Color.White;
            this.btnAddExtras.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExtras.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddExtras.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddExtras.IconMarginLeft = 11;
            this.btnAddExtras.IconPadding = 10;
            this.btnAddExtras.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddExtras.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddExtras.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddExtras.IconSize = 25;
            this.btnAddExtras.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddExtras.IdleBorderRadius = 25;
            this.btnAddExtras.IdleBorderThickness = 1;
            this.btnAddExtras.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddExtras.IdleIconLeftImage = null;
            this.btnAddExtras.IdleIconRightImage = null;
            this.btnAddExtras.IndicateFocus = false;
            this.btnAddExtras.Location = new System.Drawing.Point(255, 200);
            this.btnAddExtras.Name = "btnAddExtras";
            this.btnAddExtras.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddExtras.OnDisabledState.BorderRadius = 25;
            this.btnAddExtras.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddExtras.OnDisabledState.BorderThickness = 1;
            this.btnAddExtras.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddExtras.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddExtras.OnDisabledState.IconLeftImage = null;
            this.btnAddExtras.OnDisabledState.IconRightImage = null;
            this.btnAddExtras.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddExtras.onHoverState.BorderRadius = 25;
            this.btnAddExtras.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddExtras.onHoverState.BorderThickness = 1;
            this.btnAddExtras.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddExtras.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddExtras.onHoverState.IconLeftImage = null;
            this.btnAddExtras.onHoverState.IconRightImage = null;
            this.btnAddExtras.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddExtras.OnIdleState.BorderRadius = 25;
            this.btnAddExtras.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddExtras.OnIdleState.BorderThickness = 1;
            this.btnAddExtras.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddExtras.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddExtras.OnIdleState.IconLeftImage = null;
            this.btnAddExtras.OnIdleState.IconRightImage = null;
            this.btnAddExtras.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddExtras.OnPressedState.BorderRadius = 25;
            this.btnAddExtras.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddExtras.OnPressedState.BorderThickness = 1;
            this.btnAddExtras.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddExtras.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddExtras.OnPressedState.IconLeftImage = null;
            this.btnAddExtras.OnPressedState.IconRightImage = null;
            this.btnAddExtras.Size = new System.Drawing.Size(31, 28);
            this.btnAddExtras.TabIndex = 80;
            this.btnAddExtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddExtras.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddExtras.TextMarginLeft = 0;
            this.btnAddExtras.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddExtras.UseDefaultRadiusAndThickness = true;
            this.btnAddExtras.Click += new System.EventHandler(this.btnAddExtras_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservas";
            this.Activated += new System.EventHandler(this.HomeForm_Activated);
            this.Load += new System.EventHandler(this.ReservasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.ComboBox comboPrato;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private System.Windows.Forms.ComboBox comboTipoCliente;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.ComboBox comboClientes;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRemoveExtra;
        private System.Windows.Forms.ComboBox comboExtrasSelect;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private System.Windows.Forms.ComboBox comboExtras;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInserir;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtPrecoCliente;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel lblSaldo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddExtras;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
    }
}