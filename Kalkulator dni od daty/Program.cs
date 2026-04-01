using System.Reflection;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Podaj datę urodzin w formacie DD.MM.RRRR:");
        string dataUrodzin = Console.ReadLine(); 

        DateTime dateOnly = (DateTime.Parse(dataUrodzin));

        TimeSpan timeSpan = DateTime.Today - dateOnly;
        Console.Write("Od twoich urodzin upłynęło:");

        Console.WriteLine(timeSpan); 
    }
}