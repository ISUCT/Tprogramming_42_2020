using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfData
    {
        [Fact]
        public void TestTheSameDate()
        {
            Transport machine = new Car();
            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            int yearResult = machine.Age(year, month, day).Year - 1;
            int monthResult = machine.Age(year, month, day).Month - 1;
            int dayResult = machine.Age(year, month, day).Day - 1;
            Assert.Equal(0, yearResult);
            Assert.Equal(0, monthResult);
            Assert.Equal(0, dayResult);
        }

        [Fact]
        public void TestOfPastDate()
        {
            Transport machine = new Car();
            int year = 2001;
            int month = 12;
            int day = 6;
            int yearResult = machine.Age(year, month, day).Year - 1;
            int monthResult = machine.Age(year, month, day).Month - 1;
            int dayResult = machine.Age(year, month, day).Day - 1;
            Assert.Equal(18, yearResult);
            Assert.Equal(11, monthResult);
            Assert.Equal(18, dayResult);
        }

        [Fact]
        public void TestOfFutureDate()
        {
            Transport machine = new Car();
            int year = 2021;
            int month = 11;
            int day = 24;
            int yearResult = machine.Age(year, month, day).Year - 1;
            int monthResult = machine.Age(year, month, day).Month - 1;
            int dayResult = machine.Age(year, month, day).Day - 1;
            Assert.Equal(1, yearResult);
            Assert.Equal(0, monthResult);
            Assert.Equal(0, dayResult);
        }
    }
}