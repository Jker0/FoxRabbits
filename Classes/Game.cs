

namespace FoxRabbits.Classes
{
    internal static class Game
    {
        private static int Turn { get; set; } = 0;
        private static int TurnByStep { get; set; } = Conf._turnByStepConf;
        private static Creatures Creatures { get; set; }   

        public static void GameTurn()
        {
            if (Turn == 0) 
            {
                InitGame(); 
            }

            for (int i = 0; i < TurnByStep; i++) 
            {
                Step();
            }
        }

        private static void InitGame()
        {
            Creatures = new Creatures();
        }

        private static void Step() 
        {

        }
    }
}
