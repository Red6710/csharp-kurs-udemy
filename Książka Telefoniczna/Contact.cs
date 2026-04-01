using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Książka_Telefoniczna
{
    internal class  Contact
    {
        public string Name { get; set; }
        public int Number {  get; set; }
        
        private static Dictionary<int, Contact> bookContacts = new Dictionary<int, Contact>
        {

        };

    public Contact(string name, int number )
        {
            Name = name;
            Number = number;


           int newKey = bookContacts.Count() > 0 ? bookContacts.Keys.Max() + 1: 0 ;
           bookContacts.Add(newKey, this);
         
        }
    public Contact FindContactByNumber( int number)
        {
            return bookContacts.Values.First(c => c.Number == number);
               
        }
    public Contact FindContactByName(string name)
        {
            return bookContacts.Values.First(c => c.Name == name);
        }

    public  static IEnumerable<Contact> GetAllContact()
        {
            return bookContacts.Values;
        }


    }
}
