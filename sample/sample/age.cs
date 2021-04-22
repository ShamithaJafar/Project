using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class age
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
            if ( age >= 60)
            {
                Console.WriteLine("senior citizen");

            }
            else if (age >= 18)
            {
                Console.WriteLine("Eligible to vote ");

            }
            else 
            {
                Console.WriteLine("Not eligible to vote");
            }
            Console.ReadLine();





        }
    }
}
