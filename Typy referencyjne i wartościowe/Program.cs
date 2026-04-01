using System;
using System.Drawing;

namespace Coding.Exercise
{
    public class TemperatureConverter
    {
         static bool CheckIfMinus(string sNumber, out int number)
        {
            if (int.TryParse(sNumber, out
              number))
            {
                if (number < 0)
                {
                   return true;
                }
                else
                {
                   return false;
                }
            }
            else
            {
                number = default;
                return false; 
            }
        }
        static void Main(string[] args)
        {
           

        }

    }

}
