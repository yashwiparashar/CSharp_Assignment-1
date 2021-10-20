using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ten numbers");
            int[] num = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            int min = int.MaxValue;
            int max = int.MinValue;
            int total = 0;
            float average;
            foreach(int i in num)
            {
                total = total + i;
                if (i < min) min = i;
                if (i > max) max = i;

            }
            average = (float)total / 10;
            Array.Sort(num);
            Console.Write("ascending order");

            foreach (int i in num)
             Console.Write(i + " ");
            Array.Reverse(num);
            Console.WriteLine("\n"+"descending order");
            foreach (int i in num)
                Console.Write(i + " ");
            Console.WriteLine("\n" +"total is " + total);
            Console.WriteLine("average is " + average);
            Console.WriteLine("minimum is" + min);
            Console.WriteLine("MAX IS  " + max);

        }
    }
}
