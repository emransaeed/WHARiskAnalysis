using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHARiskAnalysis.Entities;

namespace WHARiskAnalysis.BettingAnalyzer
{
    public interface IBetsAnalyzer
    {
        IList<Customer> GetCustomersStatistics(IList<Bet> settledBets);
        IList<Customer> FindUnusualCustomers(IList<Customer> customersWithStatistics);
        IList<Bet> FindRiskyBets(IList<Customer> unUsualCustomers, IList<Bet> unSettledBets);
        IList<Bet> FindUnusualBets(IList<Customer> customersWithStatistics, IList<Bet> unSettledBets);
        IList<Bet> FindHighlyUnusualBets(IList<Customer> customersWithStatistics, IList<Bet> unSettledBets);
        IList<Bet> FindUnusualWinningBets(IList<Bet> unSettledBets);
    }
}
