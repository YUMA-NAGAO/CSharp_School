using System;
using System.Collections.Generic;

namespace _05ListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, Dictionary<string, int>>> AllData = new List<Dictionary<string, Dictionary<string, int>>>();
            Dictionary<string, Dictionary<string, int>> Datas = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> Data = new Dictionary<string, int>();

            int nn = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Data.Add(nn.ToString(), j);
                    nn++;
                    
                }
                Datas.Add(i.ToString(), Data);
                
            }
            AllData.Add(Datas);
            Console.WriteLine(AllData[0].Keys);

            string a = "";


        }
    }
}
