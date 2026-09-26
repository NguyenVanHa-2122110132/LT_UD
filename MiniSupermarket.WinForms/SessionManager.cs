/*
 -Họ Và Tên: Nguyễn Văn Hà
-Lớp :CCQ2211D
-Mô Tả: SessionManager - lớp tĩnh lưu trữ JWT Token và vai trò (Role)
        của người dùng sau khi đăng nhập thành công, dùng chung cho
        toàn bộ ứng dụng WinForms trong suốt phiên làm việc.
 */

namespace MiniSupermarket.WinForms
{
    public static class SessionManager
    {
        // Lưu trữ JWT Token nhận từ Server
        public static string JwtToken { get; set; } = string.Empty;
        // Lưu trữ vai trò người dùng (Admin / Cashier) để phân quyền giao diện
        public static string CurrentRole { get; set; } = string.Empty;
    }
}