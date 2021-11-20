using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WeeklyForecast
    {
        private DailyForecast[] dailyForecasts;


        //CONSTRUCTORS
        public WeeklyForecast(DailyForecast[] dailyForecasts) {
            this.dailyForecasts = dailyForecasts;
        }


        //METHODS

        public string GetAsString()
        {
            return $"{dailyForecasts[0].GetAsString()}\n" +
                   $"{dailyForecasts[1].GetAsString()}\n" +
                   $"{dailyForecasts[2].GetAsString()}\n" +
                   $"{dailyForecasts[3].GetAsString()}\n" +
                   $"{dailyForecasts[4].GetAsString()}\n" +
                   $"{dailyForecasts[5].GetAsString()}\n" +
                   $"{dailyForecasts[6].GetAsString()}\n";
        }


        public double GetMaxTemperature()
        {
            double max = -40;
            for(int i = 0; i < dailyForecasts.Length; i++)
            {
                if (dailyForecasts[i] > max)
                {
                    max = dailyForecasts[i].DayWeather.GetTemperature();
                }

            }

            return max;
        }

        public DailyForecast this[int index]
        {
            get { return dailyForecasts[index]; }
            set { dailyForecasts[index] = value; }
        }

    }
}
