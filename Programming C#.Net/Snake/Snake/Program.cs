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

            Food food = new Food();
            Wall wall = new Wall(28, 70, 'X');
            Game game = new Game(150m);

            Console.WindowHeight = windowHeigth+2;
            Console.WindowWidth = windowWidth+2;
            Console.CursorVisible = false;

            
            wall.Draw();

            food.CreateFood(windowWidth, windowHeigth);
            food.Draw();

            Snake snake = new Snake(new Point(5, 5, 'O'), 5, Direction.RIGHT);

            ConsoleKey command = Console.ReadKey().Key;

            do
            {
                System.Threading.Thread.Sleep((int)game.Speed);

                if (Console.KeyAvailable)
                {
                    command = Console.ReadKey().Key;
                    snake.HandleKey(command);
                }

                snake.MoveSnake();

                if(snake.Eat(food))
                {
                    game.AddSpeed();
                    food.CreateFood(windowWidth, windowHeigth);
                    food.Draw();
                }

            } while (true);



        }
    }
}
