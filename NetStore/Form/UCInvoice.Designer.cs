namespace NetStore.Form
{
    partial class UCInvoice
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
            this.lblCyphergaming = new System.Windows.Forms.Label();
            this.cbxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.rdbCollect = new System.Windows.Forms.RadioButton();
            this.rdbPay = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInvoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCyphergaming
            // 
            this.lblCyphergaming.AutoSize = true;
            this.lblCyphergaming.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblCyphergaming.ForeColor = System.Drawing.Color.Black;
            this.lblCyphergaming.Location = new System.Drawing.Point(50, 87);
            this.lblCyphergaming.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCyphergaming.Name = "lblCyphergaming";
            this.lblCyphergaming.Size = new System.Drawing.Size(511, 68);
            this.lblCyphergaming.TabIndex = 12;
            this.lblCyphergaming.Text = "Lịch sử thanh toán";
            // 
            // cbxFilter
            // 
            this.cbxFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxFilter.ItemHeight = 30;
            this.cbxFilter.Location = new System.Drawing.Point(169, 60);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(251, 36);
            this.cbxFilter.TabIndex = 43;
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(1343, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.SystemColors.WindowText;
            this.btnRefresh.Size = new System.Drawing.Size(291, 77);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Refresh";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.guna2Panel1.Controls.Add(this.lblCyphergaming);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2063, 236);
            this.guna2Panel1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 41);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bộ lọc";
            // 
            // btnPrint
            // 
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(241)))), ((int)(((byte)(143)))));
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(1665, 55);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PressedColor = System.Drawing.SystemColors.WindowText;
            this.btnPrint.Size = new System.Drawing.Size(356, 77);
            this.btnPrint.TabIndex = 53;
            this.btnPrint.Text = "In hóa đơn";
            // 
            // rdbCollect
            // 
            this.rdbCollect.AutoSize = true;
            this.rdbCollect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCollect.Location = new System.Drawing.Point(442, 63);
            this.rdbCollect.Name = "rdbCollect";
            this.rdbCollect.Size = new System.Drawing.Size(111, 45);
            this.rdbCollect.TabIndex = 55;
            this.rdbCollect.TabStop = true;
            this.rdbCollect.Text = "Thu";
            this.rdbCollect.UseVisualStyleBackColor = true;
            // 
            // rdbPay
            // 
            this.rdbPay.AutoSize = true;
            this.rdbPay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPay.Location = new System.Drawing.Point(566, 63);
            this.rdbPay.Name = "rdbPay";
            this.rdbPay.Size = new System.Drawing.Size(103, 45);
            this.rdbPay.TabIndex = 56;
            this.rdbPay.TabStop = true;
            this.rdbPay.Text = "Chi";
            this.rdbPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxFilter);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.rdbPay);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.rdbCollect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2063, 152);
            this.panel1.TabIndex = 57;
            // 
            // dgvInvoice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.ColumnHeadersHeight = 60;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.employee,
            this.invoiceType,
            this.collectedMoney,
            this.maintenanceFee,
            this.foodRevenue,
            this.revenue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInvoice.Location = new System.Drawing.Point(0, 388);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersVisible = false;
            this.dgvInvoice.RowHeadersWidth = 92;
            this.dgvInvoice.RowTemplate.Height = 37;
            this.dgvInvoice.Size = new System.Drawing.Size(2063, 805);
            this.dgvInvoice.TabIndex = 58;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInvoice.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dgvInvoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInvoice.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvInvoice.ThemeStyle.ReadOnly = false;
            this.dgvInvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInvoice.ThemeStyle.RowsStyle.Height = 37;
            this.dgvInvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // date
            // 
            this.date.HeaderText = "Ngày thanh toán";
            this.date.MinimumWidth = 11;
            this.date.Name = "date";
            // 
            // employee
            // 
            this.employee.HeaderText = "Nhân viên";
            this.employee.MinimumWidth = 11;
            this.employee.Name = "employee";
            // 
            // invoiceType
            // 
            this.invoiceType.HeaderText = "Kiểu hóa đơn";
            this.invoiceType.MinimumWidth = 11;
            this.invoiceType.Name = "invoiceType";
            // 
            // collectedMoney
            // 
            this.collectedMoney.HeaderText = "Thu từ máy";
            this.collectedMoney.MinimumWidth = 11;
            this.collectedMoney.Name = "collectedMoney";
            // 
            // maintenanceFee
            // 
            this.maintenanceFee.HeaderText = "Phí bảo trì";
            this.maintenanceFee.MinimumWidth = 11;
            this.maintenanceFee.Name = "maintenanceFee";
            // 
            // foodRevenue
            // 
            this.foodRevenue.HeaderText = "Tổng thu/chi đồ ăn";
            this.foodRevenue.MinimumWidth = 11;
            this.foodRevenue.Name = "foodRevenue";
            // 
            // revenue
            // 
            this.revenue.HeaderText = "Tổng thu chi";
            this.revenue.MinimumWidth = 11;
            this.revenue.Name = "revenue";
            // 
            // UCInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCInvoice";
            this.Size = new System.Drawing.Size(2063, 1193);
            this.Load += new System.EventHandler(this.UCInvoice_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCyphergaming;
        private Guna.UI2.WinForms.Guna2ComboBox cbxFilter;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.RadioButton rdbCollect;
        private System.Windows.Forms.RadioButton rdbPay;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenue;
    }
}
