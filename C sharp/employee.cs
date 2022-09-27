using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class employee
    {
      


        public static void Main()
        {
            emp_det();
            
         

        }
        public static void emp_det()
        {
            int empid;
            string empname;
            string dept;
            int salary;
            int num;

            Console.WriteLine("Employee Details");
            Console.WriteLine("Enter the number of employee");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the employee id");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the employee name");
                empname = Console.ReadLine();
                Console.WriteLine("Enter the employee department");
                dept = Console.ReadLine();
                Console.WriteLine("Enter the employee salary");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------");
                employee e = new employee();
                e.Display(empid, empname, dept, salary);
                Console.WriteLine();

            }
           

        }
        public void Display(int empid,string empname,string dept , int salary)
        {
            Console.WriteLine("Employee details are");
            Console.WriteLine($"Employee Id:  {empid}");
            Console.WriteLine($"Employee name:  {empname}");
            Console.WriteLine($"Employee department:  {dept}");
            Console.WriteLine($"Employee salary:  {salary}");

        }

    }
}
