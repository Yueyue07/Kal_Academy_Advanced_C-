using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Pianist : Musician
    {
        #region Constructor
        public Pianist()
        {
            Console.WriteLine("I am constructing Pianist");
        }
        #endregion

        #region Properties
        public int Experience { get; set; }
        #endregion

        #region Methods
        public override void Play()
        {
            Console.WriteLine("I am playing Piano");
        }
        #endregion
    }
}
