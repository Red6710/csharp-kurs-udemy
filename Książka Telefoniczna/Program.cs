
namespace Książka_Telefoniczna
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("1 - Dodaj Kontakt, 2 - Znajdź Kontakt, 3 - Wyświetl Wszystkie kontakty");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Proszę podaj nazwę nowego kontaktu");
                        string name = Console.ReadLine();
                        Console.WriteLine("Proszę podaj numer nowego kontaktu");
                        int number = int.Parse(Console.ReadLine());
                        new Contact(name, number);
                        Console.WriteLine("Kontakt został dodany");
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        foreach (Contact c in Contact.GetAllContact())
                        {
                            Console.WriteLine($"{c.Name} - {c.Number}");
                        }
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór");
                        break;

                }
            }       
        }
           
    }
}
