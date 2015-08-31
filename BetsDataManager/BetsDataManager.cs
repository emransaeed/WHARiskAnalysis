using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHARiskAnalysis.Entities;

namespace WHARiskAnalysis.BettingDataManager
{
    //Data manager to read bets from csv file
    public class BetsDataManager : IBetsDataManager
    {
        //Read bets from a csv file into list
        //Columns of file are: CustomerCode, EventCode, ParticipantCode, Stake, Win
        public IList<Bet> ReadBetsFromFile(string fileNameAndPath)
        {
            var bets = new List<Bet>();
            
            //Open stream reader on file
            using (var streamReader = new StreamReader(fileNameAndPath))
            {
                //Loop through all lines of file and add them to bets list
                foreach (string line in streamReader.ReadToEnd().Split('\n').Where(line => !string.IsNullOrEmpty(line)))
                {
                    var betsArray = line.Split(',').ToArray<string>();
                    bets.Add(new Bet(int.Parse(betsArray[0]), int.Parse(betsArray[1]), int.Parse(betsArray[2]), double.Parse(betsArray[3]), double.Parse(betsArray[4])));
                }
            }
            return bets;
        }
    }
}
