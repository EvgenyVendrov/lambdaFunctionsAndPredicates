using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaFunctionsAndPredicates
{
    class Student
    {
        public String Name
        {
            get;
            set;
        }

        public String Id
        {
            get;
            set;
        }

        public double AvgGrade
        {
            get;
            set;
        }

        public List<Student> getListOfStudents()
        {
            return new List<Student>
            {
                new Student() { Name = "evgeny", Id = "123456789", AvgGrade = 81.66 },
                new Student() { Name = "yossi", Id = "987654321", AvgGrade = 71.66 },
                new Student() { Name = "moshe", Id = "555555555", AvgGrade = 99 },
                new Student() { Name = "haim", Id = "666666666", AvgGrade = 23.99 },
                new Student() { Name = "whatever", Id = "012345678", AvgGrade = 77.77 },
            };

        }
    }
}
