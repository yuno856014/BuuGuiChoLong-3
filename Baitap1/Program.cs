using System;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = InitMatrix();
            Sum(matrix);
            Console.WriteLine($"So dong lon nhat la {FindMaxRow(matrix)}");
        }
        static int[,] InitMatrix()
        {
            Console.WriteLine("Nhap so hang!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot!");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m;j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }    
            } 
            for(int i = 0; i< n;i++)
            {
                for(int j = 0; j < m; j ++)
                {
                    Console.Write($"{ matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            return matrix;
        }  
        static void Sum(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Tong gia tri dong " + i + " : " + sum);
            }
        }
        static int FindMaxRow(int[,] matrix)
        {
            int max = 0;
            int maxtmp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                if (sum > maxtmp)
                {
                    maxtmp = sum;
                    max = i;
                }
            }
            return max;
        }
    }
}
