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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxDeviceName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtDevicePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeviceQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeviceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaintainance = new Guna.UI2.WinForms.Guna2Button();
            this.lblCyphergaming = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDeviceRecord = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucComputerState2 = new NetStore.Form.ComputerMaintaince.UCComputerState();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.cbxDeviceName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1556, 100);
            this.panel2.TabIndex = 46;
            // 
            // cbxDeviceName
            // 
            this.cbxDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.cbxDeviceName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeviceName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDeviceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDeviceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDeviceName.ItemHeight = 30;
            this.cbxDeviceName.Location = new System.Drawing.Point(3, 17);
            this.cbxDeviceName.Name = "cbxDeviceName";
            this.cbxDeviceName.Size = new System.Drawing.Size(178, 36);
            this.cbxDeviceName.TabIndex = 28;
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
            this.btnRefresh.Location = new System.Drawing.Point(62, 845);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.SystemColors.WindowText;
            this.btnRefresh.Size = new System.Drawing.Size(386, 77);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Refresh";
            // 
            // txtDevicePrice
            // 
            this.txtDevicePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDevicePrice.DefaultText = "";
            this.txtDevicePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDevicePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDevicePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDevicePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDevicePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDevicePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDevicePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDevicePrice.Location = new System.Drawing.Point(62, 486);
            this.txtDevicePrice.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDevicePrice.Name = "txtDevicePrice";
            this.txtDevicePrice.PlaceholderText = "";
            this.txtDevicePrice.SelectedText = "";
            this.txtDevicePrice.Size = new System.Drawing.Size(386, 62);
            this.txtDevicePrice.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 41);
            this.label3.TabIndex = 45;
            this.label3.Text = "Đơn giá";
            // 
            // txtDeviceQuantity
            // 
            this.txtDeviceQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeviceQuantity.DefaultText = "";
            this.txtDeviceQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeviceQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeviceQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeviceQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceQuantity.Location = new System.Drawing.Point(62, 338);
            this.txtDeviceQuantity.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDeviceQuantity.Name = "txtDeviceQuantity";
            this.txtDeviceQuantity.PlaceholderText = "";
            this.txtDeviceQuantity.SelectedText = "";
            this.txtDeviceQuantity.Size = new System.Drawing.Size(386, 62);
            this.txtDeviceQuantity.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 41);
            this.label2.TabIndex = 43;
            this.label2.Text = "Số lượng";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeviceName.DefaultText = "";
            this.txtDeviceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeviceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeviceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeviceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceName.Location = new System.Drawing.Point(62, 188);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.PlaceholderText = "";
            this.txtDeviceName.SelectedText = "";
            this.txtDeviceName.Size = new System.Drawing.Size(386, 62);
            this.txtDeviceName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tên hàng";
            // 
            // btnMaintainance
            // 
            this.btnMaintainance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintainance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintainance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaintainance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaintainance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(241)))), ((int)(((byte)(143)))));
            this.btnMaintainance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainance.ForeColor = System.Drawing.Color.Black;
            this.btnMaintainance.Location = new System.Drawing.Point(65, 740);
            this.btnMaintainance.Name = "btnMaintainance";
            this.btnMaintainance.PressedColor = System.Drawing.SystemColors.WindowText;
            this.btnMaintainance.Size = new System.Drawing.Size(384, 77);
            this.btnMaintainance.TabIndex = 49;
            this.btnMaintainance.Text = "Bảo trì";
            // 
            // lblCyphergaming
            // 
            this.lblCyphergaming.AutoSize = true;
            this.lblCyphergaming.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblCyphergaming.ForeColor = System.Drawing.Color.Black;
            this.lblCyphergaming.Location = new System.Drawing.Point(50, 87);
            this.lblCyphergaming.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCyphergaming.Name = "lblCyphergaming";
            this.lblCyphergaming.Size = new System.Drawing.Size(207, 68);
            this.lblCyphergaming.TabIndex = 12;
            this.lblCyphergaming.Text = "Bảo trì";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtDevicePrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDeviceQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDeviceName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMaintainance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1556, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 957);
            this.panel1.TabIndex = 45;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.guna2Panel1.Controls.Add(this.lblCyphergaming);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2063, 236);
            this.guna2Panel1.TabIndex = 44;
            // 
            // dgvDeviceRecord
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDeviceRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeviceRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeviceRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeviceRecord.ColumnHeadersHeight = 80;
            this.dgvDeviceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDeviceRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.staffName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeviceRecord.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeviceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeviceRecord.Location = new System.Drawing.Point(0, 336);
            this.dgvDeviceRecord.Name = "dgvDeviceRecord";
            this.dgvDeviceRecord.RowHeadersVisible = false;
            this.dgvDeviceRecord.RowHeadersWidth = 92;
            this.dgvDeviceRecord.RowTemplate.Height = 37;
            this.dgvDeviceRecord.Size = new System.Drawing.Size(1556, 857);
            this.dgvDeviceRecord.TabIndex = 49;
            this.dgvDeviceRecord.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeviceRecord.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDeviceRecord.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDeviceRecord.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDeviceRecord.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDeviceRecord.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dgvDeviceRecord.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeviceRecord.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDeviceRecord.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDeviceRecord.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeviceRecord.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDeviceRecord.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDeviceRecord.ThemeStyle.HeaderStyle.Height = 80;
            this.dgvDeviceRecord.ThemeStyle.ReadOnly = false;
            this.dgvDeviceRecord.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeviceRecord.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeviceRecord.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeviceRecord.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDeviceRecord.ThemeStyle.RowsStyle.Height = 37;
            this.dgvDeviceRecord.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeviceRecord.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Giá Nhập";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tồn kho";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng thêm";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tạm tính";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // staffName
            // 
            this.staffName.HeaderText = "Nhân viên ";
            this.staffName.MinimumWidth = 11;
            this.staffName.Name = "staffName";
            // 
            // ucComputerState2
            // 
            this.ucComputerState2.Location = new System.Drawing.Point(1450, 349);
            this.ucComputerState2.Margin = new System.Windows.Forms.Padding(9);
            this.ucComputerState2.Name = "ucComputerState2";
            this.ucComputerState2.Size = new System.Drawing.Size(14, 14);
            this.ucComputerState2.TabIndex = 9;
            // 
            // UCCompMaintainaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDeviceRecord);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ucComputerState2);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UCCompMaintainaceForm";
            this.Size = new System.Drawing.Size(2063, 1193);
            this.Load += new System.EventHandler(this.UCCompMaintainaceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UCComputerState ucComputerState2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDeviceName;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox txtDevicePrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDeviceQuantity;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDeviceName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnMaintainance;
        private System.Windows.Forms.Label lblCyphergaming;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDeviceRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
    }
}
