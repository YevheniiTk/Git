//-----------------------------------------------------------------------
// <copyright file="Figure.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Snake
{
    using System.Collections.Generic;

    /// <summary>
    /// Abstract figure class.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// The list of points from which the object consists.
        /// </summary>
        protected List<Point> pointsList = new List<Point>();

        /// <summary>
        /// Draws each element of the figure.
        /// </summary>
        public virtual void Draw()
        {
            foreach (Point p in this.pointsList)
            {
                p.Draw();
            }
        }
    }
}