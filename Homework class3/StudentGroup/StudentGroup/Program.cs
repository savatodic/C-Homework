using System.ComponentModel;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = ["Nikola", "Marija", "Goran", "Mirko", "Marko"];
            string[] studentsG2 = ["Niksa", "Visnja", "Tresnja", "Vuk", "Marko"];

            Console.WriteLine("Enter student group (there are 1 and 2)");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Students in group G1 are: ");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Students in group G2 are: ");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }

            else {
                Console.WriteLine("Something went wrong");
            }

        }
    }
}
