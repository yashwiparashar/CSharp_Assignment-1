using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Answer15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string word = Console.ReadLine();
            int ans=0;
            foreach(char ch in word)
            {
                ans++;
            }

            Console.WriteLine("wordlength is " + ans);


        }
    }
}
