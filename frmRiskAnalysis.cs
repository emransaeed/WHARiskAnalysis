using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHAInsuranceAssessment.BettingData;
using WHAInsuranceAssessment.Entities;

namespace WHAInsuranceAssessment
{
    public partial class frmRiskAnalysis : Form
    {
        public frmRiskAnalysis()
        {
            InitializeComponent();
        }

        IList<Bet> SettledBets = new List<Bet>();
        IList<Bet> UnsettledBets = new List<Bet>();

        private void frmRiskAssessment_Load(object sender, EventArgs e)
        {
            LoadBets();
        }

        private void LoadBets()
        {
            SettledBets = BettingDataManager.GetBets("BettingData/Settled.csv");
            UnsettledBets = BettingDataManager.GetBets("BettingData/Unsettled.csv");
        }
    }
}
