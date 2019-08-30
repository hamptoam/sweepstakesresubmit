using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class MarketingFirm 
    {
        public string userInput;

        ISweepStakeManager manager;
       


        public MarketingFirm(ISweepStakeManager manager)
        {

          this.manager = manager;
   
        }

        //public void GetSweepStakes()
        //{

        //    Console.WriteLine("Create a new sweepstakes? Y or N");
        //    userInput = Console.ReadLine();
        //    if (userInput == "Y")
        //    {
        //        ChooseStructureOption();
        //    }

        //}

        //set up menu
        //set up stack and queue managers 
        //     
       //public void ChooseStructureOption()
       //{
       //     Console.WriteLine("Would you like to use Stack or Queue data structure for your sweepstake?");
       //     userInput = Console.ReadLine();
       //     if (userInput == "Stack")
       //     {

       //         SweepstakesStackManager stackManager = new SweepstakesStackManager();

       //     }

       //     else if (userInput == "Queue")
       //     {
       //         SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                
       //     }

       //     else
       //     {
       //         Console.WriteLine("Please enter 'Stack' or 'Queue' for valid response");
       //         CreateManager();
       //     }
       //}
    }
}
