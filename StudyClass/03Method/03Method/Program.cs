using System;

namespace _03Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;


            Add(a, b);
            Console.WriteLine(Add2(a,b));

            double n = 3.5;

            Console.WriteLine(Round(n));
        }

        static  void Add(int a,int b)
        {
            Console.WriteLine(a + b);
               
        }

        static int  Add2(int a, int b)
        {
            return a + b;
        }

        static int Round(double n)
        {
            int res = (int)(n + 0.5);
            return res;
        }
    }
}
