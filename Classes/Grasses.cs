

namespace FoxRabbits.Classes
{
    internal class Grasses(int count)
    {
        private int Count { get; set; } = count;

        public void GrowUp()
        {
            Count += Count * 3;
        }
    }
}
