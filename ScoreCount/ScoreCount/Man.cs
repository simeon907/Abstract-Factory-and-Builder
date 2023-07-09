using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount
{
    class Man : IGameOperations
    {
        public int Score { get; set; }
        public Man()
        {
            Score = 0;
        }
        public void Decrease()
        {
            Score -= 5;
            if (Score < 0)
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
