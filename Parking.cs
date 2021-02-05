using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars = new List<Car>();
        private int capacity;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
            
        }
        public string AddCar(Car car)
        {
            if(this.cars.Any(c=>c.RegistrationNumber==car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if(this.cars.Count==this.capacity)
            {
                return "Parking is full!";

            }
          
            
              this.cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

        }

        public string RemoveCar(string RegistrationNumber)

        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == RegistrationNumber);
            if(car==null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            this.cars.Remove(car);
            return $"Successfully removed {RegistrationNumber}";


        }
        public Car GetCar(string RegistrationNumber)
        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == RegistrationNumber);
            return car;

        }

    }
}
