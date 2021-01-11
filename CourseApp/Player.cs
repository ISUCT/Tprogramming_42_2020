using System;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class Player
    {
        private static readonly Random Rnd = new Random();
        private static string[] names = new string[40]
           {
                "Артур",
                "Робин",
                "Мэрлин",
                "Гвин Гвинский",
                "Кэт де Джем",
                "Эдвурд Бакмэн",
                "Бадрик",
                "Грегори Хаус",
                "Барон",
                "Раz Dва",
                "Элиот",
                "Этелька",
                "Доктор",
                "Дэрил",
                "Сильвия",
                "Геральт",
                "Джоэл",
                "Амата",
                "Крэш",
                "Мистик",
                "Хесус",
                "Рыбожер",
                "Дартаньян",
                "Леонардо",
                "Цирилла",
                "Пьер",
                "Ломака",
                "Эксидае",
                "Мэри",
                "Антика",
                "Эдуард",
                "Максимильян",
                "Аннэт",
                "Дина",
                "Братишник",
                "Вебчик Великолепный",
                "Юлия",
                "Гаечка",
                "Силажик",
                "Снюсик",
           };

        public Player()
        {
            Name = names[Rnd.Next(0, 30)];
            Hp = Rnd.Next(50, 300);
            Strength = Rnd.Next(25, 150);
            Effects = false;
            StandTime = 0;
        }

        public string Class { get; protected set; }

        public string Name { get; set; }

        public double Hp { get; set; }

        public int Strength { get; set; }

        public bool Effects { get; set; }

        public int StandTime { get; set; }

        public string AbilityName { get; set; }

        public int AbilityDamage { get; set; }

        public int DamageInfo { get; set; }

        public virtual int Ability(Player player, Player enemy)
        {
            return 0;
        }

        public int Attack(Player fighter, Player fighterEnemy)
        {
            if (fighter.Effects == true)
            {
                fighter.Effects = false;
                DamageInfo = fighter.Ability(fighter, fighterEnemy);
                return DamageInfo;
            }
            else
            {
                DamageInfo = Strength;
                return Strength;
            }
        }

        public void GetDamage(int damage)
        {
            Hp -= damage;
        }

        public override string ToString()
        {
            return $"Name: {Name}. Strength: {Strength}. Health: {Hp}.";
        }
    }
}