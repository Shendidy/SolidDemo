using NUnit.Framework;

namespace Library.Tests
{
    class StudentTests
    {
        IStudent _student;

        [SetUp]
        public void Setup()
        {
            _student = new Student();
        }

        [Test]
        public void SetName_GivenNewName_ShouldSetObjectsName()
        {
            //Arr
            _student.SetName("Test Name");

            //Act
            var expected = "Test Name";
            var actual = _student.name;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetAge_GivenNewName_ShouldSetObjectsName()
        {
            //Arr
            _student.SetAge(16);

            //Act
            var expected = 16;
            var actual = _student.age;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetYear_GivenNewName_ShouldSetObjectsName()
        {
            //Arr
            _student.SetYear(5);

            //Act
            var expected = 5;
            var actual = _student.year;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetGrade_GivenNewName_ShouldSetObjectsName()
        {
            //Arr
            _student.SetGrade(88.75);

            //Act
            var expected = 88.75;
            var actual = _student.grade;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
