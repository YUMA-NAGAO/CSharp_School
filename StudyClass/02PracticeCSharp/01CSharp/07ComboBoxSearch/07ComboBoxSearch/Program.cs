using System;
using System.IO;

namespace _07ComboBoxSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"\\Mac\Home\Downloads\GitHub\Lottery\Lottery\Lottery\ClassDataCSV";
            string[] files = Directory.GetFiles(dir, "*.csv");
            string[] data= { };
            int a = 0;
            foreach (string s in files)
            {

                Array.Resize(ref data, data.Length + 1);
                data[a] = s.Remove(0, 65);
                a += 1;

            }
            foreach (string s in data)
            {
                Console.WriteLine(s);
            }
        }
    }
}
