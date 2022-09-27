using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Controlstat
    {
        enum Technology
        {
            Java,
            C=10,
            Python,
            Angular=20,
            Database,
            Dotnet
        }
        public static void Main()
        {
            conditional();
            Console.WriteLine("---------------------");
            Controlstat c = new Controlstat();
            c.loop();
            Console.WriteLine("---------------------");
            Console.WriteLine("Enumerator");
            Console.WriteLine(Technology.Java);
            var s = (Technology)10;
            Console.WriteLine(s);
            int m = (int)Technology.Database;
            Console.WriteLine(m);
        }

        public static void conditional()
        {
            int a,b;
            Console.WriteLine("Static Method");
            Console.WriteLine("Enter the 2 numbers");
            a = Convert.ToInt32( Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is greater", a);
            }
            else
                Console.WriteLine("{0} is greater", b);
        }
        public void loop()
        {
            Console.WriteLine("Instance Method");
            int[] arr = new int[] { 2, 4, 6, 8, 10, 5 };
            
            int sum = 0;
            Console.WriteLine("Array elements are");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum is:{0}", sum);
        }
    }

}
