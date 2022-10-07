using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class File_table
    {
        public void write()
        {
      
            using (StreamWriter sw = File.CreateText(@"C:\Evry\Technical Training\DotNet\TE1.txt"))
            {
                Console.WriteLine("Multiplication Table");
                for (int i = 1; i <=10; i++)
                {
                    for(int j = 1; j <=10; j++)
                    {
                        sw.WriteLine($"{i} x {j} = {i * j}");
  

                    }
                    
                }
            }
        }

        public void read()
        {
            using (StreamReader sr = File.OpenText(@"C:\Evry\Technical Training\DotNet\TE1.txt"))
            {
                string contents = null;
                while ((contents = sr.ReadLine()) != null)
                {
                    Console.WriteLine(contents);
                }

            }
        }
    }
    internal class Files
    {
        public static void Main()
        {
            File_table f = new File_table();
            f.write();
            f.read();

            Console.WriteLine("----------------------------------------");
            //File.Move(@"C:\Evry\Technical Training\DotNet\TE2.txt", @"C:\Evry\Technical Training\DotNet\html\TE2.txt");
           
            string path = @"C:\Evry\Technical Training\DotNet\html\TE2.txt";
            string dest_path = @"C:\Evry\Technical Training\DotNet\TE3.txt";

            //File.Copy(path, dest_path);
            //File.Delete(dest_path);

            string[] content;
            int count;
            content = File.ReadAllLines(path);
            count = File.ReadAllLines(path).Count();
            Console.WriteLine(count);

            Console.WriteLine("----------------------------------------");
            
            Console.WriteLine(content[0]);
        }

    }
}
