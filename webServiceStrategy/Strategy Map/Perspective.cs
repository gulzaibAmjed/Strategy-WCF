using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServiceStrategy.Strategy_Map
{
    public class Perspective
    {
        public string sc_id { get; set; }
        public string perspective_id { get; set; }
        public string perspective_code { get; set; }
        public string pname { get; set; }
        public string pdesc { get; set; }
        public string owner_id { get; set; }
        public string waitage { get; set; }
        public string display_order { get; set; }
        public string user { get; set; }
        public DateTime date { get; set; }
    }
}