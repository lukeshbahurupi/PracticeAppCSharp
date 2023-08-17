using System;
using System.Numerics;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;
using cSharpPracticeApp.OOP;
using cSharpPracticeApp.CLASS;

namespace cSharpPracticeApp
{
    
    internal class Program
    {
        static void PrintMenu()
        {
          string menu = "Addtion ---- 1\n" +
                        "String Concatination ---- 2\n" +
                        "If Else ---- 3\n" +
                        "WhileLoop ---- 4\n" +
                        "Array and loops ---- 5\n" +
                        "Static Object Array ---- 6\n" +
                        "Dynamic Object Array ---- 7\n" +
                        "Two Dimention Array ---- 8\n" +
                        "Jagged Array ---- 9\n" +
                        "Binary Search ---- 10\n" +
                        "Linear Search ---- 11\n" +
                        "Clear Array Method ---- 12\n" +
                        "Copy Array Method ---- 13\n" +
                        "Reverse Array Method ---- 14\n" +
                        "Sort Array Method ---- 15\n" +
                        "different keywords ---- 16\n" +
                        "Create Groups of students ---- 17\n" +
                        "\n OOPS \n Encapsulation ---- 18\n" +
                        "Inheritance ---- 19\n" +
                        "Polymorphism ---- 20\n" +
                        "Abstraction ----21\n"+
                        "Interface ----22\n"+
                        "MultipleInterfaces ----23\n" +
                        "Extension methods ----24\n" +
                        "\nCollections\n" +
                        "ArrayList ____25\n" +
                        "List ____26\n" +
                        "";
            
            
            Console.WriteLine(menu);

            
        }

        static void ChooseOptionFromMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Your Choice of menu number:-");
            int n = Input.User<int>();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ControlStructures ConstrolStructure = new ControlStructures();
            switch (n)
            {
                case 1:
                    Console.Clear();
                    int number1, number2, Result;

                    Console.WriteLine("enter Number 1:- ");
                    number1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter Number 2:- ");
                    number2 = int.Parse(Console.ReadLine());

                    Result = number2 + number1;

                    Console.WriteLine("the sum of {0} and {1} is {2}", number1, number2, Result);
                break;
                       
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n \t\t** String concatenation **");
                    Console.WriteLine("String concatenation is the process of combining two or more strings to create a single, longer string.\r\nIn C#, string concatenation can be achieved using various methods and operators. \r\nThe most common methods for string concatenation are using the `+` operator, `string.Concat` method, and `StringBuilder`. \n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    string name = "Lukesh Bahurupi", company = "Arohi FI Management(IT)", designation = "Web App Developer";
                    int yearOfExper = 1;

                    Console.WriteLine($"I'm {name} and working with {company} as {designation} with Year of Experiance {yearOfExper} Year");
                break    ;

                case 3:Console.Clear();  ConstrolStructure.IfElse();   break;
                case 4:Console.Clear(); ConstrolStructure.WhileLoop();   break;
                case 5:Console.Clear(); ConstrolStructure.ArrayWithForAndForEachLoop();  break;
                case 6:Console.Clear(); ConstrolStructure.staticStudentInformation(); break;
                case 7:Console.Clear(); ConstrolStructure.dynamicStudentInformation(); break;
                case 8:Console.Clear(); ConstrolStructure.twoDArray(); break;
                case 9:Console.Clear(); ConstrolStructure.jaggedArray(); break;                    
                case 10:Console.Clear(); ConstrolStructure.BinarySerachMethod(); break;
                case 11:Console.Clear(); ConstrolStructure.ArrayLinearSearch(); break;
                case 12:Console.Clear(); ConstrolStructure.ClearArrayElements(); break;
                case 13:Console.Clear(); ConstrolStructure.CopyArrayElements(); break;
                case 14:Console.Clear(); ConstrolStructure.ReverseArray(); break;
                case 15:Console.Clear(); ConstrolStructure.SortArray(); break;
                case 16:Console.Clear(); keywords.keywordExample(); break;
                case 17:Console.Clear(); StudentGroup.createGroupOfStudents(); break;
                case 18:Console.Clear(); Encapsulation.EncapsulationExample();  break;
                case 19:Console.Clear(); Inheritance.InheritanceExample(); break;
                case 20:Console.Clear(); Polymorphism.PolymorphismExample(); break;
                case 21:Console.Clear(); Abstraction.AbstractionExample(); break;
                case 22:Console.Clear(); Interface.InterfaceExample(); break;
                case 23:Console.Clear(); MultipleInterfaces.MultipleInterfacesExample(); break;
                case 24:Console.Clear(); new UseTestLibrary1().useOfTestLibrarrClass1(); break;

                default:Console.Clear(); Console.WriteLine("Choice is incorrect");  break;
            }
        }
        static void Main(string[] args)
        {

            Print.valueln("string");
            Console.ForegroundColor = ConsoleColor.Red;
            PrintMenu();
            Console.ResetColor();

            ChooseOptionFromMenu();
            Console.ResetColor();

            

            Console.Read();
        }
    }
}
