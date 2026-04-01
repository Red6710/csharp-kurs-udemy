using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy
{
    internal class WordDocument : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FileName} report... ");
        }
        public void Compress()
        {
            Console.WriteLine($"{FileName} compressing... ");
        }
    }
}
