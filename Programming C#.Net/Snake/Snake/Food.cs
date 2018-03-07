using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //TODO: According to the requirements, you need to implement several types of food using polymorphism principle
    public class Food : Figure
    {
        public Point pointFood;
        private char symbolForFood = '@';
        private Random random = new Random();
        
        internal void CreateFood(int windowWidth, int windowHeigth)
        {
            int xRandom = random.Next(2, windowWidth);
            int yRandom = random.Next(1, windowHeigth);
            pointFood = new Point(xRandom, yRandom, symbolForFood);
            
            base.pointsList = new List<Point> { pointFood };
        }
    }
}
