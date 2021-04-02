using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var conversion = new TempConverter();
            Console.WriteLine(conversion.FahrenheitToCelsius(32));
            Console.WriteLine(conversion.CelsiusToFahrenheit(0));
        }
    }
}
