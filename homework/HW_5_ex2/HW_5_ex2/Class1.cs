using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Editare
{
    class Class1
    {
        public static void Metoda(ref string[] str)
        {
            //foreach(string s in str)
            //{
            //    if (s.Equals("XXX")) str. = "YYY";
            //}
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToUpper().Equals("XXX"))
                {
                    str[i] = "YYY";
                }
            }
        }
    }
}
