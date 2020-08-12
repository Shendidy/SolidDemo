using System;
using Library;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.CreateNewSchool().StartSchool();

            //Crate an app that represents a school with a list of students
            //The list contains students names, age, year, and overall grade
            //When the app starts, it presents the user with 4 options
            //1- add a studen
            //2- get the details of an existing student
            //3- delete a student
            //4- Exit
            //After completion of each activity, the app will offer the 4 options again

            //Classes needed
            //1- School
            //2- Student
            //3- List
            //4- Logger
        }
    }
}
