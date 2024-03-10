
namespace FoxRabbits.Classes
{
    internal class Creature(int id)
    {
        private int Id { get; set; } = id;
        public int Age { get; set; }
        public void GrowUp()
        {
            Age++;
        }
    }
}
