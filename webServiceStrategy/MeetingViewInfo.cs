using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webServiceStrategy.Entitites;

namespace webServiceStrategy
{
    public class MeetingViewInfo
    {
        public List<MeetingView> info { get; set; }
        public List<MeetingView> perspectiveInfo { get; set; }

        public MeetingViewInfo()
        {
            info = new List<MeetingView>();
            perspectiveInfo = new List<MeetingView>();
        }
    }
}
