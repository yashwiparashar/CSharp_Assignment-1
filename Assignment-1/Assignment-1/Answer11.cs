using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer11
    {

        static void Main(string[] args)
        {
            for(int i=200;i<300;i++)
            {

                if (i % 7 == 0)
                    Console.Write(i + " ");
            }
            Console.ReadKey();

        }
    }
}
