using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.Entitites;
using webServiceStrategy.Strategy_Map;

namespace webServiceStrategy
{
    public class Perspectives
    {
        public List<PerspectiveView> perspectiveInfo { get; set; }

        public Perspectives()
        {
            perspectiveInfo = new List<PerspectiveView>();
        }
    }
}