using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Outkeyword
    {
        public static void Main()
        {
            int id;
            string name, dept;
            student(out id, out name,out dept);
            Console.WriteLine("Student details are"); 
            Console.WriteLine($"{id} {name} {dept}");
        }
        public static void student(out int sid, out string sname, out string sdep)
        {
            sid = 101;
            sname = "Meghana";
            sdep = "CSE";


        }
    }
}
