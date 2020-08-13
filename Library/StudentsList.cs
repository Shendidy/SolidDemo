using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class StudentsList : IStudentsList
    {
        private List<IStudent> _studentsList;
        private ILogger _logger;

        public StudentsList(List<IStudent> studentsList, ILogger logger)
        {
            _studentsList = studentsList;
            _logger = logger;
        }

        public void DeleteStudent()
        {
            _logger.ShareMessage("Deleting student from our list!");
        }

        public void GetStudent()
        {
            _logger.ShareMessage("Getting student from our list!");
        }

        public void AddStudent(Student student)
        {
            _logger.ShareMessage($"Adding {student.name} to our list!");
        }
    }
}
