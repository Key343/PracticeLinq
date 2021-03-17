using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber;
            favNumber = 3;

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < 3)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > 3) 
            {
                Console.WriteLine("Too High");
            }
            else { Console.WriteLine(" Nevermind "); }









            
        }
    }
}
