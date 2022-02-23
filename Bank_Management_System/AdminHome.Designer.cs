namespace BMS
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteacc = new Bunifu.Framework.UI.BunifuTileButton();
            this.updateacc = new Bunifu.Framework.UI.BunifuTileButton();
            this.addacc = new Bunifu.Framework.UI.BunifuTileButton();
            this.deletecus = new Bunifu.Framework.UI.BunifuTileButton();
            this.updatecus = new Bunifu.Framework.UI.BunifuTileButton();
            this.addcus = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(176, 98);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(227, 26);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Customer Operations \r\n";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(616, 98);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(244, 26);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Accountant Operations \r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 46);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.remove_button1;
            this.pictureBox1.Location = new System.Drawing.Point(904, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BMS.Properties.Resources.Bank_Logo1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // logout
            // 
            this.logout.ActiveBorderThickness = 1;
            this.logout.ActiveCornerRadius = 20;
            this.logout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout.ActiveForecolor = System.Drawing.Color.White;
            this.logout.ActiveLineColor = System.Drawing.SystemColors.Window;
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.ButtonText = "LogOut";
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Aquamarine;
            this.logout.IdleBorderThickness = 1;
            this.logout.IdleCornerRadius = 20;
            this.logout.IdleFillColor = System.Drawing.Color.Black;
            this.logout.IdleForecolor = System.Drawing.Color.White;
            this.logout.IdleLineColor = System.Drawing.Color.Silver;
            this.logout.Location = new System.Drawing.Point(14, 416);
            this.logout.Margin = new System.Windows.Forms.Padding(5);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(105, 40);
            this.logout.TabIndex = 15;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // deleteacc
            // 
            this.deleteacc.BackColor = System.Drawing.Color.White;
            this.deleteacc.color = System.Drawing.Color.White;
            this.deleteacc.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteacc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteacc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteacc.ForeColor = System.Drawing.Color.Black;
            this.deleteacc.Image = global::BMS.Properties.Resources.delete;
            this.deleteacc.ImagePosition = 10;
            this.deleteacc.ImageZoom = 50;
            this.deleteacc.LabelPosition = 36;
            this.deleteacc.LabelText = "DELETE";
            this.deleteacc.Location = new System.Drawing.Point(782, 285);
            this.deleteacc.Margin = new System.Windows.Forms.Padding(7);
            this.deleteacc.Name = "deleteacc";
            this.deleteacc.Size = new System.Drawing.Size(105, 101);
            this.deleteacc.TabIndex = 12;
            this.deleteacc.Click += new System.EventHandler(this.deleteacc_Click);
            // 
            // updateacc
            // 
            this.updateacc.BackColor = System.Drawing.Color.White;
            this.updateacc.color = System.Drawing.Color.White;
            this.updateacc.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateacc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateacc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateacc.ForeColor = System.Drawing.Color.Black;
            this.updateacc.Image = global::BMS.Properties.Resources.refresh_button1;
            this.updateacc.ImagePosition = 7;
            this.updateacc.ImageZoom = 50;
            this.updateacc.LabelPosition = 36;
            this.updateacc.LabelText = "UPDATE";
            this.updateacc.Location = new System.Drawing.Point(567, 285);
            this.updateacc.Margin = new System.Windows.Forms.Padding(7);
            this.updateacc.Name = "updateacc";
            this.updateacc.Size = new System.Drawing.Size(105, 101);
            this.updateacc.TabIndex = 11;
            this.updateacc.Click += new System.EventHandler(this.updateacc_Click);
            // 
            // addacc
            // 
            this.addacc.BackColor = System.Drawing.Color.White;
            this.addacc.color = System.Drawing.Color.White;
            this.addacc.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addacc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addacc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addacc.ForeColor = System.Drawing.Color.Black;
            this.addacc.Image = global::BMS.Properties.Resources.add;
            this.addacc.ImagePosition = 7;
            this.addacc.ImageZoom = 50;
            this.addacc.LabelPosition = 36;
            this.addacc.LabelText = "ADD";
            this.addacc.Location = new System.Drawing.Point(678, 164);
            this.addacc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addacc.Name = "addacc";
            this.addacc.Size = new System.Drawing.Size(105, 101);
            this.addacc.TabIndex = 10;
            this.addacc.Click += new System.EventHandler(this.addacc_Click);
            // 
            // deletecus
            // 
            this.deletecus.BackColor = System.Drawing.Color.White;
            this.deletecus.color = System.Drawing.Color.White;
            this.deletecus.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deletecus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletecus.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecus.ForeColor = System.Drawing.Color.Black;
            this.deletecus.Image = global::BMS.Properties.Resources.delete;
            this.deletecus.ImagePosition = 10;
            this.deletecus.ImageZoom = 50;
            this.deletecus.LabelPosition = 36;
            this.deletecus.LabelText = "DELETE";
            this.deletecus.Location = new System.Drawing.Point(318, 285);
            this.deletecus.Margin = new System.Windows.Forms.Padding(7);
            this.deletecus.Name = "deletecus";
            this.deletecus.Size = new System.Drawing.Size(105, 101);
            this.deletecus.TabIndex = 6;
            this.deletecus.Click += new System.EventHandler(this.deletecus_Click);
            // 
            // updatecus
            // 
            this.updatecus.BackColor = System.Drawing.Color.White;
            this.updatecus.color = System.Drawing.Color.White;
            this.updatecus.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updatecus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatecus.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecus.ForeColor = System.Drawing.Color.Black;
            this.updatecus.Image = global::BMS.Properties.Resources.refresh_button;
            this.updatecus.ImagePosition = 7;
            this.updatecus.ImageZoom = 50;
            this.updatecus.LabelPosition = 36;
            this.updatecus.LabelText = "UPDATE";
            this.updatecus.Location = new System.Drawing.Point(131, 285);
            this.updatecus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updatecus.Name = "updatecus";
            this.updatecus.Size = new System.Drawing.Size(105, 101);
            this.updatecus.TabIndex = 5;
            this.updatecus.Click += new System.EventHandler(this.updatecus_Click);
            // 
            // addcus
            // 
            this.addcus.BackColor = System.Drawing.Color.White;
            this.addcus.color = System.Drawing.Color.White;
            this.addcus.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addcus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addcus.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcus.ForeColor = System.Drawing.Color.Black;
            this.addcus.Image = global::BMS.Properties.Resources.add;
            this.addcus.ImagePosition = 7;
            this.addcus.ImageZoom = 50;
            this.addcus.LabelPosition = 36;
            this.addcus.LabelText = "ADD";
            this.addcus.Location = new System.Drawing.Point(231, 164);
            this.addcus.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.addcus.Name = "addcus";
            this.addcus.Size = new System.Drawing.Size(105, 101);
            this.addcus.TabIndex = 4;
            this.addcus.Click += new System.EventHandler(this.addcus_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.deleteacc);
            this.Controls.Add(this.updateacc);
            this.Controls.Add(this.addacc);
            this.Controls.Add(this.deletecus);
            this.Controls.Add(this.updatecus);
            this.Controls.Add(this.addcus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton addcus;
        private Bunifu.Framework.UI.BunifuTileButton updatecus;
        private Bunifu.Framework.UI.BunifuTileButton deletecus;
        private Bunifu.Framework.UI.BunifuTileButton deleteacc;
        private Bunifu.Framework.UI.BunifuTileButton updateacc;
        private Bunifu.Framework.UI.BunifuTileButton addacc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 logout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}