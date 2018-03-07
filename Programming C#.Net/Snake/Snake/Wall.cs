using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Wall
    {
        private List<Point> pointList = new List<Point>();

        public Wall(int windowHeigth, int windowWidth, char sym)
        {
            Point p;
            for (int i = 1; i <= windowHeigth; i++)
            {
                p = new Point(1, i, sym);
                pointList.Add(p);
                p = new Point(windowWidth, i, sym);
                pointList.Add(p);
            }
            for (int i = 1; i <= windowWidth; i++)
            {
                p = new Point(i, 0, sym);
                pointList.Add(p);
                p = new Point(i, windowHeigth, sym);
                pointList.Add(p);
            }
        }
        
        public void Draw()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
            }
        }
    }
}
