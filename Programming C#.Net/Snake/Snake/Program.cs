﻿using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var isGameOn = true;

            var game = new Game(28, 70, 10, 10, 'X', 'O', 200m);
            Food food = new FoodAt(17, 20);
            var wall = new Wall(game.WindowHeigth, game.WindowWidth, game.WallSymbol);
            var snake = new Snake(new Point(game.SnakeStartPointX,
                                                 game.SnakeStartPointY,
                                                 game.SnakeSymbol),
                                                 Direction.Right);

            Console.WindowHeight = game.WindowHeigth + 2;
            Console.WindowWidth = game.WindowWidth + 2;
            Console.CursorVisible = false;
            
            wall.Draw();
            food.Draw();
            
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
                    food = CreateFood(game);
                    food.Draw();
                }

                var isWallHit = snake.DidSnakeHitWall(snake, game.WindowWidth, game.WindowHeigth);

                if (isWallHit)
                {
                    isGameOn = false;
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("The snke hit the wall and died.");
                }

            } while (isGameOn);

            ContinueTheGameOrNot();
            
        }

        private static Food CreateFood(Game game)
        {
            Random r = new Random();
            if (r.Next(2) == 0)
            { 
             return new FoodAt(game.WindowWidth, game.WindowHeigth);
            }
            else
            {
                return new FoodSharp(game.WindowWidth, game.WindowHeigth);
            }
        }

        private static void ContinueTheGameOrNot()
        {
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("If you want to play again, press Y.");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main(null);
            }
        }
    }
}
