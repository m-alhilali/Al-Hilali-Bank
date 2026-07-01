namespace Al_Hilali_Bank
{
    partial class frmUpdateRate
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.tbLastDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCurrentExchange = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cbSelectCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudNewRate = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCurrencyCode = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRate)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.MistyRose;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(273, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 46);
            this.btnCancel.TabIndex = 92;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.MistyRose;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Navy;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(430, 430);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 46);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // tbLastDate
            // 
            this.tbLastDate.BackColor = System.Drawing.Color.Transparent;
            this.tbLastDate.BorderColor = System.Drawing.Color.Navy;
            this.tbLastDate.BorderRadius = 12;
            this.tbLastDate.BorderThickness = 2;
            this.tbLastDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastDate.DefaultText = "";
            this.tbLastDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastDate.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbLastDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbLastDate.ForeColor = System.Drawing.Color.Black;
            this.tbLastDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastDate.Location = new System.Drawing.Point(227, 319);
            this.tbLastDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbLastDate.Name = "tbLastDate";
            this.tbLastDate.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbLastDate.PlaceholderText = "Date";
            this.tbLastDate.ReadOnly = true;
            this.tbLastDate.SelectedText = "";
            this.tbLastDate.Size = new System.Drawing.Size(306, 45);
            this.tbLastDate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbLastDate.TabIndex = 84;
            // 
            // tbLastUser
            // 
            this.tbLastUser.BackColor = System.Drawing.Color.Transparent;
            this.tbLastUser.BorderColor = System.Drawing.Color.Navy;
            this.tbLastUser.BorderRadius = 12;
            this.tbLastUser.BorderThickness = 2;
            this.tbLastUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastUser.DefaultText = "";
            this.tbLastUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastUser.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbLastUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbLastUser.ForeColor = System.Drawing.Color.Black;
            this.tbLastUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastUser.Location = new System.Drawing.Point(227, 262);
            this.tbLastUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbLastUser.Name = "tbLastUser";
            this.tbLastUser.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbLastUser.PlaceholderText = "User";
            this.tbLastUser.ReadOnly = true;
            this.tbLastUser.SelectedText = "";
            this.tbLastUser.Size = new System.Drawing.Size(306, 45);
            this.tbLastUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbLastUser.TabIndex = 82;
            // 
            // tbCurrentExchange
            // 
            this.tbCurrentExchange.BackColor = System.Drawing.Color.Transparent;
            this.tbCurrentExchange.BorderColor = System.Drawing.Color.Navy;
            this.tbCurrentExchange.BorderRadius = 12;
            this.tbCurrentExchange.BorderThickness = 2;
            this.tbCurrentExchange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentExchange.DefaultText = "";
            this.tbCurrentExchange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCurrentExchange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCurrentExchange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrentExchange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrentExchange.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbCurrentExchange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentExchange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbCurrentExchange.ForeColor = System.Drawing.Color.Black;
            this.tbCurrentExchange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentExchange.Location = new System.Drawing.Point(227, 205);
            this.tbCurrentExchange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbCurrentExchange.Name = "tbCurrentExchange";
            this.tbCurrentExchange.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbCurrentExchange.PlaceholderText = "Cuurent Excange";
            this.tbCurrentExchange.ReadOnly = true;
            this.tbCurrentExchange.SelectedText = "";
            this.tbCurrentExchange.Size = new System.Drawing.Size(306, 45);
            this.tbCurrentExchange.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbCurrentExchange.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 72);
            this.label2.TabIndex = 83;
            this.label2.Text = "Update Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 12;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.PaleTurquoise;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Purple;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(574, 72);
            this.guna2CustomGradientPanel1.TabIndex = 93;
            // 
            // cbSelectCountries
            // 
            this.cbSelectCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbSelectCountries.BorderColor = System.Drawing.Color.Navy;
            this.cbSelectCountries.BorderRadius = 10;
            this.cbSelectCountries.BorderThickness = 2;
            this.cbSelectCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelectCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectCountries.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbSelectCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelectCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelectCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSelectCountries.ForeColor = System.Drawing.Color.Black;
            this.cbSelectCountries.ItemHeight = 30;
            this.cbSelectCountries.Location = new System.Drawing.Point(227, 100);
            this.cbSelectCountries.Name = "cbSelectCountries";
            this.cbSelectCountries.Size = new System.Drawing.Size(306, 36);
            this.cbSelectCountries.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbSelectCountries.TabIndex = 94;
            this.cbSelectCountries.SelectedIndexChanged += new System.EventHandler(this.cbSelectCountries_SelectedIndexChanged);
            // 
            // nudNewRate
            // 
            this.nudNewRate.BackColor = System.Drawing.Color.Transparent;
            this.nudNewRate.BorderColor = System.Drawing.Color.Navy;
            this.nudNewRate.BorderRadius = 10;
            this.nudNewRate.BorderThickness = 2;
            this.nudNewRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNewRate.DecimalPlaces = 10;
            this.nudNewRate.FillColor = System.Drawing.Color.Empty;
            this.nudNewRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudNewRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudNewRate.Location = new System.Drawing.Point(227, 376);
            this.nudNewRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNewRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNewRate.Name = "nudNewRate";
            this.nudNewRate.Size = new System.Drawing.Size(304, 39);
            this.nudNewRate.TabIndex = 95;
            this.nudNewRate.ThousandsSeparator = true;
            this.nudNewRate.UpDownButtonFillColor = System.Drawing.Color.Navy;
            this.nudNewRate.UpDownButtonForeColor = System.Drawing.SystemColors.Control;
            this.nudNewRate.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 96;
            this.label1.Text = "Select Country : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 26);
            this.label3.TabIndex = 97;
            this.label3.Text = "Current Exchange : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 26);
            this.label4.TabIndex = 98;
            this.label4.Text = "Last Update By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(2, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 26);
            this.label5.TabIndex = 99;
            this.label5.Text = "Update Date :  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(2, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 26);
            this.label6.TabIndex = 100;
            this.label6.Text = "New Exchange Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(2, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 26);
            this.label7.TabIndex = 102;
            this.label7.Text = "Cuurency Code : ";
            // 
            // tbCurrencyCode
            // 
            this.tbCurrencyCode.BackColor = System.Drawing.Color.Transparent;
            this.tbCurrencyCode.BorderColor = System.Drawing.Color.Navy;
            this.tbCurrencyCode.BorderRadius = 12;
            this.tbCurrencyCode.BorderThickness = 2;
            this.tbCurrencyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrencyCode.DefaultText = "";
            this.tbCurrencyCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCurrencyCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCurrencyCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrencyCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrencyCode.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbCurrencyCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrencyCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbCurrencyCode.ForeColor = System.Drawing.Color.Black;
            this.tbCurrencyCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrencyCode.Location = new System.Drawing.Point(227, 148);
            this.tbCurrencyCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbCurrencyCode.Name = "tbCurrencyCode";
            this.tbCurrencyCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbCurrencyCode.PlaceholderText = "CurrencyCode";
            this.tbCurrencyCode.ReadOnly = true;
            this.tbCurrencyCode.SelectedText = "";
            this.tbCurrencyCode.Size = new System.Drawing.Size(306, 45);
            this.tbCurrencyCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbCurrencyCode.TabIndex = 101;
            // 
            // frmUpdateRate
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(574, 479);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCurrencyCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNewRate);
            this.Controls.Add(this.cbSelectCountries);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbLastDate);
            this.Controls.Add(this.tbLastUser);
            this.Controls.Add(this.tbCurrentExchange);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateRate";
            this.Load += new System.EventHandler(this.frmUpdateRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox tbLastDate;
        private Guna.UI2.WinForms.Guna2TextBox tbLastUser;
        private Guna.UI2.WinForms.Guna2TextBox tbCurrentExchange;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSelectCountries;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNewRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbCurrencyCode;
    }
}