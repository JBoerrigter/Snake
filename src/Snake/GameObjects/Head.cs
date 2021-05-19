using System.Drawing;

namespace Snake.GameObjects
{
    public class Head : BaseItem
    {
        public Head(int x, int y)
        {
            Location = new Point(x, y);
        }

        public bool CheckCollision(BaseItem item)
        {
            return GetBounds().Contains(item.GetBounds());
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    Location = new Point(Location.X - Size.Width, Location.Y);
                    break;
                case Direction.Right:
                    Location = new Point(Location.X + Size.Width, Location.Y);
                    break;
                case Direction.Up:
                    Location = new Point(Location.X, Location.Y - Size.Height);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, Location.Y + Size.Height);
                    break;
            }
        }
    }
}
