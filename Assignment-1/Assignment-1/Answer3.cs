using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer3
    {
        static void Main(String[] args)
        {

            int []integers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            int first = integers[0];
            int second = integers[1];
            for (int i = Math.Min(first,second)+1;i<Math.Max(first,second);i++)
            {
                Console.WriteLine(i);
              


            }

            Console.ReadKey();


        }
    }
}
