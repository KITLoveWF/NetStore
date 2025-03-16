namespace NetStore.Form.FormMenu
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabtablemenu = new System.Windows.Forms.TabControl();
            this.tabcom = new System.Windows.Forms.TabPage();
            this.tabnuoc = new System.Windows.Forms.TabPage();
            this.tabmy = new System.Windows.Forms.TabPage();
            this.tabthecao = new System.Windows.Forms.TabPage();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tabtablemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // tabtablemenu
            // 
            this.tabtablemenu.Controls.Add(this.tabcom);
            this.tabtablemenu.Controls.Add(this.tabnuoc);
            this.tabtablemenu.Controls.Add(this.tabmy);
            this.tabtablemenu.Controls.Add(this.tabthecao);
            this.tabtablemenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabtablemenu.Location = new System.Drawing.Point(50, 71);
            this.tabtablemenu.Multiline = true;
            this.tabtablemenu.Name = "tabtablemenu";
            this.tabtablemenu.SelectedIndex = 0;
            this.tabtablemenu.Size = new System.Drawing.Size(847, 489);
            this.tabtablemenu.TabIndex = 1;
            // 
            // tabcom
            // 
            this.tabcom.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcom.Location = new System.Drawing.Point(4, 37);
            this.tabcom.Name = "tabcom";
            this.tabcom.Padding = new System.Windows.Forms.Padding(3);
            this.tabcom.Size = new System.Drawing.Size(839, 448);
            this.tabcom.TabIndex = 0;
            this.tabcom.Text = "Cơm";
            this.tabcom.UseVisualStyleBackColor = true;
            // 
            // tabnuoc
            // 
            this.tabnuoc.Location = new System.Drawing.Point(4, 30);
            this.tabnuoc.Name = "tabnuoc";
            this.tabnuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabnuoc.Size = new System.Drawing.Size(839, 455);
            this.tabnuoc.TabIndex = 1;
            this.tabnuoc.Text = "Nước";
            this.tabnuoc.UseVisualStyleBackColor = true;
            // 
            // tabmy
            // 
            this.tabmy.Location = new System.Drawing.Point(4, 30);
            this.tabmy.Name = "tabmy";
            this.tabmy.Padding = new System.Windows.Forms.Padding(3);
            this.tabmy.Size = new System.Drawing.Size(839, 455);
            this.tabmy.TabIndex = 2;
            this.tabmy.Text = "Mỳ";
            this.tabmy.UseVisualStyleBackColor = true;
            // 
            // tabthecao
            // 
            this.tabthecao.Location = new System.Drawing.Point(4, 30);
            this.tabthecao.Name = "tabthecao";
            this.tabthecao.Padding = new System.Windows.Forms.Padding(3);
            this.tabthecao.Size = new System.Drawing.Size(839, 455);
            this.tabthecao.TabIndex = 3;
            this.tabthecao.Text = "Thẻ cào";
            this.tabthecao.UseVisualStyleBackColor = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(713, 38);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "+ Add New Food";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 582);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.tabtablemenu);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabtablemenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabtablemenu;
        private System.Windows.Forms.TabPage tabcom;
        private System.Windows.Forms.TabPage tabnuoc;
        private System.Windows.Forms.TabPage tabmy;
        private System.Windows.Forms.TabPage tabthecao;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}