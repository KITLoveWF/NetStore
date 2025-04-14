namespace NetStore.Form.FormMenu
{
    partial class ItemFood
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
            this.itemname = new System.Windows.Forms.Label();
            this.itemprice = new System.Windows.Forms.Label();
            this.ptxBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(208, 31);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(134, 25);
            this.itemname.TabIndex = 1;
            this.itemname.Text = "Tên sản phẩm ";
            // 
            // itemprice
            // 
            this.itemprice.AutoSize = true;
            this.itemprice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemprice.Location = new System.Drawing.Point(208, 96);
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(37, 25);
            this.itemprice.TabIndex = 2;
            this.itemprice.Text = "Giá";
            // 
            // ptxBox
            // 
            this.ptxBox.Image = global::NetStore.Properties.Resources.image_5__1_;
            this.ptxBox.Location = new System.Drawing.Point(0, 0);
            this.ptxBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptxBox.Name = "ptxBox";
            this.ptxBox.Size = new System.Drawing.Size(198, 192);
            this.ptxBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxBox.TabIndex = 0;
            this.ptxBox.TabStop = false;
            // 
            // ItemFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.itemprice);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.ptxBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemFood";
            this.Size = new System.Drawing.Size(520, 192);
            this.Load += new System.EventHandler(this.ItemFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptxBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox ptxBox;
        public System.Windows.Forms.Label itemname;
        public System.Windows.Forms.Label itemprice;
    }
}
