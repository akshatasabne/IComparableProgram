using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Product Pen= new Product(101, "Pen", 500);
            //Product  Shooes= new Product(102, "Shooes", 200);
            //int res=Pen.CompareTo(Shooes);

            //if(res<0)
            //{
            //    Console.WriteLine("pen's price is greater than shooes");
            //}
            //else if (res > 0)
            //{
            //    Console.WriteLine("Shooes's price is greater than pen");
            //}
            //else
            //{
            //    Console.WriteLine("");
            //}
           
            Employee employee = new Employee { Id= 1,Name="Akshata",Salary=25000 };
            Employee employee1 = new Employee { Id =2, Name = "Vidyashree", Salary = 35000 };

            SalaryComparison comparison = new SalaryComparison();
            int res=comparison.Compare(employee, employee1);

            if(res>0)
            {
                Console.WriteLine("Akshata has more salary than Vidyashree");
            }
            else if(res<1)
            {
                Console.WriteLine("Vidyashree has more salary than Akshata");
            }
            else
            {
                Console.WriteLine("Anjali's Salary is 20000");
            }
        }
    }
}
