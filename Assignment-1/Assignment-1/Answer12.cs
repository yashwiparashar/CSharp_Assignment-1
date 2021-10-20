using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three numbers");
            int[] num = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            int f1 = num[0];
            int f2 = num[1];
            int f3 = num[2];
            int ans = Math.Max(Math.Max(f1, f2), f3);
            Console.WriteLine("largest number is " + ans);
            Console.ReadKey();

        }
    }
}
