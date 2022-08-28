using System;

namespace BaricadeCore
{
    public class RandomController
    {
        static Random random = new Random();

        public static Random GetRandom()
        {
            return random;
        }
    }
}