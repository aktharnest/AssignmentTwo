using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program5
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3] {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
            };
            int s = 0;
            for (int i = 0; i < 3; i++)
            {
                s = s + arr[i, i];
            }
            Console.WriteLine("Sum of Diagonal Elements = " + s);
            Console.Read();
        }

    }
}
