namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TASK NUMBER 3*/

           Console.WriteLine("Please enter first one: ");
           int number1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Please enter second two: ");
           int number2 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($"Your numbers before swaping are: first number:{number1}, second number:{number2}");
           int swap = number1;
           number1 = number2;
           number2 = swap;
           Console.WriteLine($"Your numbers after swaping are: first number:{number1}, second number:{number2}");

           
        }
    }
}
