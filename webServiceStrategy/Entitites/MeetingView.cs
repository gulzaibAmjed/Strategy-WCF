using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServiceStrategy.Entitites
{
    public class MeetingView
    {
        public string SC_ID { get; set; }
        public string SC_NAME { get; set; }
        public string SC_SCORE { get; set; }
        public string SC_COLOR { get; set; }

        public string PERSP_ID { get; set; }
        public string PERSP_NAME { get; set; }
        public string PERSP_SCORE { get; set; }
        public string PERSP_COLOR { get; set; }

        public string SO_ID { get; set; }
        public string SO_NAME { get; set; }
        public string SO_SCORE { get; set; }
        public string SO_COLOR { get; set; }

        public string ME_ID { get; set; }
        public string ME_NAME { get; set; }
        public string ME_SCORE { get; set; }
        public string ME_COLOR { get; set; }
    }
}