using System;
using Xunit;

namespace CourseApp.Tests
{
    public class ClassTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(-5, 0)]
        [InlineData(10, 10)]
        public void TestLvl(int a, int exp)
        {
            Character hero = new Character();
            hero.Lvl = a;
            Assert.Equal(hero.Lvl, exp);
        }

        [Theory]
        [InlineData("Strength",  "Strength")]
        [InlineData("Agility", "Agility")]
        [InlineData("Intellect", "Intellect")]
        [InlineData("Intelect", null)]
        public void TestAttribute(string a, string exp)
        {
            Character hero = new Character();
            hero.AttributeHero = a;
            Assert.Equal(hero.AttributeHero, exp);
        }

        [Theory]
        [InlineData("Warrior",  "Warrior")]
        [InlineData("Archer", "Archer")]
        [InlineData("Mage", "Mage")]
        [InlineData("Mae", null)]
        public void TestClass(string a, string exp)
        {
            Character hero = new Character();
            hero.ClassHero = a;
            Assert.Equal(hero.ClassHero, exp);
        }
    }
}
