using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class AgeException : ApplicationException
    {
        public AgeException(string message) : base(message)
        {

        }
    }
    internal class CustomException
    {
        public static void Main()
        {
            int age;
            try
            {
                Console.WriteLine("Enter your age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 22)
                {
                    throw (new AgeException("You are adult"));
                }
                else
                {
                    Console.WriteLine("You are minor");
                }
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
