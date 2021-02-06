using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06ComboAdd
{
    class AddCombo
    {
        public string[] DirectroyData()
        {
            string dir = @"\\Mac\Home\Downloads\GitHub\Lottery\Lottery\Lottery\ClassDataCSV";
            string[] files = Directory.GetFiles(dir, "*.csv");
            string[] data = { };
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
            return data;
        }
    }
}


