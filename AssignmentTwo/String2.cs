using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class String2
    {
        static void Main(string[] args)
        {
            String s = "Hello World";
            int a = 0, count = 0;
            while (a < s.Length)
            {
                if (s[a] == 'a' || s[a] == 'e' || s[a] == 'i' || s[a] == 'o' || s[a] == 'u' || s[a] == 'A' || s[a] == 'E' || s[a] == 'I' || s[a] == 'O' || s[a] == 'U')
                {
                    count++;
                }
                a++;
            }
            Console.WriteLine("Number of Vowels = " + count);
            Console.Read();
        }

    }
}
