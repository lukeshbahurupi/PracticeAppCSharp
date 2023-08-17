using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cSharpPracticeApp.Collections
{
    internal class ListClass
    {
        public void ListExample()
        {
            string str = "`List<T>` in C# is a generic dynamic array-like collection provided by the .NET Framework. It allows you to store elements of a specific type `T` and automatically resizes itself as elements are added or removed. `List<T>` provides various methods to perform common operations on the list efficiently.\r\n\r\nDeclaration and Initialization:\r\n```csharp\r\nList<T> listName = new List<T>();\r\n```\r\n\r\nKey features of `List<T>`:\r\n1. **Dynamic Size**: `List<T>` automatically resizes itself to accommodate any number of elements added to it, so you don't need to specify the size upfront.\r\n\r\n2. **Index-based Access**: Elements in the list can be accessed using an index (starting from 0).\r\n\r\n3. **Duplicates Allowed**: `List<T>` allows duplicate elements, meaning you can add the same value multiple times.\r\n\r\n4. **Search and Manipulation**: `List<T>` provides various methods to search for elements, insert elements, remove elements, sort, reverse, and more.\r\n\r\n5. **IEnumerable and LINQ Support**: `List<T>` implements `IEnumerable<T>`, allowing you to use LINQ queries and other LINQ-related operations on the list.\r\n";
            Console.WriteLine(str);


            /*1. * *Add(T item) * *:*/
            Print.valueln("Adds an item to the end of the list.");

            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.Add(4);
            Print.valueln("Result: { 1, 2, 3, 4 }");

            /*2. * *AddRange(IEnumerable < T > collection) * *:*/
            Print.valueln("Adds a collection of items to the end of the list.");

            List<string> colors = new List<string> { "Red", "Green" };
            string[] additionalColors = { "Blue", "Yellow" };
            colors.AddRange(additionalColors);
            Print.valueln("Result: { Red, Green, Blue, Yellow }");

            /*
            3. * *Insert(int index, T item) * *:*/
            Print.valueln("Inserts an item at the specified index.");
            List<int> number = new List<int> { 1, 2, 3 };
            number.Insert(1, 10);
            Print.valueln("Result: { 1, 10, 2, 3 }");
            /*
            4. * *Remove(T item) * *:*/
            Print.valueln("Removes the first occurrence of the specified item from the list.");
            

            List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
            fruits.Remove("Banana");
            Print.valueln("Result: { Apple, Orange }");

            /*5. * *RemoveAt(int index) * *:*/
            Print.valueln(" Removes the item at the specified index.");


            List<int> num = new List<int> { 1, 2, 3 };
            num.RemoveAt(1);
            Print.valueln("Result: { 1, 3 }");


            //6. * *RemoveRange(int index, int count) * *:
            Print.valueln("Removes a range of elements starting from the specified index."); 

            List<string> color = new List<string> { "Red", "Green", "Blue", "Yellow" };
            color.RemoveRange(1, 2);
            Print.valueln("Result: { Red, Yellow }");

            //7. * *Clear() * *:
            Print.valueln("Removes all elements from the list."); 


            List<int> nums = new List<int> { 1, 2, 3 };
            nums.Clear();
            Print.valueln("Result: { }"); 


            //8. * *Contains(T item) * *:
            Print.valueln("Determines whether the list contains the specified item."); 
            List<string> clrs = new List<string> { "Red", "Green", "Blue" };
            bool containsGreen = clrs.Contains("Green"); // true
            bool containsPurple = clrs.Contains("Purple"); // false

            //9. * *IndexOf(T item) * *:
            Print.valueln("Returns the index of the first occurrence of the specified item."); 
            List<int> numb = new List<int> { 10, 20, 30, 20 };
            int index1 = numb.IndexOf(20); // 1
            int index2 = numb.IndexOf(40); // -1 (not found)

            //10. * *LastIndexOf(T item) * *:
            Print.valueln("Returns the index of the last occurrence of the specified item.");
            List<int> numbs = new List<int> { 10, 20, 30, 20 };
            int idx1 = numbs.LastIndexOf(20); // 3
                        int idx2 = numbs.LastIndexOf(40); // -1 (not found)



            string AllMethods = "Common methods of `List<T>`:\r\n\r\n1. `Add(T item)`: Adds an item to the end of the list.\r\n\r\n2. `AddRange(IEnumerable<T> collection)`: Adds a collection of items to the end of the list.\r\n\r\n3. `Insert(int index, T item)`: Inserts an item at the specified index.\r\n\r\n4. `Remove(T item)`: Removes the first occurrence of the specified item from the list.\r\n\r\n5. `RemoveAt(int index)`: Removes the item at the specified index.\r\n\r\n6. `RemoveRange(int index, int count)`: Removes a range of elements starting from the specified index.\r\n\r\n7. `Clear()`: Removes all elements from the list.\r\n\r\n8. `Contains(T item)`: Determines whether the list contains the specified item.\r\n\r\n9. `IndexOf(T item)`: Returns the index of the first occurrence of the specified item.\r\n\r\n10. `LastIndexOf(T item)`: Returns the index of the last occurrence of the specified item.\r\n\r\n11. `Sort()`: Sorts the elements in the list.\r\n\r\n12. `Reverse()`: Reverses the order of the elements in the list.\r\n\r\n13. `ToArray()`: Converts the list to an array.\r\n\r\n14. `Count`: Property that returns the number of elements in the list.\r\n\r\n15. `Capacity`: Property that gets or sets the total number of elements the internal data structure can hold without resizing.\r\n\r\n16. `TrimExcess()`: Sets the capacity to the actual number of elements in the list.\r\n\r\n17. `ForEach(Action<T> action)`: Performs the specified action on each element of the list.\r\n\r\n18. `Find(Predicate<T> match)`: Finds the first element that matches the specified condition.\r\n\r\n19. `FindLast(Predicate<T> match)`: Finds the last element that matches the specified condition.\r\n\r\n20. `FindAll(Predicate<T> match)`: Finds all elements that match the specified condition.\r\n\r\nThese are some of the commonly used methods of `List<T>`. It's important to explore the documentation for the `List<T>` class and other collection classes to fully understand the capabilities they offer and leverage them effectively in your C# applications.";
            Console.WriteLine(AllMethods);


            //

            //11. * *Sort() * *:
            //Sorts the elements in the list.

            //```csharp
            //List<int> numbers = new List<int> { 3, 1, 4, 2 };
            //            numbers.Sort();
            //// Result: { 1, 2, 3, 4 }
            //```

            //12. * *Reverse() * *:
            //Reverses the order of the elements in the list.

            //```csharp
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //            numbers.Reverse();
            //// Result: { 4, 3, 2, 1 }
            //```

            //13. * *ToArray() * *:
            //Converts the list to an array.

            //```csharp
            //List<string> colors = new List<string> { "Red", "Green", "Blue" };
            //            string[] colorsArray = colors.ToArray();
            //// Result: { "Red", "Green", "Blue" }
            //```

            //14. * *Count * *:
            //Property that returns the number of elements in the list.

            //```csharp
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //            int count = numbers.Count; // 5
            //```

            //15. * *Capacity * *:
            //Property that gets or sets the total number of elements the internal data structure can hold without resizing.

            //```csharp
            //List<int> numbers = new List<int> { 1, 2, 3 };
            //        int capacity = numbers.Capacity; // 4 (initial capacity)
            //        numbers.Capacity = 10; // Increase the capacity to 10
            //```

            //16. **TrimExcess()**:
            //Sets the capacity to the actual number of elements in the list.

            //```csharp
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //        numbers.RemoveAt(4); // Remove the last element
            //numbers.TrimExcess(); // Reduce the capacity to the actual number of elements (4)
            //```

            //17. **ForEach(Action<T> action)**:
            //Performs the specified action on each element of the list.

            //```csharp
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //        numbers.ForEach(num => Console.WriteLine(num));
            //// Output: 1, 2, 3, 4, 5
            //```

            //18. **Find(Predicate<T> match)**:
            //Finds the first element that matches the specified condition.

            //```csharp
            //List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            //        int result = numbers.Find(num => num > 25); // 30 (first element greater than 25)
            //```

            //19. **FindLast(Predicate<T> match)**:
            //Finds the last element that matches the specified condition.

            //```csharp
            //List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            //        int result = numbers.FindLast(num => num > 25); // 50 (last element greater than 25)
            //```


        }
    }
}
