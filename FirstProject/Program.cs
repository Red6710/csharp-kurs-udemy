using System;
using System.Text;
using FirstProject.Enums;

namespace FirstProject
{
     class Program
    {
        static void Main(string[] args)
        {
          

            string[] cars = { "Volvo", "BMW", "Mazda" };



            try
            {
                Console.WriteLine("Inside try -1");
                cars[4] = "Tesla";
                Console.WriteLine("Inside try -2");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Handiling Index out of Range Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Handiling any exception");
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }
            Console.WriteLine("outside of try-catch");

            Gender gender = Gender.Female;
        }
    }
}