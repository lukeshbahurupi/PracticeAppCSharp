using cSharpPracticeApp.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
/*
 Abstraction is one of the fundamental principles of object-oriented programming (OOP) and is closely related to encapsulation.
It is the process of simplifying complex systems by breaking them down into smaller, more manageable units. In the context of OOP,
abstraction allows you to define the essential characteristics and behaviors of an object while hiding the unnecessary details from
the outside world.

In C#, abstraction is achieved through abstract classes and interfaces. An abstract class cannot be instantiated and serves as a blueprint
for other classes. It can contain both abstract and non-abstract (concrete) methods. An abstract method has no implementation in the 
abstract class and must be overridden by the derived class. Interfaces, on the other hand, are like contracts that define a set of method
signatures that implementing classes must provide.
 */
namespace cSharpPracticeApp.OOP
{
    // Abstract class as an example of Abstraction
    abstract class GeometricShape
    {
        // Abstract method (no implementation)
        public abstract double CalculateArea();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a geometric shape.");
        }
    }

    // Derived class CircleShape that inherits from GeometricShape
    class CircleShape : GeometricShape
    {
        // Properties specific to CircleShape
        public double Radius { get; set; }

        // Implementation of abstract method CalculateArea for CircleShape
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class RectangleShape that inherits from GeometricShape
    class RectangleShape : GeometricShape
    {
        // Properties specific to RectangleShape
        public double Width { get; set; }
        public double Height { get; set; }

        // Implementation of abstract method CalculateArea for RectangleShape
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    internal class Abstraction
    {
        public static void AbstractionExample()
        {
            // Creating instances of CircleShape and RectangleShape
            CircleShape circle = new CircleShape { Radius = 5 };
            RectangleShape rectangle = new RectangleShape { Width = 4, Height = 6 };

            // Using the CalculateArea method without knowing the implementation details
            double circleArea = circle.CalculateArea();
            double rectangleArea = rectangle.CalculateArea();

            // Displaying the areas
            Console.WriteLine($"Circle Area: {circleArea}");
            Console.WriteLine($"Rectangle Area: {rectangleArea}");
        }
    }
}


/*
In this example, we have an abstract class `GeometricShape` representing a generic shape. It contains an abstract method `CalculateArea()` 
that has no implementation, and a concrete method `Display()`. The `GeometricShape` class hides the internal details of calculating the area
and displays a generic message.

Two classes, `CircleShape` and `Rectangle`, derive from the `GeometricShape` class and implement their specific `CalculateArea()` methods.
The `CircleShape` class calculates the area of a circle, and the `Rectangle` class calculates the area of a rectangle.

The `Main` method creates instances of `CircleShape` and `Rectangle`, calls their `CalculateArea()` methods, and displays the calculated areas.
It doesn't need to know how the areas are calculated internally; it only interacts with the abstract `GeometricShape` class and its abstract method,
which provides a level of abstraction.

Key points about abstraction in this example:

1.The `GeometricShape` class is abstract and cannot be instantiated directly.
2. The `GeometricShape` class provides the `CalculateArea()` method as an abstraction that must be implemented by derived classes.
3. The derived classes `CircleShape` and `Rectangle` provide their specific implementations for the `CalculateArea()` method.
4.The `Main` method interacts with the abstract `GeometricShape` class without knowing the concrete implementations of the `CalculateArea()` method 
in derived classes.

Abstraction allows you to design and use classes at a higher level of understanding, focusing on what an object does rather than how it does it, 
which leads to cleaner and more maintainable code.
*/