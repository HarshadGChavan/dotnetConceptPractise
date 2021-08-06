using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasic
{

    public record Student{
        public int? StudentID {get; init;}
        public string StudentName {get; init;}
        public int? Age {get; init;}
    }

    public record Standard{
        public int? StandardID {get; init;}
        public string StandardName {get; init;}
    }

    public class LinqOperations
    {
        IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 } 
        };

        IList<Standard> standardList = new List<Standard>() { 
				new Standard(){ StandardID = 1, StandardName="Standard 1"},
				new Standard(){ StandardID = 2, StandardName="Standard 2"},
				new Standard(){ StandardID = 3, StandardName="Standard 3"}
			};

        List<string> lstOperation = new List<string> (){
            "Audi","Tesla","Ford","Ferrari","Porche"
        };

        public void ExecuteWhere()
        {
           var result =  studentList.Where(q => (q.Age == 21) && (q.StudentID == 2) );
           DisplayResult(result);
        }

        public void ExecuteOfType()
        {
           var result =  studentList.OfType<Student>();
           DisplayResult(result);
        }

        public void ExecuteOrderBy()
        {
           var result =  studentList.OrderBy(s => s.Age);
           DisplayResult(result);
        }

        public void ExecuteThenBy()
        {
           var result =  studentList.OrderBy(s => s.Age).ThenBy(s => s.StudentName);
           DisplayResult(result);
        }

        public void ExecuteGroupBy()
        {
           var result =  studentList.GroupBy(s=> s.Age);
          foreach (var studentGroup in result)
          {
            Console.WriteLine("Age Group of {0}",studentGroup.Key);
            foreach (var itemStudent in studentGroup)
            {
                Console.WriteLine(itemStudent);
            }
          }
           
        }

        public void ExecuteInnerJoin()
        {
            var joinResult = studentList.Join( // outer squence
                standardList,  // inner sequence
                student => student.StudentID,  // outer Key Selector
                standard => standard.StandardID,  // inner key selector
                (student,standard) => new{        // result selector
                    StudentName = student.StudentName,
                    StandardName = standard.StandardName
                }
            );
            foreach (var obj in joinResult)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }
        }

        public void ExecuteContains()
        {
            string strInput = "Hello I a Harshad Chavan";
            var result = strInput.Contains("Harshad");
            Console.WriteLine("Does string contains Harshad : {0}",result);
        }

        public void ExecuteCount()
        {
            Console.WriteLine("Student count wuth Age 21 is {0}", studentList.Count(s => s.Age == 21));
        }

        public void ExecuteFirst()
        {
            var result = studentList.First(x => x.Age == 21);
            Console.WriteLine("First record with criteria Age=21 =>  ID: {0} Name: {1}",result.StudentID,result.StudentName);
        }

        public void ExecuteFirstOrDefault()
        {
            // Execute First will fail with this query.
            var result = studentList.FirstOrDefault(x => x.Age == 25);
            Console.WriteLine("First record with criteria Age=21 =>  Student: {0}",result);
        }

        public void ExecuteTake()
        {
            var result = studentList.Where(s => s.Age == 21).Take(1);
            Console.WriteLine("Take 1 with age 21 : ");
            DisplayResult(result);
        }

        public void ExecuteSkip()
        {
            var result = studentList.Where(s => s.Age == 21).Skip(1);
            Console.WriteLine("Skip 1 with age 21 : ");
            DisplayResult(result);
        }

        public void DisplayResult(dynamic result)
        {
            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}