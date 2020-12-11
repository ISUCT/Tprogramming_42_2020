using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfData
    {
        [Fact]
        public void TestPastDate()
        {
            Transport machine = new Car();
            DateTime now = new DateTime(2020, 12, 8);
            DateTime birth = new DateTime(2001, 12, 6);
            string exp = "19 years 0 months 5 days";
            string result = machine.Age(now, birth);
            Assert.Equal(exp, result);
        }

        [Fact]
        public void TestOfPastDate()
        {
            Transport machine = new Car();
            DateTime now = new DateTime(2020, 12, 8);
            DateTime birth = new DateTime(2020, 12, 8);
            string exp = "0 years 0 months 0 days";
            string result = machine.Age(now, birth);
            Assert.Equal(exp, result);
        }

        [Fact]
        public void TestOfFutureDate()
        {
            Transport machine = new Car();
            DateTime now = new DateTime(2020, 12, 8);
            DateTime birth = new DateTime(2021, 11, 24);
            string exp = "0 years 10 months 31 days";
            string result = machine.Age(now, birth);
            Assert.Equal(exp, result);
        }
    }
}