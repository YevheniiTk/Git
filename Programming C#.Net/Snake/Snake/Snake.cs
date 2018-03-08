//-----------------------------------------------------------------------
// <copyright file="Snake.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Snake for game.
    /// </summary>
    public partial class Snake : Figure
    {
        /// <summary>
        /// Snake direction.
        /// </summary>
        private Direction direction;

        /// <summary>
        /// Snake head.
        /// </summary>
        private Point head;

        /// <summary>
        /// Snake tail.
        /// </summary>
        private Point tail;

        /// <summary>
        /// Gets or sets snake lengh.
        /// </summary>
        private int Length { get; set; }
    }

    /// <summary>
    /// Snake for game.
    /// </summary>
    public partial class Snake : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Snake"/> class.
        /// </summary>
        /// <param name="tail">Last snake's point</param>
        /// <param name="direction">First snake's point</param>
        public Snake(Point tail, Direction direction)
        {
            this.Length = 5;
            this.direction = direction;
            this.pointsList = new List<Point>();

            for (int i = this.Length; i > 0; i--)
            {
                Point p = new Point(tail.X, tail.Y, tail.Symbol);
                p.Move(i, direction);
                pointsList.Add(p);
            }
        }

        /// <summary>
        /// When snake eats food.
        /// </summary>
        /// <param name="food">Snake's food</param>
        /// <returns>True if snake ate food</returns>
        public bool Eat(Food food)
        {
            if (food.PointFood.X == this.head.X && food.PointFood.Y == this.head.Y)
            {
                this.Length++;
                Point p = new Point(this.head.X, this.head.Y, this.head.Symbol);
                pointsList.Add(p);
       
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get next point
        /// </summary>
        /// <returns>Next point</returns>
        public Point GetNextPoint()
        {
            Point head = pointsList.Last();
            Point nextPoint = new Point(head.X, head.Y, head.Symbol);
            nextPoint.Move(1, this.direction);
            return nextPoint;
        }

        /// <summary>
        /// Indicates the direction of the snake.
        /// </summary>
        /// <param name="key">pressed button</param>
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && this.direction != Direction.Right)
            {
                this.direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow && this.direction != Direction.Left)
            {
                this.direction = Direction.Right;
            }
            else if (key == ConsoleKey.DownArrow && this.direction != Direction.Up)
            {
                this.direction = Direction.Down;
            }
            else if (key == ConsoleKey.UpArrow && this.direction != Direction.Down)
            {
                this.direction = Direction.Up;
            }
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

        /// <summary>
        /// Move snake
        /// </summary>
        internal void MoveSnake()
        {
            this.tail = pointsList.First();
            this.pointsList.Remove(this.tail);
            this.head = this.GetNextPoint();
            this.pointsList.Add(this.head);
            
            this.tail.Clear();
            this.head.Draw();
        }
    }
}
