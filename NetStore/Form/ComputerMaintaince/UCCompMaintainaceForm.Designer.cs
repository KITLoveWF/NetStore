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
            this.ucDeviceReceipt1 = new NetStore.Form.ComputerMaintaince.UCDeviceReceipt();
            this.ucComputerState1 = new NetStore.Form.ComputerMaintaince.UCComputerState();
            this.ucSideBarTopCompMaintain1 = new NetStore.Form.ComputerMaintaince.UCSideBarTopCompMaintain();
            this.ucChoosingDeviceToMaintain1 = new NetStore.Form.ComputerMaintaince.UCChoosingDeviceToMaintain();
            this.SuspendLayout();
            // 
            // ucDeviceReceipt1
            // 
            this.ucDeviceReceipt1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucDeviceReceipt1.Location = new System.Drawing.Point(705, 311);
            this.ucDeviceReceipt1.Name = "ucDeviceReceipt1";
            this.ucDeviceReceipt1.Size = new System.Drawing.Size(464, 452);
            this.ucDeviceReceipt1.TabIndex = 6;
            // 
            // ucComputerState1
            // 
            this.ucComputerState1.Location = new System.Drawing.Point(0, 104);
            this.ucComputerState1.Name = "ucComputerState1";
            this.ucComputerState1.Size = new System.Drawing.Size(699, 624);
            this.ucComputerState1.TabIndex = 4;
            // 
            // ucSideBarTopCompMaintain1
            // 
            this.ucSideBarTopCompMaintain1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ucSideBarTopCompMaintain1.Location = new System.Drawing.Point(0, 0);
            this.ucSideBarTopCompMaintain1.Name = "ucSideBarTopCompMaintain1";
            this.ucSideBarTopCompMaintain1.Size = new System.Drawing.Size(1179, 98);
            this.ucSideBarTopCompMaintain1.TabIndex = 1;
            this.ucSideBarTopCompMaintain1.Load += new System.EventHandler(this.ucSideBarTopCompMaintain1_Load);
            // 
            // ucChoosingDeviceToMaintain1
            // 
            this.ucChoosingDeviceToMaintain1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucChoosingDeviceToMaintain1.Location = new System.Drawing.Point(705, 104);
            this.ucChoosingDeviceToMaintain1.Name = "ucChoosingDeviceToMaintain1";
            this.ucChoosingDeviceToMaintain1.Size = new System.Drawing.Size(464, 212);
            this.ucChoosingDeviceToMaintain1.TabIndex = 7;
            // 
            // UCCompMaintainaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucChoosingDeviceToMaintain1);
            this.Controls.Add(this.ucDeviceReceipt1);
            this.Controls.Add(this.ucComputerState1);
            this.Controls.Add(this.ucSideBarTopCompMaintain1);
            this.Name = "UCCompMaintainaceForm";
            this.Size = new System.Drawing.Size(1179, 794);
            this.ResumeLayout(false);

        }

        #endregion
        private UCSideBarTopCompMaintain ucSideBarTopCompMaintain1;
        private UCComputerState ucComputerState1;
        private UCDeviceReceipt ucDeviceReceipt1;
        private UCChoosingDeviceToMaintain ucChoosingDeviceToMaintain1;
    }
}
