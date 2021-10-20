using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer8
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int ans = 1;
            for(int i=num;i>=1;i--)
            {
                ans = ans * i;
            }
            Console.WriteLine("factorial is " + ans);

            Console.ReadKey();

        }
    }
}
