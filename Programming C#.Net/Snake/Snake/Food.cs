using System;
using System.Collections.Generic;

namespace Snake
{
    //TODO: According to the requirements, 
    //you need to implement several types of food using polymorphism principle
    public abstract class Food : Figure
    {
        private readonly char symbolForFood;
        public readonly Point pointFood;
        private Random random;

        public Food(int windowWidth, int windowHeigth, char symbolForFood)
        {
            this.random = new Random();
            int xRandom = random.Next(2, windowWidth);
            int yRandom = random.Next(1, windowHeigth);

            this.symbolForFood = symbolForFood;

            this.pointFood = new Point(xRandom, yRandom, this.symbolForFood);
            base.pointsList = new List<Point> { pointFood };
        }
    }

    public class FoodAt : Food
    {
        public FoodAt(int windowWidth, int windowHeigth) 
            : base(windowWidth, windowHeigth,symbolForFood: '@')
        {
        }
    }

    public class FoodSharp : Food
    {
        public FoodSharp(int windowWidth, int windowHeigth) 
            : base(windowWidth, windowHeigth, symbolForFood: '#')
        {
        }
    }

}
