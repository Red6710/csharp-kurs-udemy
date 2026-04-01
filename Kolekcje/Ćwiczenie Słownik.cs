using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;

namespace Kolekcje
{
    
        public class EvenNumberGenerator
        {
            public static IEnumerable<int> GenerateEvenNumbers()
            {
                for (int i = 0; ; i++)
                {
                if (i % 2 == 0)
                    yield return i;
                }
               
            }
            static void Main(string[] args)
            {
                var data = GenerateEvenNumbers();
                foreach (var number in data)
                {
                Console.WriteLine(number);
                }

            }
        }
        

}
