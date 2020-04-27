using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1FileIOLabStreamPractice
{
    class Program
    {
        static void Main(string[] args)
        {


            //Ask the user for a first name, last name, subject
            //Add that info to text file
            //Read that info from text file




            string textPath = @"C:\Users\hphifer\source\repos\ConsoleApp1FileIOLabStreamPractice\ConsoleApp1FileIOLabStreamPractice\StudentData.txt";

            Console.WriteLine("Give me a first name");
            string userFirstName = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Give me a last name");
            string userLastName = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Give me a subject");
            string userSubject = Console.ReadLine().ToLower().Trim();


            //Create a new student object
            Student studentObj = new Student(userFirstName, userLastName, userSubject);





            //Creates a list of student objects
            List<Student> students = new List<Student>();

            //Add the studentObj to the Student List
            students.Add(studentObj);

            //Creates an empty string list to be used to stored student data to be read by text file
            List<string> studentCollection = new List<string>();

            //Adds data to the empty list
            foreach (Student student in students)
            {
                studentCollection.Add($"{student.FirstName}|{student.LastName}|{student.ClassSubject} ");
            }


            //writes the data in the string list to the txt file
            using (StreamWriter sw = new StreamWriter(textPath))
            {
                foreach (string student in studentCollection)
                {
                    sw.WriteLine(student);
                }
            }



            string x = studentObj.ConcatenateString(studentObj.FirstName, studentObj.LastName, studentObj.ClassSubject);



            List<Student> listFromTextfile = new List<Student>();

            using (StreamReader sr2 = new StreamReader(textPath))
            {
                string line = sr2.ReadToEnd();

                //Split the lines into substring based on the '|' symbol


                string[] textArray = line.Split(',');

                Student s = new Student(null, null, null);

                s.FirstName = textArray[0];
                s.LastName = textArray[1];
                s.ClassSubject = textArray[2];

                listFromTextfile.Add(s);


              
            }







            studentObj.GetMessageFromCollection(listFromTextfile);

            Console.WriteLine(x);






            //Spacing
            Console.WriteLine();
            Console.WriteLine();







            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();

        }

        private static void ReadAndFormatText(string textPath)
        {
            using (StreamReader sr2 = new StreamReader(textPath))
            {
                string line = sr2.ReadToEnd();

                //Split the lines into substring based on the '|' symbol


                string[] textArray = line.Split(',');

                foreach (var formattedLine in textArray)
                {
                    Console.Write($"{formattedLine} ");
                }
            }
        }

        private static void ReadText(string textPath)
        {
            using (StreamReader sr = new StreamReader(textPath))
            {
                string allTheLines = sr.ReadToEnd();

                Console.WriteLine(allTheLines);
            }
        }
    }
}
