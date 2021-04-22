using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Cal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the opeartion you want to do \n1.Add \n2. Sub \n3.Mul \n4.div:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                        Console.WriteLine("ADD ");
                        break;
                case 2:
                         Console.WriteLine("SUB ");
                         break;
                case 3:
                        Console.WriteLine("MUL ");
                        break;

                case 4:
                         Console.WriteLine("DIV ");
                         break;
                default:
                         Console.WriteLine("error ");
                         break;
            }
            Console.ReadLine();
        }
           





        
    }
}
