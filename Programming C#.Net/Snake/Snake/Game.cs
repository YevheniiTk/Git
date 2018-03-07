using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Game
    {
        //TODO: Two members below should be changed to one: decimal Speed { get; private set; }
        private decimal speed;
        public  decimal Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public Game (decimal speed)
        {
            this.speed = speed;
        }

        public  void AddSpeed()
        {
            this.speed *= 0.925m;
        }
    }

    
}
