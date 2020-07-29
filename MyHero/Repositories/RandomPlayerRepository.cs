using MyHero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHero.Repositories
{
    public class RandomPlayerRepository : IRandomPlayerRepository
    {
        public void RandomPlayer(Player player)
        {
            Random rand = new Random();

            player.Health += rand.Next(player.MinHealthValue, player.MaxHealthValue);
            Console.WriteLine("Your player has: " + player.Health + " HP");
            player.Strength += rand.Next(player.MinStrengthValue, player.MaxStrengthValue);
            Console.WriteLine("Your player has: " + player.Strength + " POWER");
            player.Defence += rand.Next(player.MinDefenceValue, player.MaxDefenceValue);
            Console.WriteLine("Your player has: " + player.Defence + " SCOUT");
            player.Speed += rand.Next(player.MinSpeedValue, player.MaxSpeedValue);
            Console.WriteLine("Your player has: " + player.Speed + " MS");
            player.Luck += rand.Next(player.MinLuckValue, player.MaxLuckValue);
            Console.WriteLine("Your player has: " + player.Luck + " LUCK");
        }
    }
}
