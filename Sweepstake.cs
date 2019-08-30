using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstake
    {
        public string name;
        Random rand;
        Dictionary<int, Contestant> contestants;
        Contestant contestant;
        Contestant winner;
        public int winnerId;
        public int counter;


        public Sweepstake()
        {
            rand = new Random();

        }
        public void RegisterContestant(Contestant contestants) //insert sweepstakes?
        {

            counter = 1;

            Console.WriteLine("Enter first name");
            contestant.firstName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter last name");
            contestant.lastName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter Email ");
            contestant.email = Console.ReadLine();
            Console.Clear();

            contestant.registationNumber = counter;

            counter++; 

                    //todo
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.registationNumber);
            Console.WriteLine(contestant.email);
        }

        public string PickWinner(Contestant contestant)
        {
            winnerId = rand.Next(1, contestants.Count);

            Contestant winner = contestants[winnerId];


            return winner.firstName + winner.lastName;


        }
    }
}


