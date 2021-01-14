using System;
using System.Collections.Generic;
using System.Text;

namespace _03Inheritance
{
    class TurboKart:Kart
    {
        public void Turbo()
        {
            Console.WriteLine("Boost");
        }
        public override void Horn()
        {
            Console.WriteLine("BEE.bee");
        }
    }
}
