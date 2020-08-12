using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Student : IStudent
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public int year { get; private set; }
        public double grade { get; private set; }

        public void SetName(string name) => this.name = name;
        public void SetAge(int age) => this.age = age;
        public void SetYear(int year) => this.year = year;
        public void SetGrade(double grade) => this.grade = grade;
    }
}
