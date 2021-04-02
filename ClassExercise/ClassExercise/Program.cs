using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Toyota = new Car();

            Toyota.Make = "Chevrolet";
            Toyota.Model = "Camaro";
            Toyota.Year = 2009;


            Console.WriteLine(Toyota.Make);
            Console.WriteLine(Toyota.Model);
            Console.WriteLine(Toyota.Year);



        }
    }
}
