//-----------------------------------------------------------------------
// <copyright file="Food.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Some food for snake.
    /// </summary>
    public abstract class Food : Figure
    {
        /// <summary>
        /// Point for food.
        /// </summary>
        public readonly Point PointFood;

        /// <summary>
        /// Symbol for food.
        /// </summary>
        private readonly char symbolForFood;

        /// <summary>
        /// Аor arbitrary creation of coordinates.
        /// </summary>
        private Random random;

        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class.
        /// </summary>
        /// <param name="windowWidth">Screen width.</param>
        /// <param name="windowHeigth">Screen hight</param>
        /// <param name="symbolForFood">Symbol for food</param>
        public Food(int windowWidth, int windowHeigth, char symbolForFood)
        {
            this.random = new Random();
            int xRandom = this.random.Next(2, windowWidth);
            int yRandom = this.random.Next(1, windowHeigth);

            this.symbolForFood = symbolForFood;

            this.PointFood = new Point(xRandom, yRandom, this.symbolForFood);
            this.pointsList = new List<Point> { this.PointFood };
        }
    }
}