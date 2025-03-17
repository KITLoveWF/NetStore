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
            this.ucReceiptComputer1 = new NetStore.Form.FormStateComputer.UCReceiptComputer();
            this.ucTypeComputer1 = new NetStore.Form.FormStateComputer.UCTypeComputer();
            this.ucTopReceipt1 = new NetStore.Form.FormStateComputer.UCTopReceipt();
            this.SuspendLayout();
            // 
            // ucSideBarTop1
            // 
            this.ucSideBarTop1.Location = new System.Drawing.Point(-3, 0);
            this.ucSideBarTop1.Name = "ucSideBarTop1";
            this.ucSideBarTop1.Size = new System.Drawing.Size(1326, 123);
            this.ucSideBarTop1.TabIndex = 0;
            // 
            // ucReceiptComputer1
            // 
            this.ucReceiptComputer1.Location = new System.Drawing.Point(804, 230);
            this.ucReceiptComputer1.Name = "ucReceiptComputer1";
            this.ucReceiptComputer1.Size = new System.Drawing.Size(522, 605);
            this.ucReceiptComputer1.TabIndex = 1;
            // 
            // ucTypeComputer1
            // 
            this.ucTypeComputer1.Location = new System.Drawing.Point(-9, 114);
            this.ucTypeComputer1.Name = "ucTypeComputer1";
            this.ucTypeComputer1.Size = new System.Drawing.Size(786, 563);
            this.ucTypeComputer1.TabIndex = 2;
            // 
            // ucTopReceipt1
            // 
            this.ucTopReceipt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ucTopReceipt1.Location = new System.Drawing.Point(783, 114);
            this.ucTopReceipt1.Name = "ucTopReceipt1";
            this.ucTopReceipt1.Size = new System.Drawing.Size(540, 134);
            this.ucTopReceipt1.TabIndex = 3;
            // 
            // UCFormStateComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucTopReceipt1);
            this.Controls.Add(this.ucTypeComputer1);
            this.Controls.Add(this.ucReceiptComputer1);
            this.Controls.Add(this.ucSideBarTop1);
            this.Name = "UCFormStateComputer";
            this.Size = new System.Drawing.Size(1326, 823);
            this.ResumeLayout(false);

        }

        #endregion

        private UCSideBarTop ucSideBarTop1;
        private UCReceiptComputer ucReceiptComputer1;
        private UCTypeComputer ucTypeComputer1;
        private UCTopReceipt ucTopReceipt1;
    }
}
