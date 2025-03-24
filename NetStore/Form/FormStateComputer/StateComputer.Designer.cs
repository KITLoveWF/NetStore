namespace NetStore.Form.FormStateComputer
{
    partial class StateComputer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucImport1 = new NetStore.Form.UCImport();
            this.ucFormStateComputer1 = new NetStore.Form.FormStateComputer.UCFormStateComputer();
            this.ucSideLeft1 = new NetStore.Form.FormStateComputer.UCSideLeft();
            this.ucInvoice1 = new NetStore.Form.UCInvoice();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ucSideLeft1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 1204);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(352, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1510, 442);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucInvoice1);
            this.panel3.Controls.Add(this.ucImport1);
            this.panel3.Controls.Add(this.ucFormStateComputer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(352, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2089, 1204);
            this.panel3.TabIndex = 2;
            // 
            // ucImport1
            // 
            this.ucImport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ucImport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucImport1.Location = new System.Drawing.Point(0, 0);
            this.ucImport1.Name = "ucImport1";
            this.ucImport1.Size = new System.Drawing.Size(2089, 1204);
            this.ucImport1.TabIndex = 1;
            // 
            // ucFormStateComputer1
            // 
            this.ucFormStateComputer1.Location = new System.Drawing.Point(9, 4);
            this.ucFormStateComputer1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucFormStateComputer1.Name = "ucFormStateComputer1";
            this.ucFormStateComputer1.Size = new System.Drawing.Size(2063, 1193);
            this.ucFormStateComputer1.TabIndex = 0;
            // 
            // ucSideLeft1
            // 
            this.ucSideLeft1.Location = new System.Drawing.Point(5, 4);
            this.ucSideLeft1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucSideLeft1.Name = "ucSideLeft1";
            this.ucSideLeft1.Size = new System.Drawing.Size(338, 1030);
            this.ucSideLeft1.TabIndex = 0;
            // 
            // ucInvoice1
            // 
            this.ucInvoice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ucInvoice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInvoice1.Location = new System.Drawing.Point(0, 0);
            this.ucInvoice1.Name = "ucInvoice1";
            this.ucInvoice1.Size = new System.Drawing.Size(2089, 1204);
            this.ucInvoice1.TabIndex = 2;
            // 
            // StateComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2441, 1204);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StateComputer";
            this.Text = "StateComputer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCSideLeft ucSideLeft1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UCFormStateComputer ucFormStateComputer1;
        private UCImport ucImport1;
        private UCInvoice ucInvoice1;
    }
}