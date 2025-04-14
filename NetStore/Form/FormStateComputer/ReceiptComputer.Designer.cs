namespace NetStore.Form.FormStateComputer
{
    partial class ReceiptComputer
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
            this.cbxComputer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnChooseComputer = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cbxComputer
            // 
            this.cbxComputer.BackColor = System.Drawing.Color.Transparent;
            this.cbxComputer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComputer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxComputer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxComputer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxComputer.ItemHeight = 30;
            this.cbxComputer.Location = new System.Drawing.Point(246, 43);
            this.cbxComputer.Name = "cbxComputer";
            this.cbxComputer.Size = new System.Drawing.Size(466, 36);
            this.cbxComputer.TabIndex = 8;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(59, 47);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(140, 32);
            this.lblComputer.TabIndex = 7;
            this.lblComputer.Text = "Máy tính";
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 3;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(99)))));
            this.btnBack.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(532, 144);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 55);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Trở lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChooseComputer
            // 
            this.btnChooseComputer.BorderRadius = 3;
            this.btnChooseComputer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseComputer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseComputer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseComputer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseComputer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.btnChooseComputer.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseComputer.ForeColor = System.Drawing.Color.White;
            this.btnChooseComputer.Location = new System.Drawing.Point(262, 144);
            this.btnChooseComputer.Name = "btnChooseComputer";
            this.btnChooseComputer.Size = new System.Drawing.Size(180, 55);
            this.btnChooseComputer.TabIndex = 9;
            this.btnChooseComputer.Text = "Chọn máy";
            this.btnChooseComputer.Click += new System.EventHandler(this.btnChooseComputer_Click);
            // 
            // ReceiptComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 233);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChooseComputer);
            this.Controls.Add(this.cbxComputer);
            this.Controls.Add(this.lblComputer);
            this.Name = "ReceiptComputer";
            this.Text = "ReceiptComputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbxComputer;
        private System.Windows.Forms.Label lblComputer;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnChooseComputer;
    }
}