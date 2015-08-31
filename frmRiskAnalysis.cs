using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHARiskAnalysis.BettingAnalyzer;
using WHARiskAnalysis.BettingDataManager;
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
            try
            {
                LoadBetsData();
                AnalyzeAndShowBets();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception occurred: " + ex.Message);
            }
        }

        private void LoadBetsData()
        {
            IBetsDataManager betsDataManager = new BetsDataManager();
            SettledBets = betsDataManager.ReadBetsFromFile("BettingData/Settled.csv");
            UnsettledBets = betsDataManager.ReadBetsFromFile("BettingData/Unsettled.csv");
        }

        private void AnalyzeAndShowBets()
        {
            IBetsAnalyzer betsAnalyzer = new BetsAnalyzer();
            var customersWithStatistics = betsAnalyzer.GetCustomersStatistics(SettledBets);
            var unUsualCustomers = betsAnalyzer.FindUnusualCustomers(customersWithStatistics);
            var riskyBets = betsAnalyzer.FindRiskyBets(unUsualCustomers, UnsettledBets);
            var unUsualBets = betsAnalyzer.FindUnusualBets(customersWithStatistics, UnsettledBets);
            var highlyUnusualBets = betsAnalyzer.FindHighlyUnusualBets(customersWithStatistics, UnsettledBets);
            var unusualWinningBets = betsAnalyzer.FindUnusualWinningBets(UnsettledBets);

            gridUnusualCustomers.DataSource = unUsualCustomers;
            gridRiskyBets.DataSource = riskyBets;
            gridUsualBets.DataSource = unUsualBets;
            gridHighlyUnusualBets.DataSource = highlyUnusualBets;
            gridUnusualWinningBets.DataSource = unusualWinningBets;
            gridAllCustomers.DataSource = customersWithStatistics;
            gridAllSettledBets.DataSource = SettledBets;
            gridAllUnsettledBets.DataSource = UnsettledBets;
        }
    }
}
