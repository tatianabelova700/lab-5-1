using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int S = 0;
            for (int i = 0; i < 7; i++)
            {
                array [i] = int.Parse(Console.ReadLine());
                S+= array [i];
            }
            Console.WriteLine();
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
