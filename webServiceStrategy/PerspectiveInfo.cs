using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webServiceStrategy.Entitites;

namespace webServiceStrategy
{
    public class PerspectiveInfo
    {
        public List<PerspectiveView> viewData { get; set; }

        public PerspectiveInfo()
        {
            viewData = new List<PerspectiveView>();
        }
    }
}
