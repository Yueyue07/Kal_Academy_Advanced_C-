using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Guitarist : Musician
    {
        public override void Play()
        {
            Console.WriteLine("I am playing guitar");
        }
    }
}
