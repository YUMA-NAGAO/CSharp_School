using System;
using System.Collections.Generic;
using System.Text;

namespace _02SampleRPG
{
    class Player
    {
        public string name;
        public int hp;

        public Player(string name, int hp)
        {
            this.name = name ;
            this.hp = hp;
        }

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        public void Defence()
        {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
