

using System.ComponentModel;

namespace Kolekcje
{

    class Program
    {
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int element in list)
            {
                Console.Write($"{element},");
            }
            Console.WriteLine();
        }
        //static void Main(string[] args)
        //{
        //    List<int> intList = new List<int>() {6,1,29,3,45,69,199,2};
        //        DisplayElements(intList);

        //    Console.WriteLine("New element:");

        //    string userInput = Console.ReadLine();
        //    int intValue = int.Parse(userInput);

        //    intList.Add(intValue);
        //    DisplayElements(intList);

        //    Console.WriteLine("Remove range") ;
        //    intList.RemoveRange(1, 2);
        //    DisplayElements(intList);
        //    Console.WriteLine("sort");
        //    intList.Sort();
        //    DisplayElements(intList);

        //}
    }
}