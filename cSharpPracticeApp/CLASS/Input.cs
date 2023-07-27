using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp
{
    internal class Input
    {
        #region Code Reference  
        /*static void Main()
        {
            ArrayInput arrayInput = new ArrayInput();

            int[] intArray = arrayInput.GetUserInputArray<int>();
            double[] doubleArray = arrayInput.GetUserInputArray<double>();
            string[] stringArray = arrayInput.GetUserInputArray<string>();

            Console.WriteLine("Integer Array:");
            PrintArray(intArray);

            Console.WriteLine("Double Array:");
            PrintArray(doubleArray);

            Console.WriteLine("String Array:");
            PrintArray(stringArray);
        }*/
        #endregion

        public static T[] UserArray<T>()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Enter Size of Array :- ");
            T[] array = new T[Input.User<int>()];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\n Enter Element {i + 1} :- ");
                array[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }

            return array;
        }

        public static T User<T>()
        {
            T variable = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            return variable;
        }

        
    }
}
