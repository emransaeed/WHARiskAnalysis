using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHARiskAnalysis.Entities;

namespace WHARiskAnalysis.BettingDataManager
{
    public interface IBetsDataManager
    {
        IList<Bet> GetBets(string fileNameAndPath);
    }
}
