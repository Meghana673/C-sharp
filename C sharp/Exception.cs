using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Exception
    {
        public void MultipleCatch()
        {
            int[] a = { 4, 6, 2, 4, 8 };
            int[] b = { 2, 0, 3};
            string[] c = { "hello", "world" };
            int res;
            for (int i = 0; i < a.Length; i++)
            {
                
                try
                {
                    res = a[i] / b[i];
                    Console.WriteLine(res);
                    // Console.WriteLine("Value= "+ b[6]);
                    Array.Copy(c, b, 2);
                    res = a[i] + Int16.MaxValue + 6;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArrayTypeMismatchException e)
                {
                    Console.WriteLine( "Array type miss match exception is caught");
                }
               // catch(ArithmeticException e)
              //  {
                   // Console.WriteLine(e.Message);
               // }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();

            }


        }
        public static void Main()
        {
            Exception ex = new Exception();
            ex.MultipleCatch();
        }
    }
}
