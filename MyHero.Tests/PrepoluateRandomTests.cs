using MyHero.Models;
using MyHero.Repositories;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Xunit;

namespace MyHero.Tests
{
    public class PrepoluateRandomTests
    {
        private readonly Enemy _enemy;
        private readonly Player _player;
        public PrepoluateRandomTests( Enemy enemy, Player player)
        {
            _enemy = enemy;
            _player = player;
        }
        bool populated = false;
        [Fact]
        public void RandomPlayer_checkIfGeneratesRandom()
        {
            var actual = _player;
            if(actual != null)
                populated = true;

            Assert.True(populated);
        }
        [Fact]
        public void RandomEnemy_checkIfGeneratesRandom()
        {
            var actual = _enemy;
            if (actual != null)
                populated = true;

            Assert.True(populated);
        }
    }
}
