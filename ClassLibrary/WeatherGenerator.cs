using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WeatherGenerator
    {
        double minTemperature;
        double maxTemperature;
        double minHumidity;
        double maxHumidity;
        double minWindSpeed;
        double maxWindSpeed;
        IRandomGenerator randomGenerator;

        public WeatherGenerator(double minTemperature, double maxTemperature, double minHumidity, double maxHumidity, double minWindSpeed, double maxWindSpeed, IRandomGenerator randomGenerator)
        {
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.minHumidity = minHumidity;
            this.maxHumidity = maxHumidity;
            this.minWindSpeed = minWindSpeed;
            this.maxWindSpeed = maxWindSpeed;
            this.randomGenerator = randomGenerator;
        }

        public void SetGenerator(IRandomGenerator randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }

        public Weather Generate()
        {
            double temperature = randomGenerator.GetRandomNumber(minTemperature,maxTemperature);
            double humidity = randomGenerator.GetRandomNumber(minHumidity, maxHumidity);
            double windSpeed = randomGenerator.GetRandomNumber(minWindSpeed, maxWindSpeed);

            return new Weather(temperature,humidity,windSpeed);
        } 

    }
}
