namespace Al_Hilali_Bank
{
    partial class frmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOldValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOldValue = new System.Windows.Forms.Label();
            this.tbNewValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignIN = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubTypeChange = new System.Windows.Forms.Label();
            this.lblTypeChange = new System.Windows.Forms.Label();
            this.iconChangeSuccess = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconChangeSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbOldValue
            // 
            this.tbOldValue.BorderColor = System.Drawing.Color.Navy;
            this.tbOldValue.BorderRadius = 9;
            this.tbOldValue.BorderThickness = 2;
            this.tbOldValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldValue.DefaultText = "";
            this.tbOldValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOldValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOldValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOldValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbOldValue.ForeColor = System.Drawing.Color.Black;
            this.tbOldValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOldValue.Location = new System.Drawing.Point(103, 98);
            this.tbOldValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOldValue.Name = "tbOldValue";
            this.tbOldValue.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbOldValue.PlaceholderText = "Old Password";
            this.tbOldValue.SelectedText = "";
            this.tbOldValue.Size = new System.Drawing.Size(250, 49);
            this.tbOldValue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbOldValue.TabIndex = 95;
            // 
            // lblOldValue
            // 
            this.lblOldValue.AutoSize = true;
            this.lblOldValue.Location = new System.Drawing.Point(137, 64);
            this.lblOldValue.Name = "lblOldValue";
            this.lblOldValue.Size = new System.Drawing.Size(157, 29);
            this.lblOldValue.TabIndex = 96;
            this.lblOldValue.Text = "Old Password";
            // 
            // tbNewValue
            // 
            this.tbNewValue.BorderColor = System.Drawing.Color.Navy;
            this.tbNewValue.BorderRadius = 9;
            this.tbNewValue.BorderThickness = 2;
            this.tbNewValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewValue.DefaultText = "";
            this.tbNewValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNewValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNewValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNewValue.ForeColor = System.Drawing.Color.Black;
            this.tbNewValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewValue.Location = new System.Drawing.Point(103, 201);
            this.tbNewValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbNewValue.PlaceholderText = "New Password";
            this.tbNewValue.SelectedText = "";
            this.tbNewValue.Size = new System.Drawing.Size(250, 49);
            this.tbNewValue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbNewValue.TabIndex = 97;
            // 
            // lblNewValue
            // 
            this.lblNewValue.AutoSize = true;
            this.lblNewValue.Location = new System.Drawing.Point(130, 167);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(169, 29);
            this.lblNewValue.TabIndex = 98;
            this.lblNewValue.Text = "New Password";
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
            this.guna2Button1.Location = new System.Drawing.Point(151, 266);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(132, 46);
            this.guna2Button1.TabIndex = 100;
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
            this.btnSignIN.Location = new System.Drawing.Point(301, 266);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(132, 46);
            this.btnSignIN.TabIndex = 99;
            this.btnSignIN.Text = "Change";
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // lblSubTypeChange
            // 
            this.lblSubTypeChange.AutoSize = true;
            this.lblSubTypeChange.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblSubTypeChange.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubTypeChange.Location = new System.Drawing.Point(89, 353);
            this.lblSubTypeChange.Name = "lblSubTypeChange";
            this.lblSubTypeChange.Size = new System.Drawing.Size(0, 27);
            this.lblSubTypeChange.TabIndex = 103;
            // 
            // lblTypeChange
            // 
            this.lblTypeChange.AutoSize = true;
            this.lblTypeChange.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeChange.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTypeChange.Location = new System.Drawing.Point(89, 326);
            this.lblTypeChange.Name = "lblTypeChange";
            this.lblTypeChange.Size = new System.Drawing.Size(0, 27);
            this.lblTypeChange.TabIndex = 102;
            // 
            // iconChangeSuccess
            // 
            this.iconChangeSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.iconChangeSuccess.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconChangeSuccess.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconChangeSuccess.IconColor = System.Drawing.Color.DarkGreen;
            this.iconChangeSuccess.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChangeSuccess.IconSize = 62;
            this.iconChangeSuccess.Location = new System.Drawing.Point(12, 326);
            this.iconChangeSuccess.Name = "iconChangeSuccess";
            this.iconChangeSuccess.Size = new System.Drawing.Size(71, 62);
            this.iconChangeSuccess.TabIndex = 101;
            this.iconChangeSuccess.TabStop = false;
            this.iconChangeSuccess.Visible = false;
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnSignIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.guna2Button1;
            this.ClientSize = new System.Drawing.Size(445, 402);
            this.Controls.Add(this.lblSubTypeChange);
            this.Controls.Add(this.lblTypeChange);
            this.Controls.Add(this.iconChangeSuccess);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.lblNewValue);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.lblOldValue);
            this.Controls.Add(this.tbOldValue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconChangeSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbOldValue;
        private System.Windows.Forms.Label lblOldValue;
        private Guna.UI2.WinForms.Guna2TextBox tbNewValue;
        private System.Windows.Forms.Label lblNewValue;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnSignIN;
        private System.Windows.Forms.Label lblSubTypeChange;
        private System.Windows.Forms.Label lblTypeChange;
        private FontAwesome.Sharp.IconPictureBox iconChangeSuccess;
    }
}