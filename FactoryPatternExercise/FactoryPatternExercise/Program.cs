using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, is your headphones wired or wireless?");
            
            var input = Console.ReadLine().ToLower();



            var heaphone = HeadphoneFactory.GetHeadphone(input);
            heaphone.Listen();
        }
    }
}
