using NUnit.Framework;

namespace Library.Tests
{
    class StudentsListTests
    {
        static IStudentsList _studentsList;

        [SetUp]
        public void Setup()
        {
            _studentsList = Startup.CreateNewStudentsList();
        }

        [Test]
        public void AddStudent_ShouldAddNewStudentToStudentsList()
        {
            //Arr
            Student student = new Student();
            student.SetName("Test Student");

            //Assert
            Assert.DoesNotThrow(() => _studentsList.AddStudent(student));
        }
    }
}
