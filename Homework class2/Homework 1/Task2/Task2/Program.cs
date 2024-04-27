namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TASK NUMBER 2*/

           Console.WriteLine("Please enter number 1: ");
           int num1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Please enter number 2: ");
           int num2 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Please enter number 3: ");
           int num3 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Please enter number 4: ");
           int num4 = Convert.ToInt32(Console.ReadLine());

           int average = (num1 + num2 + num3 + num4) / 4;

           Console.WriteLine("Average of your four numbers is: " + average);

           
        }
    }
}
