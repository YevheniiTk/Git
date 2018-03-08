namespace Snake
{
    public class Game
    {
        public int WindowHeigth { get; private set; }
        public int WindowWidth { get; private set; }
        public int SnakeStartPointX { get; private set; }
        public int SnakeStartPointY { get; private set; }
        public char WallSymbol { get; private set; }
        public char SnakeSymbol { get; private set; }
        public decimal Speed { get; private set; }

        public Game(int windowHeigth, 
                    int windowWidth, 
                    int snakeStartPointX,
                    int snakeStartPointY,
                    char wallSymbol,
                    char snakeSymbol, 
                    decimal speed)
        {
            WindowHeigth = windowHeigth;
            WindowWidth =windowWidth;
            SnakeStartPointX = snakeStartPointX;
            SnakeStartPointY = snakeStartPointY;
            WallSymbol = wallSymbol;
            SnakeSymbol = snakeSymbol;
            Speed = speed;
        }

        public virtual void AddSpeed()
        {
            Speed *= 0.925m;
        }
    }


}
