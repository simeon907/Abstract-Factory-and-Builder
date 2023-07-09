using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount
{
    public class Woman : IGameOperations
    {
        public int Score { get; set; }
        public Woman()
        {
            Score = 0;
        }

        public void Decrease()
        {
            Score -= 4;
            if(Score < 0)
            {
                Score = 0;
            }
        }

        public void Increase()
        {
            Score += 100;
        }
    }
}
