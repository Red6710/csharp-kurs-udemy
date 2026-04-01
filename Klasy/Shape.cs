using System;
using System.Collections.Generic;
using System.Text;

namespace Klasy
{
    internal class Shape
    {
        public int x { get; set; }
        public int y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }
    class Circle2 : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        { 
           Console.WriteLine("Drawing Rectangle");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }
}
