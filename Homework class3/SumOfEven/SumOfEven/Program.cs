namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TASK ONE*/

            int[] numbers = new int[6];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Please enter number {i + 1} into array: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];

                }
            }

            Console.WriteLine("Sum of all positiv integers is: " + sum);
        }
    }
}
