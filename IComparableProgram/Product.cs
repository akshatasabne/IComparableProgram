using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableProgram
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int CompareTo(Product other)
        {
            if (this.Price < other.Price)
            {
                return -1;

            }
            else if (this.Price > other.Price)
            {
                return 1;

            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"Product Id-{Id}-Product Name-{Name}-Product Price{Price}";
        }

    }
}