using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    abstract class Musician
    {
        #region Constructor
        public Musician()
        {
            Console.WriteLine("I am a mucisian");
        }
        #endregion

        #region Properties
        public string Name { get; set; }

        public string Instrument { get; set; }
        #endregion

        #region Method
        public void Tune()
        {
            Console.WriteLine("Tuning the instrument!");
        }

        // abstract force inherited class to override
        public abstract void Play();
        #endregion
    }
}
