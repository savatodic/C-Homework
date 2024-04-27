using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceProject
{

    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            if (Driver != null)
                return Driver.Skill * Speed;
            else
                return 0;
        }

        public void RaceCars(Car otherCar)
        {
            int selfSpeed = CalculateSpeed();
            int otherSpeed = otherCar.CalculateSpeed();

            if (selfSpeed > otherSpeed)
                Console.WriteLine($"{Model} wins!");
            else if (selfSpeed < otherSpeed)
                Console.WriteLine($"{otherCar.Model} wins!");
            else
                Console.WriteLine("It's a tie!");
        }
    }

}

