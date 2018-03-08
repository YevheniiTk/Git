using System;

namespace Snake
{
    public class Point
    {
        public int X { get; private set; }
        public  int Y { get; private set; }
        public readonly char Symbol;

        public Point(int x, int y, char sym)
        {
            this.X = x;
            this.Y = y;
            Symbol = sym;
        }

        public void Draw()
        {
            this.Draw(X, Y, Symbol);
        }

        public void Clear()
        {
            this.Draw(X, Y, ' ');
        }
        
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    X = X + offset;
                    break;
                case Direction.Left:
                    X = X - offset;
                    break;
                case Direction.Down:
                    Y = Y + offset;
                    break;
                case Direction.Up:
                    Y = Y - offset;
                    break;
            }
        }

        private void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            Console.SetCursorPosition(0, 0);
        }
    }
}
