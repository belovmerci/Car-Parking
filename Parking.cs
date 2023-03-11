using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Parking
{
    class Parking
    {
        Car[] carSpaces;
        bool isFull;
        public Parking(uint parkingSpaces = 8)
        {
            Console.WriteLine($"Made a parking with {parkingSpaces} parking spaces.");
            this.carSpaces = new Car[parkingSpaces];
            isFull = false;
        }

        public void addCar(string brand = "Mitsubishi", string model = "Pajero", string color = "Gray",
            string number = "L84ANL", string arrivalTime = "18:00")
        {
            if (!isFull)
            {
                uint fillSpace;
                for (uint i = 0; i <= carSpaces.Length; i++)
                {
                    if (i == carSpaces.Length)
                    {
                        this.isFull = true;
                        Console.WriteLine("Car park is full!");
                        break;
                    }
                    if (carSpaces[i] == null)
                    {
                        fillSpace = i;
                        this.carSpaces[fillSpace] = new Car(brand, model, color, number, arrivalTime);
                        break;
                    }
                }
            }
            else Console.WriteLine("Car park is full!");
        }

        public void viewCar(uint parkingSpace)
        {
            if (this.carSpaces[parkingSpace] != null)
            {
                Console.WriteLine($"Info for car parked in parking space {parkingSpace}:");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Brand: {this.carSpaces[parkingSpace].brand}");
                Console.WriteLine($"Model: {this.carSpaces[parkingSpace].model}");
                Console.WriteLine($"Color: {this.carSpaces[parkingSpace].color}");
                Console.WriteLine($"Number plate: {this.carSpaces[parkingSpace].plate}");
                Console.WriteLine($"Arrival Time: {this.carSpaces[parkingSpace].arrivalTime}");

                Console.WriteLine("-----------------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"No car parked in parking space {parkingSpace}.");
                Console.WriteLine("-----------------------------------------");
            }
        }

        public void viewAllCars()
        {
            for (uint i = 0; i < this.carSpaces.Length; i++)
            {
                this.viewCar(i);
            }
        }

        public void departCar(uint parkingSpace)
        {
            // Car nullCar = new Car(null, null, null, null, null);
            this.carSpaces[parkingSpace] = null;
            Console.WriteLine($"Successfully departed car in parking space{ parkingSpace}!");
        }
    }
}
