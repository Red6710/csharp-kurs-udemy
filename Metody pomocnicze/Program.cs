using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;

namespace Metody_pomocnicze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input:");
            string userInput = Console.ReadLine();

            //Substring(userInput);
            //Modify(userInput);
            //Replace(userInput);
            //AlteredTextCase(userInput);
            //Split(userInput);
            //CheckString(userInput);
            //CamelCase(userInput);
            //KebabCase(userInput);
          StringUtils input = new StringUtils();
            input.ReverseString(userInput);
            Console.WriteLine(input.CountOccurrences("Text text Text Text ", " "));
        }

        static void Substring(string userInput)
        {
            if (userInput.Length > 10)
            {
                string startSubstring = userInput.Substring(0, 10);
                string endSubstring = userInput.Substring(userInput.Length - 10);
                Console.WriteLine($"{startSubstring}...., ....{endSubstring}");
            }
        }
        static void Replace(string userInput)
        {
            string template = "Hello {name}, how are you?";
            string output = template.Replace("{name}", userInput);
            Console.WriteLine(output);
        }
        static void Modify(string userInput)
        {
            string removedString = userInput.Remove(5);
            string insertedString = userInput.Insert(5, "Insert");
            Console.WriteLine(insertedString);
            string trimmedString = userInput.Trim();
            Console.WriteLine(trimmedString);
        }
        static void AlteredTextCase(string userInput)
        {
            string lowerCase = userInput.ToLower();
            string upperCased = userInput.ToUpper();
            Console.WriteLine(lowerCase);
            Console.WriteLine(upperCased);

        }
        static void Split(string userInput)
        {
            string[] inputParts = userInput.Split(" ");
            string firstName = inputParts[0];
            string lastName = inputParts[inputParts.Length - 1];
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }

        static void CheckString(string userInput)
        {
            bool isTextFile = userInput.EndsWith(".txt");
            bool isDoc = userInput.StartsWith("doc-");
            bool hasLetters = userInput.Contains("text", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(isTextFile);
            Console.WriteLine(isDoc);
            Console.WriteLine(hasLetters);
        }

        static void CamelCase(string userInput)
        {
            string[] stringWords = userInput.Split(" ");
            stringWords[0] = stringWords[0].ToLower();
            string output = stringWords[0];
            
            for (int i = 1; i < stringWords.Length; i++)
                {
                string word = stringWords[i].ToLower();
                stringWords[i] = char.ToUpper(word[0]) + word.Substring(1);
                output += stringWords[i];
                }

             Console.WriteLine(output);

        }
        static void KebabCase(string userInput)
        {
            string input = userInput.ToLower();
            string output =  input.Replace(" ", "-");
            Console.WriteLine(output);

        }

    }
}