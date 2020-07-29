using MyHero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHero.Repositories
{
    public class RandomEnemyRepository : IRandomEnemyRepository
    {
        Random rand = new Random();
        public void RandomEnemy(Enemy enemy)
        {
            enemy.Health += rand.Next(enemy.MinHealthValue, enemy.MaxHealthValue);
            Console.WriteLine("Your enemy has: " + enemy.Health + " HP");
            enemy.Strength += rand.Next(enemy.MinStrengthValue, enemy.MaxStrengthValue);
            Console.WriteLine("Your enemy has: " + enemy.Strength + " POWER");
            enemy.Defence += rand.Next(enemy.MinDefenceValue, enemy.MaxDefenceValue);
            Console.WriteLine("Your enemy has: " + enemy.Defence + " SCOUT");
            enemy.Speed += rand.Next(enemy.MinSpeedValue, enemy.MaxSpeedValue);
            Console.WriteLine("Your enemy has: " + enemy.Speed + " MS");
            enemy.Luck += rand.Next(enemy.MinLuckValue, enemy.MaxLuckValue);
            Console.WriteLine("Your enemy has: " + enemy.Luck + " LUCK");
        }
    }
}
