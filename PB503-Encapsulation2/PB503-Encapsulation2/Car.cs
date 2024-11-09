using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Encapsulation2
{
    public class Car
    {

        private static int _carCount = 1001;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public string CarCode { get; set; }
        
       
        public Car(int id,string name, int speed)
        {
            Id= id;
            Name = name;
            Speed = speed;
            CarCode=CarOfCode(name);
            
                
           
        }

        public string CarOfCode(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                Console.WriteLine("Zehmet olmasa avtomobil adini duzgun daxil edin");

            }
            else
            {
                name = name.Substring(0,2).ToUpper();
            }
            return $"{name}{_carCount++}";
        }

    }
}
