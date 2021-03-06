﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHARiskAnalysis.Entities;

namespace WHARiskAnalysis.BettingAnalyzer
{
    //Analyzes bets and customers
    public class BetsAnalyzer : IBetsAnalyzer
    {
        //Get aggregates i.e WinPercentage and AverageBet for each customer in provided list of bets
        public IList<Customer> GetCustomersStatistics(IList<Bet> settledBets)
        {
            var customers = new List<Customer>();

            customers = settledBets.GroupBy(b => b.CustomerCode)
                        .Select(group => new Customer(group.Key, (group.Count(g => g.Win > 0) * 100) / group.Count(), Math.Round(group.Average(g => g.Stake), 2))).ToList();
            return customers.OrderByDescending(o=>o.WinPercentage).ToList();
        }

        //Return customers having WinPercentage > 60
        public IList<Customer> FindUnusualCustomers(IList<Customer> customersWithStatistics)
        {
            return customersWithStatistics.Where(c => c.WinPercentage > 60).OrderByDescending(o=>o.WinPercentage).ToList();
        }

        //Return unsettled bets that belongs to unusual customers (customers having WinPercentage > 60)
        public IList<Bet> FindRiskyBets(IList<Customer> unUsualCustomers, IList<Bet> unSettledBets)
        {
            var riskyBets = from customer in unUsualCustomers
                            join bet in unSettledBets
                            on customer.CustomerCode equals bet.CustomerCode
                            select bet;
            return riskyBets.OrderByDescending(o => o.Win).ToList();
        }

        //Return unsettled bets having Stake 10 times greater than AverageBet of their customer
        public IList<Bet> FindUnusualBets(IList<Customer> customersWithStatistics, IList<Bet> unSettledBets)
        {
            var riskyBets = from customer in customersWithStatistics
                            join bet in unSettledBets
                            on customer.CustomerCode equals bet.CustomerCode
                            where bet.Stake > customer.AverageBet * 10
                            select bet;
            return riskyBets.OrderByDescending(o => o.Stake).ToList();
        }

        //Return unsettled bets having Stake 30 times greater than AverageBet of their customer
        public IList<Bet> FindHighlyUnusualBets(IList<Customer> customersWithStatistics, IList<Bet> unSettledBets)
        {
            var riskyBets = from customer in customersWithStatistics
                            join bet in unSettledBets
                            on customer.CustomerCode equals bet.CustomerCode
                            where bet.Stake > customer.AverageBet * 30
                            select bet;
            return riskyBets.OrderByDescending(o => o.Stake).ToList();
        }

        //Return unsettled bets having Stake >= 1000
        public IList<Bet> FindUnusualWinningBets(IList<Bet> unSettledBets)
        {
            return unSettledBets.Where(b => b.Win >= 1000).OrderByDescending(o=>o.Win).ToList();
        }
    }
}
