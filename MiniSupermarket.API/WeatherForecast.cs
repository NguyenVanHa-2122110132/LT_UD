/*
 -Họ Và Tên: Nguyễn Văn Hà
 -Lớp: CCQ2211D
 -Mô Tả: Lớp WeatherForecast thuộc namespace MiniSupermarket.API,
         dùng để lưu trữ thông tin dự báo thời tiết.
         Lớp gồm ngày dự báo (Date), nhiệt độ theo độ C (TemperatureC),
         nhiệt độ được quy đổi sang độ F (TemperatureF) và thông tin mô tả
         thời tiết (Summary). Thuộc tính TemperatureF được tính tự động
         từ giá trị TemperatureC.
*/
namespace MiniSupermarket.API
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
