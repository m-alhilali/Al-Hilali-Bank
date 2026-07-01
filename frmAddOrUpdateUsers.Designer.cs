namespace Al_Hilali_Bank
{
    partial class frmAddOrUpdateUsers
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtmbiker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignIN = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnaddPermissions = new Guna.UI2.WinForms.Guna2Button();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconUserPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.iconDeletePhoto = new FontAwesome.Sharp.IconButton();
            this.iconAddPhoto = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(32, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 63;
            this.label5.Text = "AccStatus : ";
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
            this.cbStatus.Location = new System.Drawing.Point(192, 513);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(126, 36);
            this.cbStatus.StartIndex = 0;
            this.cbStatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbStatus.TabIndex = 62;
            this.cbStatus.TextChanged += new System.EventHandler(this.ReserErrorProvider);
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
            this.cmGender.Location = new System.Drawing.Point(182, 613);
            this.cmGender.Name = "cmGender";
            this.cmGender.Size = new System.Drawing.Size(126, 36);
            this.cmGender.StartIndex = 0;
            this.cmGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmGender.TabIndex = 53;
            this.cmGender.TextChanged += new System.EventHandler(this.ReserErrorProvider);
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
            this.dtmbiker.Location = new System.Drawing.Point(182, 562);
            this.dtmbiker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmbiker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmbiker.Name = "dtmbiker";
            this.dtmbiker.Size = new System.Drawing.Size(345, 45);
            this.dtmbiker.TabIndex = 52;
            this.dtmbiker.Value = new System.DateTime(2026, 6, 20, 23, 56, 15, 144);
            this.dtmbiker.TextChanged += new System.EventHandler(this.ReserErrorProvider);
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
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(280, 676);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(132, 46);
            this.guna2Button1.TabIndex = 59;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnSignIN.Location = new System.Drawing.Point(430, 676);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(132, 46);
            this.btnSignIN.TabIndex = 58;
            this.btnSignIN.Text = "Register";
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 57;
            this.label4.Text = "Gender : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 56;
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
            this.tbPhone.Location = new System.Drawing.Point(31, 416);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPhone.PlaceholderText = "Phone";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(496, 45);
            this.tbPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPhone.TabIndex = 51;
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
            this.tbEmail.Location = new System.Drawing.Point(31, 359);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(496, 45);
            this.tbEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbEmail.TabIndex = 49;
            this.tbEmail.TextOffset = new System.Drawing.Point(25, 0);
            this.tbEmail.TextChanged += new System.EventHandler(this.ReserErrorProvider);
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
            this.tbPassword.Location = new System.Drawing.Point(31, 304);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Passwoed";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(496, 45);
            this.tbPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPassword.TabIndex = 47;
            this.tbPassword.TextOffset = new System.Drawing.Point(25, 0);
            this.tbPassword.TextChanged += new System.EventHandler(this.ReserErrorProvider);
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
            this.tbLastName.Location = new System.Drawing.Point(31, 197);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbLastName.PlaceholderText = "LastName";
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(295, 45);
            this.tbLastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbLastName.TabIndex = 45;
            this.tbLastName.TextChanged += new System.EventHandler(this.ReserErrorProvider);
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
            this.tbFirstName.Location = new System.Drawing.Point(31, 142);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbFirstName.PlaceholderText = "FirstName";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(295, 45);
            this.tbFirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbFirstName.TabIndex = 44;
            this.tbFirstName.TextChanged += new System.EventHandler(this.ReserErrorProvider);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbUserName.BorderColor = System.Drawing.Color.DarkBlue;
            this.tbUserName.BorderRadius = 12;
            this.tbUserName.BorderThickness = 2;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FillColor = System.Drawing.SystemColors.Window;
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbUserName.ForeColor = System.Drawing.Color.Black;
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Location = new System.Drawing.Point(31, 250);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbUserName.PlaceholderText = "UserName";
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(496, 45);
            this.tbUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbUserName.TabIndex = 46;
            this.tbUserName.TextOffset = new System.Drawing.Point(25, 0);
            this.tbUserName.TextChanged += new System.EventHandler(this.ReserErrorProvider);
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
            this.label1.TabIndex = 66;
            this.label1.Text = "Al-Hilali Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "Add New Users";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click_1);
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
            this.iconPictureBox2.Location = new System.Drawing.Point(37, 314);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 32);
            this.iconPictureBox2.TabIndex = 55;
            this.iconPictureBox2.TabStop = false;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(37, 259);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 31);
            this.iconPictureBox1.TabIndex = 54;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnaddPermissions
            // 
            this.btnaddPermissions.BorderRadius = 8;
            this.btnaddPermissions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddPermissions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddPermissions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddPermissions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddPermissions.FillColor = System.Drawing.Color.Navy;
            this.btnaddPermissions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddPermissions.ForeColor = System.Drawing.Color.White;
            this.btnaddPermissions.Location = new System.Drawing.Point(31, 473);
            this.btnaddPermissions.Name = "btnaddPermissions";
            this.btnaddPermissions.Size = new System.Drawing.Size(496, 34);
            this.btnaddPermissions.TabIndex = 69;
            this.btnaddPermissions.Text = "Add Permissions ";
            this.btnaddPermissions.Click += new System.EventHandler(this.btnaddPermissions_Click);
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
            this.iconPictureBox3.Location = new System.Drawing.Point(37, 370);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox3.TabIndex = 70;
            this.iconPictureBox3.TabStop = false;
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
            this.iconPictureBox4.Location = new System.Drawing.Point(37, 425);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox4.TabIndex = 71;
            this.iconPictureBox4.TabStop = false;
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
            this.iconPictureBox5.Location = new System.Drawing.Point(147, 614);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox5.TabIndex = 78;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconUserPhoto
            // 
            this.iconUserPhoto.ErrorImage = global::Al_Hilali_Bank.Properties.Resources.a282728431fcf05e2b1102f8da9370c1;
            this.iconUserPhoto.ImageRotate = 0F;
            this.iconUserPhoto.InitialImage = global::Al_Hilali_Bank.Properties.Resources.a282728431fcf05e2b1102f8da9370c1;
            this.iconUserPhoto.Location = new System.Drawing.Point(352, 115);
            this.iconUserPhoto.Name = "iconUserPhoto";
            this.iconUserPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.iconUserPhoto.Size = new System.Drawing.Size(138, 130);
            this.iconUserPhoto.TabIndex = 86;
            this.iconUserPhoto.TabStop = false;
            // 
            // iconDeletePhoto
            // 
            this.iconDeletePhoto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconDeletePhoto.IconColor = System.Drawing.Color.Red;
            this.iconDeletePhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDeletePhoto.IconSize = 30;
            this.iconDeletePhoto.Location = new System.Drawing.Point(496, 181);
            this.iconDeletePhoto.Name = "iconDeletePhoto";
            this.iconDeletePhoto.Size = new System.Drawing.Size(35, 32);
            this.iconDeletePhoto.TabIndex = 85;
            this.iconDeletePhoto.UseVisualStyleBackColor = true;
            this.iconDeletePhoto.Click += new System.EventHandler(this.iconDeletePhoto_Click);
            // 
            // iconAddPhoto
            // 
            this.iconAddPhoto.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconAddPhoto.IconColor = System.Drawing.Color.Green;
            this.iconAddPhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddPhoto.IconSize = 30;
            this.iconAddPhoto.Location = new System.Drawing.Point(496, 213);
            this.iconAddPhoto.Name = "iconAddPhoto";
            this.iconAddPhoto.Size = new System.Drawing.Size(35, 32);
            this.iconAddPhoto.TabIndex = 84;
            this.iconAddPhoto.UseVisualStyleBackColor = true;
            this.iconAddPhoto.Click += new System.EventHandler(this.iconAddPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddOrUpdateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 732);
            this.Controls.Add(this.iconUserPhoto);
            this.Controls.Add(this.iconDeletePhoto);
            this.Controls.Add(this.iconAddPhoto);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.btnaddPermissions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbStatus);
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
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddOrUpdateUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrUpdateUsers";
            this.Load += new System.EventHandler(this.frmAddOrUpdateUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
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
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnaddPermissions;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox iconUserPhoto;
        private FontAwesome.Sharp.IconButton iconDeletePhoto;
        private FontAwesome.Sharp.IconButton iconAddPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}