using System;
using System.Collections.Generic;
using System.Text;

namespace _02SampleRPG
{
    class Player
    {
        private string name;
        private int hp;

        public Player()
        {
            this.hp = 1000;
            this.name = "Hik";
        }

        public Player(string name, int hp)
        {
            this.name = name ;
            this.hp = hp;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Hp
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }

            }
            get
            {
                return this.hp;
            }
        }

        public void SetHP(int hp)
        {
            this.hp = hp;
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }

        public int GetHp()
        {
            return this.hp;
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
