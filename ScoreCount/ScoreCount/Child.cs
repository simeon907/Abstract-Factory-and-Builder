using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount
{
    public class Child : IGameOperations
    {
        public int Score { get; set; }
        public Child()
        {
            Score = 0;
        }

        public void Decrease()
        {
            Score -= 2;
            if (Score < 0)
            {
                Score = 0;
            }
        }

        public void Increase()
        {
            Score += 200;
        }
    }
}
