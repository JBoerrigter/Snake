using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snake.GameObjects

{
    public class Snake : IDisposable
    {
        public Head Kopf { get; private set; }
        public Rectangle Parent { get; private set; }
        public List<Part> Koerper { get; private set; }

        public Snake(Rectangle parent)
        {
            Parent = parent;

            int posX = Parent.Width / 2;
            int posY = Parent.Height / 2;

            posX = posX - (posX % 10);
            posY = posY - (posY % 10);

            Kopf = new Head(new Point(posX, posY));
            Koerper = new List<Part>();
        }

        public bool Ate(Meal essen)
        {
            if (Kopf.CheckCollision(essen))
            {
                Part neuesTeil = new Part();
                neuesTeil.Follow(essen);
                Koerper.Add(neuesTeil);
                return true;
            }

            return false;
        }

        public bool IsColliding()
        {
            if (Koerper.Any((item) => { return Kopf.CheckCollision(item); }))
            {
                return true;
            }
         
            if (Kopf.Location.X + Kopf.Size.Width > Parent.Width || Kopf.Location.X < 0 || 
                Kopf.Location.Y + Kopf.Size.Height > Parent.Height || Kopf.Location.Y < 0)
            {
                return true;
            }

            return false;
        }

        public void Bewegen(Direction direction)
        {
            if (Koerper.Any())
            {
                for (int i = Koerper.Count - 1; i > 0; i--)
                    Koerper[i].Follow(Koerper[i - 1]);

                Koerper.First().Follow(Kopf);
            }

            Kopf.Move(direction);
        }

        public void Draw(Graphics graphics)
        {
            Kopf.Draw(graphics);

            foreach (Part koerper in Koerper)
                koerper.Draw(graphics);
        }

        public void Dispose()
        {
            if (Kopf != null)
                Kopf = null;

            if (Koerper != null)
            {
                Koerper.Clear();
                Koerper = null;
            }
        }
    }
}
