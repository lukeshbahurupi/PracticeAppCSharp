using cSharpPracticeApp.OOP;
using cSharpPracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 Encapsulation is one of the four fundamental principles of object-oriented programming (OOP) and is aimed at bundling data(attributes)
and methods(functions) that operate on that data within a single unit, known as a class.
It allows us to control the access to the internal state of an object and provides a mechanism to hide the implementation details from
the outside world.

In C#, encapsulation is achieved through the use of access modifiers, such as `public`, `private`, `protected`, and `internal`,
to define the visibility of class members (fields, properties, and methods). By setting appropriate access levels, 
we can enforce proper usage and prevent unwanted modifications to the object's state from outside the class.

 */
namespace cSharpPracticeApp.OOP
{
   
    internal class Encapsulation
    {
        public static void EncapsulationExample()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n \t\t** Encapsulation **");
            Console.WriteLine("Encapsulation is one of the four fundamental principles of object-oriented programming (OOP) and is aimed at bundling data(attributes)\r\nand methods(functions) that operate on that data within a single unit, known as a class.\r\nIt allows us to control the access to the internal state of an object and provides a mechanism to hide the implementation details from\r\nthe outside world.\r\n\r\nIn C#, encapsulation is achieved through the use of access modifiers, such as `public`, `private`, `protected`, and `internal`,\r\nto define the visibility of class members (fields, properties, and methods). By setting appropriate access levels, \r\nwe can enforce proper usage and prevent unwanted modifications to the object's state from outside the class.\r\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            // Creating a Student object
            Student student = new Student();

            // Setting properties using public setters
            student.Name = "John Doe";
            student.Age = 20;

            // Using the public method to set studentID
            student.SetStudentID("12345");

            // Displaying student information using the public method
            student.DisplayInfo();
        }
        
    }
}

/*

In this example, the `Student` class represents a student with properties `Name` and `Age`, which have public getters and setters.
The `studentID` field is kept private, and we provide a public method `SetStudentID` to set the studentID with possible validation logic.

The key points to understand encapsulation in this example are:

1.The `studentID` field is private, so it cannot be directly accessed from outside the class.
2.The `Name` and `Age` properties have public getters and setters, providing controlled access to the private fields.
3.The `SetStudentID` method encapsulates the logic of setting the studentID, allowing us to perform additional validation or 
other operations before actually setting the value.
4. The `DisplayInfo` method provides a controlled way to display the student's information, accessing the private fields through
public properties.

Encapsulation helps to achieve data hiding, data protection, and controlled access to class members, promoting better code 
maintainability, reusability, and security.
*/