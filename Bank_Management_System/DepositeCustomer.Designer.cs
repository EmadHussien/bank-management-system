namespace BMS
{
    partial class DepositeCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositeCustomer));
            this.depmon = new System.Windows.Forms.TextBox();
            this.depo = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.depocus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depmon
            // 
            this.depmon.Location = new System.Drawing.Point(455, 204);
            this.depmon.Name = "depmon";
            this.depmon.Size = new System.Drawing.Size(181, 20);
            this.depmon.TabIndex = 0;
            this.depmon.TextChanged += new System.EventHandler(this.depmon_TextChanged);
            this.depmon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depmon_KeyPress_1);
            // 
            // depo
            // 
            this.depo.BackColor = System.Drawing.Color.Black;
            this.depo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depo.ForeColor = System.Drawing.Color.White;
            this.depo.Location = new System.Drawing.Point(455, 287);
            this.depo.Name = "depo";
            this.depo.Size = new System.Drawing.Size(134, 38);
            this.depo.TabIndex = 1;
            this.depo.Text = "Deposite ";
            this.depo.UseVisualStyleBackColor = false;
            this.depo.Click += new System.EventHandler(this.depo_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(115, 30);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // depocus
            // 
            this.depocus.AutoSize = true;
            this.depocus.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depocus.Location = new System.Drawing.Point(342, 195);
            this.depocus.Name = "depocus";
            this.depocus.Size = new System.Drawing.Size(107, 30);
            this.depocus.TabIndex = 3;
            this.depocus.Text = "Deposit ";
            // 
            // DepositeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.depocus);
            this.Controls.Add(this.back);
            this.Controls.Add(this.depo);
            this.Controls.Add(this.depmon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositeCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositeCustomer";
            this.Load += new System.EventHandler(this.DepositeCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox depmon;
        private System.Windows.Forms.Button depo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label depocus;
    }
}