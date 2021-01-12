using System;

namespace _07Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] FisInt;
            FisInt = new int[10];

            for (int i = 0; i <FisInt.Length; i++)
            {
                FisInt[i] =i;

            }
            //foreach(int n in FisInt)
            //{
            //    Console.WriteLine(n);
            //}

            int b = 2;
            int c = b;
            c = 5;
            Console.WriteLine("{0},{1}",b,c);

            int[] n = { 1, 2, 3 };
            int[] m = n;
            m[0] = 8;

            Console.WriteLine("{0},{1}", n[0], m[0]);
            
            
        }
    }
}
