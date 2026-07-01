namespace Al_Hilali_Bank
{
    partial class frmDepositWithdraw
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
            this.lblTransactionTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn100 = new Guna.UI2.WinForms.Guna2Button();
            this.btn200 = new Guna.UI2.WinForms.Guna2Button();
            this.btn500 = new Guna.UI2.WinForms.Guna2Button();
            this.btn1000 = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.cbClients = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconbtnBack = new FontAwesome.Sharp.IconButton();
            this.cbAccountNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconDoneSuccessOperator = new FontAwesome.Sharp.IconPictureBox();
            this.lblDoneSeccessOperator = new System.Windows.Forms.Label();
            this.lblSubDoneSeccessOperator = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDoneSuccessOperator)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransactionTitle
            // 
            this.lblTransactionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransactionTitle.Font = new System.Drawing.Font("Arial Black", 17F, System.Drawing.FontStyle.Bold);
            this.lblTransactionTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTransactionTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTransactionTitle.Name = "lblTransactionTitle";
            this.lblTransactionTitle.Size = new System.Drawing.Size(643, 55);
            this.lblTransactionTitle.TabIndex = 68;
            this.lblTransactionTitle.Text = "Deposit Money";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubTitle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubTitle.Location = new System.Drawing.Point(0, 55);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(275, 27);
            this.lblSubTitle.TabIndex = 69;
            this.lblSubTitle.Text = "Add funds to your Account ";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblTotalBalance);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel1);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(17, 200);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(609, 97);
            this.guna2ShadowPanel1.TabIndex = 70;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalBalance.Location = new System.Drawing.Point(119, 38);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(46, 27);
            this.lblTotalBalance.TabIndex = 72;
            this.lblTotalBalance.Text = "$ 0";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.iconPictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.guna2Panel1.Location = new System.Drawing.Point(18, 24);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(80, 53);
            this.guna2Panel1.TabIndex = 71;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 47;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(59, 47);
            this.iconPictureBox1.TabIndex = 71;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(119, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 71;
            this.label1.Text = "Total Balance";
            // 
            // tbAmount
            // 
            this.tbAmount.BorderRadius = 12;
            this.tbAmount.BorderThickness = 0;
            this.tbAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmount.DefaultText = "";
            this.tbAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmount.FillColor = System.Drawing.Color.Silver;
            this.tbAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbAmount.ForeColor = System.Drawing.Color.Black;
            this.tbAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmount.IconLeft = global::Al_Hilali_Bank.Properties.Resources.Deposit;
            this.tbAmount.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tbAmount.Location = new System.Drawing.Point(17, 365);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbAmount.PlaceholderText = "0";
            this.tbAmount.SelectedText = "";
            this.tbAmount.Size = new System.Drawing.Size(609, 58);
            this.tbAmount.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 73;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 27);
            this.label4.TabIndex = 74;
            this.label4.Text = "Quick Amount";
            // 
            // btn100
            // 
            this.btn100.BorderRadius = 10;
            this.btn100.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn100.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn100.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn100.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn100.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn100.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.ForeColor = System.Drawing.Color.Green;
            this.btn100.Location = new System.Drawing.Point(36, 512);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(98, 45);
            this.btn100.TabIndex = 75;
            this.btn100.Tag = "100";
            this.btn100.Text = "100";
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.BorderRadius = 10;
            this.btn200.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn200.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn200.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn200.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn200.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btn200.ForeColor = System.Drawing.Color.White;
            this.btn200.Location = new System.Drawing.Point(185, 512);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(108, 45);
            this.btn200.TabIndex = 76;
            this.btn200.Tag = "200";
            this.btn200.Text = "200";
            this.btn200.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn500
            // 
            this.btn500.BorderRadius = 10;
            this.btn500.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn500.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn500.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn500.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn500.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btn500.ForeColor = System.Drawing.Color.White;
            this.btn500.Location = new System.Drawing.Point(344, 512);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(107, 45);
            this.btn500.TabIndex = 77;
            this.btn500.Tag = "500";
            this.btn500.Text = "500";
            this.btn500.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn1000
            // 
            this.btn1000.BorderRadius = 10;
            this.btn1000.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1000.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1000.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1000.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1000.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btn1000.ForeColor = System.Drawing.Color.White;
            this.btn1000.Location = new System.Drawing.Point(502, 512);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(123, 45);
            this.btn1000.TabIndex = 78;
            this.btn1000.Tag = "1000";
            this.btn1000.Text = "1000";
            this.btn1000.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 8;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.Green;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(40, 614);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(571, 49);
            this.btnConfirm.TabIndex = 79;
            this.btnConfirm.Text = "Confirm Deposit";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cbClients
            // 
            this.cbClients.BackColor = System.Drawing.Color.Transparent;
            this.cbClients.BorderColor = System.Drawing.Color.Navy;
            this.cbClients.BorderRadius = 8;
            this.cbClients.BorderThickness = 2;
            this.cbClients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbClients.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbClients.ItemHeight = 30;
            this.cbClients.Location = new System.Drawing.Point(17, 151);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(410, 36);
            this.cbClients.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbClients.TabIndex = 80;
            this.cbClients.TextOffset = new System.Drawing.Point(32, 0);
            this.cbClients.SelectedIndexChanged += new System.EventHandler(this.cbClients_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(136, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 27);
            this.label5.TabIndex = 81;
            this.label5.Text = "Choose Client";
            // 
            // iconbtnBack
            // 
            this.iconbtnBack.BackColor = System.Drawing.SystemColors.Menu;
            this.iconbtnBack.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iconbtnBack.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.iconbtnBack.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnBack.IconSize = 40;
            this.iconbtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnBack.Location = new System.Drawing.Point(576, 8);
            this.iconbtnBack.Name = "iconbtnBack";
            this.iconbtnBack.Size = new System.Drawing.Size(55, 41);
            this.iconbtnBack.TabIndex = 82;
            this.iconbtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnBack.UseVisualStyleBackColor = false;
            this.iconbtnBack.Click += new System.EventHandler(this.iconbtnBack_Click);
            // 
            // cbAccountNumber
            // 
            this.cbAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.cbAccountNumber.BorderColor = System.Drawing.Color.Navy;
            this.cbAccountNumber.BorderRadius = 8;
            this.cbAccountNumber.BorderThickness = 2;
            this.cbAccountNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAccountNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountNumber.Enabled = false;
            this.cbAccountNumber.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAccountNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAccountNumber.ItemHeight = 30;
            this.cbAccountNumber.Location = new System.Drawing.Point(433, 151);
            this.cbAccountNumber.Name = "cbAccountNumber";
            this.cbAccountNumber.Size = new System.Drawing.Size(192, 36);
            this.cbAccountNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbAccountNumber.TabIndex = 83;
            this.cbAccountNumber.TextOffset = new System.Drawing.Point(32, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(449, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.TabIndex = 84;
            this.label2.Text = "Account Number";
            // 
            // iconDoneSuccessOperator
            // 
            this.iconDoneSuccessOperator.BackColor = System.Drawing.SystemColors.Control;
            this.iconDoneSuccessOperator.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconDoneSuccessOperator.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconDoneSuccessOperator.IconColor = System.Drawing.Color.DarkGreen;
            this.iconDoneSuccessOperator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDoneSuccessOperator.IconSize = 62;
            this.iconDoneSuccessOperator.Location = new System.Drawing.Point(17, 676);
            this.iconDoneSuccessOperator.Name = "iconDoneSuccessOperator";
            this.iconDoneSuccessOperator.Size = new System.Drawing.Size(71, 62);
            this.iconDoneSuccessOperator.TabIndex = 85;
            this.iconDoneSuccessOperator.TabStop = false;
            this.iconDoneSuccessOperator.Visible = false;
            // 
            // lblDoneSeccessOperator
            // 
            this.lblDoneSeccessOperator.AutoSize = true;
            this.lblDoneSeccessOperator.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoneSeccessOperator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDoneSeccessOperator.Location = new System.Drawing.Point(94, 676);
            this.lblDoneSeccessOperator.Name = "lblDoneSeccessOperator";
            this.lblDoneSeccessOperator.Size = new System.Drawing.Size(0, 27);
            this.lblDoneSeccessOperator.TabIndex = 86;
            // 
            // lblSubDoneSeccessOperator
            // 
            this.lblSubDoneSeccessOperator.AutoSize = true;
            this.lblSubDoneSeccessOperator.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblSubDoneSeccessOperator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubDoneSeccessOperator.Location = new System.Drawing.Point(94, 703);
            this.lblSubDoneSeccessOperator.Name = "lblSubDoneSeccessOperator";
            this.lblSubDoneSeccessOperator.Size = new System.Drawing.Size(0, 27);
            this.lblSubDoneSeccessOperator.TabIndex = 87;
            // 
            // frmDepositWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 750);
            this.Controls.Add(this.lblSubDoneSeccessOperator);
            this.Controls.Add(this.lblDoneSeccessOperator);
            this.Controls.Add(this.iconDoneSuccessOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccountNumber);
            this.Controls.Add(this.iconbtnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTransactionTitle);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDepositWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepositWithdraw";
            this.Load += new System.EventHandler(this.frmDepositWithdraw_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDoneSuccessOperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTotalBalance;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn100;
        private Guna.UI2.WinForms.Guna2Button btn200;
        private Guna.UI2.WinForms.Guna2Button btn500;
        private Guna.UI2.WinForms.Guna2Button btn1000;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2ComboBox cbClients;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconbtnBack;
        private Guna.UI2.WinForms.Guna2ComboBox cbAccountNumber;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconDoneSuccessOperator;
        private System.Windows.Forms.Label lblDoneSeccessOperator;
        private System.Windows.Forms.Label lblSubDoneSeccessOperator;
    }
}