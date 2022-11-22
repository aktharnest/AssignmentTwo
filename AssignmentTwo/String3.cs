using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class String3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String = ");
            String s = Console.ReadLine();
            Console.Write("Enter Substring =");
            String sub = Console.ReadLine();
            Console.WriteLine(s.Contains(sub));
            Console.Read();

        }

    }
}
