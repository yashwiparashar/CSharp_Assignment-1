using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer6
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter temp in fahrenheit");
            double temp = int.Parse(Console.ReadLine());
            temp = ((temp - 32) * 5) / 9;
            Console.WriteLine("temp in celsius is " + temp);
            Console.ReadKey();
        }




    }
}
