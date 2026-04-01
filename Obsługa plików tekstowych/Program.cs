using System;

namespace Obsluga_plikow_tekstowych
{
    class Program
    {
        static void ReadFiles()
        {
            var document1 = File.ReadAllText("D:\\Program Files\\TextFiles\\TextFile1.txt");
            var document2 = File.ReadAllLines("D:\\Program Files\\TextFiles\\TextFile2.txt");

            var document2String = string.Join(Environment.NewLine, document2);

            Console.WriteLine("document1");
            Console.WriteLine(document1);
            Console.WriteLine("document2");
            Console.WriteLine(document2String);

          
                
        }

        static void GenerateDocuments()
        {
            Console.WriteLine("Insert name");
            var name = Console.ReadLine();

            Console.WriteLine("Insert order number");
            var orderNumber = Console.ReadLine();

            var template1 = File.ReadAllText("D:\\Program Files\\TextFiles\\Write\\TextFile1.txt");

            var document = template1.Replace("{name}", name)
                 .Replace("{orderNumber}", orderNumber)
                 .Replace("{dateTime}", DateTime.Now.ToString());
            File.WriteAllText($"D:\\Program Files\\TextFiles\\Write\\TextFile-{orderNumber}.txt", document);
        }

        static void ScanAndAppend()
        {
            var files = Directory.GetFiles("D:\\Program Files\\TextFiles\\Append", "*.txt", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                File.AppendAllText(file, "All rights reserved");
            }
        }
        static void Main(string[] args)
        {
           
            ScanAndAppend();
        }

    }
 }
