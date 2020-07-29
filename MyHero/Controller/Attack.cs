using MyHero.Models;
using MyHero.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHero.Controller
{
    public class Attack
    {
        private readonly Player _player;
        private readonly Enemy _enemy;
        private readonly List<Skill> _skill;
        GameIsOver gameOver = new GameIsOver();
        Random random = new Random();
        int turns = 0;

        public Attack(Player player, Enemy enemy, List<Skill> skill)
        {
            _player = player;
            _enemy = enemy;
            _skill = skill;
        }
        PopulateSkillsRepository _skillPopulate = new PopulateSkillsRepository();
        public void Battle()
        {
            int playerDamage = _player.Strength - _enemy.Defence;
            int enemyDamage = _enemy.Strength - _player.Defence;

            Console.WriteLine($"You have damage: {playerDamage}/attack");
            Console.WriteLine($"The enemy has damage: {enemyDamage}/attack");

            if (_enemy.Speed > _player.Speed)
            {
                Console.WriteLine("The enemy attacks first!");
                EnemyAttacksFirst();
            }
            else if (_enemy.Speed < _player.Speed)
            {
                Console.WriteLine("You attack first!");
                PlayerAttacksFirst();
            }
            else
            {
                if (_enemy.Luck < _player.Luck)
                {
                    Console.WriteLine("You attack first based on your luck!");
                    PlayerAttacksFirst();
                }
                else
                {
                    Console.WriteLine("The enemy attacks first based on his luck!");
                    EnemyAttacksFirst();
                }
            }
        }
        public void EnemyAttacksFirst()
        {
            int playerDamage = _player.Strength - _enemy.Defence;
            int enemyDamage = _enemy.Strength - _player.Defence;
            var attackSkill = _skill.Where(a => a.SkillName.ToLower().Contains("Strike".ToLower())).SingleOrDefault();
            var defenceSkill = _skill.Where(a => a.SkillName.ToLower().Contains("shield".ToLower())).SingleOrDefault();
            while (turns <= 19)
            {
                turns++;
                if (random.Next(100) < _player.Luck)
                {
                    Console.WriteLine($"In round {turns}, you got lucky and took no damage!");
                }
                else if (random.Next(100) < defenceSkill.Chance)
                {
                    Console.WriteLine($"Your skill {defenceSkill.SkillName} is active! Enemy`s damage is half!");
                    _player.Health -= playerDamage;
                    if (gameOver.DeclareEnemyWinner(_player.Health))
                        break;
                    Console.WriteLine("In round " + turns + " you have health: " + _player.Health);
                }
                else
                {
                    _player.Health -= enemyDamage;
                    if (gameOver.DeclareEnemyWinner(_player.Health))
                        break;
                    Console.WriteLine($"In round {turns} you have health: {_player.Health}");
                }
              
                turns++;
                if (random.Next(100) < _enemy.Luck)
                {
                    Console.WriteLine($"In round {turns}, the enemy got lucky and took no damage!");
                }
                else if (random.Next(100) < attackSkill.Chance)
                {
                    Console.WriteLine($"Your skill {attackSkill.SkillName} is active! You strike twice!");
                    _enemy.Health -= playerDamage;
                    if (gameOver.DeclarePlayerWinner(_enemy.Health))
                        break;

                    Console.WriteLine($"In round {turns} with your first attack, the enemy has health {_enemy.Health}");
                    _enemy.Health -= playerDamage;
                    Console.WriteLine($"With your second attack, the enemy has health {_enemy.Health}");
                    if (gameOver.DeclarePlayerWinner(_enemy.Health))
                        break;
                }
                else
                {
                    _enemy.Health -= playerDamage;
                    if (gameOver.DeclarePlayerWinner(_enemy.Health))
                        break;
                    Console.WriteLine($"In round {turns} the enemy has health: {_enemy.Health}");
                }
                if(turns == 20)
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine("Game Over!");
                }
            }
        }
        public void PlayerAttacksFirst()
        {
            int playerDamage = _player.Strength - _enemy.Defence;
            int enemyDamage = _enemy.Strength - _player.Defence;
            var attackSkill = _skill.Where(a => a.SkillName.ToLower().Contains("Strike".ToLower())).SingleOrDefault();
            var defenceSkill = _skill.Where(a => a.SkillName.ToLower().Contains("shield".ToLower())).SingleOrDefault();
            while (turns <= 19)
            {
                //Iterate the skills
                turns++;
                if (random.Next(100) < _enemy.Luck)
                {
                    Console.WriteLine($"In round {turns}, the enemy got lucky and took no damage!");
                }
                else if(random.Next(100) < attackSkill.Chance)
                {
                    Console.WriteLine($"Your skill {attackSkill.SkillName} is active! You strike twice!");
                    _enemy.Health -= playerDamage;
                    if (gameOver.DeclarePlayerWinner(_enemy.Health))
                        break;

                    Console.WriteLine($"In round {turns} with your first attack, the enemy has health {_enemy.Health}");
                    _enemy.Health -= playerDamage;
                    Console.WriteLine($"With your second attack, the enemy has health {_enemy.Health}");
                    if (gameOver.DeclarePlayerWinner(_enemy.Health))
                        break;
                }
                else
                {
                    _enemy.Health -= playerDamage;
                    if(gameOver.DeclarePlayerWinner(_enemy.Health))
                        break;
                    else
                        Console.WriteLine($"In round {turns} the enemy has health {_enemy.Health}");
                }

                turns++;
                if (random.Next(100) < _player.Luck)
                {
                    Console.WriteLine($"In round {turns}, you got lucky and took no damage!");
                }
                else if (random.Next(100) < defenceSkill.Chance)
                {   
                    Console.WriteLine($"Your skill {defenceSkill.SkillName} is active! Enemy`s damage is half!");
                    _player.Health -= playerDamage;
                    if (gameOver.DeclareEnemyWinner(_player.Health))
                        break;
                    Console.WriteLine("In round " + turns + " you have health: " + _player.Health);
                }
                else
                {
                    _player.Health -= enemyDamage;
                    if (gameOver.DeclareEnemyWinner(_player.Health))
                        break;
                    else
                        Console.WriteLine("In round " + turns + " you have health: " + _player.Health);
                }
                if (turns == 20)
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine("Game Over!");
                }
            }
        }
    }
}
