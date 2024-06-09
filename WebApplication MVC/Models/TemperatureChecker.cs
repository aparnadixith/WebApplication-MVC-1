namespace WebApplication_MVC.Models
{
    public class TemperatureChecker
    {
        public static string CheckTemperature(float temperature, bool isFarenheit)
        {
            if (isFarenheit)
            {
                temperature = (temperature - 32) * 5 / 9;
            }
            if (temperature >= 38)
            {
                return "You have fever.";
            }
            else if (temperature < 35)
            {
                return " You have hypotermia.";
            }
            else
            {
                return "Your temperature is normal.";
            }
        }
    }
}
