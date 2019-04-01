using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServiceStrategy.Reports
{
    public class DataValidationReport
    {
        public string SC_ID { get; set; }
        public string MEASURE_ID { get; set; }
        public string YEARmONTH { get; set; }
        public string PERIOD { get; set; }
        public string ACTUAL { get; set; }
        public string TARGET { get; set; }
        public string BAU { get; set; }
        public string WORST { get; set; }
        public string POLARITY { get; set; }
        public string DESC { get; set; }
    }
}