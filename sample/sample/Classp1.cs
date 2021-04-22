using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Student
    {
        public int Rollnumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        static void Main()
        {
            Student student = new Student();
            student.Rollnumber = 1;
            student.Name = "Shamitha";
            student.Gender = "Female";
            Console.WriteLine(student.Rollnumber + "\t" + student.Name + "\t" + student.Gender);
            Console.ReadLine();
        }

    }
}
