using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class StudentsList : IStudentsList
    {
        private static readonly StudentsList _instance;
        private List<IStudent> _studentsList;
        private ILogger _logger;

        private StudentsList(List<IStudent> studentsList, ILogger logger)
        {
            _studentsList = studentsList;
            _logger = logger;
        }

        public static StudentsList CreateStudentsList()
        {
            return _instance;
        }

        public void DeleteStudent()
        {
            _logger.ShareMessage("Deleting student from our list!");
        }

        public void GetStudent()
        {
            _logger.ShareMessage("Getting student from our list!");
        }

        public void AddStudent()
        {
            _logger.ShareMessage("Adding a student to our list!");
        }
    }
}
