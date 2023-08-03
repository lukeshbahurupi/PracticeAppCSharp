using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp.CLASS
{
    internal class StudentGroup
    {
        static List<string> UserInputStudentName()
        {
            List<string> StudentNames = new List<string>();

            Console.WriteLine("Enter Student Name(Type 'done' when no more student name) (if you have copied List you can past it here).");

            while (true)
            {

                string name = Console.ReadLine().Trim();

                if (name.ToLower() == "done") break;

                StudentNames.Add(name);
            }

            if (StudentNames.Count == 0)
            {
                //StudentNames.Add("No name added");
                Console.WriteLine("No name added");
                
            }

            return StudentNames;
        }

        static List<string> ShuffledListOfStudent()
        {
            List<string> StudentNames = UserInputStudentName();

            Random random = new Random();

            int n = StudentNames.Count;

            while (n-- > 1)
            {

                int R = random.Next(n + 1);

                string temp = StudentNames[R];
                StudentNames[R] = StudentNames[n];
                StudentNames[n] = temp;

            }
            return StudentNames;
        }

       public static void createGroupOfStudents()
        {

            List<string> StudentNames = ShuffledListOfStudent();
            if (StudentNames.Count == 0) return;
            Console.WriteLine("Studet List are added and List is shuffled");

            Console.Write("Enter Group Count : ");
            int groupCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int groupSize = StudentNames.Count / groupCount;
            int restOfStudents = StudentNames.Count % 10;

            int startingIndex = 0, a = 1;
            for (int i = 0; i < groupCount; i++)
            {
                int size = groupSize + (i < restOfStudents ? 1 : 0);
                List<string> group = StudentNames.GetRange(startingIndex, size);

                Console.WriteLine($"Group {i + 1} List : ");
                foreach (var name in group) Console.WriteLine($"{a++}. {name}");

                startingIndex += size;
                a = 1;
            }
        }

    }
}
