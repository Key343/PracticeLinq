using System;
namespace FactoryPatternExercise
{
    public static class HeadphoneFactory
    {
        public static IHeadphone GetHeadphone(string wiredVsWireless)
        {

            switch (wiredVsWireless)
            {
                case "wired":
                    return new Wired();
                case "wireless":
                    return new Wireless();
                default:
                    return new Wired();





            }


        }
    }
}
