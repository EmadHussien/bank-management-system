namespace BMS
{
    partial class DepositeAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositeAcc));
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deposite = new Bunifu.Framework.UI.BunifuThinButton2();
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.mon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(331, 212);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(188, 20);
            this.txtid.TabIndex = 0;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID ";
            // 
            // deposite
            // 
            this.deposite.ActiveBorderThickness = 1;
            this.deposite.ActiveCornerRadius = 20;
            this.deposite.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deposite.ActiveForecolor = System.Drawing.Color.White;
            this.deposite.ActiveLineColor = System.Drawing.Color.White;
            this.deposite.BackColor = System.Drawing.Color.White;
            this.deposite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deposite.BackgroundImage")));
            this.deposite.ButtonText = "Deposite";
            this.deposite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposite.ForeColor = System.Drawing.Color.SeaGreen;
            this.deposite.IdleBorderThickness = 1;
            this.deposite.IdleCornerRadius = 20;
            this.deposite.IdleFillColor = System.Drawing.Color.Black;
            this.deposite.IdleForecolor = System.Drawing.Color.White;
            this.deposite.IdleLineColor = System.Drawing.Color.Black;
            this.deposite.Location = new System.Drawing.Point(660, 229);
            this.deposite.Margin = new System.Windows.Forms.Padding(5);
            this.deposite.Name = "deposite";
            this.deposite.Size = new System.Drawing.Size(171, 48);
            this.deposite.TabIndex = 2;
            this.deposite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deposite.Click += new System.EventHandler(this.deposite_Click);
            // 
            // back
            // 
            this.back.ActiveBorderThickness = 1;
            this.back.ActiveCornerRadius = 20;
            this.back.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.back.ActiveForecolor = System.Drawing.Color.White;
            this.back.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.ButtonText = "Back ";
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.SeaGreen;
            this.back.IdleBorderThickness = 1;
            this.back.IdleCornerRadius = 20;
            this.back.IdleFillColor = System.Drawing.Color.Black;
            this.back.IdleForecolor = System.Drawing.Color.White;
            this.back.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.back.Location = new System.Drawing.Point(14, 14);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(171, 30);
            this.back.TabIndex = 3;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(331, 270);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(188, 20);
            this.txtmoney.TabIndex = 4;
            this.txtmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress);
            // 
            // mon
            // 
            this.mon.AutoSize = true;
            this.mon.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon.Location = new System.Drawing.Point(149, 264);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(176, 26);
            this.mon.TabIndex = 5;
            this.mon.Text = "Deposite Money ";
            // 
            // DepositeAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.mon);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.back);
            this.Controls.Add(this.deposite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositeAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositeAcc";
            this.Load += new System.EventHandler(this.DepositeAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 deposite;
        private Bunifu.Framework.UI.BunifuThinButton2 back;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label mon;
    }
}