using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class userinput
    {
        static void Main(string[] args)
        {

            int firstnumber, secondnumber, result;
            Console.WriteLine("Enter first number:");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstnumber);
            
            Console.WriteLine("Enter second number:");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(secondnumber);
            result = firstnumber + secondnumber;
            Console.WriteLine("result : ");
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
