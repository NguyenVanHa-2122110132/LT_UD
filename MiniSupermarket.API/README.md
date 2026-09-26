# HỆ THỐNG QUẢN LÝ SIÊU THỊ MINI (BACKEND & WINFORMS CLIENT)

Hệ thống quản lý siêu thị mini chuyên nghiệp, được xây dựng theo mô hình phân tách Client - Server với **ASP.NET Core Web API** (Backend) và **Windows Forms** (Frontend Client).

> 📌 **Lưu ý:** Đây là phiên bản đã hoàn thành **Buổi 1** (kiến trúc RESTful CRUD cốt lõi) và **Buổi 2** (bảo mật xác thực JWT + phân quyền theo Role). Dự án sẽ tiếp tục tích hợp Cơ sở dữ liệu (SQL Server, Entity Framework Core) trong các buổi tiếp theo!

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

**MiniSupermarket Management System** là đồ án thực hành môn học nhằm nắm vững kiến trúc lập trình ứng dụng phân tầng hiện đại. Giai đoạn đầu tập trung giải quyết bài toán giao tiếp dữ liệu thông qua RESTful API giữa dịch vụ máy chủ và ứng dụng máy trạm (Desktop Client). Giai đoạn 2 nâng cấp hệ thống thành một ứng dụng có tính bảo mật thực tế: xác thực người dùng không trạng thái (Stateless Authentication) bằng JWT và phân quyền chức năng theo vai trò (Admin / Cashier).

---

## ⚡ TÍNH NĂNG GIAI ĐOẠN 1 (BUỔI 1) — RESTful CRUD

### 1. Phía Backend (`MiniSupermarket.API`)
* **Xây dựng RESTful API chuẩn mực:** Cung cấp đầy đủ các phương thức HTTP cho phân hệ Quản lý Nhóm hàng (`Categories`).
* **Đầy đủ các thao tác CRUD (In-Memory Data):**
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
* **Trải nghiệm người dùng:** Hỗ trợ tính năng tự động đổ dữ liệu lên form khi chọn dòng, làm mới danh sách và tìm kiếm nhanh chóng.

---

## 🔐 TÍNH NĂNG GIAI ĐOẠN 2 (BUỔI 2) — BẢO MẬT & PHÂN QUYỀN JWT

### 1. Phía Backend (`MiniSupermarket.API`)
* **Xác thực Stateless với JWT:**
  * `POST /api/auth/login`: Đăng nhập, trả về JWT Token + Role tương ứng.
  * Token được ký bằng khóa đối xứng (`SymmetricSecurityKey`, thuật toán `HmacSha256Signature`), thời hạn sống 2 giờ.
* **Bảo vệ tài nguyên với `[Authorize]`:** Toàn bộ endpoint trong `CategoriesController` yêu cầu Bearer Token hợp lệ mới truy cập được.
* **Phân quyền theo Role với `[Authorize(Roles = "...")]`:**
  * `GET /api/categories/admin-dashboard`: Chỉ tài khoản **Admin**.
  * `GET /api/categories/staff-pos`: Cả **Admin** và **Cashier**.
* **Cấu hình JwtBearer trong `Program.cs`:** Đăng ký `AddAuthentication().AddJwtBearer()`, thứ tự middleware bắt buộc `UseAuthentication()` → `UseAuthorization()`.
* **Swagger hỗ trợ Bearer Token:** Cấu hình `AddSecurityDefinition`/`AddSecurityRequirement` để test Token trực tiếp trên giao diện Swagger UI (nút Authorize 🔒).
* **Tài khoản demo:**

  | Username | Password | Role |
  | :--- | :--- | :--- |
  | `admin` | `123456` | Admin |
  | `cashier` | `123456` | Cashier |

### 2. Phía Client (`MiniSupermarket.WinForms`)
* **Màn hình đăng nhập (`FormLogin`):** Gửi tài khoản/mật khẩu tới `POST /api/auth/login`, nhận về Token và Role.
* **Quản lý phiên làm việc (`SessionManager`):** Lớp tĩnh lưu `JwtToken` và `CurrentRole` dùng chung toàn ứng dụng trong suốt phiên đăng nhập.
* **Đính kèm Bearer Token tự động:** `FormCategoryManagement` gắn Header `Authorization: Bearer <token>` cho mọi request GET/POST/PUT/DELETE tới Web API đã được bảo vệ.
* **Đổi Form khởi chạy:** `Program.cs` khởi động `FormLogin` trước, chỉ khi đăng nhập thành công mới mở màn hình quản lý danh mục.

---

## 🚀 HƯỚNG DẪN CÀI ĐẶT VÀ CHẠY DỰ ÁN

1. **Clone project về máy tính:**
   ```bash
   git clone https://github.com/NguyenVanHa-2122110132/LT_UD.git
   ```

2. **Mở Solution bằng Visual Studio 2022** (file `.sln` ở thư mục gốc).

3. **Chạy Backend (`MiniSupermarket.API`):**
   * Chuột phải vào project `MiniSupermarket.API` → **Set as Startup Project**.
   * Nhấn **F5** (hoặc Ctrl+F5) để chạy — Swagger UI sẽ tự mở tại `https://localhost:7101/swagger`.

4. **Chạy Client (`MiniSupermarket.WinForms`):**
   * Mở project thứ 2 (có thể chạy song song 2 project bằng **Multiple Startup Projects** trong Solution Properties).
   * Nhấn **F5** — màn hình `FormLogin` sẽ hiện lên đầu tiên.

5. **Đăng nhập thử nghiệm:**
   * Dùng tài khoản `admin`/`123456` hoặc `cashier`/`123456` (xem bảng tài khoản demo ở trên).
   * Sau khi đăng nhập thành công, màn hình quản lý danh mục (`FormCategoryManagement`) sẽ mở lên với dữ liệu đã được tải qua API có bảo vệ Token.

6. **Kiểm thử phân quyền qua Swagger UI (tùy chọn):**
   * Gọi `POST /api/auth/login` để lấy Token theo từng tài khoản.
   * Bấm nút **Authorize** 🔒 ở Swagger, dán `Bearer <token>` vào.
   * Gọi thử `GET /api/categories/admin-dashboard` và `GET /api/categories/staff-pos` để thấy sự khác biệt giữa quyền Admin và Cashier (200 OK vs 403 Forbidden).
