using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webServiceStrategy.Reports;

namespace webServiceStrategy
{
    public class DataMeasurePerformReportsInfo
    {
        public List<MeasureMonthlyPerformance> reportData { get; set; }

        public DataMeasurePerformReportsInfo()
        {
            reportData = new List<MeasureMonthlyPerformance>();
        }
    }
}
