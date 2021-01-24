using System;
using System.Collections.Generic;
using System.Text;

namespace _03Inheritance
{
    class SkyKart:Kart
    {

        
        public void Flying()
        {
            Console.WriteLine("Take out");
        }

        public override void Horn()
        {
            Console.WriteLine("Pi.Piii");
        }
    }
}
