using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webServiceStrategy.Entitites;

namespace webServiceStrategy
{
    public class AppMeasureTrendInfo
    {
        public List<AppMeasureTrend> reportData { get; set; }

        public AppMeasureTrendInfo()
        {
            reportData = new List<AppMeasureTrend>();
        }
    }
}
