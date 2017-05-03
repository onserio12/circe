using System;

namespace TestConsole
{
    public class Circle
    {
 
        // member variables
        double _radius;
  
        public Circle(double radius)
        {
            _radius = radius;
        
        }

        public double Diameter
        {
            get { return _radius*2; }
        }

        public double Circumference
        {
            get { return Math.PI * Diameter; }
        }
        public double Area
        {
            get { return Math.PI*Math.Pow(_radius, 2); }
        }

        public void Display()
        {
            Console.WriteLine("Radius: {0}", _radius);
            Console.WriteLine("Diameter: {0}", Diameter);
            Console.WriteLine("Circumference: {0}", Circumference);
            Console.WriteLine("Area: {0}", Area);
        }
    }

    class ExecuteCircle
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
          
            c.Display();
            Console.ReadLine();
        }
    }
}