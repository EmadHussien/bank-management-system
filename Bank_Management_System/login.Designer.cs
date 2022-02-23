namespace BMS
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.select = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.id = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.log = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 33);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BMS.Properties.Resources.remove_button1;
            this.pictureBox4.Location = new System.Drawing.Point(305, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.Transparent;
            this.select.BorderRadius = 3;
            this.select.DisabledColor = System.Drawing.Color.Gray;
            this.select.ForeColor = System.Drawing.Color.White;
            this.select.Items = new string[] {
        "Admin ",
        "Accountant",
        "Customer"};
            this.select.Location = new System.Drawing.Point(70, 315);
            this.select.Name = "select";
            this.select.NomalColor = System.Drawing.Color.Black;
            this.select.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select.selectedIndex = 0;
            this.select.Size = new System.Drawing.Size(217, 35);
            this.select.TabIndex = 6;
            this.select.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Location = new System.Drawing.Point(142, 192);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(161, 20);
            this.id.TabIndex = 7;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress_1);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Location = new System.Drawing.Point(142, 245);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(161, 20);
            this.pass.TabIndex = 10;
            this.pass.UseSystemPasswordChar = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-1051, 67);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pic
            // 
            this.pic.Image = global::BMS.Properties.Resources.Bank_Logo1;
            this.pic.Location = new System.Drawing.Point(120, 39);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 102);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // log
            // 
            this.log.ActiveBorderThickness = 1;
            this.log.ActiveCornerRadius = 20;
            this.log.ActiveFillColor = System.Drawing.Color.Black;
            this.log.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.log.ActiveLineColor = System.Drawing.Color.Transparent;
            this.log.BackColor = System.Drawing.Color.White;
            this.log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log.BackgroundImage")));
            this.log.ButtonText = "LogIn";
            this.log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.IdleBorderThickness = 1;
            this.log.IdleCornerRadius = 20;
            this.log.IdleFillColor = System.Drawing.Color.Black;
            this.log.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.log.IdleLineColor = System.Drawing.Color.Silver;
            this.log.Location = new System.Drawing.Point(70, 403);
            this.log.Margin = new System.Windows.Forms.Padding(5);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(217, 45);
            this.log.TabIndex = 1;
            this.log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.id);
            this.Controls.Add(this.select);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.log);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 log;
        private System.Windows.Forms.PictureBox pic;
        private Bunifu.Framework.UI.BunifuDropdown select;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pass;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}