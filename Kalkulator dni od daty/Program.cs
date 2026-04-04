using System.ComponentModel;
using System.Reflection;
using System.Reflection.Metadata;
using System.Transactions;

class Program
{
    public class Brace
    {

        public static string LongestConsec(string[] strarr, int k)
        {
            var lenght = strarr.Length;
            string currentString;
            string longestString ="";
            
            for(int i =0; i<= lenght;)
            {
               
                currentString = string.Concat(strarr[i], strarr[i++]);
                i++;
                return  longestString = longestString.Length > currentString.Length ? longestString : currentString;
                
            }



            return longestString;
        }
        static void Main(string[] args)
        {

            //Console.Write("Podaj datę urodzin w formacie DD.MM.RRRR:");
            //string dataUrodzin = Console.ReadLine(); 

            //DateTime dateOnly = (DateTime.Parse(dataUrodzin));

            //TimeSpan timeSpan = DateTime.Today - dateOnly;
            //Console.Write("Od twoich urodzin upłynęło:");

            //Console.WriteLine(timeSpan); 
            Console.WriteLine(LongestConsec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2));

        }
    }

    
}

