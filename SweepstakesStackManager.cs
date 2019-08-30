using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesStackManager:ISweepStakeManager
    {

        public Stack<Sweepstake> Manager = new Stack<Sweepstake>();

        public void InsertSweepstakes(Sweepstake sweepstake)
        {
            Manager.Push(sweepstake);
        }

        public Sweepstake GetSweepStake()
        {

          return Manager.Pop();

        }
    }
}
