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
            Console.WriteLine("Addtion ---- 1");
            Console.WriteLine("String Concatination ---- 2");
            Console.WriteLine("If Else ---- 3");
            Console.WriteLine("WhileLoop ---- 4");
            Console.WriteLine("Array and loops ---- 5");
            Console.WriteLine(" Static Object Array ---- 6");
            Console.WriteLine("Dynamic Object Array ---- 7");
            Console.WriteLine("Two Dimention Array ---- 8");
            Console.WriteLine("Jagged Array ---- 9");
            Console.WriteLine("Binary Search ---- 10");
            Console.WriteLine("Linear Search ---- 11");
            Console.WriteLine("Clear Array Method ---- 12");
            Console.WriteLine("Copy Array Method ---- 13");
            Console.WriteLine("Reverse Array Method ---- 14");
            Console.WriteLine("Sort Array Method ---- 15");
            Console.WriteLine("different keywords ---- 16");
            Console.WriteLine("\n OOPS \n Encapsulation ---- 17");
            Console.WriteLine(" Inheritance ---- 18");
            Console.WriteLine(" Polymorphism ---- 19");
            
        }

        static void ChooseOptionFromMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Your Choice of menu number:-");
            int n = Input.User<int>();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            ControlStructures ConstrolStructure = new ControlStructures();
            switch (n)
            {
                case 1:
                    int number1, number2, Result;

                    Console.WriteLine("enter Nomber 1:- ");
                    number1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter Nomber 2:- ");
                    number2 = int.Parse(Console.ReadLine());

                    Result = number2 + number1;

                    Console.WriteLine("the sum of {0} and {1} is {2}", number1, number2, Result);
                break;

                case 2:
                    string name = "Komal Kate", company = "Arohi FI Management(IT)", designation = "UI/UX designer";
                    int yearOfExper = 1;

                    Console.WriteLine($"I'm {name} and working with {company} as {designation} with Year of Experiance {yearOfExper} Year");
                break    ;

                case 3: ConstrolStructure.IfElse();   break;

                case 4: ConstrolStructure.WhileLoop();   break;

                case 5: ConstrolStructure.ArrayWithForAndForEachLoop();  break;

                case 6: ConstrolStructure.staticStudentInformation(); break;

                case 7: ConstrolStructure.dynamicStudentInformation(); break;

                case 8: ConstrolStructure.twoDArray(); break;

                case 9: ConstrolStructure.jaggedArray(); break;
                    
                case 10: ConstrolStructure.BinarySerachMethod(); break;
                case 11: ConstrolStructure.ArrayLinearSearch(); break;
                case 12: ConstrolStructure.ClearArrayElements(); break;
                case 13: ConstrolStructure.CopyArrayElements(); break;
                case 14: ConstrolStructure.ReverseArray(); break;
                case 15: ConstrolStructure.SortArray(); break;
                case 16: keywords.keywordExample(); break;
                case 17: Encapsulation.EncapsulationExample(); break;
                case 18: Inheritance.InheritanceExample(); break;
                case 19: Polymorphism.PolymorphismExample(); break;

                default: Console.WriteLine("Choice is incorrect");  break;
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
