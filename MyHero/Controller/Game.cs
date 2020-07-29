using MyHero.Models;
using MyHero.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;
using System.Text;

namespace MyHero.Controller
{
    public class Game
    {
        RandomPlayerRepository _playerRepository = new RandomPlayerRepository();
        RandomEnemyRepository _enemyRepository = new RandomEnemyRepository();
        PopulateSkillsRepository _skillPopulate = new PopulateSkillsRepository();
        Player player = new Player();
        Enemy enemy = new Enemy();
        List<Skill> skill = new List<Skill>();
        public void Start()
        {
            Console.WriteLine("My Hero");
            _playerRepository.RandomPlayer(player);
            Console.WriteLine("================");
            Console.WriteLine("GOOD LUCK!");
            Console.WriteLine("================");
            Console.WriteLine("Your enemy is: ");
            _enemyRepository.RandomEnemy(enemy);
            _skillPopulate.PopulateSkill(skill);
            Console.WriteLine("================");
            Attack attack = new Attack(player, enemy, skill);
            attack.Battle();
        }
    }
}
