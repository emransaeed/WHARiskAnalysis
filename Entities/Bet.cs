using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHARiskAnalysis.Entities
{
    public class Bet
    {
        public Bet(int customerCode, int eventCode, int participantCode, int stake, int win)
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
        public int Stake { get; set; }
        public int Win { get; set; }
    }
}
