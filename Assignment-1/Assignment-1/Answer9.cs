using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer9
    {

        static void Main(string[] args)
        {

            int num1 = 0, num2 = 1;
            int num3=0;
            Console.Write(num1 + " " + num2+" ");
            while(num3<=40)
            {
                num3 = num1 + num2;
                if (num3 > 40)
                    break;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;

            }


        }
    }
}
