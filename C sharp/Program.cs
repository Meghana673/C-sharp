using System;
namespace basic
{
    internal class hello
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            //Datatypes
            int a = 20;
            double b = 12.34;
            char c = 'a';
            bool d = true;
            string s = "John";
            //Display the output in various ways
            Console.WriteLine(a);
            //Concatenation
            Console.WriteLine("Double value is:" + b);
            //Index value
            Console.WriteLine("Char value is:{0}", c);
            //Interpolation
            Console.WriteLine($"Hi {s},How are you? There are {a} days remaining for the training to get completed");
            //Multiple index
            Console.WriteLine("I am {0} and my age is {1}", s, a);

        }
    }
}