using System;

namespace _03Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Kart[] karts = new Kart[2];

            karts[0] = new SkyKart();
            karts[1] = new TurboKart();

            for (int i = 0; i < karts.Length; i++)
            {
                karts[i].Horn();
            }
        }
    }
}
