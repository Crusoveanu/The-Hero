﻿using MyHero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHero.Repositories
{
    public interface IRandomPlayerRepository
    {
        void RandomPlayer(Player player);
    }
}
