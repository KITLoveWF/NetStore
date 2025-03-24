namespace NetStore.Form.ComputerMaintaince
{
    partial class UCCompMaintainaceForm
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
            this.ucComputerState1 = new NetStore.Form.ComputerMaintaince.UCComputerState();
            this.ucDeviceReceipt1 = new NetStore.Form.ComputerMaintaince.UCDeviceReceipt();
            this.ucSideBarTopCompMaintain1 = new NetStore.Form.ComputerMaintaince.UCSideBarTopCompMaintain();
            this.ucComputerState2 = new NetStore.Form.ComputerMaintaince.UCComputerState();
            this.ucChoosingDeviceToMaintain1 = new NetStore.Form.ComputerMaintaince.UCChoosingDeviceToMaintain();
            this.SuspendLayout();
            // 
            // ucComputerState1
            // 
            this.ucComputerState1.Location = new System.Drawing.Point(3, 129);
            this.ucComputerState1.Name = "ucComputerState1";
            this.ucComputerState1.Size = new System.Drawing.Size(747, 624);
            this.ucComputerState1.TabIndex = 12;
            this.ucComputerState1.Load += new System.EventHandler(this.ucComputerState1_Load);
            // 
            // ucDeviceReceipt1
            // 
            this.ucDeviceReceipt1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucDeviceReceipt1.Location = new System.Drawing.Point(778, 369);
            this.ucDeviceReceipt1.Name = "ucDeviceReceipt1";
            this.ucDeviceReceipt1.Size = new System.Drawing.Size(545, 451);
            this.ucDeviceReceipt1.TabIndex = 11;
            this.ucDeviceReceipt1.Load += new System.EventHandler(this.ucDeviceReceipt1_Load_1);
            // 
            // ucSideBarTopCompMaintain1
            // 
            this.ucSideBarTopCompMaintain1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ucSideBarTopCompMaintain1.Location = new System.Drawing.Point(0, 0);
            this.ucSideBarTopCompMaintain1.Name = "ucSideBarTopCompMaintain1";
            this.ucSideBarTopCompMaintain1.Size = new System.Drawing.Size(1326, 123);
            this.ucSideBarTopCompMaintain1.TabIndex = 10;
            // 
            // ucComputerState2
            // 
            this.ucComputerState2.Location = new System.Drawing.Point(828, 193);
            this.ucComputerState2.Name = "ucComputerState2";
            this.ucComputerState2.Size = new System.Drawing.Size(8, 8);
            this.ucComputerState2.TabIndex = 9;
            // 
            // ucChoosingDeviceToMaintain1
            // 
            this.ucChoosingDeviceToMaintain1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucChoosingDeviceToMaintain1.Location = new System.Drawing.Point(778, 129);
            this.ucChoosingDeviceToMaintain1.Name = "ucChoosingDeviceToMaintain1";
            this.ucChoosingDeviceToMaintain1.Size = new System.Drawing.Size(545, 233);
            this.ucChoosingDeviceToMaintain1.TabIndex = 13;
            // 
            // UCCompMaintainaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucChoosingDeviceToMaintain1);
            this.Controls.Add(this.ucComputerState1);
            this.Controls.Add(this.ucDeviceReceipt1);
            this.Controls.Add(this.ucSideBarTopCompMaintain1);
            this.Controls.Add(this.ucComputerState2);
            this.Name = "UCCompMaintainaceForm";
            this.Size = new System.Drawing.Size(1326, 823);
            this.ResumeLayout(false);

        }

        #endregion
        private UCComputerState ucComputerState2;
        private UCSideBarTopCompMaintain ucSideBarTopCompMaintain1;
        private UCDeviceReceipt ucDeviceReceipt1;
        private UCComputerState ucComputerState1;
        private UCChoosingDeviceToMaintain ucChoosingDeviceToMaintain1;
    }
}
