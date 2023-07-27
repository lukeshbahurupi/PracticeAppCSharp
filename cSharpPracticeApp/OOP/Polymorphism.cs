using cSharpPracticeApp.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
 * Polymorphism is one of the fundamental principles of object-oriented programming (OOP) and refers to the ability of different objects
 * (classes) to be treated as objects of a common base class, often allowing them to respond to the same method calls in different ways.
 * It allows you to write code that can work with objects of different types through a common interface or base class,
 * making your code more flexible, reusable, and easier to maintain.

There are two types of polymorphism in C#:

1. **Compile-time (Static) Polymorphism * *: This is achieved through method overloading and operator overloading.

2. **Run-time (Dynamic) Polymorphism * *: This is achieved through method overriding and interface-based polymorphism.
*/

namespace cSharpPracticeApp.OOP
{
    /*      *1.Compile - time(Static) Polymorphism * *:

        **Method Overloading**:
        Method overloading allows a class to have multiple methods with the same name but different parameter lists. 
        The correct method is determined at compile time based on the number and types of arguments passed to the method.
    */
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    /*      **2.Run - time(Dynamic) Polymorphism * *:

            **Method Overriding * *:
            Method overriding allows a derived class to provide a specific implementation for a method that is already defined in 
            the base class. The correct method to be executed is determined at runtime based on the actual type of the object.
    */

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    /*
    **Interface - based Polymorphism * *:
    Polymorphism can also be achieved using interfaces. An interface defines a contract that classes must implement. When a class implements an interface, it can be treated as an object of that interface type, allowing polymorphic behavior.
    */


    interface IShape
    {
        void Draw();
    }

    class Circles : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Squares : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }


    internal class Polymorphism
    {
        public static void PolymorphismExample()
        {
            Console.WriteLine("**Method Overloading**");
            MathOperations math = new MathOperations();

            // Compiler will choose the appropriate Add method based on argument types
            int sum1 = math.Add(5, 10);
            double sum2 = math.Add(2.5, 3.7);
            Console.WriteLine(sum1+"\n"+sum2);

            Console.WriteLine("**Method Overriding**");

            Shape shape1 = new Circle();
            Shape shape2 = new Square();

            // Polymorphic behavior: the correct Draw method is called based on the actual object type
            shape1.Draw(); // Output: Drawing a circle.
            shape2.Draw(); // Output: Drawing a square.

            Console.WriteLine("**Method Overriding**");

            IShape shape11 = new Circles();
            IShape shape22 = new Squares();

            // Polymorphic behavior: the correct Draw method is called based on the actual object type
            shape11.Draw(); // Output: Drawing a circle.
            shape22.Draw(); // Output: Drawing a square.
        }
    }
}

/*
    In both the method overriding and interface-based polymorphism examples,
    actual method called is determined at runtime based on the actual type of the object,
    which is what makes polymorphism dynamic and flexible.

    Polymorphism allows you to write code that can handle different types of objects through a common interface, 
    enabling you to design more versatile and maintainable applications.
*/