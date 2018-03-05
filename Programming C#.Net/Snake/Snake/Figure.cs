using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {
        protected List<Point> pointsList;

        public void Drow()
        {
            foreach (Point p in pointsList)
            {
                p.Draw();
            }
        }
    }
}

