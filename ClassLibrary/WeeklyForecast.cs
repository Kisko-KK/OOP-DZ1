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

        public override string ToString()
        {
            return $"{dailyForecasts[0].ToString()}\n" +
                   $"{dailyForecasts[1].ToString()}\n" +
                   $"{dailyForecasts[2].ToString()}\n" +
                   $"{dailyForecasts[3].ToString()}\n" +
                   $"{dailyForecasts[4].ToString()}\n" +
                   $"{dailyForecasts[5].ToString()}\n" +
                   $"{dailyForecasts[6].ToString()}\n";
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
