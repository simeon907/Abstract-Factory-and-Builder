using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount
{
    public class Algorithm
    {
        public void TemplateMethod(IGameOperations operations, bool isGoal)
        {
            if (isGoal)
            {
                operations.Increase();
            }
            else
            {
                operations.Decrease();
            }
        }
    }
}
