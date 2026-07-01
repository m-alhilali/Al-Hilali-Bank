namespace Al_Hilali_Bank
{
    partial class frmUpdateORAddNewClient
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtmbiker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignIN = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.tbAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbBalance = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmGender
            // 
            this.cmGender.BackColor = System.Drawing.Color.Transparent;
            this.cmGender.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmGender.BorderRadius = 15;
            this.cmGender.BorderThickness = 3;
            this.cmGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmGender.ItemHeight = 30;
            this.cmGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmGender.Location = new System.Drawing.Point(182, 609);
            this.cmGender.Name = "cmGender";
            this.cmGender.Size = new System.Drawing.Size(126, 36);
            this.cmGender.StartIndex = 0;
            this.cmGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmGender.TabIndex = 31;
            // 
            // dtmbiker
            // 
            this.dtmbiker.BackColor = System.Drawing.Color.Transparent;
            this.dtmbiker.BorderColor = System.Drawing.Color.RoyalBlue;
            this.dtmbiker.BorderRadius = 15;
            this.dtmbiker.BorderThickness = 3;
            this.dtmbiker.Checked = true;
            this.dtmbiker.FillColor = System.Drawing.Color.White;
            this.dtmbiker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmbiker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmbiker.Location = new System.Drawing.Point(182, 552);
            this.dtmbiker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmbiker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmbiker.Name = "dtmbiker";
            this.dtmbiker.Size = new System.Drawing.Size(308, 45);
            this.dtmbiker.TabIndex = 30;
            this.dtmbiker.Value = new System.DateTime(2026, 6, 20, 23, 56, 15, 144);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.MistyRose;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(280, 666);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(132, 46);
            this.guna2Button1.TabIndex = 37;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btnSignIN
            // 
            this.btnSignIN.Animated = true;
            this.btnSignIN.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIN.BorderColor = System.Drawing.Color.MistyRose;
            this.btnSignIN.BorderRadius = 20;
            this.btnSignIN.BorderThickness = 2;
            this.btnSignIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIN.FillColor = System.Drawing.Color.Navy;
            this.btnSignIN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignIN.ForeColor = System.Drawing.Color.White;
            this.btnSignIN.Location = new System.Drawing.Point(430, 666);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(132, 46);
            this.btnSignIN.TabIndex = 36;
            this.btnSignIN.Text = "Register";
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(26, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Gender : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(26, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "BirthDate : ";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.Transparent;
            this.tbPhone.BorderColor = System.Drawing.Color.DarkBlue;
            this.tbPhone.BorderRadius = 12;
            this.tbPhone.BorderThickness = 2;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FillColor = System.Drawing.SystemColors.Window;
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPhone.ForeColor = System.Drawing.Color.Black;
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(31, 385);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPhone.PlaceholderText = "Phone";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(496, 45);
            this.tbPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPhone.TabIndex = 29;
            this.tbPhone.TextOffset = new System.Drawing.Point(25, 0);
            this.tbPhone.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.BorderColor = System.Drawing.Color.DarkBlue;
            this.tbEmail.BorderRadius = 12;
            this.tbEmail.BorderThickness = 2;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FillColor = System.Drawing.SystemColors.Window;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(31, 321);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(496, 45);
            this.tbEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbEmail.TabIndex = 27;
            this.tbEmail.TextOffset = new System.Drawing.Point(25, 0);
            this.tbEmail.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(37, 271);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 32);
            this.iconPictureBox2.TabIndex = 33;
            this.iconPictureBox2.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderColor = System.Drawing.Color.DarkBlue;
            this.tbPassword.BorderRadius = 12;
            this.tbPassword.BorderThickness = 2;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FillColor = System.Drawing.SystemColors.Window;
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(31, 262);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Passwoed";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(496, 45);
            this.tbPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPassword.TabIndex = 25;
            this.tbPassword.TextOffset = new System.Drawing.Point(25, 0);
            this.tbPassword.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.At;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(37, 211);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 32);
            this.iconPictureBox1.TabIndex = 32;
            this.iconPictureBox1.TabStop = false;
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.tbAccountNumber.BorderColor = System.Drawing.Color.Navy;
            this.tbAccountNumber.BorderRadius = 12;
            this.tbAccountNumber.BorderThickness = 2;
            this.tbAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAccountNumber.DefaultText = "";
            this.tbAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAccountNumber.FillColor = System.Drawing.SystemColors.Window;
            this.tbAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.tbAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAccountNumber.Location = new System.Drawing.Point(31, 202);
            this.tbAccountNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbAccountNumber.PlaceholderText = "AccountNumber";
            this.tbAccountNumber.SelectedText = "";
            this.tbAccountNumber.Size = new System.Drawing.Size(496, 45);
            this.tbAccountNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbAccountNumber.TabIndex = 24;
            this.tbAccountNumber.TextOffset = new System.Drawing.Point(25, 0);
            this.tbAccountNumber.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.Transparent;
            this.tbLastName.BorderColor = System.Drawing.Color.DarkBlue;
            this.tbLastName.BorderRadius = 12;
            this.tbLastName.BorderThickness = 2;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FillColor = System.Drawing.SystemColors.Window;
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbLastName.ForeColor = System.Drawing.Color.Black;
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Location = new System.Drawing.Point(331, 135);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbLastName.PlaceholderText = "LastName";
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(196, 45);
            this.tbLastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbLastName.TabIndex = 23;
            this.tbLastName.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitle.Location = new System.Drawing.Point(0, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(576, 56);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Add New client";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 56);
            this.label1.TabIndex = 26;
            this.label1.Text = "Al-Hilali Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.tbFirstName.BorderColor = System.Drawing.Color.DarkBlue;
            this.tbFirstName.BorderRadius = 12;
            this.tbFirstName.BorderThickness = 2;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FillColor = System.Drawing.SystemColors.Window;
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Location = new System.Drawing.Point(31, 135);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbFirstName.PlaceholderText = "FirstName";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(196, 45);
            this.tbFirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbFirstName.TabIndex = 22;
            this.tbFirstName.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // tbPinCode
            // 
            this.tbPinCode.BackColor = System.Drawing.Color.Transparent;
            this.tbPinCode.BorderColor = System.Drawing.Color.DarkBlue;
            this.tbPinCode.BorderRadius = 12;
            this.tbPinCode.BorderThickness = 2;
            this.tbPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPinCode.DefaultText = "";
            this.tbPinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPinCode.FillColor = System.Drawing.SystemColors.Window;
            this.tbPinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPinCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPinCode.ForeColor = System.Drawing.Color.Black;
            this.tbPinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPinCode.Location = new System.Drawing.Point(31, 442);
            this.tbPinCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPinCode.Name = "tbPinCode";
            this.tbPinCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPinCode.PlaceholderText = "PinCode";
            this.tbPinCode.SelectedText = "";
            this.tbPinCode.Size = new System.Drawing.Size(196, 45);
            this.tbPinCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPinCode.TabIndex = 39;
            this.tbPinCode.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cbStatus.BorderRadius = 15;
            this.cbStatus.BorderThickness = 3;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbStatus.Location = new System.Drawing.Point(182, 504);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(126, 36);
            this.cbStatus.StartIndex = 0;
            this.cbStatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbStatus.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(26, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "AccStatus : ";
            // 
            // mtbBalance
            // 
            this.mtbBalance.Location = new System.Drawing.Point(383, 442);
            this.mtbBalance.Mask = "00000000";
            this.mtbBalance.Name = "mtbBalance";
            this.mtbBalance.Size = new System.Drawing.Size(144, 36);
            this.mtbBalance.TabIndex = 42;
            this.mtbBalance.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbBalance.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(248, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "Balance : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.White;
            this.iconPictureBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 29;
            this.iconPictureBox4.Location = new System.Drawing.Point(37, 395);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox4.TabIndex = 72;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 29;
            this.iconPictureBox3.Location = new System.Drawing.Point(37, 331);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(29, 29);
            this.iconPictureBox3.TabIndex = 73;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Transgender;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 35;
            this.iconPictureBox5.Location = new System.Drawing.Point(141, 610);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox5.TabIndex = 77;
            this.iconPictureBox5.TabStop = false;
            // 
            // frmUpdateORAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 732);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbPinCode);
            this.Controls.Add(this.cmGender);
            this.Controls.Add(this.dtmbiker);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateORAddNewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewClient";
            this.Load += new System.EventHandler(this.frmAddNewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ComboBox cmGender;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmbiker;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnSignIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2TextBox tbPinCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbBalance;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}