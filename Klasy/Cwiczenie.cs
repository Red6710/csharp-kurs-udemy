using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Klasy
{
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
        
    }

    public class Square : IShape
    {
        string Name {  get; set; }
        double A {  get; set; }
        public Square (string name, int a) 
        {
            Name = name;
            A = a;
        }
        public double CalculateArea()
        {
            return  A * A;
            

        }
        public double CalculatePerimeter()
        {
            return 4 * A;
            

        }
    }

    public class Circle : IShape
    {
        string Name { get; set; }
        double R { get; set; }
        public Circle(string name, int r)
        {
            Name = name;
            R = r;
        }
        public double CalculateArea()
        {
            return Math.PI * (R*R);
            

        }
        public double CalculatePerimeter()
        {
            return  2 * Math.PI * R;
           
            
        }
    }
}

