using System;

namespace CourseApp
{
    public class Knight : Player
    {
        public Knight()
        {
            Class = "Knight";
            AbilityName = "Retaliation strike";
        }

        public override int Ability(Player player, Player enemy)
        {
            Logger.LogText($"({Class}) {Name} использовал способность {AbilityName}");
            AbilityDamage = (int)(Strength * 1.3);
            return AbilityDamage;
        }

        public override string ToString()
        {
            return $"Class: {Class}. Name: {Name}. Strength: {Strength}. Health: {Hp}.";
        }
    }
}