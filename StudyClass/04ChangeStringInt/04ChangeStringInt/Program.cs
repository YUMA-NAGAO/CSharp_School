using System;

namespace _04ChangeStringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "123";
            string s2 = "1222";

            int n = Int32.Parse(s1);
            int z = Int32.Parse(s2);

            Console.WriteLine(n + z);
        }
    }
}
