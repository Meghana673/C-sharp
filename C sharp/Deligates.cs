using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{

    public delegate void BankDelegate(string bankname, double rate);
 

    public class Bank
    {
        int p=7000;
        double y=2;
    
        public void bank1(string bankname, double rate)
        {
          
            double res = (p * y * rate) / 100;
            Console.WriteLine($"Bank Name: {bankname}\t Rate: {rate} \t Interest is {res}");
        }
        public void bank2(string bankname, double rate)
        {
            double res = (p * y * rate) / 100;
            Console.WriteLine($"Bank Name: {bankname}\t Rate: {rate} \t Interest is {res}");
        }
        public void bank3(string bankname, double rate)
        {
            double res = (p * y * rate) / 100;
            Console.WriteLine($"Bank Name: {bankname}\t Rate: {rate} \t Interest is {res}");
        }
        public void bank4(string bankname, double rate)
        {
            double res = (p * y * rate) / 100;
            Console.WriteLine($"Bank Name: {bankname}\t Rate: {rate} \t Interest is {res}");
        }
        public void bank5(string bankname, double rate)
        {
            double res = (p * y * rate) / 100;
            Console.WriteLine($"Bank Name: {bankname}\t Rate: {rate} \t Interest is {res}");
        }

    }
    internal class Deligates
    {
        public static void Main()
        {
            Bank b = new Bank();
            BankDelegate bankdel = b.bank1;

            bankdel("SBI", 2.7);
            bankdel("HDFC Bank", 3.2);
            bankdel("Kotak Mahindra Bank", 3.5);
            bankdel("Axis Bank", 3.3);
            bankdel("ICICI Bank", 3.4);
           
            bankdel += b.bank2;
            bankdel += b.bank3;
            bankdel += b.bank4;
            bankdel += b.bank5;



        }
    }
}
