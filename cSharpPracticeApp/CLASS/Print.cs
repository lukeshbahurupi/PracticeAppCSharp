using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp
{
    public class Print
    {
        public static void Array<T>(T[] array)
        {

            Console.Write("\n Array Elements \n[ ");
            foreach (T el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("]");
            Console.ResetColor();

        }


        public static void valueln<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
