namespace NetStore.Form.ComputerMaintaince
{
    partial class UCComputerState
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
            this.cbbTypecomputer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTypecomputer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plError = new Guna.UI2.WinForms.Guna2Panel();
            this.plOffline = new Guna.UI2.WinForms.Guna2Panel();
            this.plOnline = new Guna.UI2.WinForms.Guna2Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTypeonline = new System.Windows.Forms.Label();
            this.lblOffline = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnComputer1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputer2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputer3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputer4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputer5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputer6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTypecomputer
            // 
            this.cbbTypecomputer.BackColor = System.Drawing.Color.Transparent;
            this.cbbTypecomputer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTypecomputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypecomputer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTypecomputer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTypecomputer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cbbTypecomputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTypecomputer.ItemHeight = 30;
            this.cbbTypecomputer.Items.AddRange(new object[] {
            "Online ",
            "Offline",
            "Error ",
            "Tất cả "});
            this.cbbTypecomputer.Location = new System.Drawing.Point(337, 43);
            this.cbbTypecomputer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbTypecomputer.Name = "cbbTypecomputer";
            this.cbbTypecomputer.Size = new System.Drawing.Size(473, 36);
            this.cbbTypecomputer.TabIndex = 27;
            // 
            // lblTypecomputer
            // 
            this.lblTypecomputer.AutoSize = true;
            this.lblTypecomputer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypecomputer.Location = new System.Drawing.Point(29, 31);
            this.lblTypecomputer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTypecomputer.Name = "lblTypecomputer";
            this.lblTypecomputer.Size = new System.Drawing.Size(188, 48);
            this.lblTypecomputer.TabIndex = 22;
            this.lblTypecomputer.Text = "Loại máy";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTypecomputer);
            this.panel1.Controls.Add(this.cbbTypecomputer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 110);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.plError);
            this.panel2.Controls.Add(this.plOffline);
            this.panel2.Controls.Add(this.plOnline);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.lblTypeonline);
            this.panel2.Controls.Add(this.lblOffline);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 100);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // plError
            // 
            this.plError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(99)))));
            this.plError.Location = new System.Drawing.Point(706, 14);
            this.plError.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plError.Name = "plError";
            this.plError.Size = new System.Drawing.Size(65, 39);
            this.plError.TabIndex = 36;
            // 
            // plOffline
            // 
            this.plOffline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.plOffline.Location = new System.Drawing.Point(380, 17);
            this.plOffline.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plOffline.Name = "plOffline";
            this.plOffline.Size = new System.Drawing.Size(65, 39);
            this.plOffline.TabIndex = 35;
            this.plOffline.Paint += new System.Windows.Forms.PaintEventHandler(this.plOffline_Paint);
            // 
            // plOnline
            // 
            this.plOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(105)))));
            this.plOnline.Location = new System.Drawing.Point(37, 17);
            this.plOnline.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plOnline.Name = "plOnline";
            this.plOnline.Size = new System.Drawing.Size(65, 39);
            this.plOnline.TabIndex = 34;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.lblError.Location = new System.Drawing.Point(805, 26);
            this.lblError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(63, 27);
            this.lblError.TabIndex = 33;
            this.lblError.Text = "Error";
            // 
            // lblTypeonline
            // 
            this.lblTypeonline.AutoSize = true;
            this.lblTypeonline.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.lblTypeonline.Location = new System.Drawing.Point(121, 26);
            this.lblTypeonline.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTypeonline.Name = "lblTypeonline";
            this.lblTypeonline.Size = new System.Drawing.Size(76, 27);
            this.lblTypeonline.TabIndex = 32;
            this.lblTypeonline.Text = "Online";
            // 
            // lblOffline
            // 
            this.lblOffline.AutoSize = true;
            this.lblOffline.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.lblOffline.Location = new System.Drawing.Point(482, 29);
            this.lblOffline.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(80, 27);
            this.lblOffline.TabIndex = 31;
            this.lblOffline.Text = "Offline";
            this.lblOffline.Click += new System.EventHandler(this.lblOffline_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 905);
            this.panel3.TabIndex = 34;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnComputer1);
            this.flowLayoutPanel1.Controls.Add(this.btnComputer2);
            this.flowLayoutPanel1.Controls.Add(this.btnComputer3);
            this.flowLayoutPanel1.Controls.Add(this.btnComputer4);
            this.flowLayoutPanel1.Controls.Add(this.btnComputer5);
            this.flowLayoutPanel1.Controls.Add(this.btnComputer6);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button1);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button2);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button3);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button4);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button5);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1017, 905);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // btnComputer1
            // 
            this.btnComputer1.BorderRadius = 5;
            this.btnComputer1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputer1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(105)))));
            this.btnComputer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer1.ForeColor = System.Drawing.Color.White;
            this.btnComputer1.Location = new System.Drawing.Point(5, 4);
            this.btnComputer1.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.btnComputer1.Name = "btnComputer1";
            this.btnComputer1.Size = new System.Drawing.Size(280, 188);
            this.btnComputer1.TabIndex = 0;
            this.btnComputer1.Text = "Máy 1";
            // 
            // btnComputer2
            // 
            this.btnComputer2.BorderRadius = 5;
            this.btnComputer2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputer2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(99)))));
            this.btnComputer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer2.ForeColor = System.Drawing.Color.White;
            this.btnComputer2.Location = new System.Drawing.Point(322, 4);
            this.btnComputer2.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.btnComputer2.Name = "btnComputer2";
            this.btnComputer2.Size = new System.Drawing.Size(280, 188);
            this.btnComputer2.TabIndex = 1;
            this.btnComputer2.Text = "Máy 2";
            // 
            // btnComputer3
            // 
            this.btnComputer3.BorderRadius = 5;
            this.btnComputer3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputer3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputer3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.btnComputer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer3.ForeColor = System.Drawing.Color.White;
            this.btnComputer3.Location = new System.Drawing.Point(639, 4);
            this.btnComputer3.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.btnComputer3.Name = "btnComputer3";
            this.btnComputer3.Size = new System.Drawing.Size(280, 188);
            this.btnComputer3.TabIndex = 2;
            this.btnComputer3.Text = "Máy 3";
            // 
            // btnComputer4
            // 
            this.btnComputer4.BorderRadius = 5;
            this.btnComputer4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputer4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputer4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.btnComputer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer4.ForeColor = System.Drawing.Color.White;
            this.btnComputer4.Location = new System.Drawing.Point(5, 225);
            this.btnComputer4.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.btnComputer4.Name = "btnComputer4";
            this.btnComputer4.Size = new System.Drawing.Size(280, 188);
            this.btnComputer4.TabIndex = 3;
            this.btnComputer4.Text = "Máy 4";
            // 
            // btnComputer5
            // 
            this.btnComputer5.BorderRadius = 5;
            this.btnComputer5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputer5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputer5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(105)))));
            this.btnComputer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer5.ForeColor = System.Drawing.Color.White;
            this.btnComputer5.Location = new System.Drawing.Point(322, 225);
            this.btnComputer5.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.btnComputer5.Name = "btnComputer5";
            this.btnComputer5.Size = new System.Drawing.Size(280, 188);
            this.btnComputer5.TabIndex = 4;
            this.btnComputer5.Text = "Máy 5";
            // 
            // btnComputer6
            // 
            this.btnComputer6.BorderRadius = 5;
            this.btnComputer6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComputer6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComputer6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComputer6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.btnComputer6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer6.ForeColor = System.Drawing.Color.White;
            this.btnComputer6.Location = new System.Drawing.Point(639, 225);
            this.btnComputer6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnComputer6.Name = "btnComputer6";
            this.btnComputer6.Size = new System.Drawing.Size(280, 188);
            this.btnComputer6.TabIndex = 5;
            this.btnComputer6.Text = "Máy 6";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(639, 446);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(280, 188);
            this.guna2Button3.TabIndex = 8;
            this.guna2Button3.Text = "Máy 9";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.guna2Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(5, 667);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(280, 188);
            this.guna2Button4.TabIndex = 9;
            this.guna2Button4.Text = "Máy 10";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 5;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(105)))));
            this.guna2Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(322, 667);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(280, 188);
            this.guna2Button5.TabIndex = 10;
            this.guna2Button5.Text = "Máy 11";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.guna2Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(639, 667);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(280, 188);
            this.guna2Button6.TabIndex = 11;
            this.guna2Button6.Text = "Máy 12";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(105)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(5, 446);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(280, 188);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Máy 7";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(99)))));
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(322, 446);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(5, 4, 32, 29);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(280, 188);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Máy 8";
            // 
            // UCComputerState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UCComputerState";
            this.Size = new System.Drawing.Size(1017, 1115);
            this.Load += new System.EventHandler(this.UCComputerState_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbbTypecomputer;
        private System.Windows.Forms.Label lblTypecomputer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel plError;
        private Guna.UI2.WinForms.Guna2Panel plOffline;
        private Guna.UI2.WinForms.Guna2Panel plOnline;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTypeonline;
        private System.Windows.Forms.Label lblOffline;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnComputer1;
        private Guna.UI2.WinForms.Guna2Button btnComputer2;
        private Guna.UI2.WinForms.Guna2Button btnComputer3;
        private Guna.UI2.WinForms.Guna2Button btnComputer4;
        private Guna.UI2.WinForms.Guna2Button btnComputer5;
        private Guna.UI2.WinForms.Guna2Button btnComputer6;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
