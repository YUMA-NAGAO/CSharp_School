using System;

namespace _05For
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "6";
            int n = Int32.Parse(s);

            for (int i = 0; i< n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
