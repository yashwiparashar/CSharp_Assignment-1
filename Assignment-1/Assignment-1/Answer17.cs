using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two words");
            string[] str = Console.ReadLine().Split().ToArray();
            int len = str[0].Length;
            int flag = 0;
            for(int i=0;i<len;i++)
            {
                if (str[0][i] != str[1][i])
                    flag = 1;


            }
            if (flag == 0) Console.WriteLine("same word");
            else Console.WriteLine("different word");

        }
    }
}
