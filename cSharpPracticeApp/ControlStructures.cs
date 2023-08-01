using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Mathematics;


namespace cSharpPracticeApp
{
    internal class ControlStructures
    {
        
        public void IfElse()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n \t\t** if esle  Statements**");
            Console.WriteLine("`if` and `else` are conditional statements used in programming to make decisions based on the evaluation of certain conditions. They control the flow of execution in a program by allowing different blocks of code to be executed based on whether a specific condition is true or false.\r\n\r\nHere's an overview of `if` and `else` statements:\r\n\r\n1. **if statement**: The `if` statement allows you to execute a block of code only if a specified condition is true. If the condition is false, the block of code is skipped, and the program continues to the next statement.\r\n\r\n2. **else statement**: The `else` statement is used in combination with the `if` statement. It allows you to specify an alternative block of code to be executed if the `if` condition is false.\r\n\r\n3. **else if statement**: The `else if` statement is used to specify additional conditions to check after the initial `if` condition. It allows you to chain multiple conditions and execute different blocks of code based on the evaluation of each condition.\r\n\r\n4. **Nested if-else**: You can also nest `if` and `else` statements inside each other to create more complex decision-making scenarios. This allows you to handle different cases and conditions more precisely.\r\n\r\nThe general syntax for `if` and `else` statements is as follows:\r\n\r\n```csharp\r\nif (condition)\r\n{\r\n    // Code to execute if the condition is true\r\n}\r\nelse if (condition2)\r\n{\r\n    // Code to execute if condition2 is true (optional, can have multiple else if blocks)\r\n}\r\nelse\r\n{\r\n    // Code to execute if none of the conditions above are true (optional)\r\n}\r\n```\r\n\r\nIn C#, the condition in an `if` statement must evaluate to a Boolean value (`true` or `false`). If the condition is true, the block of code following the `if` statement is executed. If the condition is false, the program checks the `else if` statements (if present) or executes the `else` block (if present).\r\n\r\nBy using `if` and `else` statements, you can control the flow of your program based on certain conditions, making your code more dynamic and responsive to different scenarios.\r\n\r\nIt's important to handle all possible cases and edge cases in your code to ensure that it behaves as expected under various conditions. Properly using `if` and `else` statements helps you write robust and reliable programs.\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            /*get gread from marks*/
            Console.WriteLine("Enter Marks:-");
            int marks = int.Parse(Console.ReadLine());
            if (marks > 100) Console.WriteLine("Invalid!!!!");
            else if (marks >= 75)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Grade A");
            }else if (marks >= 60)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Grade B");
            }else if (marks>=45)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!!!!!!!!!!");
            }
            
        }
        public void WhileLoop()
        {

            Console.WriteLine("Enter Number to Generate table :-");
            int num = int.Parse(Console.ReadLine()),i=0;

            while(i++<10)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }

        }
        public void ArrayWithForAndForEachLoop()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n \t\t** Array (1-D) **");
            Console.WriteLine("An array is a data structure in C# that allows you to store a collection of elements of the same type in a contiguous block of memory. It provides a convenient and efficient way to access and manipulate multiple elements at once. Arrays are widely used in programming to hold lists of items such as numbers, characters, or objects.\r\n\r\nKey points about arrays in C#:\r\n\r\n1. **Fixed Size**: Arrays have a fixed size, meaning you need to specify the number of elements it can hold when creating the array. Once the array is created, its size cannot be changed.\r\n\r\n2. **Zero-based Indexing**: Elements in an array are accessed using an index, which starts from 0 for the first element, 1 for the second element, and so on. The last element's index is one less than the array's size.\r\n\r\n3. **Single Type**: All elements in an array must be of the same data type (e.g., int, string, char, etc.). C# does not allow mixing different data types in a single array.\r\n\r\n4. **Contiguous Memory**: The elements in an array are stored in contiguous memory locations. This property enables fast access to elements using their index.\r\n\r\n5. **Length Property**: You can find the number of elements in an array using its `Length` property.\r\n\r\n6. **Declaration and Initialization**: Arrays can be declared and initialized using square brackets `[]` with the number of elements specified in the declaration, or using the `new` keyword along with the array type.\r\n\r\n7. **Multidimensional Arrays**: C# supports multidimensional arrays (e.g., 2D arrays) to store elements in multiple dimensions or in the form of a matrix.\r\n\r\n8. **Jagged Arrays**: Jagged arrays are arrays of arrays, where each element of the array can be another array, potentially of different sizes.\r\n\r\n9. **Array Methods**: Arrays provide several methods like `Sort`, `Reverse`, `Copy`, and more to manipulate the array's elements efficiently.\r\n\r\n10. **For-each Loop**: C# provides a `foreach` loop to iterate over the elements of an array without using an explicit index.\r\n\r\nArrays are an essential part of C# programming and are widely used in various scenarios, including data storage, sorting, searching, and handling large amounts of data. They provide a simple and efficient way to manage collections of elements with fixed sizes and identical data types.\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Enter Size Of Array :-");
            int size = int.Parse(Console.ReadLine());

            int[] NumberArray = new int[size];
            Console.WriteLine("Enter Elements of array :-");
            for(int i=0; i< NumberArray.Length; i++)
            {
                NumberArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Element of Arrya:-");

            foreach(int Number in NumberArray)
            {
                Console.Write(Number+" ");
            }
        }
        public void staticStudentInformation()
        {
            Student obj = new Student();

            obj.ID = 1;
            obj.Name = "Lukesh Bahurupi";
            obj.Email = "Temp@mail.com";
            obj.PhoneNo = "+91 987654321";

            Console.WriteLine($"\n From Obj \n ID : {obj.ID}\n Name : {obj.Name}\n EmailId : {obj.Email}\n PhoneNo : {obj.PhoneNo}");

            Student student1 = new Student();
            student1.ID = 10;
            student1.Name = "Manoj";
            student1.PhoneNo = "+91 8788739284";
            student1.Email = "student1@gmail.com";

            Student student2 = new Student();
            student2.ID = 20;
            student2.Name = "Tushar";
            student2.PhoneNo = "+91 2323232";
            student2.Email = "student2@gmail.com";

            Student student3 = new Student();
            student3.ID = 30;
            student3.Name = "Ganesh";
            student3.PhoneNo = "+91 2332432434";
            student3.Email = "student3@gmail.com";


            object[] studentList = new object[4];

            studentList[0] = obj;
            studentList[1] = student1;
            studentList[2] = student2;
            studentList[3] = student3;

            Console.WriteLine("\n \n From object Array");
            foreach (object studentObj in studentList)
            {
                string result = $" ID : {((Student)studentObj).ID}\n" +
                                 $" Name : {((Student)studentObj).Name}\n" +
                                 $" PhoneNo : {((Student)studentObj).PhoneNo}\n" +
                                 $" Email : {((Student)studentObj).Email}\n";

                Console.WriteLine(result);
            }





            Console.WriteLine("\n \n \n");
            Student[] studentList2 = new Student[4];

            studentList2[0] = new Student();
            studentList2[1] = new Student();
            studentList2[2] = new Student();
            studentList2[3] = new Student();

            studentList2[0].ID = 10;
            studentList2[0].Name = "Lukesh Bahurupi";
            studentList2[0].Email = "Temp@mail.com";
            studentList2[0].PhoneNo = "+91 987654321";

            studentList2[1].ID = 20;
            studentList2[1].Name = "Manoj";
            studentList2[1].PhoneNo = "+91 8788739284";
            studentList2[1].Email = "student1@gmail.com";


            studentList2[2].ID = 30;
            studentList2[2].Name = "Tushar";
            studentList2[2].PhoneNo = "+91 2323232";
            studentList2[2].Email = "student2@gmail.com";


            studentList2[3].ID = 40;
            studentList2[3].Name = "Ganesh";
            studentList2[3].PhoneNo = "+91 2332432434";
            studentList2[3].Email = "student3@gmail.com";


            foreach (Student studentObj in studentList2)
            {
                string result = $" ID : {((Student)studentObj).ID}\n" +
                         $" Name : {((Student)studentObj).Name}\n" +
                         $" PhoneNo : {((Student)studentObj).PhoneNo}\n" +
                         $" Email : {((Student)studentObj).Email}\n";

                Console.WriteLine(result);
            }

        }
        public void dynamicStudentInformation()
        {
            // Student newObj = new Student();

            Console.Write("\n Enter numbers Of Student :- ");
            int size = int.Parse(Console.ReadLine());

            Student[] StudentList = new Student[size];

            for (int i = 0; i < StudentList.Length; i++)
            {

                StudentList[i] = new Student();

                Console.WriteLine($"\n\n Enter Student{i + 1} Information:- ");

                Console.Write("\n Enter Student Id:- ");
                StudentList[i].ID = int.Parse(Console.ReadLine());

                Console.Write("\n Enter Student Name:- ");
                StudentList[i].Name = Console.ReadLine();

                Console.Write("\n Enter Student Email:- ");
                StudentList[i].Email = Console.ReadLine();

                Console.Write("\n Enter Student PhoneNo:- ");
                StudentList[i].PhoneNo = Console.ReadLine();
            }

            Console.WriteLine("\n\n\n Student List:- \n ______________________________");
            int a = 0;
            foreach (Student StudentObj in StudentList)
            {
                Console.WriteLine($" Student{++a} : \n ID : {StudentObj.ID}\n Name : {StudentObj.Name}\n Email : {StudentObj.Email}\n PhoneNo : {StudentObj.PhoneNo}");
            }


        }
        public void twoDArray()
        {
            Console.Write(" Enter  size of Row for 2D Array:- ");
            int Row = int.Parse(Console.ReadLine());
            Console.Write("\n Enter  size of Column for 2D Array:- ");
            int Col = int.Parse(Console.ReadLine());

            int[,] arr = new int[Row, Col];

            Console.WriteLine("\n Enter Elements\n----------------------------");
            for (int i = 0; i < Row; i++)
            {
                Console.WriteLine($" Enter Elements in Row {i + 1}");
                for (int j = 0; j < Col; j++)
                {
                    Console.Write($" Enter Elements for Column {j + 1} :- ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }


            for (int i = 0; i < Row; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Col; j++)
                {
                    Console.Write(" " + arr[i, j] + " ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("If you Want to run using sting input the type 'yes' else tyepe 'no' ");
            string str = (Console.ReadLine()).ToLower();
            if (str == "yes") twoDArray2();
            else Console.Write("Happy Coding!!");

        }
        public void twoDArray2()
        {
            Console.Write("Enter Size Of Array For Row And Column by separating ',' ex(3,3) :- ");
            string size = Console.ReadLine();

            int Row = int.Parse(size.Split(',')[0]);
            int Col = int.Parse(size.Split(',')[1]);

            int[,] arr = new int[Row, Col];

            int a = 1;
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    arr[i, j] = a++;
                }
            }

            for (int i = 0; i < Row; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Col; j++)
                {
                    Console.Write(" " + arr[i, j] + " ");
                }
                Console.Write("|");
                Console.WriteLine();
            }

        }
       public void jaggedArray()
        {
            /*
                Jagged array is an array of 1-D array.
                In 2-D array each row contains same number of columns where as in Jagged array, each row contents different no. of columns.
                A jagged array is initialized with two square brackets [][]. The first bracket specifies the size of an array, 
                and the second bracket specifies the dimensions of the array which is going to be stored.

                int[][] jArray1 = new int[2][]; // two single-dimensional arrays 
                int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays
            */
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n \t\t** Polymorphism **");
            Console.WriteLine("Jagged array is an array of 1-D array.\r\nIn 2-D array each row contains same number of columns where as in Jagged array, each row contents different no. of columns.\r\nA jagged array is initialized with two square brackets [][]. The first bracket specifies the size of an array, \r\n                and the second bracket specifies the dimensions of the array which is going to be stored.\r\n\r\nint[][] jArray1 = new int[2][]; // two single-dimensional arrays \r\nint[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Enter size of Jagged Array :- ");
            int size = int.Parse(Console.ReadLine());
            //[size][type of Array(1-D)]
            int[][] jArray = new int[size][];


            for (int i = 0; i < jArray.Length; i++)
            {

                Console.Write($"\n Enter size of Elements Array{i + 1} :- ");
                int sz = int.Parse(Console.ReadLine());

                int[] arr = new int[sz];

                Console.WriteLine("\n Enter Elements of Array \n ________________________");
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write($" Enter Element {j + 1} :- ");
                    arr[j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                jArray[i] = arr;
            }


            for (int i = 0; i < jArray.Length; i++)
            {
                Console.Write($" Array{i+1} Element :- ");
                Console.Write(" {");
                foreach (int Element in jArray[i])
                {
                    Console.Write($" {Element}");
                }
                // for(int j=0; j<jArray[i].Length; i++){
                //     Console.Write(" "+jArray[i][j]);
                // }
                Console.Write(" }\n");
            }

        }

        public void BinarySerachMethod()
        {
            Console.WriteLine(" Please Enter Element in sorted Stucture :- ");
            int[] arr = Input.UserArray<int>();
            

            Console.Write(" Enter searching Element to Get Index :- ");
            int Element = Input.User<int>();

            int result = Array.BinarySearch(arr, Element);

            if (result >= 0)
            {
                Print.valueln($"\n Element {Element} on Index : {result}");
            }
            else 
            {
                Console.WriteLine(" Element Not found!"); 
            }
            
        }

        public void ClearArrayElements()
        {
            
            int[] NumberCollection = Input.UserArray<int>();

            Console.Write("Enter Number of Elements to Clear : ");
            int NumberOfElementsToClear = int.Parse(Console.ReadLine());

            Console.Write("Enter StartIndex from where to Clear the Elements ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Printing Array Before Clear");
            Print.Array(NumberCollection);

            if ((NumberOfElementsToClear + startIndex) > NumberCollection.Length)
            {
                Console.WriteLine("invalid Input");
            }
            else
            {
                Array.Clear(NumberCollection, startIndex, NumberOfElementsToClear);
                Console.WriteLine("Printing Array After Clear");
                Print.Array(NumberCollection);
            }
        }

        public void CopyArrayElements()
        {
            
            int[] SourceArray = Input.UserArray<int>();

            int[] DestinationArray = Input.UserArray<int>();

            Console.Write("Enter Number of Elements to Copy : ");
            int NumberOfElementsToCopy = int.Parse(Console.ReadLine());

            Console.Write("Enter Start Index of Source Array to Copy the Elements : ");
            int SourceArrayStartIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter Start Index of Destination Array to Paste the Copied Elements :");
            int DestinationArrayStartIndex = int.Parse(Console.ReadLine());

            if ((NumberOfElementsToCopy + SourceArrayStartIndex) > SourceArray.Length ||
                (NumberOfElementsToCopy + DestinationArrayStartIndex) > DestinationArray.Length)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("Array Before Copy");
                Print.Array(DestinationArray);
                Console.WriteLine();
                Array.Copy(SourceArray, SourceArrayStartIndex, DestinationArray, DestinationArrayStartIndex, NumberOfElementsToCopy);
                Console.WriteLine("Array After Copy");
                Print.Array(DestinationArray);
                Console.WriteLine();
            }


        }

        public void ArrayLinearSearch()
        {
            int[] Numbers = Input.UserArray<int>();

            Console.Write("Enter Element to search : ");
            int searchElement = int.Parse(Console.ReadLine());

            int result = Array.IndexOf(Numbers, searchElement);

            int LastIndexResult = Array.LastIndexOf(Numbers, searchElement);

            if (result >= 0)
            {
                Console.WriteLine("First Occurance of the Element found at location : {0}", result);
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }




            if (LastIndexResult >= 0)
            {
                Console.WriteLine("Last Occurance of the Element found at location : {0}", LastIndexResult);
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }





        }

        public void ReverseArray()
        {
            
            int[] Numbers = Input.UserArray<int>();

            Console.WriteLine("Printing Array Before Reverse");
            Console.WriteLine();
            Print.Array(Numbers);

            Array.Reverse(Numbers);
            Console.WriteLine("Printing Array After Reverse");
            Console.WriteLine();
            Print.Array(Numbers);
        }

        public void SortArray()
        {
            
            int[] Numbers = Input.UserArray<int>();

            Console.WriteLine("Printing Array Before Sort");
            Console.WriteLine();
            Print.Array(Numbers);
            Console.WriteLine();

            Array.Sort(Numbers);
            Console.WriteLine("Array in Ascending Order");
            Console.WriteLine();
            Print.Array(Numbers);
            Console.WriteLine();

            Console.WriteLine("Array in Descending Order");
            Array.Reverse(Numbers);
            Console.WriteLine();
            Print.Array(Numbers);

        }

        public static void AccessModifire()
        {
            Calc obj = new Calc();
            obj.Calculate(50, 60);
        }

    }
}
