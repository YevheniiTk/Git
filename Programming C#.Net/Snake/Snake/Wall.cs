//-----------------------------------------------------------------------
// <copyright file="Wall.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    /// <summary>
    /// Wall for game.
    /// </summary>
    public class Wall : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wall"/> class.
        /// </summary>
        /// <param name="windowHeigth">window heigth</param>
        /// <param name="windowWidth">window width</param>
        /// <param name="sym">wall's symbol</param>
        public Wall(int windowHeigth, int windowWidth, char sym)
        {
            for (int i = 1; i <= windowHeigth; i++)
            {
                var p = new Point(1, i, sym);
                this.pointsList.Add(p);
                p = new Point(windowWidth, i, sym);
                this.pointsList.Add(p);
            }

            for (int i = 1; i <= windowWidth; i++)
            {
                var p = new Point(i, 0, sym);
                this.pointsList.Add(p);
                p = new Point(i, windowHeigth, sym);
                this.pointsList.Add(p);
            }
        }
    }
}
