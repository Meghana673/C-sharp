using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Matrix
    {
        public static void Main()
        {
            int m, n, i, j;
            int[,] mat1 = new int[20, 20];
            int[,] mat2 = new int[20, 20];
            int[,] res = new int[20, 20];
            Console.Write("Enter number of rows and columns of matrices\n ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first matrix: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("Enter the second matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    res[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            Console.WriteLine("First matrix ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(mat1[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Second  matrix ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(mat2[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of 2 matrix :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(res[i, j] + "\t");

                }
                Console.WriteLine();
            }


        }
    }
}

