using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webServiceStrategy.Reports;

namespace webServiceStrategy
{
    public class DataPerformanceComparisonReportsInfo
    {
        public List<PerformanceComparison> reportData { get; set; }

        public DataPerformanceComparisonReportsInfo()
        {
            reportData = new List<PerformanceComparison>();
        }
    }
}
