using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter five numbers");
            int[] num = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            int ans = int.MaxValue;
            foreach(int i in num)
            {
                if (i < ans)
                    ans = i;
            }
            Console.WriteLine("answer is "+ans);
            Console.ReadKey();
        }
    }
}
