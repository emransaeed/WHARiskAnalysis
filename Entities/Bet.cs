using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHARiskAnalysis.Entities
{
    public class Bet
    {
        public Bet(int customerCode, int eventCode, int participantCode, double stake, double win)
        {
            CustomerCode = customerCode;
            EventCode = eventCode;
            ParticipantCode = participantCode;
            Stake = stake;
            Win = win;
        }

        public int CustomerCode { get; set; }
        public int EventCode { get; set; }
        public int ParticipantCode { get; set; }
        public double Stake { get; set; }
        public double Win { get; set; }
    }
}
