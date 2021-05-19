using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snake.GameObjects

{
    public class Snake : IDisposable
    {
        public Head HeadElement { get; private set; }
        public List<Part> BodyList { get; private set; }

        public Snake(Size playgroundSize)
        {
            int posX = playgroundSize.Width / 2;
            int posY = playgroundSize.Height / 2;

            posX -= (posX % 10);
            posY -= (posY % 10);

            HeadElement = new Head(posX, posY);
            BodyList = new List<Part>();
        }

        public bool CanEat(Meal meal)
        {
            return HeadElement.CheckCollision(meal);
        }

        public void Eat(Meal meal)
        {
            Part newPart = new Part();
            newPart.Follow(meal);
            BodyList.Add(newPart);
        }

        public bool IsColliding(Rectangle playground)
        {
            if (BodyList.Any(item => HeadElement.CheckCollision(item)))
            {
                return true;
            }
            
            bool isColliding = !playground.Contains(HeadElement.Location);

            return isColliding;
        }

        public void Move(Direction direction)
        {
            if (BodyList.Any())
            {
                for (int i = BodyList.Count - 1; i > 0; i--)
                {
                    BodyList[i].Follow(BodyList[i - 1]);
                }

                BodyList.First().Follow(HeadElement);
            }

            HeadElement.Move(direction);
        }

        public void Draw(Graphics graphics)
        {
            HeadElement.Draw(graphics);

            foreach (Part koerper in BodyList)
            {
                koerper.Draw(graphics);
            }
        }

        public void Dispose()
        {
            if (HeadElement != null)
            {
                HeadElement.Dispose();
                HeadElement = null;
            }

            if (BodyList != null)
            {
                foreach (BaseItem item in BodyList)
                {
                    item.Dispose();
                }
                BodyList.Clear();
                BodyList = null;
            }
        }
    }
}
