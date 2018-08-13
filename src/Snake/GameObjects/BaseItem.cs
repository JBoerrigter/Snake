using System.Drawing;

namespace Snake.GameObjects
{
    public class BaseItem
    {
        const int STEP_SIZE = 10;
        const int DEFAULT_WIDTH = 10;
        const int DEFAULT_HEIGHT = 10;

        public Size Size { get; private set; }
        public Color Color { get; private set; }
        public Point Location { get; protected set; }

        public BaseItem() : this(Color.Black) { }

        public BaseItem(Color color)
        {
            Color = color;
            Size = new Size(DEFAULT_WIDTH, DEFAULT_HEIGHT);
        }

        private Brush GetBrush()
        {
            return new SolidBrush(Color);
        }

        public Rectangle GetBounds()
        {
            return new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
        }

        public virtual void Draw(Graphics graphics)
        {
            graphics.FillRectangle(GetBrush(), GetBounds());
        }
    }
}
