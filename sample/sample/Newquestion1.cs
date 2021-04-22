using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Newquestion1
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2,2];
            Console.WriteLine("Enter elements");
          
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr [row, col] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("-------------------");

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row, col] + "\t");
                }
                Console.Write("\n");
            }

            for (int col = 0; col < arr.GetLength(0); col++)
            {
                for (int row = 0; row < arr.GetLength(1); row++)
                {
                    Console.Write(arr[row, col] + "\t");
                }
                Console.Write("\n");
            }
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[col, row] + "\t");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
        }
}
