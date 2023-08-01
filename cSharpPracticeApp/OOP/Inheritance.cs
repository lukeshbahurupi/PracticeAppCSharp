using cSharpPracticeApp.OOP;
using cSharpPracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

/*
Inheritance is a fundamental concept in object-oriented programming (OOP) that allows one class to inherit the properties and
behaviors (fields and methods) of another class. The class that is inherited from is called the base class or parent class,
and the class that inherits from the base class is called the derived class or child class. Inheritance facilitates code reuse,
extensibility, and the creation of a hierarchical structure among classes.

In C#, you can implement inheritance using the `:` symbol followed by the name of the base class after the derived class declaration.
The derived class automatically gains access to all the public and protected members of the base class,
and it can also override the behavior of virtual methods from the base class.

Let's illustrate inheritance with an example:
*/

namespace cSharpPracticeApp.OOP
{
    class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }
    class Dog : Animal
    {
        public string Breed { get; set; }

        // Overriding the MakeSound method from the base class
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }

        public void Fetch()
        {
            Console.WriteLine("Dog is fetching.");
        }
    }
    internal class Inheritance
    {
        public static void InheritanceExample()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n \t\t** Inheritance **\n");
            Console.WriteLine("Inheritance is a fundamental concept in object-oriented programming (OOP) that allows one class to inherit the properties and\r\nbehaviors (fields and methods) of another class. The class that is inherited from is called the base class or parent class,\r\nand the class that inherits from the base class is called the derived class or child class. Inheritance facilitates code reuse,\r\nextensibility, and the creation of a hierarchical structure among classes.\r\n\r\nIn C#, you can implement inheritance using the `:` symbol followed by the name of the base class after the derived class declaration.\r\nThe derived class automatically gains access to all the public and protected members of the base class,\r\nand it can also override the behavior of virtual methods from the base class.\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            // Creating an instance of the derived class
            Dog dog = new Dog();

            // Accessing properties and methods from the base class
            dog.Species = "Canine";
            dog.Age = 3;
            dog.MakeSound(); // Output: Dog barks.

            // Accessing properties and methods specific to the derived class
            dog.Breed = "Labrador";
            dog.Fetch(); // Output: Dog is fetching.
        }
    }
}

/*
In this example, we have an `Animal` class as the base class, which has properties `Species` and `Age`, and a method `MakeSound`.
Then, we have a `Dog` class as the derived class, which inherits from the `Animal` class.
The `Dog` class has an additional property `Breed`, and it overrides the `MakeSound` method from the base class to provide its own
implementation.

Key points to understand inheritance:

1.The `Dog` class inherits the `Species` and `Age` properties and the `MakeSound` method from the `Animal` class.
2.The `Dog` class can also add its own members like the `Breed` property and the `Fetch` method.
3. The `MakeSound` method in the `Dog` class is marked with the `override` keyword, indicating that it overrides 
the `MakeSound` method from the base class.
4.In the `Main` method, we create an instance of the `Dog` class and access properties and methods from both 
the base and derived classes.

Inheritance allows us to create a hierarchy of related classes, 
enabling code reuse and organizing classes based on their common characteristics.
It promotes polymorphism, as you can treat derived objects as instances of their base class and still access their specific behaviors 
through overridden methods.
*/