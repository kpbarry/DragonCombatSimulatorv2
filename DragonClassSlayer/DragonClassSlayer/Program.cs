﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonClassSlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 110;
            Game game = new Game();
            game.PlayGame();
            Console.ReadKey();
        }
    }
}
