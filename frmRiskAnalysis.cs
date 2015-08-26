using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHARiskAnalysis.BettingData;
using WHARiskAnalysis.Entities;

namespace WHARiskAnalysis
{
    public partial class frmRiskAnalysis : Form
    {
        public frmRiskAnalysis()
        {
            InitializeComponent();
        }

        private IList<Bet> SettledBets { get; set; }
        private IList<Bet> UnsettledBets { get; set; }

        private void frmRiskAssessment_Load(object sender, EventArgs e)
        {
            //SettledBets = new List<Bet>();
            //UnsettledBets = new List<Bet>();

            LoadBetsData();
            AnalyzeAndShowBets();
        }

        private void LoadBetsData()
        {
            BetsDataManager betsDataManager = new BetsDataManager();
            SettledBets = betsDataManager.GetBets("BettingData/Settled.csv");
            UnsettledBets = betsDataManager.GetBets("BettingData/Unsettled.csv");
        }

        private void AnalyzeAndShowBets()
        {
            BetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var customersWithStatistics = betsAnalyzer.GetCustomersStatistics(SettledBets);
            var unUsualCustomers = betsAnalyzer.FindUnusualCustomers(customersWithStatistics);
            var riskyBets = betsAnalyzer.FindRiskyBets(unUsualCustomers, UnsettledBets);
            var unUsualBets = betsAnalyzer.FindUnusualBets(customersWithStatistics, UnsettledBets);
            var highlyUnusualBets = betsAnalyzer.FindHighlyUnusualBets(customersWithStatistics, UnsettledBets);
            var unusualWinningBets = betsAnalyzer.FindUnusualWinningBets(UnsettledBets);

            gridUnusualCustomers.DataSource = unUsualCustomers;
            gridRiskyBets.DataSource = riskyBets;
        }
    }
}
