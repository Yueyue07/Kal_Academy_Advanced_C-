using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Error: Abstract Class cannot be initiated
            // var muscician = new Musician();

            Console.WriteLine("**********");

            //Pianist p = new Pianist();
            //p.Name = "Ruby";
            //p.Instrument = "Song";
            //p.Experience = 15;
            //p.Play();

            KeyboardPlayer kb = new KeyboardPlayer();
            kb.Play();
            Console.ReadLine();
        }
    }
}
