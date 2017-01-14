using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class KeyboardPlayer:Pianist
    {
        #region Constructor
        public KeyboardPlayer()
        {
            Console.WriteLine("I am constructing the KeyboardPlayer");
        }
        #endregion
        public override void Play() // overwrite Painist instead Mucisian
        {
            //base.Play();
            //Console.WriteLine("I am playing KeyBoard");
        }
    }
}
