using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{

    class SweepstakesQueueManager : ISweepStakeManager
    {
        public Queue<Sweepstake> Manager = new Queue<Sweepstake>();
 
        public SweepstakesQueueManager()
        {
      
        }
        
        public void InsertSweepstakes(Sweepstake sweepstake)
        {

            Manager.Enqueue(sweepstake);

        }
        public Sweepstake GetSweepStake()
        {

            return Manager.Dequeue();

        }
    }
}
