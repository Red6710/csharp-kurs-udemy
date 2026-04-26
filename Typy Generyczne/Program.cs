namespace Typy_Generyczne
{
    internal class Program
    {
        public delegate bool GenericPredicate<T>(T value);
        public delegate void Display(string value);

        static void Main(string[] args)
        {
           

            Display display = (string value) => Console.Write(value + ",");
            display("Kocham Pieski");
            var number = new[] { 1, 3, 40, 50 };

            //DisplayNumbers(number, display);
            var count = Count(number,(int value) => value > 45);
            Console.WriteLine(count);
            var strings = new string[] { "generic", "test", "test2" };
            var countStrings = Count(strings, (string value) => value.Length == 4);
            Console.Write(countStrings);
        }
        static void DisplayNumbers(IEnumerable<int> numbers, Display display)
          
        {
            foreach (int number in numbers)
            { 
            display(number.ToString());
            }

        }
        static int Count<T>(IEnumerable<T> elements, GenericPredicate<T> predicate)
        {
            int count = 0;
            foreach (T element in elements)
            {
                if (predicate(element))
                {
                    count++;
                }    
            }
            return count;
        }
    }
}
