using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.Entitites;

namespace webServiceStrategy
{
    public class Services
    {
        public List<Service> service { get; set; }

        public Services()
        {
            service = new List<Service>();
        }
    }
}