using Appka_Liczbowa;
using System;
using System.ComponentModel;
using System.Text;

namespace FirstProject
{
    internal class Program
    {

        private static void Main(string[] args)
        {

            Console.WriteLine("What is your Gender? 1 - Male, 2 - Female");
            string userInput = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("Only Women are allowed");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }
    }
}