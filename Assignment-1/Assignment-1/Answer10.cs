using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(num * i);

            }
            Console.ReadKey();

        }
    }
}
