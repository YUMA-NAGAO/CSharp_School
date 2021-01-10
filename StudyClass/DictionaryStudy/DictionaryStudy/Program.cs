using System;
using System.Collections.Generic;

namespace DictionaryStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> fis = new Dictionary<string, int>();
            Dictionary<string, int> fis2 = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> sec = new Dictionary<string, Dictionary<string, int>>();

            fis.Add("stt", 89);
            fis.Add("ff", 80);
            fis2.Add("stt", 67);
            fis2.Add("ff", 58);
            sec.Add("aa", fis);
            sec.Add("bb", fis2);



            foreach(string kojinmei in sec.Keys)
            {
                Dictionary<string, int> kojinseiseki = sec[kojinmei];

                foreach(string kamokumei in kojinseiseki.Keys)
                {
                    if (kamokumei == "stt")
                    {
                        Console.WriteLine(kojinseiseki[kamokumei]);
                    }
                }
            }
        }
    }
}
