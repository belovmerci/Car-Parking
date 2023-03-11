using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Parking
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public string plate;
        public string arrivalTime;

        public Car(string brand = "Mitsubishi", string model = "Pajero", 
            string color = "Gray", string plate = "L84ANL", string arrivalTime = "18:00")
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.plate = plate;
            this.arrivalTime = arrivalTime;
        }
    }
}
