using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace C_sharp
{
    internal class Regexexp
    {
        public static void Main()
        {
            mobile();
        }

        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            string mobile = "9961234427";
            var validate = Regex.IsMatch(mobile, @"^[7-9][0-9]{9}$");
            Console.WriteLine(validate);
        }
    }
}
