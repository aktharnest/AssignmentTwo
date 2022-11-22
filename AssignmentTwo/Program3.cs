using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { -1, 2, 3, -7, -4, -5, 6, -8, 9, -10 };
            int[] neg = new int[10];
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] < 0)
                {
                    neg[j] = arr[i];
                    j++;
                }
            }
            Console.WriteLine("Negative Numbers\n");
            for (int i = 0; i < j; i++)
            {
                Console.Write(neg[i] + "\t");
            }
            Console.Read();
        }

    }
}
