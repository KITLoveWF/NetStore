namespace NetStore.Form.ComputerMaintaince
{
    partial class UCSideBarTopCompMaintain
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
            this.lblNamestaff = new System.Windows.Forms.Label();
            this.lblStatecomputer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamestaff
            // 
            this.lblNamestaff.AutoSize = true;
            this.lblNamestaff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamestaff.Location = new System.Drawing.Point(1134, 31);
            this.lblNamestaff.Name = "lblNamestaff";
            this.lblNamestaff.Size = new System.Drawing.Size(121, 33);
            this.lblNamestaff.TabIndex = 4;
            this.lblNamestaff.Text = "Duc Kien";
            // 
            // lblStatecomputer
            // 
            this.lblStatecomputer.AutoSize = true;
            this.lblStatecomputer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatecomputer.Location = new System.Drawing.Point(41, 34);
            this.lblStatecomputer.Name = "lblStatecomputer";
            this.lblStatecomputer.Size = new System.Drawing.Size(182, 33);
            this.lblStatecomputer.TabIndex = 3;
            this.lblStatecomputer.Text = "Tình trạng máy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetStore.Properties.Resources.Vector;
            this.pictureBox1.Location = new System.Drawing.Point(1101, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UCSideBarTopCompMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNamestaff);
            this.Controls.Add(this.lblStatecomputer);
            this.Name = "UCSideBarTopCompMaintain";
            this.Size = new System.Drawing.Size(1326, 123);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNamestaff;
        private System.Windows.Forms.Label lblStatecomputer;
    }
}
