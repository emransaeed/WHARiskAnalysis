using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHARiskAnalysis.Entities;

namespace WHARiskAnalysis.BettingDataManager
{
    public class BetsDataManager : IBetsDataManager
    {
        public IList<Bet> GetBets(string fileNameAndPath)
        {
            var bets = new List<Bet>();
            using (var sr = new StreamReader(fileNameAndPath))
            {
                foreach(string line in sr.ReadToEnd().Split('\n').Where(l => !string.IsNullOrEmpty(l)))
                {
                    var betArray = line.Split(',').Select(x => int.Parse(x)).ToArray<int>();
                    bets.Add(new Bet(betArray[0], betArray[1], betArray[2], betArray[3], betArray[4]));
                }
            }
            return bets;
        }
    }
}
