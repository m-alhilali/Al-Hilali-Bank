namespace Al_Hilali_Bank
{
    partial class frmShowUserPhoto
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
            this.iconDeletePhoto = new FontAwesome.Sharp.IconButton();
            this.iconAddPhoto = new FontAwesome.Sharp.IconButton();
            this.userpicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iconbtnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // iconDeletePhoto
            // 
            this.iconDeletePhoto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconDeletePhoto.IconColor = System.Drawing.SystemColors.WindowText;
            this.iconDeletePhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDeletePhoto.IconSize = 30;
            this.iconDeletePhoto.Location = new System.Drawing.Point(282, 317);
            this.iconDeletePhoto.Name = "iconDeletePhoto";
            this.iconDeletePhoto.Size = new System.Drawing.Size(35, 32);
            this.iconDeletePhoto.TabIndex = 81;
            this.iconDeletePhoto.UseVisualStyleBackColor = true;
            this.iconDeletePhoto.Click += new System.EventHandler(this.iconDeletePhoto_Click);
            // 
            // iconAddPhoto
            // 
            this.iconAddPhoto.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconAddPhoto.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconAddPhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddPhoto.IconSize = 30;
            this.iconAddPhoto.Location = new System.Drawing.Point(323, 316);
            this.iconAddPhoto.Name = "iconAddPhoto";
            this.iconAddPhoto.Size = new System.Drawing.Size(35, 32);
            this.iconAddPhoto.TabIndex = 80;
            this.iconAddPhoto.UseVisualStyleBackColor = true;
            this.iconAddPhoto.Click += new System.EventHandler(this.iconAddPhoto_Click);
            // 
            // userpicture
            // 
            this.userpicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userpicture.ErrorImage = global::Al_Hilali_Bank.Properties.Resources.a282728431fcf05e2b1102f8da9370c1;
            this.userpicture.ImageRotate = 0F;
            this.userpicture.InitialImage = global::Al_Hilali_Bank.Properties.Resources.a282728431fcf05e2b1102f8da9370c1;
            this.userpicture.Location = new System.Drawing.Point(0, 0);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(362, 351);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpicture.TabIndex = 82;
            this.userpicture.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.iconbtnBack.Location = new System.Drawing.Point(0, 0);
            this.iconbtnBack.Name = "iconbtnBack";
            this.iconbtnBack.Size = new System.Drawing.Size(52, 35);
            this.iconbtnBack.TabIndex = 83;
            this.iconbtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnBack.UseVisualStyleBackColor = false;
            this.iconbtnBack.Click += new System.EventHandler(this.iconbtnBack_Click);
            // 
            // frmShowUserPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 351);
            this.Controls.Add(this.iconbtnBack);
            this.Controls.Add(this.iconDeletePhoto);
            this.Controls.Add(this.iconAddPhoto);
            this.Controls.Add(this.userpicture);
            this.Name = "frmShowUserPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo";
            this.Load += new System.EventHandler(this.frmShowUserPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconDeletePhoto;
        private FontAwesome.Sharp.IconButton iconAddPhoto;
        private Guna.UI2.WinForms.Guna2PictureBox userpicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton iconbtnBack;
    }
}