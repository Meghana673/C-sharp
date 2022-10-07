using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Collections
    {
        public static void Dictionary_Demo()
        {
            Dictionary<int, string> vs = new Dictionary<int, string>();
            vs.Add(1, "C#");
            vs.Add(2, "SQL");
            vs.Add(3, "Java");
            vs.Add(4, "Angular");
            Console.WriteLine("DICTIONARY");
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
           
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Key: {vs[3]}");
            //Console.WriteLine($"Key: {vs[9]}");//If the key is not found -> raise an exception

        }
       

        public static void Hashtable_Demo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "C#");
            ht.Add(2, "Java");
            ht.Add(3, "Angular");
            ht.Add(4, 200);
            ht.Add(5, "React");
            ht.Add(6, "DotNet");
            Console.WriteLine("HASHTABLE");

            //ICollection Interface
            ICollection key = ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine($"Key: {ht[1]}");
            Console.WriteLine($"Key: {ht[0]}");//If the key is not found -> null value
        }

        public static void Main()
        {
           
            Dictionary_Demo();
            Console.WriteLine("-----------------------------------------");
            Hashtable_Demo();
        }
    }
}
