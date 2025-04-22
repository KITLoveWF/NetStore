namespace NetStore.Form.FormMenu
{
    partial class UCMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabtablemenu = new System.Windows.Forms.TabControl();
            this.tabcom = new System.Windows.Forms.TabPage();
            this.flowcom = new System.Windows.Forms.FlowLayoutPanel();
            this.tabnuoc = new System.Windows.Forms.TabPage();
            this.flownuoc = new System.Windows.Forms.FlowLayoutPanel();
            this.tabmy = new System.Windows.Forms.TabPage();
            this.flowmy = new System.Windows.Forms.FlowLayoutPanel();
            this.tabthecao = new System.Windows.Forms.TabPage();
            this.flowthecao = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabtablemenu.SuspendLayout();
            this.tabcom.SuspendLayout();
            this.tabnuoc.SuspendLayout();
            this.tabmy.SuspendLayout();
            this.tabthecao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 27;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1060, 35);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 56);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm món ăn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 125);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabtablemenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 697);
            this.panel2.TabIndex = 1;
            // 
            // tabtablemenu
            // 
            this.tabtablemenu.Controls.Add(this.tabcom);
            this.tabtablemenu.Controls.Add(this.tabnuoc);
            this.tabtablemenu.Controls.Add(this.tabmy);
            this.tabtablemenu.Controls.Add(this.tabthecao);
            this.tabtablemenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabtablemenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabtablemenu.Location = new System.Drawing.Point(0, 0);
            this.tabtablemenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabtablemenu.Multiline = true;
            this.tabtablemenu.Name = "tabtablemenu";
            this.tabtablemenu.SelectedIndex = 0;
            this.tabtablemenu.Size = new System.Drawing.Size(1326, 697);
            this.tabtablemenu.TabIndex = 2;
            // 
            // tabcom
            // 
            this.tabcom.Controls.Add(this.flowcom);
            this.tabcom.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcom.Location = new System.Drawing.Point(4, 41);
            this.tabcom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabcom.Name = "tabcom";
            this.tabcom.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabcom.Size = new System.Drawing.Size(1318, 652);
            this.tabcom.TabIndex = 0;
            this.tabcom.Text = "Cơm";
            this.tabcom.UseVisualStyleBackColor = true;
            // 
            // flowcom
            // 
            this.flowcom.AutoScroll = true;
            this.flowcom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowcom.Location = new System.Drawing.Point(3, 4);
            this.flowcom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowcom.Name = "flowcom";
            this.flowcom.Size = new System.Drawing.Size(1312, 644);
            this.flowcom.TabIndex = 0;
            // 
            // tabnuoc
            // 
            this.tabnuoc.AutoScroll = true;
            this.tabnuoc.Controls.Add(this.flownuoc);
            this.tabnuoc.Location = new System.Drawing.Point(4, 41);
            this.tabnuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabnuoc.Name = "tabnuoc";
            this.tabnuoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabnuoc.Size = new System.Drawing.Size(1318, 652);
            this.tabnuoc.TabIndex = 1;
            this.tabnuoc.Text = "Nước";
            this.tabnuoc.UseVisualStyleBackColor = true;
            // 
            // flownuoc
            // 
            this.flownuoc.AutoScroll = true;
            this.flownuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flownuoc.Location = new System.Drawing.Point(3, 4);
            this.flownuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flownuoc.Name = "flownuoc";
            this.flownuoc.Size = new System.Drawing.Size(1312, 644);
            this.flownuoc.TabIndex = 1;
            // 
            // tabmy
            // 
            this.tabmy.Controls.Add(this.flowmy);
            this.tabmy.Location = new System.Drawing.Point(4, 41);
            this.tabmy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabmy.Name = "tabmy";
            this.tabmy.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabmy.Size = new System.Drawing.Size(1318, 652);
            this.tabmy.TabIndex = 2;
            this.tabmy.Text = "Mỳ";
            this.tabmy.UseVisualStyleBackColor = true;
            // 
            // flowmy
            // 
            this.flowmy.AutoScroll = true;
            this.flowmy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowmy.Location = new System.Drawing.Point(3, 4);
            this.flowmy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowmy.Name = "flowmy";
            this.flowmy.Size = new System.Drawing.Size(1312, 644);
            this.flowmy.TabIndex = 1;
            // 
            // tabthecao
            // 
            this.tabthecao.Controls.Add(this.flowthecao);
            this.tabthecao.Location = new System.Drawing.Point(4, 41);
            this.tabthecao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabthecao.Name = "tabthecao";
            this.tabthecao.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabthecao.Size = new System.Drawing.Size(1318, 652);
            this.tabthecao.TabIndex = 3;
            this.tabthecao.Text = "Thẻ cào";
            this.tabthecao.UseVisualStyleBackColor = true;
            // 
            // flowthecao
            // 
            this.flowthecao.AutoScroll = true;
            this.flowthecao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowthecao.Location = new System.Drawing.Point(3, 4);
            this.flowthecao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowthecao.Name = "flowthecao";
            this.flowthecao.Size = new System.Drawing.Size(1312, 644);
            this.flowthecao.TabIndex = 1;
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(1326, 822);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabtablemenu.ResumeLayout(false);
            this.tabcom.ResumeLayout(false);
            this.tabnuoc.ResumeLayout(false);
            this.tabmy.ResumeLayout(false);
            this.tabthecao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabtablemenu;
        public System.Windows.Forms.TabPage tabcom;
        public System.Windows.Forms.FlowLayoutPanel flowcom;
        public System.Windows.Forms.TabPage tabnuoc;
        public System.Windows.Forms.FlowLayoutPanel flownuoc;
        public System.Windows.Forms.TabPage tabmy;
        public System.Windows.Forms.FlowLayoutPanel flowmy;
        public System.Windows.Forms.TabPage tabthecao;
        public System.Windows.Forms.FlowLayoutPanel flowthecao;
    }
}
