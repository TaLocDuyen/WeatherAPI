namespace WeatherAPI.Models
{
    public class WeatherResponse
    {
        public string Name { get; set; } // Tên thành phố
        public MainData Main { get; set; } // Nhiệt độ, độ ẩm
        public WeatherInfo[] Weather { get; set; } // Mô tả thời tiết
    }

    public class MainData
    {
        public float Temp { get; set; } // Nhiệt độ
        public float Humidity { get; set; } // Độ ẩm
    }

    public class WeatherInfo
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}