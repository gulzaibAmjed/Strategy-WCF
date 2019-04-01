using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webServiceStrategy.DataEntry;

namespace webServiceStrategy
{
    public class DataEntryFrequencyAnnualInfo
    {
        public List<DataEntryFrequencyAnnual> reportData { get; set; }
        public bool userValidate { get; set; }

        public DataEntryFrequencyAnnualInfo()
        {
            reportData = new List<DataEntryFrequencyAnnual>();
        }
    }
}
