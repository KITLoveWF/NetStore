using Guna.UI2.WinForms;
using NetStore.DAO;
using NetStore.Form.Customer;
using NetStore.Form.FormCustomerAdmin;
using NetStore.Form.FormLoginAndFoget;
using NetStore.Form.FormMenu;
using NetStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.IO.Font;

namespace NetStore.Form.FormStateComputer
{
    public partial class StateComputer : System.Windows.Forms.Form
    {
        private string ComputerString;
        public StateComputer()
        {
            InitializeComponent();
            this.ucImport1.Hide();
            this.ucInvoice1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucFormStateComputer1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucMenu1.Hide();
            this.ucCustomer1.Hide();
            ucSideLeft1.btnStatecomputer.Click += performStateComputer;
            ucSideLeft1.btnImport.Click += performImport;
            ucSideLeft1.btnTotalreceipt.Click += performInvoice;
            ucSideLeft1.btnError.Click += performError;
            ucSideLeft1.btnFoodandrink.Click += menu;
            ucSideLeft1.btnCustomer.Click += customer;
            ucSideLeft1.btnLogout.Click += BtnLogout_Click;
            
            this.Size = new Size(1100, 700); // Đặt kích thước form

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void performStateComputer(object sender, EventArgs e)
        {
            this.ucFormStateComputer1.Show();
            this.ucImport1.Hide();
            this.ucInvoice1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucMenu1.Hide();
            this.ucCustomer1.Hide();
            this.ucFormStateComputer1.ucTypeComputer1.btnAddcomputer.Click += BtnAddcomputer_Click;


            StaffDAO staffDAO = new StaffDAO();
            DataTable staff = staffDAO.FindStaff(LoginSave.Username, LoginSave.Password);
            DataRow staffRow = staff.Rows[0];
            this.ucFormStateComputer1.ucSideBarTop1.lblNamestaff.Text = staffRow["nameStaff"].ToString();
            ComputerDAO computerDAO = new ComputerDAO();

            DataTable dataTable = computerDAO.LoadDB();
            this.ucFormStateComputer1.ucTypeComputer1.flpComputer.Controls.Clear();
            this.ucFormStateComputer1.ucTypeComputer1.flpComputer.Height = 400;
            foreach (DataRow dt in dataTable.Rows)
            {
                Guna2Button Computer = new Guna2Button();
                Computer.Text = dt["nameComputer"].ToString();
                Computer.BorderRadius = 5;
                Computer.Size = new Size(180, 130);
                Computer.Font = new Font("Cooper Black", 16F);
                Computer.Margin = new Padding(3, 3, 20, 20);
                
                if (dt["status"].ToString() == "1")
                {
                    Computer.FillColor = Color.FromArgb(137, 226, 105);
                }   
                else if (dt["status"].ToString() == "2")
                {
                    Computer.FillColor = Color.FromArgb(69, 175, 250);

                }   
                else if (dt["status"].ToString() == "3")
                {
                    Computer.FillColor = Color.FromArgb(255, 108, 99);
                }
                Computer.Click += Edit_Click;
                this.ucFormStateComputer1.ucTypeComputer1.flpComputer.Controls.Add(Computer);
            }
            this.ucFormStateComputer1.ucTypeComputer1.btnChooseComputer.Click += ChooseComputer;
            this.ucFormStateComputer1.ucReceiptComputer1.btnReceipt.Click += AnInvoice;
            this.ucFormStateComputer1.ucReceiptComputer1.Hide();
            this.ucFormStateComputer1.ucTopReceipt1.Hide();


            
        }

        private void BtnAddcomputer_Click(object sender, EventArgs e)
        {
            AddComputer addComputer = new AddComputer();
            //addComputer.Show();
            if(addComputer.ShowDialog() == DialogResult.OK)
            {
                LoadComputer();
            }    
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            Guna2Button Computer = sender as Guna2Button;
            EditComputer editComputer = new EditComputer();
            ComputerDAO computerDAO = new ComputerDAO();
            DataTable dataTable = computerDAO.FindComputer(Computer.Text);
            DataRow dataRow = dataTable.Rows[0];
            editComputer.txtNamecomputer.Text = Computer.Text;
            editComputer.txtMoney.Text = dataRow["price"].ToString();
            if (dataRow["status"].ToString() == "1")
            {
                editComputer.cbxTypecomputer.SelectedItem = "Online";
            }  
            else if(dataRow["status"].ToString() == "2")
            {
                editComputer.cbxTypecomputer.SelectedItem = "Offline";
            }
            else if (dataRow["status"].ToString() == "3")
            {
                editComputer.cbxTypecomputer.SelectedItem = "Error";
            }
            editComputer.id = Convert.ToInt32(dataRow["computerID"]);
            //editComputer.Show();
            if (editComputer.ShowDialog() == DialogResult.OK)
            {
                LoadComputer();
            }
        }

        private void ChooseComputer(object sender,EventArgs e)
        {
            ReceiptComputer receiptComputer = new ReceiptComputer();
            
            //receiptComputer.Show();
            if (receiptComputer.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(receiptComputer.Computer, "Name");
                ComputerString = receiptComputer.Computer;
                ComputerDAO computerDAO = new ComputerDAO();
                ReceiptDAO receiptDAO = new ReceiptDAO();
                DataTable computer = computerDAO.FindComputer(receiptComputer.Computer);
                if (computer.Rows.Count > 0)
                {
                    DataRow dataRowComputer = computer.Rows[0];
                    DataTable receipt = receiptDAO.FindReceipt(Convert.ToInt32(dataRowComputer["computerID"]));
                    if (receipt.Rows.Count > 0)
                    {
                        DataRow dataRowReceipt = receipt.Rows[0];
                        this.ucFormStateComputer1.ucTopReceipt1.lblNamecomputer.Text = dataRowComputer["nameComputer"].ToString();
                        this.ucFormStateComputer1.ucTopReceipt1.lblMoneyreal.Text = Convert.ToDouble(dataRowReceipt["computerCost"].ToString()).ToString("N0") + " VND";
                        DateTime timeBegin = Convert.ToDateTime(dataRowReceipt["timeBegin"]);
                        DateTime timeEnd = Convert.ToDateTime(dataRowReceipt["timeEnd"]);
                        TimeSpan timeUsed = timeEnd - timeBegin;
                        string formattedTime = $"{(int)timeUsed.TotalHours}h:{timeUsed.Minutes}'";
                        this.ucFormStateComputer1.ucTopReceipt1.lblTimereal.Text = formattedTime;
                        this.ucFormStateComputer1.ucTopReceipt1.Show();
                        
                        this.ucFormStateComputer1.ucReceiptComputer1.flpOrder.Controls.Clear();

                        OrderServiceDAO orderServiceDAO = new OrderServiceDAO();
                        DataTable Orders = orderServiceDAO.FindOrder(Convert.ToInt32(dataRowReceipt["receiptID"].ToString()));
                        foreach(DataRow dr in Orders.Rows)
                        {
                            System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
                            panel.Height = 50;
                            panel.Width = 350;
                            InventoryDAO inventoryDAO = new InventoryDAO();
                            DataTable Inventorys = inventoryDAO.FindInventoryID(Convert.ToInt32(dr["inventoryID"].ToString()));

                            if(Inventorys.Rows.Count > 0)
                            {

                                DataRow inventory = Inventorys.Rows[0];

                                System.Windows.Forms.Label nameInventory = new System.Windows.Forms.Label();
                                nameInventory.Text = inventory["nameInventory"].ToString();
                                nameInventory.Font = new Font("Palatino Linotype", 10f);
                                nameInventory.Location = new Point(0, 0);
                                nameInventory.AutoSize = true;


                                System.Windows.Forms.Label quantity = new System.Windows.Forms.Label();
                                quantity.Text = dr["quantityOrder"].ToString();
                                quantity.Font = new Font("Palatino Linotype", 10f);
                                quantity.Location = new Point(130,0);
                                quantity.AutoSize = true;


                                System.Windows.Forms.Label totalMoney = new System.Windows.Forms.Label();
                                double quantityValue = Convert.ToInt32(dr["quantityOrder"]);
                                double priceValue = Convert.ToDouble(inventory["sellingPrice"]);
                                totalMoney.Text = (quantityValue * priceValue).ToString("N0") + " VND";
                                totalMoney.Font = new Font("Palatino Linotype", 10f);
                                totalMoney.Location = new Point(220, 0);
                                totalMoney.AutoSize = true;

                                panel.Controls.Add(nameInventory);
                                panel.Controls.Add(quantity);
                                panel.Controls.Add(totalMoney);
                                this.ucFormStateComputer1.ucReceiptComputer1.flpOrder.Controls.Add(panel);

                            }
                            

                        }
                        this.ucFormStateComputer1.ucReceiptComputer1.Show();

                    }
                    else
                    {
                        this.ucFormStateComputer1.ucTopReceipt1.Hide();
                        this.ucFormStateComputer1.ucReceiptComputer1.Hide();
                    }


                }
            }
        }


        private void LoadComputer()
        {
            ComputerDAO computerDAO = new ComputerDAO();
            this.ucFormStateComputer1.ucTypeComputer1.flpComputer.Controls.Clear();

            DataTable dataTable = computerDAO.LoadDB();
            foreach (DataRow dt in dataTable.Rows)
            {
                Guna2Button Computer = new Guna2Button();
                Computer.Text = dt["nameComputer"].ToString();
                Computer.BorderRadius = 5;
                Computer.Size = new Size(180, 130);
                Computer.Font = new Font("Cooper Black", 16F);
                Computer.Margin = new Padding(3, 3, 20, 20);

                if (dt["status"].ToString() == "1")
                {
                    Computer.FillColor = Color.FromArgb(137, 226, 105);
                }
                else if (dt["status"].ToString() == "2")
                {
                    Computer.FillColor = Color.FromArgb(69, 175, 250);

                }
                else if (dt["status"].ToString() == "3")
                {
                    Computer.FillColor = Color.FromArgb(255, 108, 99);
                }
                Computer.Click += Edit_Click;
                this.ucFormStateComputer1.ucTypeComputer1.flpComputer.Controls.Add(Computer);
            }
        }


        private void AnInvoice(object sender, EventArgs e)
        {
          
                
                ComputerDAO computerDAO = new ComputerDAO();
                ReceiptDAO receiptDAO = new ReceiptDAO();
                DataTable computer = computerDAO.FindComputer(ComputerString);
                List<OrderService> orderspdf = new List<OrderService>();
                if (computer.Rows.Count > 0)
                {
                    DataRow dataRowComputer = computer.Rows[0];
                    DataTable receipt = receiptDAO.FindReceipt(Convert.ToInt32(dataRowComputer["computerID"]));
                    if (receipt.Rows.Count > 0)
                    {
                        DataRow dataRowReceipt = receipt.Rows[0];
                        string nameComputer = dataRowComputer["nameComputer"].ToString();
                        double computerCost = Convert.ToDouble(dataRowReceipt["computerCost"]);
                        double serviceCost = Convert.ToDouble(dataRowReceipt["serviceCost"]);
                        double totalCost = Convert.ToDouble(dataRowReceipt["totalPrice"]);

                        OrderServiceDAO orderServiceDAO = new OrderServiceDAO();
                        DataTable Orders = orderServiceDAO.FindOrder(Convert.ToInt32(dataRowReceipt["receiptID"].ToString()));
                        foreach (DataRow dr in Orders.Rows)
                        {
                            InventoryDAO inventoryDAO = new InventoryDAO();
                            DataTable Inventorys = inventoryDAO.FindInventoryID(Convert.ToInt32(dr["inventoryID"].ToString()));

                            if (Inventorys.Rows.Count > 0)
                            {

                                DataRow inventory = Inventorys.Rows[0];
                                int quantityOder = Convert.ToInt32(dr["quantityOrder"].ToString());
                                double quantityValue = Convert.ToInt32(dr["quantityOrder"]);
                                double priceValue = Convert.ToDouble(inventory["sellingPrice"]);
                                string nameInventory = inventory["nameInventory"].ToString();
                                OrderService orderService = new OrderService(quantityValue * priceValue,quantityOder , nameInventory);
                                orderspdf.Add(orderService);
                            }
                        }
                       
                        StaffDAO staffDAO = new StaffDAO();
                        DataTable staff = staffDAO.FindStaff(LoginSave.Username, LoginSave.Password);
                        DataRow staffRow = staff.Rows[0];
                        ExplorePDF("D://DAI HOC DUNG HOC DAI//THIRD//HK2//DBMS//bill.pdf", nameComputer, orderspdf, computerCost, serviceCost, totalCost, staffRow["nameStaff"].ToString());
                        receiptDAO.UpdateReceipt(Convert.ToInt32(dataRowReceipt["receiptID"]), Convert.ToInt32(staffRow["staffID"]));
                    }
                }
            

        }
        private void ExplorePDF(string filePath,string nameComputer, List<OrderService> items, double computerCost,double serviceCost,double totalCost,string nameStaff )
        {
            PdfWriter writer = new PdfWriter(filePath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            string fontpath = "D:\\DAI HOC DUNG HOC DAI\\THIRD\\HK2\\DBMS\\week3\\Project\\NetStore\\NetStore\\Resources\\arial.ttf";

            PdfFont font = PdfFontFactory.CreateFont(fontpath, PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.FORCE_EMBEDDED);
            document.Add(new Paragraph(nameComputer)
                .SetFont(font)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(11));

            iText.Layout.Element.Table table = new iText.Layout.Element.Table(3).UseAllAvailableWidth();
            table.AddHeaderCell(new Paragraph("Tên món").SetFont(font));
            table.AddHeaderCell(new Paragraph("Số lượng").SetFont(font));
            table.AddHeaderCell(new Paragraph("Thành tiền").SetFont(font));

            foreach (var item in items)
            {
                table.AddCell(new Paragraph(item.NameOrderService).SetFont(font));
                table.AddCell(new Paragraph(item.Quantity.ToString()).SetFont(font));
                table.AddCell(new Paragraph(item.Price.ToString("N0") + " VND").SetFont(font));
            }
            document.Add(table);
            document.Add(new Paragraph("\n"));

           
            document.Add(new Paragraph("Tiền máy: " + computerCost.ToString("N0") + " VND")
                .SetFont(font)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(11));

           
            document.Add(new Paragraph("Tiền dịch vụ: " + serviceCost.ToString("N0") + " VND")
                .SetFont(font)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(11));
            document.Add(new Paragraph("Nhân viên: " + nameStaff)
                .SetFont(font)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(11));

            string fontbold = "D:\\DAI HOC DUNG HOC DAI\\THIRD\\HK2\\DBMS\\week3\\Project\\NetStore\\NetStore\\Resources\\arialbd.ttf";

            PdfFont boldFont = PdfFontFactory.CreateFont(fontbold, PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.FORCE_EMBEDDED);
            document.Add(new Paragraph("Tổng cộng: " + totalCost.ToString("N0") + " VND")
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFont(boldFont)
                .SetFontSize(12));

            document.Close();

        }


        private void performImport(object sender, EventArgs e)
        {
            this.ucImport1.Show();
            this.ucFormStateComputer1.Hide();
            this.ucInvoice1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucMenu1.Hide();
            this.ucCustomer1.Hide();
            this.ucImport1.dgvImportRecord.DataSource = LoadInventoryRecord();
            this.ucImport1.btnImport.Click += AddInventoryImportRecord;
            this.ucImport1.btnRefresh.Click += LoadInventory;
        }

        private DataTable LoadInventoryRecord()
        {
            InventoryImportRecordDAO inventoryImportRecordDAO = new InventoryImportRecordDAO();
            DataTable dt = inventoryImportRecordDAO.LoadDB();
            DataTable displayTable = new DataTable();
            displayTable.Columns.Add("Tên món ăn");
            displayTable.Columns.Add("Tổng số món ăn");
            displayTable.Columns.Add("Tổng số món ăn nhập");
            displayTable.Columns.Add("Tổng số tiền của món ăn nhập vào");
            displayTable.Columns.Add("Nhân viên");
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = displayTable.NewRow();
                newRow["Nhân viên"] = row["staffName"];
                newRow["Tên món ăn"] = row["nameInventory"];
                newRow["Tổng số món ăn"] = row["totalQuantity"];
                newRow["Tổng số món ăn nhập"] = row["quantityImport"];
                newRow["Tổng số tiền của món ăn nhập vào"] = string.Format("{0:N0} VND", row["totalPriceImport"]);
                displayTable.Rows.Add(newRow);
            }
            return displayTable;

        }
        private void LoadInventory(object sender, EventArgs e)
        {
            this.ucImport1.dgvImportRecord.DataSource = LoadInventoryRecord();
        }
        private void AddInventoryImportRecord(object sender, EventArgs e)
        {
            if (this.ucImport1.txtInventoryName.Text == "" || this.ucImport1.txtInventoryQuantity.Text == "" || this.ucImport1.txtInventoryPrice.Text == "")
            {
                MessageBox.Show("Nhập sai thông tin món ăn hoặc thẻ cào", "Nhập món ăn và thẻ cào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.ucImport1.txtInventoryQuantity.Text != "" && !int.TryParse(this.ucImport1.txtInventoryQuantity.Text, out int result))
            {
                MessageBox.Show("Nhập sai số lượng món ăn hoặc thẻ cào", "Nhập món ăn và thẻ cào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.ucImport1.txtInventoryPrice.Text != "" && !double.TryParse(this.ucImport1.txtInventoryPrice.Text, out double Price))
            {
                MessageBox.Show("Nhập sai giá món ăn hoặc thẻ cào", "Nhập món ăn và thẻ cào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.ucImport1.txtInventoryName.Text != "" && this.ucImport1.txtInventoryQuantity.Text != "" && this.ucImport1.txtInventoryPrice.Text != "")
            {
                string InventoryName = this.ucImport1.txtInventoryName.Text;
                int quantity = Convert.ToInt32(this.ucImport1.txtInventoryQuantity.Text);
                double price = Convert.ToDouble(this.ucImport1.txtInventoryPrice.Text);
                InventoryImportRecord inventoryImportRecord = new InventoryImportRecord(quantity, price * quantity);
                inventoryImportRecord.InventoryName = InventoryName;
                InventoryImportRecordDAO inventoryImportRecordDAO = new InventoryImportRecordDAO();
                inventoryImportRecordDAO.Add(inventoryImportRecord);
            }
        }










        private void performInvoice(object sender, EventArgs e)
        {
            this.ucInvoice1.Show();
            this.ucFormStateComputer1.Hide();
            this.ucImport1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucMenu1.Hide();
            this.ucCustomer1.Hide();
            this.ucInvoice1.dgvInvoice.DataSource = LoadReceipt();

           
        }

        private DataTable LoadReceipt()
        {
            //DeviceImportRecordDAO deviceImportRecordDAO = new DeviceImportRecordDAO();
            //DataTable dt = deviceImportRecordDAO.LoadDB();
            ReceiptDAO receiptDAO = new ReceiptDAO();
            DataTable dt = receiptDAO.LoadDB();
            DataTable displayTable = new DataTable();
            displayTable.Columns.Add("Nhân viên");
            displayTable.Columns.Add("Tổng chi");
            displayTable.Columns.Add("Tổng thu");
            displayTable.Columns.Add("Tổng lợi nhuận");
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = displayTable.NewRow();
                newRow["Nhân viên"] = row["NameStaff"];
                newRow["Tổng chi"] = string.Format("{0:N0} VND", row["MoneySpent"]);
                newRow["Tổng thu"] = string.Format("{0:N0} VND", row["MoneyReceive"]);
                newRow["Tổng lợi nhuận"] = string.Format("{0:N0} VND", row["Revenue"]);
                displayTable.Rows.Add(newRow);
            }
            return displayTable;
        }
       
        
        
        
        
        
        private void performError(object sender, EventArgs e)
        {
            this.ucInvoice1.Hide();
            this.ucFormStateComputer1.Hide();
            this.ucImport1.Hide();
            this.ucCustomer1.Hide();
            this.ucMenu1.Hide();
            this.ucCompMaintainaceForm1.Show();
            this.ucCompMaintainaceForm1.dgvDeviceRecord.DataSource = LoadDeviceRecord();
            this.ucCompMaintainaceForm1.btnRefresh.Click += LoadDevice;
            this.ucCompMaintainaceForm1.btnMaintainance.Click += AddDeviceImportRecord;
        }
        private DataTable LoadDeviceRecord()
        {
            DeviceImportRecordDAO deviceImportRecordDAO = new DeviceImportRecordDAO();
            DataTable dt = deviceImportRecordDAO.LoadDB();
            DataTable displayTable = new DataTable();
            displayTable.Columns.Add("Tên thiết bị");
            displayTable.Columns.Add("Tổng số thiết bị");
            displayTable.Columns.Add("Tổng số thiết bị nhập");
            displayTable.Columns.Add("Tổng số tiền của thiết bị nhập vào");
            displayTable.Columns.Add("Nhân viên");
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = displayTable.NewRow();
                newRow["Nhân viên"] = row["staffName"];
                newRow["Tên thiết bị"] = row["nameDevice"];
                newRow["Tổng số thiết bị"] = row["totalQuantity"];
                newRow["Tổng số thiết bị nhập"] = row["quantityImport"];
                newRow["Tổng số tiền của thiết bị nhập vào"] = string.Format("{0:N0} VND", row["totalPriceImport"]);
                displayTable.Rows.Add(newRow);
            }
            return displayTable;

        }
        private void LoadDevice(object sender, EventArgs e)
        {
            this.ucCompMaintainaceForm1.dgvDeviceRecord.DataSource = LoadDeviceRecord();
        }
        private void AddDeviceImportRecord(object sender, EventArgs e)
        {
            if(this.ucCompMaintainaceForm1.txtDeviceName.Text == "" || this.ucCompMaintainaceForm1.txtDeviceQuantity.Text == "" || this.ucCompMaintainaceForm1.txtDevicePrice.Text == "")
            {
                MessageBox.Show("Nhập sai thông tin thiết bị","Nhập thiết bị",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.ucCompMaintainaceForm1.txtDeviceQuantity.Text != "" && !int.TryParse(this.ucCompMaintainaceForm1.txtDeviceQuantity.Text,out int result))
            {
                MessageBox.Show("Nhập sai số lượng thiết bị", "Nhập thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.ucCompMaintainaceForm1.txtDevicePrice.Text != "" && !double.TryParse(this.ucCompMaintainaceForm1.txtDevicePrice.Text,out double Price))
            {
                MessageBox.Show("Nhập sai giá thiết bị", "Nhập thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(this.ucCompMaintainaceForm1.txtDeviceName.Text!= "" && this.ucCompMaintainaceForm1.txtDeviceQuantity.Text!="" && this.ucCompMaintainaceForm1.txtDevicePrice.Text!="")
            {
                string DeviceName = this.ucCompMaintainaceForm1.txtDeviceName.Text;
                int quantity = Convert.ToInt32(this.ucCompMaintainaceForm1.txtDeviceQuantity.Text);
                double price = Convert.ToDouble(this.ucCompMaintainaceForm1.txtDevicePrice.Text);
                DeviceImportRecord deviceImportRecord = new DeviceImportRecord(quantity, price * quantity);
                deviceImportRecord.DeviceName = DeviceName;
                DeviceImportRecordDAO deviceImportRecordDAO = new DeviceImportRecordDAO();
                deviceImportRecordDAO.Add(deviceImportRecord);
            }    
           
        }











        //private void menu(object sender, EventArgs e)
        //{
        //    this.ucMenu1.Show();
        //    this.ucImport1.Hide();
        //    this.ucInvoice1.Hide();
        //    this.ucFormStateComputer1.Hide();
        //    this.ucCompMaintainaceForm1.Hide();
        //    this.ucCustomer1.Hide();
        //    this.ucMenu1.btnAdd.Click += AddFoodMenu;

        //    //this.ucMenu1.tabcom.Controls.Add(this.ucMenu1.flowcom);
        //    //this.ucMenu1.tabmy.Controls.Add(this.ucMenu1.flowmy);
        //    //this.ucMenu1.tabnuoc.Controls.Add(this.ucMenu1.flownuoc);
        //    //this.ucMenu1.tabthecao.Controls.Add(this.ucMenu1.flowthecao);


        //    this.ucMenu1.flowcom.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flowcom.WrapContents = true;
        //    this.ucMenu1.flowcom.AutoScroll = true;



        //    this.ucMenu1.flowmy.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flowmy.WrapContents = true;
        //    this.ucMenu1.flowmy.AutoScroll = true;



        //    this.ucMenu1.flownuoc.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flownuoc.WrapContents = true;
        //    this.ucMenu1.flownuoc.AutoScroll = true;

        //    this.ucMenu1.flowthecao.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flowthecao.WrapContents = true;
        //    this.ucMenu1.flowthecao.AutoScroll = true;
        //    //this.ucMenu1.flowthecao.AutoSize = false;



        //    InventoryDAO inventoryDAO = new InventoryDAO();
        //    DataTable dtCom = inventoryDAO.FindInventoryType("Food");
        //    DataTable dtNuoc = inventoryDAO.FindInventoryType("Drink");
        //    DataTable dtMy = inventoryDAO.FindInventoryType("Noodles");
        //    DataTable dtTheCao = inventoryDAO.FindInventoryType("Card");

        //    this.ucMenu1.flowcom.Controls.Clear();
        //    foreach (DataRow dr in dtCom.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //        itemFood.Size = new Size(205, 110);



        //        itemFood.itemname.Text = dr["nameInventory"].ToString();
        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;

        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.path = dr["image"].ToString();
        //        //MessageBox.Show(itemFood.Size.ToString(), "Cơm");

        //        itemFood.Click += Item_Click;
        //        this.ucMenu1.flowcom.Controls.Add(itemFood);
        //    }


        //    this.ucMenu1.flownuoc.Controls.Clear();
        //    foreach (DataRow dr in dtNuoc.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //        itemFood.Size = new Size(265, 125);
        //        itemFood.itemname.Text = dr["nameInventory"].ToString();

        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;

        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.path = dr["image"].ToString();
        //        itemFood.Click += Item_Click;

        //        this.ucMenu1.flownuoc.Controls.Add(itemFood);
        //    }

        //    this.ucMenu1.flowmy.Controls.Clear();
        //    foreach (DataRow dr in dtMy.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //        itemFood.Size = new Size(265, 125);
        //        itemFood.itemname.Text = dr["nameInventory"].ToString();

        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;

        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.path = dr["image"].ToString();
        //        itemFood.Click += Item_Click;

        //        this.ucMenu1.flowmy.Controls.Add(itemFood);
        //    }

        //    this.ucMenu1.flowthecao.Controls.Clear();
        //    foreach (DataRow dr in dtTheCao.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        //itemFood.AutoSize = false;
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        //        //itemFood.Size = new Size(300, 200);
        //        itemFood.itemname.Text = dr["nameInventory"].ToString();

        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;

        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.Size = new Size(265, 125);
        //        //MessageBox.Show("Thẻ cào",itemFood.Size.ToString());
        //        itemFood.path = dr["image"].ToString();
        //        itemFood.Click += Item_Click;
        //        this.ucMenu1.flowthecao.Controls.Add(itemFood);
        //    }
        //}
        private void menu(object sender, EventArgs e)
        {
            this.ucMenu1.Show();
            this.ucImport1.Hide();
            this.ucInvoice1.Hide();
            this.ucFormStateComputer1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucCustomer1.Hide();
            this.ucMenu1.btnAdd.Click += AddFoodMenu;

            // Cấu hình các flow layout
            this.ucMenu1.flowcom.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flowcom.WrapContents = true;
            this.ucMenu1.flowcom.AutoScroll = true;

            this.ucMenu1.flowmy.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flowmy.WrapContents = true;
            this.ucMenu1.flowmy.AutoScroll = true;

            this.ucMenu1.flownuoc.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flownuoc.WrapContents = true;
            this.ucMenu1.flownuoc.AutoScroll = true;

            this.ucMenu1.flowthecao.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flowthecao.WrapContents = true;
            this.ucMenu1.flowthecao.AutoScroll = true;

            InventoryDAO inventoryDAO = new InventoryDAO();
            DataTable dtCom = inventoryDAO.FindInventoryType("Rice");
            DataTable dtNuoc = inventoryDAO.FindInventoryType("Drink");
            DataTable dtMy = inventoryDAO.FindInventoryType("Noodles");
            DataTable dtTheCao = inventoryDAO.FindInventoryType("Card");

            // Lấy đường dẫn gốc của dự án và thư mục resources
            string rootPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string resourcesPath = Path.Combine(rootPath, "resources");

            this.ucMenu1.flowcom.Controls.Clear();
            foreach (DataRow dr in dtCom.Rows)
            {
                ItemFood item = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(205, 110));
                item.Size = new Size(205, 110); // nếu cần kích thước riêng cho "com"
                this.ucMenu1.flowcom.Controls.Add(item);
            }

            this.ucMenu1.flownuoc.Controls.Clear();
            foreach (DataRow dr in dtNuoc.Rows)
            {
                ItemFood item = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(265, 125));
                this.ucMenu1.flownuoc.Controls.Add(item);
            }

            this.ucMenu1.flowmy.Controls.Clear();
            foreach (DataRow dr in dtMy.Rows)
            {
                ItemFood item = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(265, 125));
                this.ucMenu1.flowmy.Controls.Add(item);
            }

            this.ucMenu1.flowthecao.Controls.Clear();
            foreach (DataRow dr in dtTheCao.Rows)
            {
                ItemFood item = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(265, 125));
                this.ucMenu1.flowthecao.Controls.Add(item);
            }

        }

        private void AddFoodMenu(object sender, EventArgs e)
        {
            AddNewFood addNewFood = new AddNewFood();   
            //addNewFood.Show();
            InventoryDAO inventoryDAO   = new InventoryDAO();
            DataTable dt = inventoryDAO.LoadDB();
            foreach(DataRow dr in dt.Rows)
            {
                addNewFood.cbxName.Items.Add(dr["nameInventory"]);
            }
            addNewFood.cbxCategory.Items.Add("Rice");
            addNewFood.cbxCategory.Items.Add("Drink");
            addNewFood.cbxCategory.Items.Add("Noodles");
            addNewFood.cbxCategory.Items.Add("Card");
            if (addNewFood.ShowDialog() == DialogResult.OK)
            {
                LoadMenu();
            }

        }
        private void Item_Click(object sender, EventArgs e)
        {
            ItemFood itemFood = sender as ItemFood;
            EditFood editFood = new EditFood();
            editFood.txtName.Text = itemFood.itemname.Text;
            string price = itemFood.itemprice.Text.Replace("VND","").Trim();
            editFood.txtPrice.Text = price;
            editFood.ptxImage.Image = itemFood.ptxBox.Image;
            editFood.ptxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            editFood.path = itemFood.path;
            //editFood.Show();
            if (editFood.ShowDialog() == DialogResult.OK)
            {
                LoadMenu();
            }
        }

        //private void LoadMenu()
        //{
        //    this.ucMenu1.flowcom.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flowcom.WrapContents = true;
        //    this.ucMenu1.flowcom.AutoScroll = true;



        //    this.ucMenu1.flowmy.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flowmy.WrapContents = true;
        //    this.ucMenu1.flowmy.AutoScroll = true;



        //    this.ucMenu1.flownuoc.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flownuoc.WrapContents = true;
        //    this.ucMenu1.flownuoc.AutoScroll = true;

        //    this.ucMenu1.flowthecao.FlowDirection = FlowDirection.LeftToRight;
        //    this.ucMenu1.flowthecao.WrapContents = true;
        //    this.ucMenu1.flowthecao.AutoScroll = true;
        //    //this.ucMenu1.flowthecao.AutoSize = false;



        //    InventoryDAO inventoryDAO = new InventoryDAO();
        //    DataTable dtCom = inventoryDAO.FindInventoryType("Food");
        //    DataTable dtNuoc = inventoryDAO.FindInventoryType("Drink");
        //    DataTable dtMy = inventoryDAO.FindInventoryType("Noodles");
        //    DataTable dtTheCao = inventoryDAO.FindInventoryType("Card");

        //    this.ucMenu1.flowcom.Controls.Clear();
        //    foreach (DataRow dr in dtCom.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //        itemFood.Size = new Size(205, 110);
        //        itemFood.itemname.Text = dr["nameInventory"].ToString();
        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;
        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.path = dr["image"].ToString();
        //        //MessageBox.Show(itemFood.Size.ToString(), "Cơm");

        //        itemFood.Click += Item_Click;
        //        this.ucMenu1.flowcom.Controls.Add(itemFood);
        //    }


        //    this.ucMenu1.flownuoc.Controls.Clear();
        //    foreach (DataRow dr in dtNuoc.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //        itemFood.Size = new Size(265, 125);
        //        itemFood.itemname.Text = dr["nameInventory"].ToString();
        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;
        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.path = dr["image"].ToString();
        //        itemFood.Click += Item_Click;

        //        this.ucMenu1.flownuoc.Controls.Add(itemFood);
        //    }

        //    this.ucMenu1.flowmy.Controls.Clear();
        //    foreach (DataRow dr in dtMy.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //        itemFood.Size = new Size(265, 125);
        //        itemFood.itemname.Text = dr["nameInventory"].ToString();
        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;
        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.path = dr["image"].ToString();
        //        itemFood.Click += Item_Click;

        //        this.ucMenu1.flowmy.Controls.Add(itemFood);
        //    }

        //    this.ucMenu1.flowthecao.Controls.Clear();
        //    foreach (DataRow dr in dtTheCao.Rows)
        //    {
        //        ItemFood itemFood = new ItemFood();
        //        //itemFood.AutoSize = false;
        //        itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        //        //itemFood.Size = new Size(300, 200);
        //        itemFood.itemname.Text = dr["nameInventory"].ToString();
        //        itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";
        //        itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
        //        itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
        //        itemFood.lblQuantity.UseCompatibleTextRendering = true;
        //        itemFood.ptxBox.Image = System.Drawing.Image.FromFile(dr["image"].ToString());
        //        itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //        itemFood.Size = new Size(265, 125);
        //        //MessageBox.Show("Thẻ cào",itemFood.Size.ToString());
        //        itemFood.path = dr["image"].ToString();
        //        itemFood.Click += Item_Click;
        //        this.ucMenu1.flowthecao.Controls.Add(itemFood);
        //    }

        //}
        private void LoadMenu()
        {
            // Thiết lập FlowDirection và Scroll cho các flow panel
            this.ucMenu1.flowcom.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flowcom.WrapContents = true;
            this.ucMenu1.flowcom.AutoScroll = true;

            this.ucMenu1.flowmy.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flowmy.WrapContents = true;
            this.ucMenu1.flowmy.AutoScroll = true;

            this.ucMenu1.flownuoc.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flownuoc.WrapContents = true;
            this.ucMenu1.flownuoc.AutoScroll = true;

            this.ucMenu1.flowthecao.FlowDirection = FlowDirection.LeftToRight;
            this.ucMenu1.flowthecao.WrapContents = true;
            this.ucMenu1.flowthecao.AutoScroll = true;

            // Lấy đường dẫn gốc tới thư mục resources
            string rootPath = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string resourcesPath = Path.Combine(rootPath, "resources");

            InventoryDAO inventoryDAO = new InventoryDAO();
            DataTable dtCom = inventoryDAO.FindInventoryType("Rice");
            DataTable dtNuoc = inventoryDAO.FindInventoryType("Drink");
            DataTable dtMy = inventoryDAO.FindInventoryType("Noodles");
            DataTable dtTheCao = inventoryDAO.FindInventoryType("Card");

            // === Load "Cơm" ===
            this.ucMenu1.flowcom.Controls.Clear();
            foreach (DataRow dr in dtCom.Rows)
            {
                ItemFood itemFood = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(205, 110));
                this.ucMenu1.flowcom.Controls.Add(itemFood);
            }

            // === Load "Nước" ===
            this.ucMenu1.flownuoc.Controls.Clear();
            foreach (DataRow dr in dtNuoc.Rows)
            {
                ItemFood itemFood = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(265, 125));
                this.ucMenu1.flownuoc.Controls.Add(itemFood);
            }

            // === Load "Mì" ===
            this.ucMenu1.flowmy.Controls.Clear();
            foreach (DataRow dr in dtMy.Rows)
            {
                ItemFood itemFood = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(265, 125));
                this.ucMenu1.flowmy.Controls.Add(itemFood);
            }

            // === Load "Thẻ cào" ===
            this.ucMenu1.flowthecao.Controls.Clear();
            foreach (DataRow dr in dtTheCao.Rows)
            {
                ItemFood itemFood = CreateItemFoodFromDataRow(dr, resourcesPath, new Size(265, 125));
                this.ucMenu1.flowthecao.Controls.Add(itemFood);
            }
        }



        private ItemFood CreateItemFoodFromDataRow(DataRow dr, string resourcesPath, Size itemSize)
        {
            ItemFood itemFood = new ItemFood();
            itemFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            itemFood.Size = itemSize;

            itemFood.itemname.Text = dr["nameInventory"].ToString();
            itemFood.itemprice.Text = Convert.ToDouble(dr["sellingPrice"]).ToString("N0") + " VND";

            itemFood.lblQuantity.Text = "Số lượng: " + dr["quantity"].ToString();
            itemFood.lblQuantity.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            itemFood.lblQuantity.UseCompatibleTextRendering = true;

            string imageFileName = dr["image"].ToString(); // ví dụ: "pho.jpg"
            string imagePath = Path.Combine(resourcesPath, imageFileName);

            if (!File.Exists(imagePath))
            {
                imagePath = Path.Combine(resourcesPath, "notfound.jpg");
            }

            itemFood.ptxBox.Image = System.Drawing.Image.FromFile(imagePath);

            itemFood.ptxBox.SizeMode = PictureBoxSizeMode.StretchImage;
            itemFood.path = imagePath;

            itemFood.Click += Item_Click;
            return itemFood;
        }
















        private void customer(object sender, EventArgs e)
        {
            this.ucCustomer1.Show();
            this.ucMenu1.Hide();
            this.ucImport1.Hide();
            this.ucInvoice1.Hide();
            this.ucFormStateComputer1.Hide();
            this.ucCompMaintainaceForm1.Hide();
            this.ucCustomer1.btnadd.Click += BtnaddCustomer_Click;
            this.ucCustomer1.dgvCustomer.CellMouseDown += DgvCustomer_CellMouseDown; ;
            this.ucCustomer1.dgvCustomer.CellClick += ECustomer;
            this.ucCustomer1.dgvCustomer.DataSource = LoadCustomer();
            //MessageBox.Show($"sao không có dữ liệu: {this.ucCustomer1.dgvCustomer.Rows[0].Cells[0].Value}kkk");
        }

        private void DgvCustomer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show($"xin chào {e.RowIndex}");
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 )
            {
                DataGridViewRow dgvrow = this.ucCustomer1.dgvCustomer.Rows[e.RowIndex];
                var customer = new Model.Customer(dgvrow.Cells[1].Value.ToString(), dgvrow.Cells[2].Value.ToString());
                customer.Id = Convert.ToInt32(dgvrow.Cells[0].Value.ToString());
                CustomerDAO customerDAO = new CustomerDAO();
                customerDAO.Delete(customer);
                LoadCustomerTable();
            }
        }
        private void BtnaddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            if(addCustomer.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerTable();
            }    
            //addCustomer.Show();
               
        }
        private void ECustomer(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("chỉnh form");
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow dgvrow = this.ucCustomer1.dgvCustomer.Rows[e.RowIndex];
                EditCustomer editCustomer = new EditCustomer(Convert.ToInt32(dgvrow.Cells[0].Value.ToString()));
                //MessageBox.Show($"{Convert.ToInt32(dgvrow.Cells[0].Value.ToString())}");
                //editCustomer.Show();
                editCustomer.txtUsername.Text = dgvrow.Cells[1].Value.ToString();
                editCustomer.txtPassword.Text = dgvrow.Cells[2].Value.ToString();
                if (editCustomer.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerTable();
                }
                //foreach (DataGridViewRow row in this.ucCustomer1.dgvCustomer.Rows)
                //{
                //    if (!row.IsNewRow)
                //    {
                //        string line = "";
                //        foreach (DataGridViewCell cell in row.Cells)
                //        {
                //            line += (cell.Value?.ToString() ?? "null") + " | ";
                //        }
                //        Console.WriteLine(line);
                //    }
                //}
            }

        }
        private DataTable LoadCustomer()
        {
            //DataTable dt = new DataTable();
            CustomerDAO customerDAO = new CustomerDAO();
            DataTable dt = customerDAO.LoadDB();
            DataTable displayTable = new DataTable();
            displayTable.Columns.Add("ID");
            displayTable.Columns.Add("Tài Khoản");
            displayTable.Columns.Add("Mật khẩu");
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = displayTable.NewRow();
                newRow["ID"] = row["customerID"];
                newRow["Tài khoản"] = row["username"];
                newRow["Mật khẩu"] = row["password"];
                displayTable.Rows.Add(newRow);
            }
            return displayTable;
        }
        private void LoadCustomerTable()
        {
            this.ucCustomer1.dgvCustomer.DataSource = LoadCustomer();
        }

    }
}
