using System;
using Xunit;

namespace CourseApp.Tests
{
    public class EmployeeTest
    {
        [Theory]
        [InlineData("Microsoft", "Microsoft")]
        [InlineData("Yandex", "Yandex")]
        public void TestCompany(string a, string exp)
        {
             Employee person = new Employee();
             person.Company = a;
             Assert.Equal(person.Company, exp);
        }

        [Theory]
        [InlineData("Works")]
        public void TestDoestEmployee(string exp)
        {
            Employee emp = new Employee();
            var empDues = emp.DoesSomething();
            Assert.Equal(empDues, exp);
        }

        [Theory]
        [InlineData("Company")]
        public void TestGoingEmployee(string exp)
        {
            Employee emp = new Employee();
            var empGoing = emp.GoingSomewhere();
            Assert.Equal(empGoing, exp);
        }
    }
}