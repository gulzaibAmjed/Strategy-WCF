using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.Entitites;

namespace webServiceStrategy
{
    public class UserInfo
    {
        public List<UserData> userInfo { get; set; }

        public UserInfo()
        {
            userInfo = new List<UserData>();
        }
    }
}