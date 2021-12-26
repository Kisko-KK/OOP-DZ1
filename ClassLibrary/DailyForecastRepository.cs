using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DailyForecastRepository : IEnumerator, IEnumerable
    {
        List<DailyForecast> dailyForecasts;
        int position = -1;

        public DailyForecastRepository(DailyForecastRepository other)
        {
            dailyForecasts = new List<DailyForecast>();
            dailyForecasts.AddRange(other.dailyForecasts);
        }
        public DailyForecastRepository()
        {
            dailyForecasts = new List<DailyForecast>();
        }

        public void Add(DailyForecast dailyForecast)
        {
            foreach (DailyForecast daily in dailyForecasts)
            {
                if (ForecastUtilities.IsTheSameDate(daily.Date,dailyForecast.Date))
                {
                    dailyForecasts.Remove(daily);
                    break;
                }
            }
            dailyForecasts.Add(dailyForecast);           

            //sort by date
            dailyForecasts.Sort((x, y) => x.Date.CompareTo(y.Date));
        }

        public void Add(List<DailyForecast> dailyForecasts)
        {
            foreach (DailyForecast dailyForecast in dailyForecasts)
            {
                Add(dailyForecast);
            }
        }

        public void Remove(DateTime date)
        {
            bool dateIsFound = false;
            foreach (DailyForecast dailyForecast in dailyForecasts)
            {
                if (ForecastUtilities.IsTheSameDate(date,dailyForecast.Date))
                {
                    dailyForecasts.Remove(dailyForecast);
                    dateIsFound = true;
                    break;
                }
                if (dateIsFound == false) {
                    throw new NoSuchDailyWeatherException(date,$"No daily forecast for {date}");
                }
            }
        }        

        public override string ToString()
        {
            string output;
            output = string.Empty;

            foreach(DailyForecast dailyForecast in dailyForecasts)
            {
                output += $"{dailyForecast.ToString()}{Environment.NewLine}";
            }
            return output;
        }



        //IEnumerator and IEnumerable implementation
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return position < dailyForecasts.Count;
        }
        //IEnumerable
        public void Reset()
        {
            position = -1;
        }
        //IEnumerable
        public object Current
        {
            get { return dailyForecasts[position]; }
        }

    }
}
