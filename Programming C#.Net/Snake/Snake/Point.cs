using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            symbol = sym;
        }

        public void Draw()
        {
            this.Draw(x, y, symbol);
        }

        public void Clear()
        {
            this.Draw(x, y, ' ');
        }
        
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    x = x + offset;
                    break;
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;
                case Direction.UP:
                    y = y - offset;
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
