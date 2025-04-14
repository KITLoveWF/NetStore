namespace NetStore.Form
{
    partial class UCImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCyphergaming = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtInventoryPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInventoryQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInventoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvImportRecord = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.guna2Panel1.Controls.Add(this.lblCyphergaming);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1326, 163);
            this.guna2Panel1.TabIndex = 27;
            // 
            // lblCyphergaming
            // 
            this.lblCyphergaming.AutoSize = true;
            this.lblCyphergaming.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblCyphergaming.ForeColor = System.Drawing.Color.Black;
            this.lblCyphergaming.Location = new System.Drawing.Point(32, 60);
            this.lblCyphergaming.Name = "lblCyphergaming";
            this.lblCyphergaming.Size = new System.Drawing.Size(204, 45);
            this.lblCyphergaming.TabIndex = 12;
            this.lblCyphergaming.Text = "Nhập hàng";
            this.lblCyphergaming.Click += new System.EventHandler(this.lblCyphergaming_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtInventoryPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInventoryQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtInventoryName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1000, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 660);
            this.panel1.TabIndex = 41;
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(40, 583);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.SystemColors.WindowText;
            this.btnRefresh.Size = new System.Drawing.Size(248, 53);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Refresh";
            // 
            // txtInventoryPrice
            // 
            this.txtInventoryPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventoryPrice.DefaultText = "";
            this.txtInventoryPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInventoryPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInventoryPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventoryPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventoryPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInventoryPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInventoryPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInventoryPrice.Location = new System.Drawing.Point(40, 335);
            this.txtInventoryPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInventoryPrice.Name = "txtInventoryPrice";
            this.txtInventoryPrice.PlaceholderText = "";
            this.txtInventoryPrice.SelectedText = "";
            this.txtInventoryPrice.Size = new System.Drawing.Size(248, 43);
            this.txtInventoryPrice.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 45;
            this.label3.Text = "Đơn giá";
            // 
            // txtInventoryQuantity
            // 
            this.txtInventoryQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventoryQuantity.DefaultText = "";
            this.txtInventoryQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInventoryQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInventoryQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventoryQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventoryQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInventoryQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInventoryQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInventoryQuantity.Location = new System.Drawing.Point(40, 233);
            this.txtInventoryQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInventoryQuantity.Name = "txtInventoryQuantity";
            this.txtInventoryQuantity.PlaceholderText = "";
            this.txtInventoryQuantity.SelectedText = "";
            this.txtInventoryQuantity.Size = new System.Drawing.Size(248, 43);
            this.txtInventoryQuantity.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Số lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtInventoryName
            // 
            this.txtInventoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventoryName.DefaultText = "";
            this.txtInventoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInventoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInventoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInventoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInventoryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInventoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInventoryName.Location = new System.Drawing.Point(40, 130);
            this.txtInventoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.PlaceholderText = "";
            this.txtInventoryName.SelectedText = "";
            this.txtInventoryName.Size = new System.Drawing.Size(248, 43);
            this.txtInventoryName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tên hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnImport
            // 
            this.btnImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(241)))), ((int)(((byte)(143)))));
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(42, 510);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.PressedColor = System.Drawing.SystemColors.WindowText;
            this.btnImport.Size = new System.Drawing.Size(247, 53);
            this.btnImport.TabIndex = 49;
            this.btnImport.Text = "Nhập hàng";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 69);
            this.panel2.TabIndex = 42;
            // 
            // dgvImportRecord
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvImportRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportRecord.ColumnHeadersHeight = 80;
            this.dgvImportRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportRecord.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportRecord.Location = new System.Drawing.Point(0, 232);
            this.dgvImportRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dgvImportRecord.Name = "dgvImportRecord";
            this.dgvImportRecord.RowHeadersVisible = false;
            this.dgvImportRecord.RowHeadersWidth = 92;
            this.dgvImportRecord.RowTemplate.Height = 37;
            this.dgvImportRecord.Size = new System.Drawing.Size(1000, 591);
            this.dgvImportRecord.TabIndex = 43;
            this.dgvImportRecord.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportRecord.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvImportRecord.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvImportRecord.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvImportRecord.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvImportRecord.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dgvImportRecord.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportRecord.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvImportRecord.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvImportRecord.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportRecord.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvImportRecord.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvImportRecord.ThemeStyle.HeaderStyle.Height = 80;
            this.dgvImportRecord.ThemeStyle.ReadOnly = false;
            this.dgvImportRecord.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportRecord.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvImportRecord.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportRecord.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvImportRecord.ThemeStyle.RowsStyle.Height = 37;
            this.dgvImportRecord.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportRecord.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvImportRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // UCImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.dgvImportRecord);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCImport";
            this.Size = new System.Drawing.Size(1326, 823);
            this.Load += new System.EventHandler(this.UCImport_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblCyphergaming;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2Button btnRefresh;
        public Guna.UI2.WinForms.Guna2TextBox txtInventoryPrice;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtInventoryQuantity;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtInventoryName;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnImport;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2DataGridView dgvImportRecord;
    }
}
