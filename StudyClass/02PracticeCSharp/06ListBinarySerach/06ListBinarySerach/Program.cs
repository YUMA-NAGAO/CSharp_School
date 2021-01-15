using System;
using System.Collections.Generic;

namespace _06ListBinarySerach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> l = new List<double>();
            l.Add(10);
            l.Add(5);
            l.Add(2);
            l.Sort();
            //バイナリーサーチが、真ん中から変えるというものなので、小さいのから増えていくということを想定していない。
            //なので、下のリバースは行けない
            //l.Reverse();
            Console.WriteLine(l[0]);
            Console.WriteLine(l.BinarySearch(10));
        }
    }
}
