using System;
using Xunit;

namespace CourseApp.Tests
{
    public class StudentTest
    {
        [Theory]
        [InlineData("ISUCT", "ISUCT")]
        [InlineData("Cambridge", "Cambridge")]
        public void TestUniversity(string a, string exp)
        {
             Student person = new Student();
             person.University = a;
             Assert.Equal(person.University, exp);
        }

        [Theory]
        [InlineData("Study")]
        public void TestDoestStudent(string exp)
        {
            Student st = new Student();
            var stDues = st.DoesSomething();
            Assert.Equal(stDues, exp);
        }

        [Theory]
        [InlineData("University")]
        public void TestGoingStudent(string exp)
        {
            Student st = new Student();
            var stGoing = st.GoingSomewhere();
            Assert.Equal(stGoing, exp);
        }
    }
}