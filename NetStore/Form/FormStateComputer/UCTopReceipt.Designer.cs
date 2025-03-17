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
            this.lblNamecomputer.Location = new System.Drawing.Point(3, 48);
            this.lblNamecomputer.Name = "lblNamecomputer";
            this.lblNamecomputer.Size = new System.Drawing.Size(117, 36);
            this.lblNamecomputer.TabIndex = 0;
            this.lblNamecomputer.Text = "Máy 05";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(168, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(159, 36);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Thời gian:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(168, 75);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(165, 36);
            this.lblMoney.TabIndex = 2;
            this.lblMoney.Text = "Tổng tiền: ";
            // 
            // lblTimereal
            // 
            this.lblTimereal.AutoSize = true;
            this.lblTimereal.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimereal.ForeColor = System.Drawing.Color.White;
            this.lblTimereal.Location = new System.Drawing.Point(348, 19);
            this.lblTimereal.Name = "lblTimereal";
            this.lblTimereal.Size = new System.Drawing.Size(49, 36);
            this.lblTimereal.TabIndex = 3;
            this.lblTimereal.Text = "1h";
            // 
            // lblMoneyreal
            // 
            this.lblMoneyreal.AutoSize = true;
            this.lblMoneyreal.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyreal.ForeColor = System.Drawing.Color.White;
            this.lblMoneyreal.Location = new System.Drawing.Point(348, 77);
            this.lblMoneyreal.Name = "lblMoneyreal";
            this.lblMoneyreal.Size = new System.Drawing.Size(163, 36);
            this.lblMoneyreal.TabIndex = 4;
            this.lblMoneyreal.Text = "7.000 VND";
            // 
            // UCTopReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.Controls.Add(this.lblMoneyreal);
            this.Controls.Add(this.lblTimereal);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNamecomputer);
            this.Name = "UCTopReceipt";
            this.Size = new System.Drawing.Size(540, 134);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamecomputer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTimereal;
        private System.Windows.Forms.Label lblMoneyreal;
    }
}
