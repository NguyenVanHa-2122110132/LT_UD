/*
    -Họ Và Tên: Nguyễn Văn Hà
    -Lớp: CCQ2211D
    -Mô Tả: Controller WeatherForecastController thuộc namespace MiniSupermarket.API.Controllers,
           được cấu hình là API Controller với định tuyến theo tên controller.
           Cung cấp phương thức GET (GetWeatherForecast) để trả về danh sách 
           gồm 5 phần tử dữ liệu dự báo thời tiết ngẫu nhiên (bao gồm ngày, 
           nhiệt độ C và trạng thái thời tiết) dưới dạng mảng IEnumerable<WeatherForecast>.
*/
using Microsoft.AspNetCore.Mvc;

namespace MiniSupermarket.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
