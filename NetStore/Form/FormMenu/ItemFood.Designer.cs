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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(185, 25);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(110, 20);
            this.itemname.TabIndex = 1;
            this.itemname.Text = "Tên sản phẩm ";
            // 
            // itemprice
            // 
            this.itemprice.AutoSize = true;
            this.itemprice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemprice.Location = new System.Drawing.Point(185, 77);
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(31, 20);
            this.itemprice.TabIndex = 2;
            this.itemprice.Text = "Giá";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetStore.Properties.Resources.image_5__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ItemFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.itemprice);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ItemFood";
            this.Size = new System.Drawing.Size(462, 154);
            this.Load += new System.EventHandler(this.ItemFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label itemprice;
    }
}
