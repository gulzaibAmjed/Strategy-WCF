using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.Strategy_Map;

namespace webServiceStrategy
{
    public class StrategyMaps
    {
        public List<SMap> map { get; set; }

        public StrategyMaps()
        {
            map = new List<SMap>();
        }
    }
    
}