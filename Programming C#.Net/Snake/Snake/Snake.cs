using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake : Figure
    {
        
        private Direction direction;
        private int Length { get; set; }

        private Point head;
        private Point tail;

        public Snake(Point tail, Direction direction)
        {
            this.Length = 5;
            this.direction = direction;
            base.pointsList = new List<Point>();

            for (int i = this.Length; i > 0; i--)
            {
                Point p = new Point(tail.X, tail.Y, tail.Symbol);
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

        public bool Eat(Food food)
        {
            if (food.pointFood.X == head.X && food.pointFood.Y == head.Y)
            {
                this.Length++;
                Point p = new Point(head.X, head.Y, head.Symbol);
                pointsList.Add(p);
       
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
            Point nextPoint = new Point(head.X, head.Y, head.Symbol);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && direction != Direction.Right)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow && direction != Direction.Left)
                direction = Direction.Right;
            else if (key == ConsoleKey.DownArrow && direction != Direction.Up)
                direction = Direction.Down;
            else if (key == ConsoleKey.UpArrow && direction != Direction.Down)
                direction = Direction.Up;
        }

        public bool DidSnakeHitWall(Snake snake, int windowWidth, int windowHeigth)
        {
            if (snake.head.X == 1 || snake.head.X == windowWidth
             || snake.head.Y == 0 || snake.head.Y == windowHeigth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
