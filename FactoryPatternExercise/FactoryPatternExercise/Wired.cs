using System;
namespace FactoryPatternExercise
{
    public class Wired : IHeadphone
    {
        public Wired()
        {
        }

        void IHeadphone.Listen()
        {
            Console.WriteLine(" Connected and Listening");
        }
    }
}
