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
            _student.SetName("Test Name");

            //Act
            var expected = "Test Name";
            var actual = _student.name;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
