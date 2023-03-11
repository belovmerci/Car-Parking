using System;

namespace Car_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking mallPark = new Parking(10);

            mallPark.addCar("Tesla", "Model 3", "White", "LOLGAS", "03:00");
            mallPark.addCar("Audi", "A8", "Blue", "BAMF", "never");
            mallPark.addCar();
            mallPark.addCar();

            mallPark.viewAllCars();

            mallPark.departCar(3);
            mallPark.departCar(1);

            mallPark.viewAllCars();

            Console.WriteLine();
            mallPark.addCar();
            mallPark.addCar();
            mallPark.addCar();

            Console.WriteLine();
            mallPark.viewAllCars();
        }
    }
}
