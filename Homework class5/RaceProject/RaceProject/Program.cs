using System.Reflection;

namespace RaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Driver[] drivers = {
            new Driver("Bob", 90),
            new Driver("Greg", 85),
            new Driver("Jill", 88),
            new Driver("Anne", 87)
        };

           
            Car[] cars = {
            new Car("Hyundai", 300),
            new Car("Mazada", 290),
            new Car("Ferrari", 295),
            new Car("Porsche", 285)
        };


            for (int i = 0; i < 4; i++)
            {
                cars[i].Driver = drivers[i];
            }


            Console.WriteLine("Select two cars (1-4):");
            int car1Index = int.Parse(Console.ReadLine()) - 1;
            int car2Index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Select two drivers (1-4):");
            int driver1Index = int.Parse(Console.ReadLine()) - 1;
            int driver2Index = int.Parse(Console.ReadLine()) - 1;

            cars[car1Index].RaceCars(cars[car2Index]);
        }
    }
    }

