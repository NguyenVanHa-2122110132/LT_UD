/*
 -Họ Và Tên: Nguyễn Văn Hà
 -Lớp: CCQ2211D
 -Mô Tả: Lớp Category thuộc namespace MiniSupermarket.API.Models,
         dùng để biểu diễn thực thể Nhóm hàng hóa trong hệ thống
         MiniSupermarket.
         Lớp lưu trữ mã định danh nhóm hàng (CategoryId), tên nhóm hàng
         (CategoryName) và mô tả chi tiết nhóm hàng (Description).
         CategoryName được khởi tạo mặc định bằng chuỗi rỗng và
         Description có thể nhận giá trị null.
*/
namespace MiniSupermarket.API.Models
{
    // Lớp biểu diễn thực thể Nhóm hàng hóa trong siêu thị mini
    public class Category
    {
        // Mã định danh nhóm hàng (Khóa chính)
        public int CategoryId { get; set; }

        // Tên nhóm hàng (Bắt buộc, không được để trống)
        public string CategoryName { get; set; } = string.Empty;

        // Mô tả chi tiết về nhóm hàng (Có thể để trống)
        public string? Description { get; set; }
    }
}
