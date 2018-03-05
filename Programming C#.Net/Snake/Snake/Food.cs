using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food : Figure
    {
        public Point pointFood;
        private char symbolForFood = '@';

        public Food(int windowWidth, int windowHeigth)
        {
            Random random = new Random();
            

            int xRandom = random.Next(1, windowWidth);
            int yRandom = random.Next(1, windowHeigth);

            base.pointsList = new List<Point> { new Point(xRandom, yRandom, symbolForFood) };
        }
        

        internal void CreateFood(int windowWidth, int windowHeigth)
        {
            Random random = new Random();

            int xRandom = random.Next(1, windowWidth);
            int yRandom = random.Next(1, windowHeigth);
            pointFood = new Point(xRandom, yRandom, symbolForFood);

            base.pointsList[0] = pointFood;

        }
    }
}
