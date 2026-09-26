/*
 -Họ Và Tên: Nguyễn Văn Hà
 -Lớp: CCQ2211D
 -Mô Tả: File khởi động chính của ứng dụng MiniSupermarket.WinForms.
         Chứa phương thức Main() làm điểm bắt đầu khi chạy chương trình.
         Ứng dụng thực hiện khởi tạo cấu hình WinForms thông qua
         ApplicationConfiguration.Initialize() và mở FormCategoryManagement
         làm giao diện chính của chương trình.
*/
namespace MiniSupermarket.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormCategoryManagement());
            Application.Run(new FormLogin());
        }
    }
}