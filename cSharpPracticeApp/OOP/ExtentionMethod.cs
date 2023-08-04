using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary1;



namespace cSharpPracticeApp.OOP
{
    public static class ExtentionMethod
    {
           public static void ExtentionMethodExample(this Class1 obj)
           {    
                Console.ForegroundColor = ConsoleColor.Yellow;
                string str = "Extension methods in C# allow you to add new methods to existing classes without modifying their source code. They provide a way to extend the behavior of a class or interface, even if you don't have access to the original source code. Extension methods are defined in static classes and must be in the same namespace as the class you want to extend or included in the scope using a `using` directive.\r\n\r\nTo define an extension method, you need to follow these rules:\r\n\r\n1. The extension method must be defined in a static class.\r\n2. The extension method must be defined as a static method.\r\n3. The first parameter of the extension method must use the `this` keyword followed by the type you want to extend. This parameter represents the instance of the type being extended.\r\n4. You can use any valid access modifier (public, private, protected, internal) for the extension method.\r\n\r\nHere's a simple example of defining an extension method for the `int` type:\r\n\r\n```csharp\r\nusing System;\r\n\r\nnamespace ExtensionMethodsExample\r\n{\r\n    public static class IntExtensions\r\n    {\r\n        public static int Square(this int number)\r\n        {\r\n            return number * number;\r\n        }\r\n    }\r\n\r\n    class Program\r\n    {\r\n        static void Main()\r\n        {\r\n            int num = 5;\r\n            int squaredNum = num.Square(); // Using the extension method\r\n            Console.WriteLine(squaredNum); // Output: 25\r\n        }\r\n    }\r\n}\r\n```\r\n\r\nIn this example, we define an extension method `Square` for the `int` type. The method takes an integer as the first parameter (`this int number`), and we can call this method directly on an integer variable (e.g., `num.Square()`). The extension method calculates the square of the number and returns the result.\r\n\r\nIt's important to note that extension methods are just syntactic sugar and do not actually modify the original class. They can be useful for adding utility or convenience methods to existing types or for providing additional functionality to third-party libraries or types that you don't control.\r\n\r\nTo use extension methods in your project, make sure to include the namespace where the static class containing the extension method is defined using a `using` directive.\n\n";
                Console.WriteLine(str);
                Console.ResetColor();    
                List<int> list = new List<int>();
                for (int i = 0; i<10; i++)list.Add(i+10);
                Console.WriteLine("From Extend method");
                list.ForEach(x => Console.Write(x+" ")); 

           }
    }
    public class UseTestLibrary1
    {
            public void useOfTestLibrarrClass1()
                {
                    Class1 obj = new Class1();
            
                    obj.ExtentionMethodExample();
            
                    Console.WriteLine("\n\nFrom anouther Project");
                    obj.MyName = 10212;
                    obj.TestMethod();

                }

    }
    
}
