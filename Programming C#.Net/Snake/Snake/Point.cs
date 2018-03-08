//-----------------------------------------------------------------------
// <copyright file="Point.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    using System;

    /// <summary>
    /// Describes a point.
    /// </summary>
    public partial class Point
    {
        /// <summary>
        /// Gets symbol of point.
        /// </summary>
        public readonly char Symbol;

        /// <summary>
        /// Gets position X.
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Gets position Y.
        /// </summary>
        public int Y { get; private set; }
    }

    /// <summary>
    /// Describes a point.
    /// </summary>
    public partial class Point
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="symbol">symbol for point</param>
        public Point(int x, int y, char symbol)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = symbol;
        }

        /// <summary>
        /// Draw point.
        /// </summary>
        public void Draw()
        {
            this.Draw(this.X, this.Y, this.Symbol);
        }

        /// <summary>
        /// Clear point.
        /// </summary>
        public void Clear()
        {
            this.Draw(this.X, this.Y, ' ');
        }

        /// <summary>
        /// Moves point by some position.
        /// </summary>
        /// <param name="offset">How many positions to shift.</param>
        /// <param name="direction">In which direction to shift.</param>
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    this.X = this.X + offset;
                    break;
                case Direction.Left:
                    this.X = this.X - offset;
                    break;
                case Direction.Down:
                    this.Y = this.Y + offset;
                    break;
                case Direction.Up:
                    this.Y = this.Y - offset;
                    break;
            }
        }

        /// <summary>
        /// Draw point.
        /// </summary>
        /// <param name="x">position X</param>
        /// <param name="y">position Y</param>
        /// <param name="symbol">symbol for draw</param>
        private void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            Console.SetCursorPosition(0, 0);
        }
    }
}
