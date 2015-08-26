using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHARiskAnalysis.Entities
{
    public class Customer
    {
        public int CustomerCode { get; set; }
        public int WinPercentage { get; set; }
        public double AverageBet { get; set; }

        public Customer(int customerCode, int winPercentage, double averageBet)
        {
            CustomerCode = customerCode;
            WinPercentage = winPercentage;
            AverageBet = averageBet;
        }
    }
}
