using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp.Collections
{
    internal class ArrayListClass
    {
        private void printList(ArrayList list)
        {

            Console.Write("List Elements : ");

            foreach (object el in list) Console.Write(el + " ");

            Console.WriteLine();
            Console.WriteLine();
        }

        public void ArraListExample()
        {
            string str = "`ArrayList` is a non-generic collection class in C# that allows you to store and manipulate objects of any type. It is part of the `System.Collections` namespace and provides a dynamic array-like structure that can automatically resize as elements are added or removed. `ArrayList` was introduced in .NET Framework 1.0 and is commonly used in older codebases. However, it is recommended to use generic collections like `List<T>` for type safety and better performance.\r\n\r\nKey points about `ArrayList`:\r\n1. **Non-Generic**: Unlike generic collections (e.g., `List<T>`), `ArrayList` can store objects of any type. It achieves this by internally storing objects as `object` type, leading to the need for explicit casting when retrieving elements.\r\n\r\n2. **Dynamic Sizing**: `ArrayList` automatically resizes itself as elements are added or removed, so you don't need to specify the size upfront.\r\n\r\n3. **Boxing and Unboxing**: When elements are added to an `ArrayList`, value types are implicitly boxed (wrapped in an object) and stored as objects. Unboxing is required when extracting value types from the `ArrayList`.\r\n\r\n4. **Slower and Less Type-Safe**: Because of boxing/unboxing and the lack of type safety, `ArrayList` can be slower and prone to runtime errors if elements are incorrectly casted.\r\n\r\n5. **IEnumerable Support**: `ArrayList` implements `IEnumerable`, allowing it to be used in foreach loops and with LINQ methods (with extra casting).\r\n\r\n6. **Common Methods**: `ArrayList` provides methods like `Add`, `Remove`, `Contains`, `Sort`, `ToArray`, and more.\r\n\r\nPlease note that it's generally recommended to use generic collections (`List<T>`, `Dictionary<TKey, TValue>`, etc.) instead of `ArrayList` whenever possible, as they provide better type safety and performance due to the absence of boxing/unboxing.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str + "\n");
            Console.ResetColor();
            ArrayList list = new ArrayList();
            /* 
            list.Add("Lukesh");
            list.Add(10);
            list.Add(true);


            int[] arr = {10,11,12,13,14,15};
            list.Add(arr);
            */
            Student obj = new Student() { ID = 10, Name = "Mayur" };

            list.Add(obj);
            //1. `Add(T item)`: Adds an item to the end of the list.
            list.Add(2);
            list.Add(1);
            list.Add(2);
            list.Add(22);
            for (int i = 0; i < 5; i++) list.Add(i + 10);
            list.Add(22);
            list.Add(2);
            list.Add(22);
            printList(list);

            //  `Count`: Property that returns the number of elements in the list.
            int size = list.Count;
            Console.WriteLine("Size of List or Element count in List : " + size + "\n");

            //2. `AddRange(IEnumerable<T> collection)`: Adds a collection of items to the end of the list.
            int[] arr = { 9, 8, 7, 6, 5, 4, 2, 3, 5, 6, 36, 32, 2, 6, 2, 3, 5, 6, 2, 21, 4, 5, 252, 1, 12, 56, 2515, 2, 2 };
            list.AddRange(arr);
            Console.WriteLine("after AddRange");
            printList(list);


            List<int> listex = new List<int>() { 1, 2, 3, 4, 5, 6 };
            list.AddRange(listex);
            Console.WriteLine("after AddRange");
            printList(list);

            //3. `Insert(int index, T item)`: Inserts an item at the specified index.
            list.Insert(2, "lukesh");
            Console.WriteLine("after Insert '24' on index '2' ");
            printList(list);

            //4. `Remove(T item)`: Removes the first occurrence of the specified item from the list.
            list.Remove(obj);
            Console.WriteLine("after Removes 'ObjectClass'(first occurrence)");
            printList(list);

            //5. `RemoveAt(int index)`: Removes the item at the specified index.
            list.RemoveAt(2);
            Console.WriteLine("after RemoveAt index '2' ");
            printList(list);

            //6. `RemoveRange(int index, int count)`: Removes a range of elements starting from the specified index.
            list.RemoveRange(3, 4);
            Console.WriteLine("after RemoveRange from index '3' four elements ");
            printList(list);

            //8. `Contains(T item)`: Determines whether the list contains the specified item.
            Console.WriteLine("Contains method");
            bool isIt = list.Contains(24);
            Console.WriteLine(isIt ? "24 is contains\n" : "24 is not contains\n");

            //9. `IndexOf(T item)`: Returns the index of the first occurrence of the specified item.
            int index = list.IndexOf(22);
            Console.WriteLine($"Index  Of '22' is '{index}' (first occurrence)\n");

            // 10. `LastIndexOf(T item)`: Returns the index of the last occurrence of the specified item.
            index = list.LastIndexOf(22);
            Console.WriteLine($"Index  Of '22' is '{index}' (last occurrence)\n");

            //12. `Reverse()`: Reverses the order of the elements in the list.
            list.Reverse();
            Console.WriteLine("After Reverse");
            printList(list);

            //13.`ToArray()`: Converts the list to an array.
            object[] arr2 = list.ToArray();
            Console.WriteLine("Converted in to array : ");
            foreach (object el in arr2) Console.Write(el + " ");
            Console.WriteLine();

            //15. `Capacity`: Property that gets or sets the total number of elements the internal data structure can hold without resizing.
            int cap = list.Capacity;
            Console.Write($"\nArrayList Capacity is {cap}");
            list.Capacity += 10;
            cap = list.Capacity;
            Console.Write($"\nAfter increase ArrayList Capacity by '10' -> {cap}");


            //7. `Clear()`: Removes all elements from the list.
            list.Clear();
            Console.WriteLine("\n\nafter Clear all ");
            printList(list);

        }
    }
}
