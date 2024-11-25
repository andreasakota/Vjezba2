using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    class Student
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return name + ":" + grade;
        }
        public static bool CompareName(object obj1, object obj2)
        {
            Student student1 = obj1 as Student;
            Student student2 = obj2 as Student;

            if (student1 == null || student2 == null)
           
                throw new ArgumentException("Both objects must beof type Student");

            return student1.name.CompareTo(student2.name) < 0;
           
        }

        public static bool CompareGrade(object obj1, object obj2)
        {
            Student student1 = obj1 as Student;
            Student student2 = obj2 as Student;

            if (student1 == null || student2 == null)
                throw new ArgumentException("Both objects must be of type Student");

            return (student1.grade > student2.grade);

        }
    }
}
