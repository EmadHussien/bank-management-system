namespace BMS
{
    partial class ConvertMoneyCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertMoneyCustomer));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.convert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtidrecieve = new System.Windows.Forms.TextBox();
            this.txtmon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Money Send";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Reciever";
            // 
            // back
            // 
            this.back.ActiveBorderThickness = 1;
            this.back.ActiveCornerRadius = 20;
            this.back.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.ActiveForecolor = System.Drawing.Color.White;
            this.back.ActiveLineColor = System.Drawing.Color.White;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.ButtonText = "Back";
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.SeaGreen;
            this.back.IdleBorderThickness = 1;
            this.back.IdleCornerRadius = 20;
            this.back.IdleFillColor = System.Drawing.Color.Black;
            this.back.IdleForecolor = System.Drawing.Color.White;
            this.back.IdleLineColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(725, 36);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(187, 35);
            this.back.TabIndex = 13;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // convert
            // 
            this.convert.ActiveBorderThickness = 1;
            this.convert.ActiveCornerRadius = 20;
            this.convert.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convert.ActiveForecolor = System.Drawing.Color.White;
            this.convert.ActiveLineColor = System.Drawing.Color.White;
            this.convert.BackColor = System.Drawing.Color.White;
            this.convert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("convert.BackgroundImage")));
            this.convert.ButtonText = "ConvertMoney";
            this.convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convert.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.Color.SeaGreen;
            this.convert.IdleBorderThickness = 1;
            this.convert.IdleCornerRadius = 20;
            this.convert.IdleFillColor = System.Drawing.Color.Black;
            this.convert.IdleForecolor = System.Drawing.Color.White;
            this.convert.IdleLineColor = System.Drawing.Color.Black;
            this.convert.Location = new System.Drawing.Point(725, 370);
            this.convert.Margin = new System.Windows.Forms.Padding(5);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(187, 55);
            this.convert.TabIndex = 12;
            this.convert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // txtidrecieve
            // 
            this.txtidrecieve.Location = new System.Drawing.Point(360, 254);
            this.txtidrecieve.Name = "txtidrecieve";
            this.txtidrecieve.Size = new System.Drawing.Size(195, 20);
            this.txtidrecieve.TabIndex = 11;
            this.txtidrecieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidrecieve_KeyPress);
            // 
            // txtmon
            // 
            this.txtmon.Location = new System.Drawing.Point(360, 156);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(195, 20);
            this.txtmon.TabIndex = 10;
            this.txtmon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidrecieve_KeyPress);
            // 
            // ConvertMoneyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.back);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.txtidrecieve);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertMoneyCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvertMoneyCustomer";
            this.Load += new System.EventHandler(this.ConvertMoneyCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 back;
        private Bunifu.Framework.UI.BunifuThinButton2 convert;
        private System.Windows.Forms.TextBox txtidrecieve;
        private System.Windows.Forms.TextBox txtmon;
    }
}