using System;
using System.Drawing;

namespace Snake.GameObjects
{
    public class BaseItem : IDisposable
    {
        const int DEFAULT_WIDTH = 10;
        const int DEFAULT_HEIGHT = 10;

        private readonly Brush _brush;

        public Size Size { get; }
        public Point Location { get; protected set; }

        public BaseItem() : this(Color.Black) { }

        public BaseItem(Color color)
        {
            _brush = new SolidBrush(color);
            Size = new Size(DEFAULT_WIDTH, DEFAULT_HEIGHT);
        }

        public Rectangle GetBounds()
        {
            return new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
        }

        public virtual void Draw(Graphics graphics)
        {
            graphics.FillRectangle(_brush, GetBounds());
        }

        public void Dispose()
        {
            _brush.Dispose();
        }
    }
}
