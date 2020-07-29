using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyHero.Controller
{
    public class GameIsOver
    {
        public bool DeclarePlayerWinner(int defence)
        {
            if (defence <= 0)
            {
                Console.WriteLine("You won!");
                Console.WriteLine("Game Over!");
                return true;
            }
            else
                return false;
        }
        public bool DeclareEnemyWinner(int defence)
        {
            if (defence <= 0)
            {
                Console.WriteLine("The enemy won");
                Console.WriteLine("Game Over!");
                return true;
            }
            else
                return false;
        }
    }
}
