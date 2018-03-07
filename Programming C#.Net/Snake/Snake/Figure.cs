using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //TODO: Is it an abstract or concrete class for the purpose of this project?
    public class Figure
    {
        protected List<Point> pointsList;

        public void Draw()
        {
            foreach (Point p in pointsList)
            {
                p.Draw();
            }
        }
    }
}

