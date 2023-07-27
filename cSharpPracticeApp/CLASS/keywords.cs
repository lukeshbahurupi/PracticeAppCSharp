using cSharpPracticeApp.CLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp.CLASS
    {
    /* 1. **`static`**:   */
    class MathUtils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    /*       In this example, the `Add` method is declared as `static`. This means you can call it without creating an instance of 
             the `MathUtils` class.
    */

    /*       2. **`this`**       */
    class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine(this.name);
        }
    }

    /*
            In the constructor of the `Person` class, we use `this.name` to refer to the instance variable `name` and assign the value passed to the constructor to it. It helps distinguish between the local parameter `name` and the instance variable `name`.
    */

    /*      3. **`base`**      */
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("base : Animal makes a sound.");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks.");
        }
    }
    /*
            In this example, we have an `Animal` class with a `MakeSound` method. The `Dog` class inherits from `Animal` and overrides the `MakeSound` method. In the `Dog` class, we use `base.MakeSound()` to call the `MakeSound` method from the `Animal` class and then add additional behavior to it.
    */

    /*      4. **`const`**          */
    class MathConstants
    {
        public const double Pi = 3.14159;
    }
    /*
            The `const` keyword is used to declare a constant field. In this example, we declare `Pi` as a constant with the value `3.14159`, and its value cannot be changed once it's assigned.
    */

    /*      5. **`readonly`**           */
    class Config
    {
        public readonly string ServerUrl;

        public Config()
        {
            ServerUrl = "http://example.com";
        }
    }
    /*
            The `readonly` keyword is used to declare a read-only field. It can be assigned only once, either during the declaration or in the constructor. After that, its value cannot be changed.
    */


    /*      6. **`enum`**       */
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    /*
        The `enum` keyword is used to declare an enumeration.
        In this example, we define an enumeration `DaysOfWeek` with the days of the week as named constants.
    */

    internal class keywords
    {
        public static void keywordExample()
        {
            int result = MathUtils.Add(10, 5);
            Console.WriteLine($"static :  {result}");

            new Person("this : Lukesh");

            Dog obj1 = new Dog();
            obj1.MakeSound();

            Config confg = new Config();           
            Console.WriteLine($"readonly :  {confg.ServerUrl}");



        }
        
    }
}












