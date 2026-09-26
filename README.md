# HỆ THỐNG QUẢN LÝ SIÊU THỊ MINI (BACKEND & WINFORMS CLIENT)

Hệ thống quản lý siêu thị mini chuyên nghiệp, được xây dựng theo mô hình phân tách Client - Server với **ASP.NET Core Web API** (Backend) và **Windows Forms** (Frontend Client).

> 📌 **Lưu ý:** Dự án đã hoàn thành các giai đoạn: **Buổi 1** (kiến trúc RESTful CRUD cốt lõi), **Buổi 2** (bảo mật xác thực JWT + phân quyền theo Role), và **Buổi 3** (tích hợp Cơ sở dữ liệu SQL Server qua Entity Framework Core, phát triển phân hệ Quản lý Khách hàng và tối ưu hóa tìm kiếm tiếng Việt).

---

## 👨‍🎓 THÔNG TIN SINH VIÊN

| Thông tin | Chi tiết |
| :--- | :--- |
| **Họ và tên** | Nguyễn Văn Hà |
| **MSSV** | 2122110132 |
| **Lớp học** | CCQ2211D |
| **Môn học** | Lập trình Ứng dụng .NET Core |
| **Giảng viên** | Nguyễn Cao Thái |
| **GitHub** | [NguyenVanHa-2122110132/LT_UD](https://github.com/NguyenVanHa-2122110132/LT_UD) |

---

## 📖 GIỚI THIỆU DỰ ÁN

**MiniSupermarket Management System** là đồ án thực hành môn học nhằm nắm vững kiến trúc lập trình ứng dụng phân tầng hiện đại. Dự án tập trung giải quyết bài toán giao tiếp dữ liệu thông qua RESTful API giữa dịch vụ máy chủ và ứng dụng máy trạm (Desktop Client), đồng thời đảm bảo các tiêu chuẩn về bảo mật (Stateless Authentication với JWT), phân quyền chức năng theo vai trò (`Admin` / `Cashier`), và tương tác dữ liệu thực tế với cơ sở dữ liệu quan hệ SQL Server thông qua ORM Entity Framework Core.

---

## ⚡ TÍNH NĂNG GIAI ĐOẠN 1 (BUỔI 1) — RESTful CRUD CỐT LÕI

### 1. Phía Backend (`MiniSupermarket.API`)
* **Xây dựng RESTful API chuẩn mực:** Cung cấp đầy đủ các phương thức HTTP cho phân hệ Quản lý Nhóm hàng (`Categories`).
* **Đầy đủ các thao tác CRUD:**
  * `GET /api/categories`: Lấy toàn bộ danh sách nhóm hàng.
  * `GET /api/categories/{id}`: Xem chi tiết nhóm hàng theo mã định danh.
  * `GET /api/categories/search?keyword=...`: Tìm kiếm linh hoạt theo từ khóa.
  * `POST /api/categories`: Thêm mới nhóm hàng hóa.
  * `PUT /api/categories/{id}`: Cập nhật thông tin nhóm hàng.
  * `DELETE /api/categories/{id}`: Xóa nhóm hàng theo ID.
* **Tài liệu API tự động:** Tích hợp sẵn giao diện **Swagger UI** giúp kiểm thử trực quan các endpoint.

### 2. Phía Client (`MiniSupermarket.WinForms`)
* **Giao diện trực quan (Windows Forms):** Thiết kế bảng dữ liệu `DataGridView` kết hợp các ô nhập liệu thao tác nhanh.
* **Tiêu thụ API bất đồng bộ:** Sử dụng `HttpClient` và gói `System.Net.Http.Json` để gửi nhận dữ liệu JSON mượt mà (`async/await`).

---

## 🔐 TÍNH NĂNG GIAI ĐOẠN 2 (BUỔI 2) — BẢO MẬT & PHÂN QUYỀN JWT

### 1. Phía Backend (`MiniSupermarket.API`)
* **Xác thực Stateless với JWT:**
  * `POST /api/auth/login`: Đăng nhập, trả về JWT Token + Role tương ứng.
  * Token được ký bằng khóa đối xứng (`SymmetricSecurityKey`, thuật toán `HmacSha256Signature`).
* **Bảo vệ tài nguyên với `[Authorize]`:** Toàn bộ endpoint yêu cầu Bearer Token hợp lệ mới truy cập được.
* **Phân quyền theo Role với `[Authorize(Roles = "...")]`:**
  * `GET /api/categories/admin-dashboard`: Chỉ tài khoản **Admin**.
  * `GET /api/categories/staff-pos`: Cả **Admin** và **Cashier**.
* **Tài khoản demo:**

  | Username | Password | Role |
  | :--- | :--- | :--- |
  | `admin` | `123456` | Admin |
  | `cashier` | `123456` | Cashier |

### 2. Phía Client (`MiniSupermarket.WinForms`)
* **Màn hình đăng nhập (`FormLogin`):** Gửi tài khoản/mật khẩu tới Server, nhận về Token và lưu trữ thông qua `SessionManager`.
* **Đính kèm Bearer Token tự động:** Gắn Header `Authorization: Bearer <token>` cho mọi request gọi tới Web API.

---

## 🗄️ TÍNH NĂNG GIAI ĐOẠN 3 (BUỔI 3) — SQL SERVER, EF CORE & QUẢN LÝ KHÁCH HÀNG

### 1. Phía Backend (`MiniSupermarket.API`)
* **Chuyển đổi sang Entity Framework Core & SQL Server:** Tái cấu trúc toàn bộ dữ liệu mẫu In-Memory sang `SupermarketDbContext`, kết nối trực tiếp cơ sở dữ liệu quan hệ SQL Server.
* **Mở rộng phân hệ Khách hàng (`CustomersController`):**
  * `GET /api/customers`: Lấy toàn bộ danh sách khách hàng thành viên (`AsNoTracking()`).
  * `GET /api/customers/{id}`: Xem chi tiết khách hàng theo mã.
  * `GET /api/customers/search?keyword=...`: Tìm kiếm khách hàng theo tên hoặc số điện thoại.
  * `POST /api/customers`: Thêm mới khách hàng với các trường dữ liệu chi tiết (`CustomerName`, `PhoneNumber`, `Address`, `RewardPoints`, `MembershipRank`).
  * `PUT /api/customers/{id}`: Cập nhật thông tin và hạng thẻ khách hàng.
  * `DELETE /api/customers/{id}`: Xóa tài khoản khách hàng (bảo mật nghiêm ngặt với phân quyền `[Authorize(Roles = "Admin")]`).

### 2. Phía Client (`MiniSupermarket.WinForms`)
* **Phân hệ Quản lý Khách hàng (`FormCustomerManagement`):** Giao diện tương tác chuyên nghiệp, tự động đính kèm `Bearer Token` từ phiên làm việc (`SessionManager`).
* **Xử lý triệt để lỗi tìm kiếm tiếng Việt có dấu:** 
  * Áp dụng hàm mã hóa URL an toàn **`Uri.EscapeDataString(keyword)`** trước khi gửi request lên Web API, giúp xử lý hoàn hảo các ký tự Unicode tiếng Việt (có dấu) và khoảng trắng mà không bị lỗi cú pháp HTTP/URI.
* **Tối ưu hóa giao diện người dùng (UI/UX):** 
  * Gộp và tinh chỉnh các ô nhập liệu tìm kiếm trực tiếp (truy vấn qua ô Tên hoặc SĐT) giúp giao diện gọn gàng, trực quan, loại bỏ các ô thừa thãi gây rối mắt.
  * Tích hợp đầy đủ các thao tác: Tải lại, Thêm mới, Cập nhật, Xóa (có phân quyền Admin) và tìm kiếm mượt mà.

---

## 🚀 HƯỚNG DẪN CÀI ĐẶT VÀ CHẠY DỰ ÁN

1. **Clone project về máy tính:**
   ```bash
   git clone [https://github.com/NguyenVanHa-2122110132/LT_UD.git](https://github.com/NguyenVanHa-2122110132/LT_UD.git)