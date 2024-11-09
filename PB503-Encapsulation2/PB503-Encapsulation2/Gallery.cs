using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Encapsulation2
{
    public class Gallery 

    {
         public int Id { get; set; }
         public string Name { get; set; }

         public Car[] cars =Array.Empty<Car>();
       
       


        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length+1);
            cars[cars.Length-1]=car;

        }


        public void ShowAllCars()
        {
            foreach (var car in cars)
            {

                Console.WriteLine($"car id:{car.Id}, car name:{car.Name}, car speed:{car.Speed}, car carcode:{car.CarCode}");
            }
        }
            
        public Car[] GetAllCars()
        { 
            return cars; 
        }


        public Car FindCarById(int id)
        {
            foreach (var car in cars)
            {
                if (car.Id == id)
                {
                    return car;
                }
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            foreach (var car in cars)
            {
                if (car.CarCode == carCode)
                {
                    return car;
                }
            }
            return null;
        }


        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] wantedcars = Array.Empty<Car>();
            foreach (var car in cars)
            {
                if(car.Speed>minSpeed &&  car.Speed<maxSpeed)
                {
                    Array.Resize(ref wantedcars, wantedcars.Length+1);
                    wantedcars[wantedcars.Length-1] = car;
                    
                }
            }
            return wantedcars;
        }


    }
}
