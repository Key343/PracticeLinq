using System;
namespace StaticExercise
{
    public class TempConverter
    {
        public TempConverter()
        {
        }
        public double FahrenheitToCelsius(double temp)
        {
            var cel = (temp - 32) / 1.8;
                return cel;
        }
        public double CelsiusToFahrenheit(double temp)
        {
            var far =(temp * 1.8) + 32;
            return far;
        }
    }
}
