using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program2
    {
        static void Main(string[] args)
        {
            int s = 0;
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in arr)
            {
                s = s + i;
            }
            Console.WriteLine("sum = " + s);
            Console.Read();
        }

    }
}
