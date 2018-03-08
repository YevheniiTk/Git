//-----------------------------------------------------------------------
// <copyright file="Game.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    /// <summary>
    /// Class for managing the game.
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="windowHeigth">Window heigth</param>
        /// <param name="windowWidth">Window width</param>
        /// <param name="snakeStartPositionX">Snake start position X</param>
        /// <param name="snakeStartPositionY">Snake start position Y</param>
        /// <param name="wallSymbol">Wall symbol</param>
        /// <param name="snakeSymbol">Snake symbol</param>
        /// <param name="speed">Game speed</param>
        public Game(
                    int windowHeigth,
                    int windowWidth,
                    int snakeStartPositionX,
                    int snakeStartPositionY,
                    char wallSymbol,
                    char snakeSymbol,
                    decimal speed)
        {
            this.WindowHeigth = windowHeigth;
            this.WindowWidth = windowWidth;
            this.SnakeStartPositionX = snakeStartPositionX;
            this.SnakeStartPositionY = snakeStartPositionY;
            this.WallSymbol = wallSymbol;
            this.SnakeSymbol = snakeSymbol;
            this.Speed = speed;
        }

        /// <summary>
        /// Increases game speed.
        /// </summary>
        public virtual void AddSpeed()
        {
            this.Speed *= 0.925m;
        }
    }

    /// <summary>
    /// Class for managing the game.
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// Gets Window Heigth
        /// </summary>
        public int WindowHeigth { get; private set; }

        /// <summary>
        /// Gets Window Width
        /// </summary>
        public int WindowWidth { get; private set; }

        /// <summary>
        /// Gets Snake start position X 
        /// </summary>
        public int SnakeStartPositionX { get; private set; }

        /// <summary>
        /// Gets Snake start position Y
        /// </summary>
        public int SnakeStartPositionY { get; private set; }

        /// <summary>
        /// Gets Symball for wall
        /// </summary>
        public char WallSymbol { get; private set; }

        /// <summary>
        /// Gets Symball for wall
        /// </summary>
        public char SnakeSymbol { get; private set; }

        /// <summary>
        /// Gets Game speed
        /// </summary>
        public decimal Speed { get; private set; }
    }
}
