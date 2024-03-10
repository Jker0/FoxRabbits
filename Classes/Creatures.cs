
namespace FoxRabbits.Classes
{
    internal class Creatures
    {
        private List<Fox> Foxes { get; set; } = new List<Fox>();
        private List<Rabbit> Rabbits { get; set; } = [];
        private Grasses Grasses { get; set; }

        public Creatures() 
        { 
            Grasses = new Grasses(Conf._countGrassesConf);

            for (int i = 0; i < Conf._rabbitsConf; i++)
                Rabbits.Add(new Rabbit(i));

            for (int i = 0; i < Conf._foxConf; i++)
                Foxes.Add(new Fox(i));
        }  


    }
}
