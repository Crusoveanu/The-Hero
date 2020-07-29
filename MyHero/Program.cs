using MyHero.Controller;
using MyHero.Models;
using System;

namespace MyHero
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            Console.ReadKey();
        }
    }
}
