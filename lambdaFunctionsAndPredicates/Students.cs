using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaFunctionsAndPredicates
{
    class Students
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

        public static List<Students> getListOfStudents()
        {
            return new List<Students>
            {
                new Students() { Name = "evgeny", Id = "123456789", AvgGrade = 81.66 },
                new Students() { Name = "yossi", Id = "987654321", AvgGrade = 71.66 },
                new Students() { Name = "moshe", Id = "555555555", AvgGrade = 99 },
                new Students() { Name = "haim", Id = "666666666", AvgGrade = 23.99 },
                new Students() { Name = "whatever", Id = "012345678", AvgGrade = 77.77 },
            };

        }

        public override string ToString() {
            return ("student name: "+this.Name+", student id:"+ this.Id+", student's average grade:" + this.AvgGrade);
        }

    }
}
