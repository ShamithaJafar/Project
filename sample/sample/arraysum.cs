using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class arraysum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter elements");
            int sum = 0;
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (int i = 0; i < arr.Length; i++)
            {
               sum = sum + arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        }
}
