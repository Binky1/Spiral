using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    internal class Program
    {
        static int[,] arr = new int[4, 4];
        static Random rnd = new Random();
        static int row = 0; 
        static int row2 = arr.GetLength(0); 
        static int c = 0; 
        static int c2 = arr.GetLength(1); 
        
        public static void Up()
        {
            
                for (int j = c; j < c2; j++)
                {
                    Console.Write(arr[row, j] + " ");
                }
                row++;
            
        }

        public static void Down()
        {

            for (int j = c2 -1; j >= c; j--)
            {
                Console.Write(arr[row2 -1, j] + " ");
            }
            row2--;

        }
        public static void Right()
        {

            for (int i = row; i < row2; i++)
            {
                Console.Write(arr[i, c2 -1] + " ");
            }
            c2--;

        }
        public static void Left()
        {

            for (int i = row2 -1; i >= row; i--)
            {
                Console.Write(arr[i, c] + " ");
            }
            c++;

        }
        static void Main(string[] args)
        {
           

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }


            int count = 0;
            while (row2 != row && c2 != c)
            {
                if (count == 4)
                {
                    count = 0;
                }
                if (count == 0)
                {
                    Up();
                }
                else if (count == 1)
                {
                    Right();
                }
                else if (count == 2)
                {
                    Down();
                    
                }
                else if (count == 3)
                {
                    Left();
                  
                }
                count++;

            }


            Console.ReadKey();

        }
    }
}
