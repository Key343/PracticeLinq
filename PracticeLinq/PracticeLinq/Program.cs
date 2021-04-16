using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>();

            videoGames.Add("SpiderMan");
            videoGames.Add("Arkham Knight");
            videoGames.Add("2k21");
            videoGames.Add("Madden");

            var gameNameLength = videoGames.OrderBy(x => x.Length);

            foreach (var num in gameNameLength)
            {
                Console.WriteLine(num);
            }





        }
    }
}
