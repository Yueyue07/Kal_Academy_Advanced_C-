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
            Pianist p = new Pianist();
            p.Name = "Ruby";
            p.Instrument = "Song";
            p.Experience = 15;
            p.Play();
            p.Tune();


            KeyboardPlayer kp = new KeyboardPlayer();
            kp.Play();
            kp.Tune();




            // polymorphism
            Musician m = kp; // my keyboard player is musician
            m.Play();
            m.Tune();
            Console.ReadLine();
        }
    }
}
