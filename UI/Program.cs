using System;
using ClassLibrary;

namespace UI
{
    class Program
    {

        static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
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




        private static void Main(string[] args)
        {
            Weather current = new Weather();
            current.SetTemperature(24.12);
            current.SetWindSpeed(3.5);
            current.SetHumidity(0.56);
            Console.WriteLine("Weather info:\n"
                + "\ttemperature: " + current.GetTemperature() + "\n"
                + "\thumidity: " + current.GetHumidity() + "\n"
                + "\twind speed: " + current.GetWindSpeed() + "");
            Console.WriteLine("Feels like: " + current.CalculateFeelsLikeTemperature()+"\n");


            
            

            
            Console.WriteLine("Finding weather info with largest windchill!");
            const int Count = 5;
            double[] temperatures = new double[Count] { 8.33, -1.45, 5.00, 12.37, 7.67 };
            double[] humidities = new double[Count] { 0.3790, 0.4555, 0.743, 0.3750, 0.6612 };
            double[] windSpeeds = new double[Count] { 4.81, 1.5, 5.7, 4.9, 1.2 };

            Weather[] weathers = new Weather[Count];
            for (int i = 0; i < weathers.Length; i++)
            {
                weathers[i] = new Weather(temperatures[i], humidities[i], windSpeeds[i]);
                Console.WriteLine("Windchill for weathers[" + i + "] is: " + weathers[i].CalculateWindChill());
            }
            Weather largestWindchill = FindWeatherWithLargestWindchill(weathers);
            Console.WriteLine(
                "Weather info:" + largestWindchill.GetTemperature() + ", " +
                largestWindchill.GetHumidity() + ", " + largestWindchill.GetWindSpeed()
            );
            



        }
    }
}
