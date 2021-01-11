using System;
using System.Collections.Generic;

namespace RPG
{
    public class Logger
    {
        public Logger()
        {
        }

        public void Fight(List<Player> players)
        {
            string[] namearr = new string[20] { "Coolz", "Jskonst", "MixerXXL", "Etogjesanya", "Exideinside", "Nugmate", "D1njo", "4i4a", "Bandi", "Incris", "Hroma", "MrColter", "Geralt", "Stalin", "Swearless", "Yanix", "Slava228", "Ciri", "Plotva", "Linys" };
            Console.WriteLine("Введите количество игроков:");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Random rnd = new Random();
                string name = namearr[rnd.Next(0, 19)];
                Console.WriteLine($"Выберите класс игрока №{i + 1}\n 1.Рыцарь\n 2.Маг\n 3.Лучник");
                int classkey = Convert.ToInt16(Console.ReadLine());
                switch (classkey)
                {
                    case 1:
                        Knight knight = new Knight($"{name} {i + 1}");
                        players.Add(knight);
                        break;
                    case 2:
                        Mage mage = new Mage($"{name} {i + 1}");
                        players.Add(mage);
                        break;
                    case 3:
                        Archer archer = new Archer($"{name} {i + 1}");
                        players.Add(archer);
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную клавишу");
                        break;
                }
            }

            for (int i = 0; i < players.Count; i = i + 2)
            {
                Console.WriteLine($"------------Да начнётся битва------------");
                int p1Health = players[i].GetHealth();
                int p2Health = players[i + 1].GetHealth();
                Console.WriteLine($"Игрок_1: {players[i].Name}, HP = {p1Health}");
                Console.WriteLine($"Игрок_2: {players[i + 1].Name}, HP = {p2Health}");
                while (p1Health > 0 && p2Health > 0)
                {
                    p1Health = p1Health - players[i + 1].Damage;
                    Console.WriteLine($"{players[i + 1].Name} наносит урон {players[i + 1].Damage} противнику {players[i].Name}");
                    Console.WriteLine($"HP {players[i].Name} = {p1Health}");
                    if (p1Health > 0)
                    {
                        p2Health = p2Health - players[i].Damage;
                        Console.WriteLine($"{players[i].Name} наносит урон {players[i].Damage} противнику {players[i + 1].Name}");
                        Console.WriteLine($"HP {players[i + 1].Name} = {p2Health}");
                    }
                    else
                    {
                        Console.WriteLine($"-------{players[i + 1]} победил-----------");
                    }
                }

                if (p2Health <= 0)
                {
                    Console.WriteLine($"-------{players[i]} победил-----------");
                }
            }
        }
    }
}