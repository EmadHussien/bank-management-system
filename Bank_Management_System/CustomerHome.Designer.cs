namespace BMS
{
    partial class CustomerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.convert = new System.Windows.Forms.Button();
            this.withdrew = new System.Windows.Forms.Button();
            this.deposite = new System.Windows.Forms.Button();
            this.prof = new System.Windows.Forms.GroupBox();
            this.gridwithdrew = new System.Windows.Forms.DataGridView();
            this.griddeposite = new System.Windows.Forms.DataGridView();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.prof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridwithdrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddeposite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.convert);
            this.bunifuGradientPanel1.Controls.Add(this.withdrew);
            this.bunifuGradientPanel1.Controls.Add(this.deposite);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-23, -46);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(256, 606);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convert.FlatAppearance.BorderSize = 0;
            this.convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.Color.White;
            this.convert.Location = new System.Drawing.Point(52, 395);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(181, 51);
            this.convert.TabIndex = 2;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // withdrew
            // 
            this.withdrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.withdrew.FlatAppearance.BorderSize = 0;
            this.withdrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrew.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrew.ForeColor = System.Drawing.Color.White;
            this.withdrew.Location = new System.Drawing.Point(52, 272);
            this.withdrew.Name = "withdrew";
            this.withdrew.Size = new System.Drawing.Size(181, 51);
            this.withdrew.TabIndex = 3;
            this.withdrew.Text = "Withdrew";
            this.withdrew.UseVisualStyleBackColor = false;
            this.withdrew.Click += new System.EventHandler(this.withdrew_Click);
            // 
            // deposite
            // 
            this.deposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deposite.FlatAppearance.BorderSize = 0;
            this.deposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposite.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposite.ForeColor = System.Drawing.Color.White;
            this.deposite.Location = new System.Drawing.Point(52, 154);
            this.deposite.Name = "deposite";
            this.deposite.Size = new System.Drawing.Size(181, 51);
            this.deposite.TabIndex = 1;
            this.deposite.Text = "Deposite";
            this.deposite.UseVisualStyleBackColor = false;
            this.deposite.Click += new System.EventHandler(this.deposite_Click);
            // 
            // prof
            // 
            this.prof.Controls.Add(this.pictureBox1);
            this.prof.Controls.Add(this.gridwithdrew);
            this.prof.Controls.Add(this.griddeposite);
            this.prof.Controls.Add(this.fname);
            this.prof.Controls.Add(this.lname);
            this.prof.Controls.Add(this.gender);
            this.prof.Controls.Add(this.adress);
            this.prof.Controls.Add(this.email);
            this.prof.Controls.Add(this.total);
            this.prof.Controls.Add(this.phone);
            this.prof.Controls.Add(this.id);
            this.prof.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof.Location = new System.Drawing.Point(239, 2);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(709, 456);
            this.prof.TabIndex = 1;
            this.prof.TabStop = false;
            this.prof.Text = "Profile";
            this.prof.Enter += new System.EventHandler(this.prof_Enter);
            // 
            // gridwithdrew
            // 
            this.gridwithdrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridwithdrew.Location = new System.Drawing.Point(416, 248);
            this.gridwithdrew.Name = "gridwithdrew";
            this.gridwithdrew.Size = new System.Drawing.Size(240, 177);
            this.gridwithdrew.TabIndex = 8;
            // 
            // griddeposite
            // 
            this.griddeposite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddeposite.Location = new System.Drawing.Point(74, 248);
            this.griddeposite.Name = "griddeposite";
            this.griddeposite.Size = new System.Drawing.Size(240, 177);
            this.griddeposite.TabIndex = 9;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(70, 88);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(50, 20);
            this.fname.TabIndex = 7;
            this.fname.Text = "label8";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(70, 137);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(50, 20);
            this.lname.TabIndex = 6;
            this.lname.Text = "label7";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(70, 188);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(50, 20);
            this.gender.TabIndex = 5;
            this.gender.Text = "label6";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(412, 88);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(50, 20);
            this.adress.TabIndex = 4;
            this.adress.Text = "label5";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(412, 137);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(50, 20);
            this.email.TabIndex = 3;
            this.email.Text = "label4";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(412, 188);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(50, 20);
            this.total.TabIndex = 2;
            this.total.Text = "label3";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(412, 46);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(50, 20);
            this.phone.TabIndex = 1;
            this.phone.Text = "label2";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(70, 46);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(50, 20);
            this.id.TabIndex = 0;
            this.id.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(656, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerHome";
            this.Load += new System.EventHandler(this.CustomerHome_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.prof.ResumeLayout(false);
            this.prof.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridwithdrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddeposite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button withdrew;
        private System.Windows.Forms.Button deposite;
        private System.Windows.Forms.GroupBox prof;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridView gridwithdrew;
        private System.Windows.Forms.DataGridView griddeposite;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}