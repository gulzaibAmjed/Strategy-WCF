using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServiceStrategy.Reports
{
    public class MeasureMonthlyPerformance
    {
        public string PERS { get; set; }
        public string SO { get; set; }
        public string MEASURE { get; set; }

        public string TARGET { get; set; }
        public string ACTUAL { get; set; }
        public string BAU { get; set; }

        public string SCORE { get; set; }
        public string COLOR { get; set; }
        public string PERIOD { get; set; }
    }
}