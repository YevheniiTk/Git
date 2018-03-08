//-----------------------------------------------------------------------
// <copyright file="FoodAt.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    /// <summary>
    /// Class food with symbol "@".
    /// </summary>
    public class FoodAt : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodAt"/> class.
        /// </summary>
        /// <param name="windowWidth">Screen width.</param>
        /// <param name="windowHeigth">Screen hight.</param>
        public FoodAt(int windowWidth, int windowHeigth)
            : base(windowWidth, windowHeigth, symbolForFood: '@')
        {
        }
    }
}
