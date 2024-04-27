namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday date(year - month - day)");
            string bDay = Console.ReadLine();

            DateTime birthDay;
            if (DateTime.TryParse(bDay, out birthDay)) {
                int age = BirthCalculator(birthDay);
                Console.WriteLine("You have: " + age + " ages");
            }
        }


        static int BirthCalculator(DateTime birthDay) {

            DateTime timeToday = DateTime.Today;

            int age = timeToday.Year - birthDay.Year;
            if (timeToday.Month < birthDay.Month) {
                --age;
            }
            return age;

        }
    }
}
