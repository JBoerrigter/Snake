using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snake.GameObjects

{
    public class Snake : IDisposable
    {
        public Head HeadElement { get; private set; }
        public LinkedList<Part> BodyList { get; private set; }

        public Snake(Size playgroundSize)
        {
            int posX = playgroundSize.Width / 2;
            int posY = playgroundSize.Height / 2;

            posX -= (posX % 10);
            posY -= (posY % 10);

            HeadElement = new Head(posX, posY);
            BodyList = new LinkedList<Part>();
        }

        public bool CanEat(Meal meal)
        {
            return HeadElement.CheckCollision(meal);
        }

        public void Eat(Meal meal)
        {
            Part newPart = new Part();
            if (BodyList.Any())
                newPart.Follow(BodyList.Last.Value);
            else
                newPart.Follow(HeadElement);
            BodyList.AddLast(newPart);
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
                Part part = BodyList.Last.Value;
                BodyList.RemoveLast();
                part.Follow(HeadElement);
                BodyList.AddFirst(part);
            }

            HeadElement.Move(direction);
        }

        public void Draw(Graphics graphics)
        {
            HeadElement.Draw(graphics);

            foreach (Part bodyPart in BodyList)
            {
                bodyPart.Draw(graphics);
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
