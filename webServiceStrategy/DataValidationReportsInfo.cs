using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.Reports;

namespace webServiceStrategy
{
    public class DataValidationReportsInfo
    {
        public List<DataValidationReport> reportData { get; set; }

        public DataValidationReportsInfo()
        {
            reportData = new List<DataValidationReport>();
        }
    }
}