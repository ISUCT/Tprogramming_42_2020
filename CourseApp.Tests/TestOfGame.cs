using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfGame
    {
        [Fact]
        public void TestOfCreateClass()
        {
            Hero hero1 = new Archer("Name");
            Hero hero2 = new Fencer("Name");
            Hero hero3 = new Warlock("Name");
            Assert.Equal("Archer", hero1.NameClass);
            Assert.Equal("Fencer", hero2.NameClass);
            Assert.Equal("Warlock", hero3.NameClass);
        }

        [Fact]
        public void TestAbilityArcher()
        {
            List<Hero> listofhero = new List<Hero>();
            Logger logger = new Logger();
            Arena arena = new Arena(listofhero, logger);
            Hero hero = new Archer("Name");
            Hero enemy = new Hero();
            arena.UseAbility(hero, enemy);
            Assert.Equal(2, hero.Damage);
        }

        [Fact]
        public void TestAbilityFencer()
        {
            List<Hero> listofhero = new List<Hero>();
            Logger logger = new Logger();
            Arena arena = new Arena(listofhero, logger);
            Hero hero = new Fencer("Name");
            Hero enemy = new Hero();
            int exp = (int)(hero.Damage * 1.3);
            arena.UseAbility(hero, enemy);
            Assert.Equal(exp, hero.Damage);
        }

        [Fact]
        public void TestAbilityWarlock()
        {
            List<Hero> listofhero = new List<Hero>();
            Logger logger = new Logger();
            Arena arena = new Arena(listofhero, logger);
            Hero hero = new Warlock("Name");
            Hero enemy = new Hero();
            arena.UseAbility(hero, enemy);
            Assert.Equal(0, hero.Damage);
            Assert.Equal(0, enemy.Damage);
        }

        [Fact]
        public void TestFight()
        {
            Hero hero1 = new Fencer("Name1");
            Hero hero2 = new Archer("Name2");
            hero1.Damage = 5;
            hero2.Damage = 8;
            hero1.HealthRnd = 50;
            hero2.HealthRnd = 25;
            List<Hero> listofhero = new List<Hero>() { hero1, hero2 };
            Logger logger = new Logger("Log.txt");
            Arena arena = new Arena(listofhero, logger);
            Assert.Equal("Name2", arena.Fight());
        }
    }
}
