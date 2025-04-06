namespace NetStore.Form.FormCustomer
{
    partial class CustomerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucCustomerSideLeft1 = new NetStore.Form.FormCustomer.UCCustomerSideLeft();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ucCustomerOrderFood1 = new NetStore.Form.UCCustomerOrderFood();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucCustomerSideLeft1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 1161);
            this.panel1.TabIndex = 3;
            // 
            // ucCustomerSideLeft1
            // 
            this.ucCustomerSideLeft1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomerSideLeft1.Location = new System.Drawing.Point(0, 0);
            this.ucCustomerSideLeft1.Name = "ucCustomerSideLeft1";
            this.ucCustomerSideLeft1.Size = new System.Drawing.Size(352, 1161);
            this.ucCustomerSideLeft1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(352, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1510, 442);
            this.panel2.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ucCustomerOrderFood1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(352, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2075, 1161);
            this.guna2Panel1.TabIndex = 4;
            // 
            // ucCustomerOrderFood1
            // 
            this.ucCustomerOrderFood1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomerOrderFood1.Location = new System.Drawing.Point(0, 0);
            this.ucCustomerOrderFood1.Name = "ucCustomerOrderFood1";
            this.ucCustomerOrderFood1.Size = new System.Drawing.Size(2075, 1161);
            this.ucCustomerOrderFood1.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2427, 1161);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UCCustomerSideLeft ucCustomerSideLeft1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UCCustomerOrderFood ucCustomerOrderFood1;
    }
}