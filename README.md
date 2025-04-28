
# 📚 Project - Quản lý Thiết bị & Dịch vụ (Sử dụng SQL Server + C#)

## 🛠 Công nghệ sử dụng
- C# (WinForms/WPF)
- SQL Server 2019
- Mô hình 3 lớp (**Three-Layer Architecture**)

## 🏛 Mô hình 3 lớp áp dụng

- **Model**:  
  Chứa các lớp đại diện dữ liệu (Entities) như: `Computer`, `Device`, `Inventory`, `Receipt`, `OrderService`, `Staff`,...

- **DAO (Data Access Object)**:  
  Chứa các lớp truy cập dữ liệu (Data Access Layer) dùng để kết nối và giao tiếp với cơ sở dữ liệu thông qua ADO.NET.  
  Bao gồm các phương thức: `Find`, `Insert`, `Update`, `Delete`, v.v...

- **Giao diện (UI)**:  
  Các Form hoặc màn hình giao diện người dùng cho phép thực hiện các chức năng:  
  - Đăng nhập
  - Quản lý máy tính
  - Quản lý thiết bị
  - Quản lý tồn kho
  - Quản lý hóa đơn dịch vụ...

## 📂 Các thành phần trong Database

- Các bảng: `Computer`, `Device`, `Inventory`, `OrderService`, `Receipt`, `Staff`
- Các Function (`fn_`) thay cho Stored Procedure (`sp_`), giúp lọc và tìm kiếm dữ liệu nhanh chóng:
  - `fn_FindComputerByName`
  - `fn_FindDevice`
  - `fn_FindInventory`
  - `fn_FindInventoryID`
  - `fn_FindInventoryType`
  - `fn_FindOrderByReceiptID`
  - `fn_FindReceipt`
  - `fn_FindStaff`

## 🔗 Cách thức hoạt động

1. Người dùng nhập thông tin (ví dụ: tìm máy tính, đăng nhập, thêm thiết bị).
2. Giao diện gọi tới DAO (tầng Data Access) để thực hiện câu lệnh SQL.
3. DAO nhận dữ liệu từ Database và đẩy về Model để UI hiển thị.

## 📑 Hướng dẫn chạy chương trình

- Cấu hình chuỗi kết nối Database trong `DBConnection.cs`
- Sử dụng file `.sql` để tạo Database và các hàm (`function`) trước khi chạy chương trình.
- Các Form giao diện sẽ gọi hàm DAO để thao tác.

---

### 🎯 Ghi chú:

- Các câu truy vấn sử dụng **Table-Valued Function** (`SELECT * FROM dbo.fn_FunctionName(@param)`) với `CommandType.Text` trong C#.
- Không sử dụng Stored Procedures trong phiên bản này.
- Đảm bảo Database đã khởi tạo trước khi chạy ứng dụng.

---

# 🖥 Demo Giao diện (nếu có)

(Có thể chèn thêm ảnh chụp màn hình Form nếu bạn cần.)

