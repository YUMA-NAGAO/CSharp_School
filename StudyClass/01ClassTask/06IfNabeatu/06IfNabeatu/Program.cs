using System;

namespace _06IfNabeatu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1111;
            int m = 27;
            int j = 13;


            if (NabeCheck(n))
            {
                Console.WriteLine("Aho");
            }
            else
            {
                Console.WriteLine("Not Aho");
            }

        }

        static bool NabeCheck(int n)
        {
            if (n % 3 == 0)
            {
                return true;
            }

            else
            {
                //無限ループ
                for (int i = 1; i > 0; i++)
                {
                    if (n % 10==3)
                    {
                        return true;
                    }
                    n = n / 10;
                    if (n == 0) { break; }
                }
                return false;
            }
        }
    }
}
