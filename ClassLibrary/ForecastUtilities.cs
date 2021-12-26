using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassLibrary
{
    public static class ForecastUtilities
    {

        public static DailyForecast Parse(string line)
        {
            string[] words = line.Split(',');


            //Parse string from dd/MM/YYYY to MM/dd/YYYY for DateTime instance
            CultureInfo provider = CultureInfo.InvariantCulture;
            provider = new CultureInfo("hr-HR");
            DateTime time = DateTime.Parse(words[0], provider);


            double temperature, windSpeed, humidity;
            temperature = double.Parse(words[1]);
            humidity = double.Parse(words[2]);
            windSpeed = double.Parse(words[3]);


            return new DailyForecast(time, new Weather(temperature, windSpeed, humidity));
        }

        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            int i;
            double max = -100;
            Weather maxWeather = weathers[0];
            for (i = 0; i < weathers.Length; i++)
            {
                if (weathers[i].GetTemperature() <= 10 && weathers[i].GetWindSpeed() > 4.8)
                {
                    if (weathers[i].CalculateWindChill() > maxWeather.CalculateWindChill())
                    {
                        max = weathers[i].CalculateWindChill();
                        maxWeather = weathers[i];
                    }

                }
            }
            return maxWeather;
        }


        public static void PrintWeathers(IPrinter[] printers, Weather[] weathers)
        {
            foreach(IPrinter printer in printers)
            {
                foreach (Weather weather in weathers)
                {
                    printer.Print(printer, weather);
                }
            }
        }


        public static bool IsTheSameDate(DateTime left, DateTime right)
        {
            return left.Day == right.Day && left.Date.Month == right.Month && left.Date.Year == right.Year;
        }

    }
}
