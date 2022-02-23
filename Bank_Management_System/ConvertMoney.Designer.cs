namespace BMS
{
    partial class ConvertMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertMoney));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmon = new System.Windows.Forms.TextBox();
            this.txtidsend = new System.Windows.Forms.TextBox();
            this.txtidrecieve = new System.Windows.Forms.TextBox();
            this.convert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Reciever";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Money Send";
            // 
            // txtmon
            // 
            this.txtmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtmon.Location = new System.Drawing.Point(439, 229);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(206, 20);
            this.txtmon.TabIndex = 5;
            this.txtmon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidrecieve_KeyPress);
            // 
            // txtidsend
            // 
            this.txtidsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtidsend.Location = new System.Drawing.Point(439, 165);
            this.txtidsend.Name = "txtidsend";
            this.txtidsend.Size = new System.Drawing.Size(206, 20);
            this.txtidsend.TabIndex = 6;
            this.txtidsend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidrecieve_KeyPress);
            // 
            // txtidrecieve
            // 
            this.txtidrecieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtidrecieve.Location = new System.Drawing.Point(439, 304);
            this.txtidrecieve.Name = "txtidrecieve";
            this.txtidrecieve.Size = new System.Drawing.Size(206, 20);
            this.txtidrecieve.TabIndex = 7;
            this.txtidrecieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidrecieve_KeyPress);
            // 
            // convert
            // 
            this.convert.ActiveBorderThickness = 1;
            this.convert.ActiveCornerRadius = 20;
            this.convert.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.convert.ActiveForecolor = System.Drawing.Color.White;
            this.convert.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.convert.BackColor = System.Drawing.Color.White;
            this.convert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("convert.BackgroundImage")));
            this.convert.ButtonText = "ConvertMoney";
            this.convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.Color.SeaGreen;
            this.convert.IdleBorderThickness = 1;
            this.convert.IdleCornerRadius = 20;
            this.convert.IdleFillColor = System.Drawing.Color.Black;
            this.convert.IdleForecolor = System.Drawing.Color.White;
            this.convert.IdleLineColor = System.Drawing.Color.White;
            this.convert.Location = new System.Drawing.Point(721, 376);
            this.convert.Margin = new System.Windows.Forms.Padding(5);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(192, 47);
            this.convert.TabIndex = 8;
            this.convert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.convert.Click += new System.EventHandler(this.withdrew_Click);
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
            this.back.IdleLineColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(721, 14);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(192, 39);
            this.back.TabIndex = 9;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ConvertMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.back);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.txtidrecieve);
            this.Controls.Add(this.txtidsend);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvertMoney";
            this.Load += new System.EventHandler(this.ConvertMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmon;
        private System.Windows.Forms.TextBox txtidsend;
        private System.Windows.Forms.TextBox txtidrecieve;
        private Bunifu.Framework.UI.BunifuThinButton2 convert;
        private Bunifu.Framework.UI.BunifuThinButton2 back;
    }
}