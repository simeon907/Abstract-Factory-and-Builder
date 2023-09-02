using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount
{
    public interface IGameOperations
    {
        int Score { get; set; }
        void Increase();
        void Decrease();
    }
}
