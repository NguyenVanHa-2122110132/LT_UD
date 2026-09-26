/*
 -Họ Và Tên: Nguyễn Văn Hà
 -Lớp: CCQ2211D
 -Mô Tả: Lớp Customer thuộc namespace MiniSupermarket.API.Models,
         biểu diễn thực thể Khách hàng thân thiết trong hệ thống
         MiniSupermarket (Bài tập mở rộng Buổi 3).
*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniSupermarket.API.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        [StringLength(100)]
        public string CustomerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Address { get; set; }

        public int RewardPoints { get; set; } = 0;

        [StringLength(50)]
        public string MembershipRank { get; set; } = "Chuẩn";
    }
}