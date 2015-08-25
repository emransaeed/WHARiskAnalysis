using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHAInsuranceAssessment.Entities
{
    public class Bet
    {
        public Bet(int customer, int eventCode, int participant, int stake, int win)
        {
            Customer = customer;
            EventCode = eventCode;
            Participant = participant;
            Stake = stake;
            Win = win;
        }

        public int Customer { get; set; }
        public int EventCode { get; set; }
        public int Participant { get; set; }
        public int Stake { get; set; }
        public int Win { get; set; }
    }
}
