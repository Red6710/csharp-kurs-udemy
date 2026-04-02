using System.Reflection;
using System.Reflection.Metadata;

class Program
{
    public class Brace
    {

        public static bool validBraces(String braces)
        {
            var hasBrackets = braces.Contains("[");
            var hasbraces = braces.Contains("(");
            var hasCurlyBraces = braces.Contains("{");
            bool isCorrect = false;

            if (hasBrackets == true)
            {
               return isCorrect = braces.IndexOf(']') < braces.IndexOf('[');
               
            }
            return isCorrect;
        }

        static void Main(string[] args)
        {

            //Console.Write("Podaj datę urodzin w formacie DD.MM.RRRR:");
            //string dataUrodzin = Console.ReadLine(); 

            //DateTime dateOnly = (DateTime.Parse(dataUrodzin));

            //TimeSpan timeSpan = DateTime.Today - dateOnly;
            //Console.Write("Od twoich urodzin upłynęło:");

            //Console.WriteLine(timeSpan); 
            Console.WriteLine(validBraces("[]"));

        }
    }
}