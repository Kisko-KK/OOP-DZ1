using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Weather
    {
        private double temperature;
        private double humidity;
        private double windSpeed;



        //KONSTRUKTORI

        public Weather()
        {
            temperature = 0;
            humidity = 0;
            windSpeed = 0;
        }

        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }


        //SET
        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }
        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }
        public void SetWindSpeed(double windspeed)
        {
            this.windSpeed = windspeed;
        }

        //GET
        public double GetTemperature()
        {
            return temperature;
        }
        public double GetHumidity()
        {
            return humidity;
        }
        public double GetWindSpeed()
        {
            return windSpeed;
        }

        //METODE
        public double CalculateFeelsLikeTemperature()
        {
            return -8.78469475556 + 1.61139411 * temperature + 2.33854883889 * humidity * 100 + -0.14611605 * humidity * 100 * temperature + -0.012308094 * (temperature * temperature) + -0.0164248277778 * ((humidity * 100) * (100 * humidity)) + 0.002211732 * (temperature * temperature) * humidity * 100 + 0.00072546 * temperature * ((humidity * 100) * (100 * humidity)) + -0.000003582 * ((humidity * 100) * (humidity * 100)) * (temperature * temperature);
        }

        public double CalculateWindChill()
        {
            if (temperature <= 10 && windSpeed > 4.8)
            {
                return 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);
            }
            else
                return 0.0;
        }

    }
}
