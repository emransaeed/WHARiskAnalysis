using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WHARiskAnalysis.BettingDataManager;

namespace WHARiskAnalysisTests
{
    [TestClass]
    public class BetsDataManagerTests
    {
        private string fileName = "BettingData/Settled.csv";

        [TestMethod]
        public void Test_GetBets()
        {
            IBetsDataManager betsDataManager = new BetsDataManager();
            var bets = betsDataManager.ReadBetsFromFile(fileName);
            Assert.AreEqual(bets.Count, 50);
        }
    }
}
