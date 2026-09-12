# HỆ THỐNG QUẢN LÝ SIÊU THỊ MINI (BACKEND & WINFORMS CLIENT)

Hệ thống quản lý siêu thị mini chuyên nghiệp, được xây dựng theo mô hình phân tách Client - Server với **ASP.NET Core Web API** (Backend) và **Windows Forms** (Frontend Client).

> 📌 **Lưu ý:** Đây là phiên bản nền tảng (**Buổi 1**) tập trung xây dựng kiến trúc cốt lõi và sẽ tiếp tục được phát triển, tích hợp Cơ sở dữ liệu (SQL Server, Entity Framework Core) cũng như các tính năng nâng cao trong các buổi tiếp theo!

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

**MiniSupermarket Management System** là đồ án thực hành môn học nhằm nắm vững kiến trúc lập trình ứng dụng phân tầng hiện đại. Giai đoạn đầu tập trung giải quyết bài toán giao tiếp dữ liệu thông qua RESTful API giữa dịch vụ máy chủ và ứng dụng máy trạm (Desktop Client).

---

## ⚡ TÍNH NĂNG GIAI ĐOẠN 1

### 1. Phía Backend (`MiniSupermarket.API`)
* **Xây dựng RESTful API chuẩn mực:** Cung cấp đầy đủ các phương thức HTTP cho phân hệ Quản lý Nhóm hàng (`Categories`).
* **Đầy đủ các thao tác CRUD (In-Memory Data):**
  * `GET /api/categories`: Lấy toàn bộ danh sách nhóm hàng.
  * `GET /api/categories/{id}`: Xem chi tiết nhóm hàng theo mã định danh[cite: 1].
  * `GET /api/categories/search?keyword=...`: Tìm kiếm linh hoạt theo từ khóa[cite: 1].
  * `POST /api/categories`: Thêm mới nhóm hàng hóa[cite: 1].
  * `PUT /api/categories/{id}`: Cập nhật thông tin nhóm hàng[cite: 1].
  * `DELETE /api/categories/{id}`: Xóa nhóm hàng theo ID[cite: 1].
* **Tài liệu API tự động:** Tích hợp sẵn giao diện **Swagger UI** giúp kiểm thử trực quan các endpoint[cite: 1].

### 2. Phía Client (`MiniSupermarket.WinForms`)
* **Giao diện trực quan (Windows Forms):** Thiết kế bảng dữ liệu `DataGridView` kết hợp các ô nhập liệu thao tác nhanh[cite: 1].
* **Tiêu thụ API bất đồng bộ:** Sử dụng `HttpClient` và gói `System.Net.Http.Json` để gửi nhận dữ liệu JSON mượt mà (`async/await`)[cite: 1].
* **Trải nghiệm người dùng:** Hỗ trợ tính năng tự động đổ dữ liệu lên form khi chọn dòng, làm mới danh sách và tìm kiếm nhanh chóng[cite: 1].

---

## 🚀 HƯỚNG DẪN CÀI ĐẶT VÀ CHẠY DỰ ÁN

1. **Clone project về máy tính:**
   ```bash
   git clone [https://github.com/NguyenVanHa-2122110132/LT_UD.git](https://github.com/NguyenVanHa-2122110132/LT_UD.git)