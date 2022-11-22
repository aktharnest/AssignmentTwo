using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class String1
    {
        static void Main(string[] args)
        {
            String s = "Hello World";
            int a = 0, wc = 1;
            while (a < s.Length)
            {
                Console.WriteLine(s[a]);
                if (s[a] == ' ' || s[a] == '\t' || s[a] == '\n')
                {
                    wc++;
                }
                a++;
            }
            Console.WriteLine("Number of Words = " + wc);
            Console.Read();
        }

    }
}
