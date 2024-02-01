using System;

namespace MyApplication
{
    class Car
    {
        public string Name;
        public string Model;
        public int Year;

        public Car(string name, string model, int year)
        {
            Name = name;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\n\nCar Information:\n{Year} {Name} {Model}");
        }
    }

    class ElectricCar : Car
    {
        public double Batterycapacity;

        public ElectricCar(string name, string model, int year, double batterycapacity)
            : base(name, model, year)
        {
            Batterycapacity = batterycapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery Capacity: {Batterycapacity} kWh");
        }
    }

    class GasCar : Car
    {
        public int Fuelefficiency;

        public GasCar(string name, string model, int year, int fuelefficiency)
            : base(name, model, year)
        {
            Fuelefficiency = fuelefficiency;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fuel Efficiency: {Fuelefficiency} MPG");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter car type (Electric/Gas): ");
                string carType = Console.ReadLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter model: ");
                string model = Console.ReadLine();

                Console.Write("Enter year: ");
                int year = int.Parse(Console.ReadLine());

                if (carType.ToLower() == "electric")
                {
                    Console.Write("Enter battery capacity (kWh): ");
                    double batterycapacity = double.Parse(Console.ReadLine());

                    ElectricCar electricCar = new ElectricCar(name, model, year, batterycapacity);
                    electricCar.DisplayInfo();
                }
                else if (carType.ToLower() == "gas")
                {
                    Console.Write("Enter fuel efficiency (MPG): ");
                    int fuelefficiency = int.Parse(Console.ReadLine());

                    GasCar gasCar = new GasCar(name, model, year, fuelefficiency);
                    gasCar.DisplayInfo();
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }

                Console.Write("\n\nDo you want to enter another car? (yes/no): ");

            } while (Console.ReadLine().ToLower() == "yes");

        }
    }
}