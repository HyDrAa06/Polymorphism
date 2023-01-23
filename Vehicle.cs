using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double fuelCapacity;
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double FuelCapacity
        {
            get { return fuelCapacity; }
            set { fuelCapacity = value; }
        }

        public Vehicle(double fuelQuantity, double fuelConsumption, double fuelCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.FuelCapacity = fuelCapacity;
        }

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);

        public abstract void Print();
    }

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double fuelCapacity) : base(fuelQuantity, fuelConsumption, fuelCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 0.9;
            this.FuelCapacity = fuelCapacity;
        }

        public override void Drive(double distance)
        {
            if (FuelQuantity >= FuelConsumption * distance)
            {
                FuelQuantity = FuelQuantity - FuelConsumption * distance;
                Console.WriteLine($"Car travelled {distance}km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Car: {FuelQuantity:f2}");
        }

        public override void Refuel(double liters)
        {
            if(liters > 0)
            {
                if(FuelCapacity >= FuelQuantity + liters)
                {
                    FuelQuantity = FuelQuantity + liters;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be positive number.");
            }
            
        }
    }

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double fuelCapacity) : base(fuelQuantity, fuelConsumption, fuelCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 1.6;
            this.FuelCapacity = fuelCapacity;
        }
        public override void Drive(double distance)
        {
            if (FuelQuantity >= FuelConsumption * distance)
            {
                FuelQuantity = FuelQuantity - FuelConsumption * distance;
                Console.WriteLine($"Truck travelled {distance}km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }        
        }
        public override void Refuel(double liters)
        {
            if (liters > 0)
            {
                if (FuelCapacity >= FuelQuantity + liters*0.95)
                {
                    FuelQuantity = FuelQuantity + liters*0.95;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be positive number.");
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Truck: {FuelQuantity:f2}");
        }
    }

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double fuelCapacity) : base(fuelQuantity, fuelConsumption, fuelCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 1.4;
            this.FuelCapacity = fuelCapacity;
        }

        public override void Drive(double distance)
        {
            if (FuelQuantity >= FuelConsumption * distance)
            {
                FuelQuantity = FuelQuantity - FuelConsumption * distance;
                Console.WriteLine($"Bus travelled {distance}km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpty(double distance, double fuelConsumption)
        {
            this.FuelConsumption = fuelConsumption;
            if (FuelQuantity >= FuelConsumption * distance)
            {
                FuelQuantity = FuelQuantity - FuelConsumption * distance;
                Console.WriteLine($"Bus travelled {distance}km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
            this.FuelConsumption = fuelConsumption*1.4;
        }

        public override void Print()
        {
            Console.WriteLine($"Bus: {FuelQuantity:f2}");
        }

        public override void Refuel(double liters)
        {
            if (liters > 0)
            {
                if (FuelCapacity >= FuelQuantity + liters)
                {
                    FuelQuantity = FuelQuantity + liters;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be positive number.");
            }
        }
    }
}
