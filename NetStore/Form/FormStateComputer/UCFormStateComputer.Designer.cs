namespace NetStore.Form.FormStateComputer
{
    partial class UCFormStateComputer
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
            this.ucSideBarTop1 = new NetStore.Form.FormStateComputer.UCSideBarTop();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ucTopReceipt1 = new NetStore.Form.FormStateComputer.UCTopReceipt();
            this.ucReceiptComputer1 = new NetStore.Form.FormStateComputer.UCReceiptComputer();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ucTypeComputer1 = new NetStore.Form.FormStateComputer.UCTypeComputer();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucSideBarTop1
            // 
            this.ucSideBarTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSideBarTop1.Location = new System.Drawing.Point(0, 0);
            this.ucSideBarTop1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucSideBarTop1.Name = "ucSideBarTop1";
            this.ucSideBarTop1.Size = new System.Drawing.Size(2063, 178);
            this.ucSideBarTop1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ucReceiptComputer1);
            this.guna2Panel1.Controls.Add(this.ucTopReceipt1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1220, 178);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(843, 1015);
            this.guna2Panel1.TabIndex = 3;
            // 
            // ucTopReceipt1
            // 
            this.ucTopReceipt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ucTopReceipt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTopReceipt1.Location = new System.Drawing.Point(0, 0);
            this.ucTopReceipt1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucTopReceipt1.Name = "ucTopReceipt1";
            this.ucTopReceipt1.Size = new System.Drawing.Size(843, 194);
            this.ucTopReceipt1.TabIndex = 5;
            // 
            // ucReceiptComputer1
            // 
            this.ucReceiptComputer1.BackColor = System.Drawing.Color.White;
            this.ucReceiptComputer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReceiptComputer1.Location = new System.Drawing.Point(0, 194);
            this.ucReceiptComputer1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucReceiptComputer1.Name = "ucReceiptComputer1";
            this.ucReceiptComputer1.Size = new System.Drawing.Size(843, 821);
            this.ucReceiptComputer1.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.ucTypeComputer1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 178);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1220, 1015);
            this.guna2Panel2.TabIndex = 4;
            // 
            // ucTypeComputer1
            // 
            this.ucTypeComputer1.BackColor = System.Drawing.Color.White;
            this.ucTypeComputer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTypeComputer1.Location = new System.Drawing.Point(0, 0);
            this.ucTypeComputer1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucTypeComputer1.Name = "ucTypeComputer1";
            this.ucTypeComputer1.Size = new System.Drawing.Size(1220, 1015);
            this.ucTypeComputer1.TabIndex = 3;
            // 
            // UCFormStateComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ucSideBarTop1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UCFormStateComputer";
            this.Size = new System.Drawing.Size(2063, 1193);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCSideBarTop ucSideBarTop1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UCReceiptComputer ucReceiptComputer1;
        private UCTopReceipt ucTopReceipt1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private UCTypeComputer ucTypeComputer1;
    }
}
