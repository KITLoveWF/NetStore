namespace NetStore.Form.FormStateComputer
{
    partial class AddComputer
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
            this.lblNamecomputer = new System.Windows.Forms.Label();
            this.lblTypecomputer = new System.Windows.Forms.Label();
            this.btnAddcomputer = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.txtNamecomputer = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxTypecomputer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNamecomputer
            // 
            this.lblNamecomputer.AutoSize = true;
            this.lblNamecomputer.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamecomputer.Location = new System.Drawing.Point(72, 40);
            this.lblNamecomputer.Name = "lblNamecomputer";
            this.lblNamecomputer.Size = new System.Drawing.Size(135, 32);
            this.lblNamecomputer.TabIndex = 0;
            this.lblNamecomputer.Text = "Tên máy";
            // 
            // lblTypecomputer
            // 
            this.lblTypecomputer.AutoSize = true;
            this.lblTypecomputer.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypecomputer.Location = new System.Drawing.Point(72, 220);
            this.lblTypecomputer.Name = "lblTypecomputer";
            this.lblTypecomputer.Size = new System.Drawing.Size(142, 32);
            this.lblTypecomputer.TabIndex = 1;
            this.lblTypecomputer.Text = "Loại máy";
            // 
            // btnAddcomputer
            // 
            this.btnAddcomputer.BorderRadius = 3;
            this.btnAddcomputer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddcomputer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddcomputer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddcomputer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddcomputer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.btnAddcomputer.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcomputer.ForeColor = System.Drawing.Color.White;
            this.btnAddcomputer.Location = new System.Drawing.Point(321, 287);
            this.btnAddcomputer.Name = "btnAddcomputer";
            this.btnAddcomputer.Size = new System.Drawing.Size(180, 55);
            this.btnAddcomputer.TabIndex = 2;
            this.btnAddcomputer.Text = "Thêm máy";
            this.btnAddcomputer.Click += new System.EventHandler(this.btnAddcomputer_Click);
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
            this.btnBack.Location = new System.Drawing.Point(591, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 55);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNamecomputer
            // 
            this.txtNamecomputer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNamecomputer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamecomputer.DefaultText = "";
            this.txtNamecomputer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamecomputer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamecomputer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamecomputer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamecomputer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamecomputer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamecomputer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamecomputer.Location = new System.Drawing.Point(259, 31);
            this.txtNamecomputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamecomputer.Name = "txtNamecomputer";
            this.txtNamecomputer.PlaceholderText = "";
            this.txtNamecomputer.SelectedText = "";
            this.txtNamecomputer.Size = new System.Drawing.Size(466, 50);
            this.txtNamecomputer.TabIndex = 4;
            // 
            // cbxTypecomputer
            // 
            this.cbxTypecomputer.BackColor = System.Drawing.Color.Transparent;
            this.cbxTypecomputer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTypecomputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypecomputer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypecomputer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypecomputer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxTypecomputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTypecomputer.ItemHeight = 30;
            this.cbxTypecomputer.Items.AddRange(new object[] {
            "Online",
            "Offline",
            "Error"});
            this.cbxTypecomputer.Location = new System.Drawing.Point(259, 216);
            this.cbxTypecomputer.Name = "cbxTypecomputer";
            this.cbxTypecomputer.Size = new System.Drawing.Size(466, 36);
            this.cbxTypecomputer.TabIndex = 6;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoney.DefaultText = "";
            this.txtMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoney.Location = new System.Drawing.Point(259, 124);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.PlaceholderText = "";
            this.txtMoney.SelectedText = "";
            this.txtMoney.Size = new System.Drawing.Size(466, 50);
            this.txtMoney.TabIndex = 8;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(72, 133);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(127, 32);
            this.lblMoney.TabIndex = 7;
            this.lblMoney.Text = "Giá tiền";
            // 
            // AddComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.cbxTypecomputer);
            this.Controls.Add(this.txtNamecomputer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddcomputer);
            this.Controls.Add(this.lblTypecomputer);
            this.Controls.Add(this.lblNamecomputer);
            this.Name = "AddComputer";
            this.Text = "AddComputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamecomputer;
        private System.Windows.Forms.Label lblTypecomputer;
        private Guna.UI2.WinForms.Guna2Button btnAddcomputer;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox txtNamecomputer;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTypecomputer;
        private Guna.UI2.WinForms.Guna2TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
    }
}