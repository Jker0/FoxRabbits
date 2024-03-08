using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxRabbits.Classes
{
    internal class Game
    {
        private int Turn { get; set; } = 0;
        private int TurnByStep { get; set; } = Conf._turnByStepConf;
        private List<Fox> Foxes { get; set; } = new List<Fox>(); 
        private List<Rabbit> Rabbits { get; set; } = new List<Rabbit>();
        private List<Grass> Grasses { get; set; } = [];
        public Game() 
        {

        }   

        public void GameTurn()
        {
            if (Turn == 0) 
            {
                InitGame(); 
            }
        }

        private void InitGame()
        {
            for (int i = 0; i < Conf._countGrassesConf; i++) 
                Grasses.Add(new Grass(i));

            for (int i = 0; i < Conf._rabbitsConf; i++)  
                Rabbits.Add(new Rabbit(i));

            for (int i = 0; i < Conf._foxConf; i++)
                Foxes.Add(new Fox(i));  
        }
    }
}
