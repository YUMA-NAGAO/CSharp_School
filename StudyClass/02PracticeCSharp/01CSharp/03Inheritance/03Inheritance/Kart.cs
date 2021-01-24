using System;
using System.Collections.Generic;
using System.Text;

namespace _03Inheritance
{
    class Kart
    {
        public int weight;
        public int speed;



        public void Force()
        {
            Console.WriteLine("Accel or Slow");
        }
        
        public virtual void Horn()
        {
            Console.WriteLine("B.Bhooo");
        }
    }
}
