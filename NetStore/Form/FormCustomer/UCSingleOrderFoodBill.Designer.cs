namespace NetStore.Form.FormCustomer
{
    partial class UCSingleOrderFoodBill
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIncrease = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDecrease = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnIncrease);
            this.panel4.Controls.Add(this.btnDecrease);
            this.panel4.Controls.Add(this.lblFoodName);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lblQuantity);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 123);
            this.panel4.TabIndex = 14;
            // 
            // btnIncrease
            // 
            this.btnIncrease.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnIncrease.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnIncrease.Image = global::NetStore.Properties.Resources.plus;
            this.btnIncrease.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnIncrease.ImageRotate = 0F;
            this.btnIncrease.Location = new System.Drawing.Point(699, 29);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnIncrease.Size = new System.Drawing.Size(24, 37);
            this.btnIncrease.TabIndex = 47;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDecrease.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDecrease.Image = global::NetStore.Properties.Resources.minus1;
            this.btnDecrease.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDecrease.ImageRotate = 0F;
            this.btnDecrease.Location = new System.Drawing.Point(746, 29);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDecrease.Size = new System.Drawing.Size(24, 37);
            this.btnDecrease.TabIndex = 13;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.lblFoodName.Location = new System.Drawing.Point(9, 29);
            this.lblFoodName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(70, 32);
            this.lblFoodName.TabIndex = 5;
            this.lblFoodName.Text = "Pepsi";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(23, 87);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 3);
            this.panel5.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.lblQuantity.Location = new System.Drawing.Point(249, 29);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(26, 32);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "1";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.lblPrice.Location = new System.Drawing.Point(436, 29);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(142, 32);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "10.000 VND";
            // 
            // UCSingleOrderFoodBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "UCSingleOrderFoodBill";
            this.Size = new System.Drawing.Size(830, 123);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ImageButton btnIncrease;
        private Guna.UI2.WinForms.Guna2ImageButton btnDecrease;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
    }
}
