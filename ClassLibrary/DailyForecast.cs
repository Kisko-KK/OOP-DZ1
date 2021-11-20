using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DailyForecast
    {
        private DateTime date;
        private Weather dayWeather;



        //CONSTRUCTORS
        public DailyForecast (DateTime date, Weather dayWeather)
        {
            this.date = date;
            this.dayWeather = dayWeather;
        }

        public DailyForecast()
        {
            date = new DateTime(2021,11,20);
            dayWeather = new Weather(0,0,0);
        }


        //PROPERTIES

        public Weather DayWeather
        {
            get { return dayWeather; }
        }

        //METHODS

        public string GetAsString()
        {
            return $"{date.ToString("dd/MM/yyyy HH:mm:ss")}: {dayWeather.GetAsString()}";

        }


        public static bool operator <(DailyForecast left, double right) {
            return left.dayWeather.GetTemperature() < right;
        }

        public static bool operator >(DailyForecast left, double right)
        {
            return left.dayWeather.GetTemperature() > right;
        }



    }
}
