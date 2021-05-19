using System;
using System.Drawing;

namespace Snake.GameObjects
{
    public class Meal : BaseItem
    {
        private readonly Random random;

        public Meal(int maxX, int maxY) : base(Color.Red)
        {
            random = new Random();

            int posX = random.Next(0, maxX);
            int posY = random.Next(0, maxY);

            posX -= (posX % 10);
            posY -= (posY % 10);

            Location = new Point(posX, posY);
        }
    }
}
