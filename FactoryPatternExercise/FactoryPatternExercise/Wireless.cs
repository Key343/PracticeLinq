using System;
namespace FactoryPatternExercise
{
    public class Wireless : IHeadphone
    {
        public Wireless()
        {
        }

        void IHeadphone.Listen()
        {
            Console.WriteLine("Listening on the Go");
        }
    }
}
