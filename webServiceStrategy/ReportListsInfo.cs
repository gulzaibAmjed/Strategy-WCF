using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webServiceStrategy.Reports;

namespace webServiceStrategy
{
    public class ReportListsInfo
    {
        public List<DataReportList> list { get; set; }

        public ReportListsInfo()
        {
            list = new List<DataReportList>();
        }
    }
}
