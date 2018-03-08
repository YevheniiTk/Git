//-----------------------------------------------------------------------
// <copyright file="FoodSharp.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    /// <summary>
    /// Class food with symbol "#".
    /// </summary>
    public class FoodSharp : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodSharp"/> class.
        /// </summary>
        /// <param name="windowWidth">Screen width.</param>
        /// <param name="windowHeigth">Screen hight.</param>
        public FoodSharp(int windowWidth, int windowHeigth)
            : base(windowWidth, windowHeigth, symbolForFood: '#')
        {
        }
    }
}