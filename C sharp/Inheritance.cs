using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class Bonus
    {
        //protected int salary;
        protected int bonus;
        public void Calc(int salary)
        {
            bonus = bonus * salary;
            Console.WriteLine($"Bonus is:{bonus}");
        }
    } 
    public class Staff:Bonus
    {
        public void GetBonus()
        {
            bonus = 3;
        }
    }
    public class Nonstaff:Staff
    {
        public void NGetBonus()
        {
            bonus = 2;
        }
    }

    internal class Inheritance
    {
        public static void Main()
        {
            Nonstaff n = new Nonstaff();
            n.NGetBonus();
            n.Calc(20000);
            n.GetBonus();
            n.Calc(20000);
        }
        

    }
}
