using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WHARiskAnalysis.BettingAnalyzer;
using WHARiskAnalysis.BettingDataManager;
using System.Collections.Generic;
using WHARiskAnalysis.Entities;

namespace WHARiskAnalysisTests
{
    [TestClass]
    public class BetsAnalyzerTests
    {
        private string fileName = "BettingData/Settled.csv";
        private IList<Bet> settledBets;
        private IList<Bet> unsettledBets;
        private IList<Customer> customers;
        private IList<Customer> unusualCustomers;

        public BetsAnalyzerTests()
        {
            Setup();
        }

        private void Setup()
        {
            settledBets = new List<Bet>();
            settledBets.Add(new Bet(1, 1, 1, 100, 200));
            settledBets.Add(new Bet(1, 2, 2, 200, 0));
            settledBets.Add(new Bet(2, 3, 3, 300, 500));

            unsettledBets = new List<Bet>();
            unsettledBets.Add(new Bet(1, 1, 1, 500, 800));
            unsettledBets.Add(new Bet(2, 2, 2, 300, 1200));

            customers = new List<Customer>();
            customers.Add(new Customer(1, 50, 150));
            customers.Add(new Customer(2, 100, 300));

            unusualCustomers = new List<Customer>();
            unusualCustomers.Add(new Customer(2, 100, 300));
        }

        [TestMethod]
        public void Test_GetCustomersStatistics()
        {
            IBetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var customers = betsAnalyzer.GetCustomersStatistics(settledBets);
            Assert.AreEqual(customers.Count, 2);
        }

        [TestMethod]
        public void Test_FindUnusualCustomers()
        {
            IBetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var unusualCustomers = betsAnalyzer.FindUnusualCustomers(customers);
            Assert.AreEqual(unusualCustomers.Count, 1);
        }

        [TestMethod]
        public void Test_FindRiskyBets()
        {
            IBetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var riskyBets = betsAnalyzer.FindRiskyBets(unusualCustomers, unsettledBets);
            Assert.AreEqual(riskyBets.Count, 1);
        }

        [TestMethod]
        public void Test_FindUnusualBets()
        {
            IBetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var unusualBets = betsAnalyzer.FindUnusualBets(customers, unsettledBets);
            Assert.AreEqual(unusualBets.Count, 0);
        }

        [TestMethod]
        public void Test_FindHighlyUnusualBets()
        {
            IBetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var highllyUnusualBets = betsAnalyzer.FindHighlyUnusualBets(customers, unsettledBets);
            Assert.AreEqual(highllyUnusualBets.Count, 0);
        }

        [TestMethod]
        public void Test_FindUnusualWinningBets()
        {
            IBetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var highllyUnusualBets = betsAnalyzer.FindUnusualWinningBets(unsettledBets);
            Assert.AreEqual(highllyUnusualBets.Count, 1);
        }
    }
}
