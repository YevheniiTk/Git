using System.Collections.Generic;

namespace Snake
{
    public abstract class Figure
    {
        protected List<Point> pointsList = new List<Point>();

        public virtual void Draw()
        {
            foreach (Point p in pointsList)
            {
                p.Draw();
            }
        }
    }
}

