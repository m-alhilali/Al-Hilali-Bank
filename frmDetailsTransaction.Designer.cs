namespace Al_Hilali_Bank
{
    partial class frmDetailsTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel17 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalWithdrow = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel25 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cbFilterTransaction = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ShadowPanel26 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvTransaction = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbSearchTransaction = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel27 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label37 = new System.Windows.Forms.Label();
            this.lblTotalDeposit = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel28 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalTransaction = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconbtnBack = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox27 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox28 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.iconPictureBox31 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel17.SuspendLayout();
            this.guna2ShadowPanel25.SuspendLayout();
            this.guna2ShadowPanel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.guna2ShadowPanel27.SuspendLayout();
            this.guna2ShadowPanel28.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel17
            // 
            this.guna2ShadowPanel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel17.Controls.Add(this.guna2PictureBox2);
            this.guna2ShadowPanel17.Controls.Add(this.lblTotalWithdrow);
            this.guna2ShadowPanel17.Controls.Add(this.label17);
            this.guna2ShadowPanel17.Controls.Add(this.label20);
            this.guna2ShadowPanel17.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel17.Location = new System.Drawing.Point(544, 151);
            this.guna2ShadowPanel17.Name = "guna2ShadowPanel17";
            this.guna2ShadowPanel17.Radius = 11;
            this.guna2ShadowPanel17.ShadowColor = System.Drawing.Color.Navy;
            this.guna2ShadowPanel17.Size = new System.Drawing.Size(244, 98);
            this.guna2ShadowPanel17.TabIndex = 27;
            this.guna2ShadowPanel17.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel17_Paint);
            // 
            // lblTotalWithdrow
            // 
            this.lblTotalWithdrow.AutoSize = true;
            this.lblTotalWithdrow.Location = new System.Drawing.Point(83, 39);
            this.lblTotalWithdrow.Name = "lblTotalWithdrow";
            this.lblTotalWithdrow.Size = new System.Drawing.Size(26, 29);
            this.lblTotalWithdrow.TabIndex = 7;
            this.lblTotalWithdrow.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(74, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 24);
            this.label17.TabIndex = 5;
            this.label17.Text = "Total Withdrawal";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(74, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 24);
            this.label20.TabIndex = 9;
            this.label20.Text = "All Item";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ShadowPanel25
            // 
            this.guna2ShadowPanel25.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel25.Controls.Add(this.iconPictureBox27);
            this.guna2ShadowPanel25.Controls.Add(this.cbFilterTransaction);
            this.guna2ShadowPanel25.Controls.Add(this.guna2ShadowPanel26);
            this.guna2ShadowPanel25.Controls.Add(this.iconPictureBox28);
            this.guna2ShadowPanel25.Controls.Add(this.tbSearchTransaction);
            this.guna2ShadowPanel25.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ShadowPanel25.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel25.Location = new System.Drawing.Point(0, 279);
            this.guna2ShadowPanel25.Name = "guna2ShadowPanel25";
            this.guna2ShadowPanel25.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.guna2ShadowPanel25.Radius = 11;
            this.guna2ShadowPanel25.ShadowColor = System.Drawing.Color.DarkBlue;
            this.guna2ShadowPanel25.ShadowShift = 10;
            this.guna2ShadowPanel25.Size = new System.Drawing.Size(1151, 546);
            this.guna2ShadowPanel25.TabIndex = 25;
            // 
            // cbFilterTransaction
            // 
            this.cbFilterTransaction.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterTransaction.BorderColor = System.Drawing.Color.Navy;
            this.cbFilterTransaction.BorderRadius = 15;
            this.cbFilterTransaction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTransaction.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterTransaction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterTransaction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterTransaction.ItemHeight = 30;
            this.cbFilterTransaction.Items.AddRange(new object[] {
            "TransactionType",
            "ClientID"});
            this.cbFilterTransaction.Location = new System.Drawing.Point(576, 19);
            this.cbFilterTransaction.Name = "cbFilterTransaction";
            this.cbFilterTransaction.Size = new System.Drawing.Size(202, 36);
            this.cbFilterTransaction.StartIndex = 0;
            this.cbFilterTransaction.TabIndex = 12;
            // 
            // guna2ShadowPanel26
            // 
            this.guna2ShadowPanel26.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel26.Controls.Add(this.dgvTransaction);
            this.guna2ShadowPanel26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ShadowPanel26.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel26.Location = new System.Drawing.Point(6, 96);
            this.guna2ShadowPanel26.Name = "guna2ShadowPanel26";
            this.guna2ShadowPanel26.Padding = new System.Windows.Forms.Padding(8, 0, 8, 4);
            this.guna2ShadowPanel26.Radius = 8;
            this.guna2ShadowPanel26.ShadowColor = System.Drawing.Color.Blue;
            this.guna2ShadowPanel26.Size = new System.Drawing.Size(1139, 450);
            this.guna2ShadowPanel26.TabIndex = 11;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransaction.ColumnHeadersHeight = 40;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransaction.Location = new System.Drawing.Point(8, 0);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowHeadersWidth = 12;
            this.dgvTransaction.RowTemplate.Height = 29;
            this.dgvTransaction.Size = new System.Drawing.Size(1123, 446);
            this.dgvTransaction.TabIndex = 9;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvTransaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dgvTransaction.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTransaction.ThemeStyle.ReadOnly = true;
            this.dgvTransaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dgvTransaction.ThemeStyle.RowsStyle.Height = 29;
            this.dgvTransaction.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTransaction_CellFormatting);
            // 
            // tbSearchTransaction
            // 
            this.tbSearchTransaction.BorderColor = System.Drawing.Color.Navy;
            this.tbSearchTransaction.BorderRadius = 15;
            this.tbSearchTransaction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchTransaction.DefaultText = "";
            this.tbSearchTransaction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransaction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransaction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchTransaction.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbSearchTransaction.ForeColor = System.Drawing.Color.Black;
            this.tbSearchTransaction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchTransaction.Location = new System.Drawing.Point(27, 18);
            this.tbSearchTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchTransaction.Name = "tbSearchTransaction";
            this.tbSearchTransaction.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchTransaction.PlaceholderText = "Search By Transaction Type";
            this.tbSearchTransaction.SelectedText = "";
            this.tbSearchTransaction.Size = new System.Drawing.Size(442, 42);
            this.tbSearchTransaction.TabIndex = 0;
            this.tbSearchTransaction.TextOffset = new System.Drawing.Point(35, 0);
            this.tbSearchTransaction.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // guna2ShadowPanel27
            // 
            this.guna2ShadowPanel27.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel27.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel27.Controls.Add(this.label37);
            this.guna2ShadowPanel27.Controls.Add(this.lblTotalDeposit);
            this.guna2ShadowPanel27.Controls.Add(this.label41);
            this.guna2ShadowPanel27.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel27.Location = new System.Drawing.Point(273, 151);
            this.guna2ShadowPanel27.Name = "guna2ShadowPanel27";
            this.guna2ShadowPanel27.Radius = 11;
            this.guna2ShadowPanel27.ShadowColor = System.Drawing.Color.Navy;
            this.guna2ShadowPanel27.Size = new System.Drawing.Size(244, 98);
            this.guna2ShadowPanel27.TabIndex = 23;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label37.Location = new System.Drawing.Point(73, 15);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(138, 24);
            this.label37.TabIndex = 8;
            this.label37.Text = "Total Deposit";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalDeposit
            // 
            this.lblTotalDeposit.AutoSize = true;
            this.lblTotalDeposit.Location = new System.Drawing.Point(81, 39);
            this.lblTotalDeposit.Name = "lblTotalDeposit";
            this.lblTotalDeposit.Size = new System.Drawing.Size(26, 29);
            this.lblTotalDeposit.TabIndex = 7;
            this.lblTotalDeposit.Text = "0";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label41.Location = new System.Drawing.Point(82, 67);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(66, 24);
            this.label41.TabIndex = 9;
            this.label41.Text = "All Item";
            this.label41.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ShadowPanel28
            // 
            this.guna2ShadowPanel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel28.Controls.Add(this.lblTotalTransaction);
            this.guna2ShadowPanel28.Controls.Add(this.iconPictureBox31);
            this.guna2ShadowPanel28.Controls.Add(this.label43);
            this.guna2ShadowPanel28.Controls.Add(this.label44);
            this.guna2ShadowPanel28.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel28.Location = new System.Drawing.Point(10, 151);
            this.guna2ShadowPanel28.Name = "guna2ShadowPanel28";
            this.guna2ShadowPanel28.Radius = 11;
            this.guna2ShadowPanel28.ShadowColor = System.Drawing.Color.Navy;
            this.guna2ShadowPanel28.Size = new System.Drawing.Size(244, 98);
            this.guna2ShadowPanel28.TabIndex = 22;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.AutoSize = true;
            this.lblTotalTransaction.Location = new System.Drawing.Point(83, 39);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(26, 29);
            this.lblTotalTransaction.TabIndex = 7;
            this.lblTotalTransaction.Text = "0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label43.Location = new System.Drawing.Point(63, 5);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(153, 24);
            this.label43.TabIndex = 5;
            this.label43.Text = "Total Transactions";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label44.Location = new System.Drawing.Point(68, 67);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(66, 24);
            this.label44.TabIndex = 9;
            this.label44.Text = "All Item";
            this.label44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblCurrentBalance);
            this.guna2ShadowPanel1.Controls.Add(this.iconPictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(804, 151);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 11;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Navy;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(333, 98);
            this.guna2ShadowPanel1.TabIndex = 28;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(83, 34);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(26, 29);
            this.lblCurrentBalance.TabIndex = 7;
            this.lblCurrentBalance.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(84, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Balance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(84, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "All Accounts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1151, 83);
            this.label5.TabIndex = 67;
            this.label5.Text = "Transactions Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(34, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transactions";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconbtnBack
            // 
            this.iconbtnBack.BackColor = System.Drawing.SystemColors.Menu;
            this.iconbtnBack.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iconbtnBack.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.iconbtnBack.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnBack.IconSize = 40;
            this.iconbtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnBack.Location = new System.Drawing.Point(14, 12);
            this.iconbtnBack.Name = "iconbtnBack";
            this.iconbtnBack.Size = new System.Drawing.Size(55, 41);
            this.iconbtnBack.TabIndex = 68;
            this.iconbtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnBack.UseVisualStyleBackColor = false;
            this.iconbtnBack.Click += new System.EventHandler(this.iconbtnBack_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 27);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(45, 56);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox27
            // 
            this.iconPictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox27.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconPictureBox27.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox27.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox27.IconSize = 30;
            this.iconPictureBox27.Location = new System.Drawing.Point(736, 22);
            this.iconPictureBox27.Name = "iconPictureBox27";
            this.iconPictureBox27.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox27.TabIndex = 13;
            this.iconPictureBox27.TabStop = false;
            // 
            // iconPictureBox28
            // 
            this.iconPictureBox28.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox28.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox28.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox28.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox28.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox28.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox28.IconSize = 30;
            this.iconPictureBox28.Location = new System.Drawing.Point(38, 25);
            this.iconPictureBox28.Name = "iconPictureBox28";
            this.iconPictureBox28.Size = new System.Drawing.Size(31, 30);
            this.iconPictureBox28.TabIndex = 9;
            this.iconPictureBox28.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Al_Hilali_Bank.Properties.Resources.Deposit;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 24);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(44, 59);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 69;
            this.guna2PictureBox1.TabStop = false;
            // 
            // iconPictureBox31
            // 
            this.iconPictureBox31.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox31.ForeColor = System.Drawing.Color.DarkBlue;
            this.iconPictureBox31.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.iconPictureBox31.IconColor = System.Drawing.Color.DarkBlue;
            this.iconPictureBox31.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox31.IconSize = 45;
            this.iconPictureBox31.Location = new System.Drawing.Point(23, 27);
            this.iconPictureBox31.Name = "iconPictureBox31";
            this.iconPictureBox31.Size = new System.Drawing.Size(45, 56);
            this.iconPictureBox31.TabIndex = 7;
            this.iconPictureBox31.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Al_Hilali_Bank.Properties.Resources.Whithdrow;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(24, 24);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(44, 59);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 70;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmDetailsTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 825);
            this.Controls.Add(this.iconbtnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2ShadowPanel25);
            this.Controls.Add(this.guna2ShadowPanel27);
            this.Controls.Add(this.guna2ShadowPanel28);
            this.Controls.Add(this.guna2ShadowPanel17);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDetailsTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetailsTransaction";
            this.Load += new System.EventHandler(this.frmDetailsTransaction_Load);
            this.guna2ShadowPanel17.ResumeLayout(false);
            this.guna2ShadowPanel17.PerformLayout();
            this.guna2ShadowPanel25.ResumeLayout(false);
            this.guna2ShadowPanel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.guna2ShadowPanel27.ResumeLayout(false);
            this.guna2ShadowPanel27.PerformLayout();
            this.guna2ShadowPanel28.ResumeLayout(false);
            this.guna2ShadowPanel28.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel17;
        private System.Windows.Forms.Label lblTotalWithdrow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel25;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox27;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterTransaction;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel26;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransaction;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox28;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchTransaction;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel27;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblTotalDeposit;
        private System.Windows.Forms.Label label41;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel28;
        private System.Windows.Forms.Label lblTotalTransaction;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox31;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblCurrentBalance;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconbtnBack;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}