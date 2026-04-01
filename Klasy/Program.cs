using System.Reflection;

namespace Klasy
{

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle2(), new Rectangle(), new Triangle() };

            foreach (Shape shape in shapes)
            {
                shape.Draw();     
                
            }
                
        }
    }
}