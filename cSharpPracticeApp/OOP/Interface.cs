using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp.OOP
{
    /*
     An interface in C# is a reference type that defines a contract or a set of rules that a class must follow.
    It only contains method signatures, properties, events, or indexers, without any implementation.
    A class that implements an interface is required to provide implementations for all the members declared in the interface.
     */
    public interface IDrawable
    {
        void Draw(); // Method signature for Draw()
    }
    public class GeoCircle : IDrawable
    {
        private int radius;

        public GeoCircle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {radius}");
        }
    }

    // Another class that implements the "IDrawable" interface
    public class GeoSquare : IDrawable
    {
        private int sideLength;

        public GeoSquare(int sideLength)
        {
            this.sideLength = sideLength;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a square with side length {sideLength}");
        }
    }

    internal class Interface
    {
           

        // Method to draw any shape that implements IDrawable
        static void DrawShape(IDrawable shape)
        {
            shape.Draw();
        }
        public static void InterfaceExample()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n \t\t** Interface **\n");
            Console.WriteLine(" An interface in C# is a reference type that defines a contract or a set of rules that a class must follow.\r\n    It only contains method signatures, properties, events, or indexers, without any implementation.\r\n    A class that implements an interface is required to provide implementations for all the members declared in the interface.\n");
            Console.ResetColor();
            // Create objects of Circle and Square
            GeoCircle circle = new GeoCircle(5);
            GeoSquare square = new GeoSquare(10);

            // Call the Draw() method on objects
            DrawShape(circle);
            DrawShape(square);
        }

       
    }
}
