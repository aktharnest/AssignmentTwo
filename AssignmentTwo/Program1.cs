using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int odd = 0;
            int even = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    odd++;
                }
                else
                    even++;
            }
            Console.WriteLine("Count of Odd Numbers = " + odd);
            Console.WriteLine("Count of Even Numbers = " + even);
            Console.Read();
        }

    }
}
