
namespace FoxRabbits.Classes
{
    internal class Creatures
    {
        private List<Fox> Foxes { get; set; } = new List<Fox>();
        private List<Rabbit> Rabbits { get; set; } = new List<Rabbit>();
        private List<Grass> Grasses { get; set; } = [];

        public Creatures() 
        {
            for (int i = 0; i < Conf._countGrassesConf; i++)
                Grasses.Add(new Grass());

            for (int i = 0; i < Conf._rabbitsConf; i++)
                Rabbits.Add(new Rabbit(i));

            for (int i = 0; i < Conf._foxConf; i++)
                Foxes.Add(new Fox(i));
        }  
    }
}
