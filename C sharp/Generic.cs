using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Generic
    {
        public delegate T SampleDelegate<T>(T a);
        class Area
        {
            public int square(int a)
            {
                return a * a;
            }
            public double square(double a)
            {
                return a * a;
            }
            public int cube(int s)
            {
                return  6*s*s;
            }
            public double cube(double s)
            {
                return 6 * s * s;
            }
            public double circle(double r)
            {
                return 3.14 * r*r;
            }
            public int circle(int r)
            {
                return ((22* r * r)/7);
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
          
                Area a = new Area();
        
                SampleDelegate<int> dlgt = new SampleDelegate<int>(a.square);
                Console.WriteLine("Area of Square int: " + dlgt(4));
                

                dlgt = a.cube;
                Console.WriteLine("Area of cube int: " + dlgt(10));
                dlgt=a.circle;
                Console.WriteLine("Area of circle int: " + dlgt(7));

                Console.WriteLine("---------------------------------");

                SampleDelegate<double> dlgt1 = new SampleDelegate<double>(a.cube);
                Console.WriteLine("Area of cube double: " + dlgt1(10.1));

                dlgt1= a.circle;
           
                Console.WriteLine("Area of circle double: " + dlgt1(5.1));

                dlgt1 = a.square;

                Console.WriteLine("Area of square double: " + dlgt1(4.1));



            }
        }
    }
}
