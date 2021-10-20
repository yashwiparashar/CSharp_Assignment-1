using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string str1 = Console.ReadLine();
            string str2= String.Concat(str1.Reverse());

            if (str1 == str2)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine(" not a palindrome");
        }
    }
}
