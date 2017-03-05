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
        // Has to Override Play Method, because it is inherited from abastract class' abstract method
        public override void Play()
        {
            Console.WriteLine("i am playing piano");
        }

        new public virtual void Tune()
        {
            Console.WriteLine("I am tuning a piano");
        }

        public override void Position()
        {
            //base.Position();
            Console.WriteLine("Pianist Level");
        }
        #endregion
    }
}
