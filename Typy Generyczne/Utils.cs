using System;
using System.Collections.Generic;
using System.Text;

namespace Typy_Generyczne
{
    public class Utils
    {
        public static void Swap<T>(ref T first,ref T second) 
        {
            T temp = first;
            first = second;
            second = temp;

        }
    }
}
