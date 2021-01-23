using System;
using System.Collections.Generic;

namespace RPG
{
    public class Logger
    {
        public Logger()
        {
        }

        public void Fight()
        {
            Random rnd = new Random();
            List<Player> players = new List<Player>();
            string[] namearr = new string[20] { "Coolz", "Jskonst", "MixerXXL", "Etogjesanya", "Exideinside", "Nugmate", "D1njo", "4i4a", "Bandi", "Incris", "Hroma", "MrColter", "Geralt", "Stalin", "Swearless", "Yanix", "Slava228", "Ciri", "Plotva", "Linys" };
            Console.WriteLine("Введите количество игроков:");
            int number = Convert.ToInt16(Console.ReadLine());
            if (number % 2.0 != 0)
            {
                throw new InvalidOperationException("Количество игроков нечетное");
            }

            for (int i = 0; i < number; i++)
            {
                string name = namearr[rnd.Next(0, 19)];
                Console.WriteLine($"Выберите класс игрока №{i + 1}\n 1.Рыцарь\n 2.Маг\n 3.Лучник");
                int classkey = Convert.ToInt16(Console.ReadLine());
                switch (classkey)
                {
                    case 1:
                        Knight knight = new Knight($"(Рыцарь) {name}({i + 1})");
                        players.Add(knight);
                        break;
                    case 2:
                        Mage mage = new Mage($"(Маг) {name}({i + 1})");
                        players.Add(mage);
                        break;
                    case 3:
                        Archer archer = new Archer($"(Лучник) {name}({i + 1})");
                        players.Add(archer);
                        break;
                    default:
                        throw new InvalidOperationException("Вы нажали неизвестную клавишу");
                }
            }

            int count = players.Count / 2;
            int kon = 1;
            for (int j = 0; j <= count; j = j + 2)
            {
                Console.WriteLine($"Кон {kon++}\n");
                for (int i = 0; i < players.Count; i++)
                {
                    if (players.Count > i + 1)
                    {
                        Console.WriteLine($"------------Да начнётся битва------------");
                        double p1Health = players[i].GetHealth();
                        double p2Health = players[i + 1].GetHealth();
                        Console.WriteLine($"Игрок_1: {players[i].Name}, HP = {p1Health}, Damage = {players[i].Damage}");
                        Console.WriteLine($"Игрок_2: {players[i + 1].Name}, HP = {p2Health}, Damage = {players[i + 1].Damage}");
                        while (p1Health > 0 && p2Health > 0)
                        {
                            var ult = rnd.Next(2) == 1;
                            double prevDamagep2 = players[i + 1].Damage;
                            if (ult)
                            {
                                players[i + 1].UseUlt();
                            }

                            p1Health = p1Health - players[i + 1].Damage;
                            Console.WriteLine($"{players[i + 1].Name} наносит урон {players[i + 1].Damage} противнику {players[i].Name}");
                            Console.WriteLine($"HP {players[i].Name} = {p1Health}");
                            players[i + 1].Damage = prevDamagep2;
                            if (p1Health > 0)
                            {
                                double prevDamagep1 = players[i].Damage;
                                if (ult)
                                {
                                    players[i].UseUlt();
                                }

                                p2Health = p2Health - players[i].Damage;
                                Console.WriteLine($"{players[i].Name} наносит урон {players[i].Damage} противнику {players[i + 1].Name}");
                                Console.WriteLine($"HP {players[i + 1].Name} = {p2Health}");
                                players[i].Damage = prevDamagep1;
                            }
                            else
                            {
                                Console.WriteLine($"-------{players[i + 1]} победил-----------\n");
                                players.RemoveAt(i);
                            }
                        }

                        if (p2Health <= 0)
                        {
                            Console.WriteLine($"-------{players[i]} победил-----------\n");
                            players.RemoveAt(i + 1);
                        }
                    }
                    else
                    {
                        j--;
                    }
                }
            }
        }
    }
}