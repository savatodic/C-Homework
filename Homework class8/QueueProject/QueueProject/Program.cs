namespace QueueProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            while (true)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                numbers.Enqueue(number);

                
                Console.Write("Do you want to enter another number? (Y/N): ");
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("\nNumbers in the order you entered them:");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Dequeue());
            }
        }
    }
}
    

