using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string aa = Console.ReadLine();
            string bb = new string(aa.Reverse().ToArray());
            Console.WriteLine(bb);
        }
    }
}
