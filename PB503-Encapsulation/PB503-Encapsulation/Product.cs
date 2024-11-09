using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Encapsulation
{
    public class Product
    {
        private double _price;
        private int _count;
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;

                }
                else
                {
                    Console.WriteLine("daxil etdiyiniz qiymet yanlisdir.");
                }
            }
        }

        public int Count { get { return _count; } set 
            { 
                if (value > 0) 
                {
                    _count = value; 
                } 
                else 
                { 
                    Console.WriteLine("Daxil etdiyiniz deyer duzgun deyil"); 
                } 
            } 
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            _price = price;
        }
    }
}
