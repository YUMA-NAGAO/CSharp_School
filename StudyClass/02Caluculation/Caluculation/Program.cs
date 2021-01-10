using System;

namespace Caluculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = 1;
            b = 2;

            double c = a * 1.0;
            double d = b * 1.0;

            Console.WriteLine(c / d);
            double res;
            res = (double)b;

            double res2 = a / (double)b;
  
            Console.WriteLine(a/res);
            Console.WriteLine(res2);

            double fis = 3.4;
            int n = (int)fis;
            int z = (int)((fis - n) / 0.5);
            Console.WriteLine(n+z);

            int sec = (int)(fis +(fis - n) / 0.5);
            Console.WriteLine(sec);

//            これで、四捨五入できる
            int thr = (int)(fis + 0.5);
            Console.WriteLine(thr);

        }
    }
}
