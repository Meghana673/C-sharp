using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_array
{
    internal class Mutiplication
    {

        public static void Main()
        {
           multit(1, 2,3,4,5,6,7,8,9,10);
           
        }
        

        public static void multit(params int[] num)
        {
            foreach (int i in num)
            {
                Console.WriteLine("Multiplication table of {0}", i);
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");

                }

                Console.WriteLine();
            }
            

        }
        

    }
}
