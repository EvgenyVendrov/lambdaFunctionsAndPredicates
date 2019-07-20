using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaFunctionsAndPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = Students.getListOfStudents();
            //printing to console first studnet with average grade above 70
            Console.WriteLine(studentList.Find(student=>student.AvgGrade>70));
            //printing all the students which average grade is above 70
            var allStudentsAbove70 = studentList.FindAll(student => student.AvgGrade > 70);
            foreach(var student in allStudentsAbove70)
            {
                Console.WriteLine(student);
            }
            //last student contains "123" in he's id
            Console.WriteLine(studentList.FindLast(student=>student.Name.Contains("123")));
            //printing the indexes of the first students which name starts with a letter between 'c' and 'j'
            var index = studentList.FindIndex(student=>student.Name.ElementAt(0)>='c'&& student.Name.ElementAt(0) <= 'j');
            Console.WriteLine("first student whose name starts with a letter between c and j: "+studentList[index]);
            //inserting new element to the list we got earlier, now the student which returns should be the new one   
            studentList.Insert(0,new Students() { Name="caaa",Id="1212121",AvgGrade=33});
            index = studentList.FindIndex(student => student.Name.ElementAt(0) >= 'c' && student.Name.ElementAt(0) <= 'j');
            Console.WriteLine("first student whose name starts with a letter between c and j: " + studentList[index]);
        }
    }
}
