using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Specifiers
{
    
    public class Employee
    {
        public int eid=20;
        public string ename="Alice";

        public void get()
        {
            Console.WriteLine($"Id :{eid}\nName:{ename}");
        } 
    }
    internal class department
    {
        public int did=10;
        public string dname="IT";
        
    }
    public class EmployeeMain
    {
        public static void Main()
        {
           Employee e = new Employee();
            Console.WriteLine("Employee details are");
           Console.WriteLine($"{e.eid}: {e.ename}");
            e.get();
           department department = new department();
            Console.WriteLine();
            Console.WriteLine("Department details are");
            Console.WriteLine($"{department.did} : {department.dname}");


        }
    }
}
