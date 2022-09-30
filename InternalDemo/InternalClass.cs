using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specifiers;

namespace InternalDemo
{
    internal class InternalClass
    {



            public static void Main()
            {
                Employee employee = new Employee();
                employee.eid = 10;
                employee.ename = "meghana";
                //department dep = new department();
                Console.WriteLine("Employee Details are");
                employee.get();
                Console.WriteLine();
                Console.WriteLine($"{employee.eid}: {employee.ename}");


            }
        }
    
}
