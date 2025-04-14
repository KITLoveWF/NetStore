namespace NetStore.Form.FormStateComputer
{
    partial class UCTopReceipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNamecomputer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTimereal = new System.Windows.Forms.Label();
            this.lblMoneyreal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNamecomputer
            // 
            this.lblNamecomputer.AutoSize = true;
            this.lblNamecomputer.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamecomputer.ForeColor = System.Drawing.Color.White;
            this.lblNamecomputer.Location = new System.Drawing.Point(3, 38);
            this.lblNamecomputer.Name = "lblNamecomputer";
            this.lblNamecomputer.Size = new System.Drawing.Size(101, 31);
            this.lblNamecomputer.TabIndex = 0;
            this.lblNamecomputer.Text = "Máy 05";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(149, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 31);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Thời gian:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(149, 60);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(141, 31);
            this.lblMoney.TabIndex = 2;
            this.lblMoney.Text = "Tổng tiền: ";
            // 
            // lblTimereal
            // 
            this.lblTimereal.AutoSize = true;
            this.lblTimereal.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimereal.ForeColor = System.Drawing.Color.White;
            this.lblTimereal.Location = new System.Drawing.Point(309, 15);
            this.lblTimereal.Name = "lblTimereal";
            this.lblTimereal.Size = new System.Drawing.Size(43, 31);
            this.lblTimereal.TabIndex = 3;
            this.lblTimereal.Text = "1h";
            this.lblTimereal.Click += new System.EventHandler(this.lblTimereal_Click);
            // 
            // lblMoneyreal
            // 
            this.lblMoneyreal.AutoSize = true;
            this.lblMoneyreal.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyreal.ForeColor = System.Drawing.Color.White;
            this.lblMoneyreal.Location = new System.Drawing.Point(309, 60);
            this.lblMoneyreal.Name = "lblMoneyreal";
            this.lblMoneyreal.Size = new System.Drawing.Size(143, 31);
            this.lblMoneyreal.TabIndex = 4;
            this.lblMoneyreal.Text = "7.000 VND";
            // 
            // UCTopReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.Controls.Add(this.lblMoneyreal);
            this.Controls.Add(this.lblTimereal);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNamecomputer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCTopReceipt";
            this.Size = new System.Drawing.Size(480, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNamecomputer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoney;
        public System.Windows.Forms.Label lblTimereal;
        public System.Windows.Forms.Label lblMoneyreal;
    }
}
