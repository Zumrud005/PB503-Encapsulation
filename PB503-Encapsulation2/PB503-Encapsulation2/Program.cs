namespace PB503_Encapsulation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1,"BMW",230);
            Car car2 = new Car(2, "Mercedes", 150);
            Car car3 = new Car(3, "Kia", 130);

            Gallery gallery = new Gallery();
            gallery.Name = "Car Gallery";
            gallery.Id = 1;
            gallery.AddCar(car1);
            gallery.AddCar(car2);
            gallery.AddCar(car3);

            Console.WriteLine(car1.CarCode);
            Console.WriteLine(car2.CarCode);
            Console.WriteLine(car3.CarCode);

            gallery.ShowAllCars();

            Car[] allCars = gallery.GetAllCars();

            foreach (var car in allCars)
            {
                Console.WriteLine($"Car ID: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");
            }

            
           

            Console.WriteLine(gallery.FindCarById(1).Name);

            Console.WriteLine(gallery.FindCarByCarCode("BM1001").Speed);

            Car[] wantedcars = gallery.FindCarsBySpeedInterval(100, 200);
            foreach (var car in wantedcars)
            {
                Console.WriteLine($"car name:{car.Name} , car speed: {car.Speed}");
            }

        }
    }
}
