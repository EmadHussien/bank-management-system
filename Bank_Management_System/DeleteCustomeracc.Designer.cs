namespace BMS
{
    partial class DeleteCustomeracc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomeracc));
            this.check = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labl = new System.Windows.Forms.Label();
            this.gridinfo = new System.Windows.Forms.DataGridView();
            this.id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deletecus = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.ActiveBorderThickness = 1;
            this.check.ActiveCornerRadius = 20;
            this.check.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.check.ActiveForecolor = System.Drawing.Color.White;
            this.check.ActiveLineColor = System.Drawing.Color.Silver;
            this.check.BackColor = System.Drawing.Color.White;
            this.check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check.BackgroundImage")));
            this.check.ButtonText = "Check";
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.SeaGreen;
            this.check.IdleBorderThickness = 1;
            this.check.IdleCornerRadius = 20;
            this.check.IdleFillColor = System.Drawing.Color.Black;
            this.check.IdleForecolor = System.Drawing.Color.White;
            this.check.IdleLineColor = System.Drawing.Color.Silver;
            this.check.Location = new System.Drawing.Point(180, 243);
            this.check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(145, 44);
            this.check.TabIndex = 9;
            this.check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Location = new System.Drawing.Point(47, 185);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(129, 26);
            this.labl.TabIndex = 8;
            this.labl.Text = "Customer ID ";
            // 
            // gridinfo
            // 
            this.gridinfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridinfo.Location = new System.Drawing.Point(536, 73);
            this.gridinfo.Name = "gridinfo";
            this.gridinfo.Size = new System.Drawing.Size(364, 214);
            this.gridinfo.TabIndex = 7;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.BorderColorFocused = System.Drawing.Color.Transparent;
            this.id.BorderColorIdle = System.Drawing.Color.Transparent;
            this.id.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.BorderThickness = 3;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.isPassword = false;
            this.id.Location = new System.Drawing.Point(194, 185);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(222, 26);
            this.id.TabIndex = 6;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress_1);
            // 
            // back
            // 
            this.back.ActiveBorderThickness = 1;
            this.back.ActiveCornerRadius = 20;
            this.back.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.ActiveForecolor = System.Drawing.Color.White;
            this.back.ActiveLineColor = System.Drawing.Color.SeaGreen;
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
            this.back.Location = new System.Drawing.Point(14, 14);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(169, 34);
            this.back.TabIndex = 10;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // deletecus
            // 
            this.deletecus.ActiveBorderThickness = 1;
            this.deletecus.ActiveCornerRadius = 20;
            this.deletecus.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deletecus.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.deletecus.ActiveLineColor = System.Drawing.Color.Silver;
            this.deletecus.BackColor = System.Drawing.Color.White;
            this.deletecus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletecus.BackgroundImage")));
            this.deletecus.ButtonText = "DELETE";
            this.deletecus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletecus.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecus.ForeColor = System.Drawing.Color.SeaGreen;
            this.deletecus.IdleBorderThickness = 1;
            this.deletecus.IdleCornerRadius = 20;
            this.deletecus.IdleFillColor = System.Drawing.Color.Black;
            this.deletecus.IdleForecolor = System.Drawing.Color.White;
            this.deletecus.IdleLineColor = System.Drawing.Color.Silver;
            this.deletecus.Location = new System.Drawing.Point(637, 317);
            this.deletecus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletecus.Name = "deletecus";
            this.deletecus.Size = new System.Drawing.Size(159, 43);
            this.deletecus.TabIndex = 11;
            this.deletecus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletecus.Click += new System.EventHandler(this.deletecus_Click);
            // 
            // DeleteCustomeracc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 439);
            this.Controls.Add(this.deletecus);
            this.Controls.Add(this.back);
            this.Controls.Add(this.check);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.gridinfo);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteCustomeracc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCustomeracc";
            this.Load += new System.EventHandler(this.DeleteCustomeracc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 check;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.DataGridView gridinfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox id;
        private Bunifu.Framework.UI.BunifuThinButton2 back;
        private Bunifu.Framework.UI.BunifuThinButton2 deletecus;
    }
}