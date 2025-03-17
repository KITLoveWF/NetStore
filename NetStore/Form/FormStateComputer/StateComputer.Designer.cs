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
            this.ucSideLeft1 = new NetStore.Form.FormStateComputer.UCSideLeft();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucFormStateComputer1 = new NetStore.Form.FormStateComputer.UCFormStateComputer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucSideLeft1
            // 
            this.ucSideLeft1.Location = new System.Drawing.Point(3, 3);
            this.ucSideLeft1.Name = "ucSideLeft1";
            this.ucSideLeft1.Size = new System.Drawing.Size(217, 710);
            this.ucSideLeft1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ucSideLeft1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 830);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(226, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 305);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucFormStateComputer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(226, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1343, 830);
            this.panel3.TabIndex = 2;
            // 
            // ucFormStateComputer1
            // 
            this.ucFormStateComputer1.Location = new System.Drawing.Point(6, 3);
            this.ucFormStateComputer1.Name = "ucFormStateComputer1";
            this.ucFormStateComputer1.Size = new System.Drawing.Size(1326, 823);
            this.ucFormStateComputer1.TabIndex = 0;
            // 
            // StateComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 830);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
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
    }
}