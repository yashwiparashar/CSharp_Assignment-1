using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer5
    {
        static void Main(String[] args)
        {

            int[] integers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            int even = 0, odd = 0;
            foreach(int i in integers)
            {
              if (i % 2 == 0) even++;
             else odd++;


              }
            Console.WriteLine("even numbers are " + even);
            Console.WriteLine("odd numbers are " + odd);

        }

    }
}
