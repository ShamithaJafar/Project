using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class newques
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            if (n % 2 == 0)
            {
                Console.WriteLine("divisible by 2");

            }
            else if(n % 3 == 0)
            {
                Console.WriteLine("divisible by 3");

            }
             else if(n % 5 == 0)
            {
                Console.WriteLine("divisible by 5");

            }
              else
            {
                Console.WriteLine("Not divisible by 2,3,5");

            }
            Console.ReadLine();
        }
}
