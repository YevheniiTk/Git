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
            var isGameOn = true;

            int windowHeigth = 28;
            int windowWidth = 70;

            Food food = new Food();
            Wall wall = new Wall(28, 70, 'X');
            Game game = new Game(200m);

            Console.WindowHeight = windowHeigth + 2;
            Console.WindowWidth = windowWidth + 2;
            Console.CursorVisible = false;


            wall.Drow();

            food.CreateFood(windowWidth, windowHeigth);
            food.Drow();

            Snake snake = new Snake(new Point(5, 5, 'O'), 5, Direction.RIGHT);

            ConsoleKey command = ConsoleKey.RightArrow;

            do
            {
                System.Threading.Thread.Sleep((int)game.Speed);

                if (Console.KeyAvailable)
                {
                    command = Console.ReadKey().Key;
                    snake.HandleKey(command);
                }

                snake.MoveSnake();

                if (snake.Eat(food))
                {
                    game.AddSpeed();
                    food.CreateFood(windowWidth, windowHeigth);
                    food.Drow();
                }

                var isWallHit = snake.DidSnakeHitWall(snake, windowWidth, windowHeigth);

                if (isWallHit)
                {
                    isGameOn = false;
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("The snke hit the wall and died.");
                }

            } while (isGameOn);

            ContinueTheGameOrNot();
            
        }

        private static void ContinueTheGameOrNot()
        {
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("\t If you want to play again, press Y.");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main(null);
            }
        }
    }
}
