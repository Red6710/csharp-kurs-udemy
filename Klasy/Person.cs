using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Klasy
{
    internal class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dayOfBirth;
        private string contactNumber;
        public static int Count = 0;

        public string ContactNumber
        {
            get {  return contactNumber; }
            set 
            {
                if (value.Length < 0)
                {
                    Console.WriteLine("Invalid contact number");
                }
                else
                {
                    contactNumber = value;
                }
            }
        }
        public DateTime DayOfBirth
        {
            get { return dayOfBirth; }
            set
            {
                if(value > DateTime.Now)
            {
                    Console.WriteLine("Invalid date of Birth");
                }
            else
                {
                    dayOfBirth = value;
                }
            }
            

        }

        public Person(string  firstName, string lastName)
        {
            FirstName = firstName;
            LastName  = lastName;
            Count++;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth) : this(firstName, lastName)
        {
            DayOfBirth = dateOfBirth;
        }


        public void SayHi()
        {
            Console.WriteLine($"Hi, i'm {FirstName}, {DayOfBirth}");
        }
        
    }
}
