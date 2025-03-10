namespace NetStore.Form.FormStateComputer
{
    partial class UCSideBarTop
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
            this.lblStatecomputer = new System.Windows.Forms.Label();
            this.lblNamestaff = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatecomputer
            // 
            this.lblStatecomputer.AutoSize = true;
            this.lblStatecomputer.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatecomputer.Location = new System.Drawing.Point(37, 48);
            this.lblStatecomputer.Name = "lblStatecomputer";
            this.lblStatecomputer.Size = new System.Drawing.Size(264, 36);
            this.lblStatecomputer.TabIndex = 0;
            this.lblStatecomputer.Text = "Tình trạng máy";
            // 
            // lblNamestaff
            // 
            this.lblNamestaff.AutoSize = true;
            this.lblNamestaff.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamestaff.Location = new System.Drawing.Point(907, 47);
            this.lblNamestaff.Name = "lblNamestaff";
            this.lblNamestaff.Size = new System.Drawing.Size(163, 36);
            this.lblNamestaff.TabIndex = 1;
            this.lblNamestaff.Text = "Duc Kien";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetStore.Properties.Resources.Vector;
            this.pictureBox1.Location = new System.Drawing.Point(853, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 37);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UCSideBarTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNamestaff);
            this.Controls.Add(this.lblStatecomputer);
            this.Name = "UCSideBarTop";
            this.Size = new System.Drawing.Size(1093, 123);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatecomputer;
        private System.Windows.Forms.Label lblNamestaff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
