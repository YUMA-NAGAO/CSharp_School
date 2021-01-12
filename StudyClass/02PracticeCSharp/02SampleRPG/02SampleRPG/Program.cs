using System;
using System.Collections.Generic;
using System.Linq;


namespace _02SampleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hp = { 420, 120, 6000, 0, 1200 };

            int[] newHP = hp.Where(n => n >= 500).ToArray<int>();

            foreach (int n in newHP)
            {
                Console.WriteLine(n);
            }

            Player player = new Player("ひろし", 100);

            Console.WriteLine(player.name + "体力は" + player.hp);
        
        }
    }
}
