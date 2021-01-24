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
            //int hp1 = player.GetHp();
            //int newHP1 = hp1 - 2000;
            //player.SetHP(newHP1);
            //Console.WriteLine("HPは" + player.GetHp());

            player.Hp -= 2000;
            Console.WriteLine("HPは" + player.Hp);
            Player player1 = new Player();

            Console.WriteLine(player1.Name+player1.Hp);


        }
    }
}
