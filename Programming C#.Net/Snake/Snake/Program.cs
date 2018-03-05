using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int windowHeigth = 28;
            int windowWidth = 70; 

            Console.WindowHeight = windowHeigth+2;
            Console.WindowWidth = windowWidth+2;
            Console.CursorVisible = false;

            Food food = new Food(windowWidth, windowHeigth);
            Wall wall = new Wall(28, 70, 'X');
            wall.Drow();

            food.CreateFood(windowWidth, windowHeigth);
            food.Drow();

            Snake snake = new Snake(new Point(5, 5, 'O'), 5, Direction.RIGHT);

            ConsoleKey command = Console.ReadKey().Key;

            do
            {
                System.Threading.Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    command = Console.ReadKey().Key;
                }

                snake.MoveSnake();
                snake.HandleKey(command);

                if(snake.Eat(food))
                {
                    food = new Food(windowWidth, windowHeigth);
                    food.CreateFood(windowWidth, windowHeigth);
                    food.Drow();
                }
                
            } while (true);



        }
    }
}
