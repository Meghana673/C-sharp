using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class Add
    {   
        Add(int a, int b)
        {
            int res;
            res = a + b;
            Console.WriteLine(res);
        }
        Add(float a, float b)
        {
            float res = a + b;
            Console.WriteLine(res);
        }
        Add(string a, string b)
        {
           string res = a + b;
            Console.WriteLine(res);
        }
        public static void Main()
        {
            Add a = new Add(10,20);
            Add a1= new Add("hello", "Meghana");
            Add a3 = new Add(2.4f, 1.2f);


        }
    }
}
