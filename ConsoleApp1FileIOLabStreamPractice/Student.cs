using System;
using System.Collections.Generic;

namespace ConsoleApp1FileIOLabStreamPractice
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassSubject { get; set; }

        public Student(string firstName, string lastName, string classSubject)
        {
            FirstName = firstName;
            LastName = lastName;
            ClassSubject = classSubject;
        }

        //Create a method that will concatenate a string that says "{firstname} {lastname} will be taking {class subject}" and returns the string

        //Call that method in the Program class




        public string ConcatenateString(string firstName, string lastName, string classSubject)
        {
            return $"{firstName} {lastName} will be taking {classSubject}";
        }

        public void GetMessageFromCollection(List<Student> student1)
        {

            foreach (var item in student1)
            {
                string message = $"{item.FirstName} {item.LastName} will be taking {item.ClassSubject}";

                Console.WriteLine(message);
            }


        }



    }
}
