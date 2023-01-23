using System;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0, 0, 0);
            Truck truck = new Truck(0, 0, 0);
            Bus bus = new Bus(0, 0, 0);

            Console.WriteLine("Fuel quantity, consumption and tank capacity:");

            string[] info = Console.ReadLine().Split().ToArray();
            if (double.Parse(info[1]) > double.Parse(info[3]))
            {
                car = new Car(0, double.Parse(info[2]), double.Parse(info[3]));
            }
            else
            {
                car = new Car(double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3]));
            }
            
            info = Console.ReadLine().Split().ToArray();
            if (double.Parse(info[1]) > double.Parse(info[3]))
            {
                truck = new Truck(0, double.Parse(info[2]), double.Parse(info[3]));
            }
            else
            {
                truck = new Truck(double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3]));
            }

            info = Console.ReadLine().Split().ToArray();
            if (double.Parse(info[1]) > double.Parse(info[3]))
            {
                bus = new Bus(0, double.Parse(info[2]), double.Parse(info[3]));
            }
            else
            {
                bus = new Bus(double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3]));
            }


            Console.WriteLine("Number of commands");
            int number = int.Parse(Console.ReadLine());

            for(int i =0;i< number; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if(command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        car.Drive(double.Parse(command[2]));
                    }
                    if(command[1] == "Truck")
                    {
                        truck.Drive(double.Parse(command[2]));
                    }
                    if (command[1]=="Bus")
                    {
                        bus.Drive(double.Parse(command[2]));
                    }
                }

                if (command[0] == "DriveEmpty")
                {
                    bus.DriveEmpty(double.Parse(command[2]), double.Parse(info[2]));
                }

                if(command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    if (command[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                    if (command[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                }
            }

            car.Print();
            truck.Print();
            bus.Print();
        }
    }
}