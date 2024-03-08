using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxRabbits.Classes
{
    internal class Game
    {
        private int Turn { get; set; } = 1;
        private int TurnByStep { get; set; }
        public Game() 
        {
            TurnByStep = Conf._turnByStepConf;
        }   
    }
}
