using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class Startup
    {
        public static IStudent CreateNewStudent() => new Student();
        public static IStudentsList CreateNewStudentsList() => StudentsList.CreateStudentsList();
        public static ILogger CreateNewLogger() => new Logger();
        public static ISchool CreateNewSchool() => new School(CreateNewLogger());
    }
}
