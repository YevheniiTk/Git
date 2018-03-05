using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : Figure
    {
        private Direction direction;
        private int Length { get; set; }

        private Point head;
        private Point tail;

        public Snake(Point tail, int length, Direction direction)
        {
            this.Length = length;
            this.direction = direction;
            base.pointsList = new List<Point>();
            
                for (int i = 0; i < this.Length; i++)
                {
                    Point p = new Point(tail.x, tail.y, tail.symbol);
                    p.Move(i, direction);
                    pointsList.Add(p);
                }
        }

        internal void MoveSnake()
        {
            tail = pointsList.First();

            pointsList.Remove(tail);
            head = GetNextPoint();
            pointsList.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal bool Eat(Food food)
        {
            if(food.pointFood.x == head.x && food.pointFood.y == head.y)
            {
                this.Length++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point GetNextPoint()
        {
            Point head = pointsList.Last();
            Point nextPoint = new Point(head.x, head.y, head.symbol);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

    }
}
