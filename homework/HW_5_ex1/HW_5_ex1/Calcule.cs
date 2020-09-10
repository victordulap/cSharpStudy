using System;
using System.Collections.Generic;
using System.Text;

namespace CalculeNameSpace
{
    class Calcule
    {
        public static float Divide(int _1, int _2)
        {
            //double z;
            //try
            //{
            //    //return (_1 / Convert.ToDouble(_2));
            //    z = (_1 / /*Convert.ToDouble*/(float)_2);
            //}
            //catch (DivideByZeroException)
            //{
            //    throw new DivideByZeroException("Impartire la 0!");
            //}
            //return z;
            // cu catch nu lucreaza imi returneaza infinit daca am conversia la rezultat

            if (_2 == 0) throw new DivideByZeroException("Impartire la 0!");
            else return (_1 / /*Convert.ToDouble*/(float)_2);
        }
    }
}
