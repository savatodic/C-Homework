namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

              /*TASK NUMBER 1*/

             *Console.WriteLine("Enter first number:");
             int num1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter second number:");
             int num2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the operation +, -, *, /");
             char operation = Convert.ToChar(Console.ReadLine());

             int result = 0;

             switch (operation)
             {
                 case '+':
                     result = num1 + num2;
                     break;
                 case '-':
                     result = num1 - num2;
                     break;
                 case '*':
                     result = num1 * num2;
                     break;
                 default:
                     Console.WriteLine("Something went wrrong!");
                     break;
             }

             Console.WriteLine("result is: " + result);
         }  



           

        }
    }
}

