using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServiceStrategy.Entitites
{
    public class UserData
    {
        public bool loginFlagCheck { get; set; }
        public int user_id { get; set; }
        public string userName { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string designation { get; set; }
        public int userType { get; set; }
        public int dept_id { get; set; }
        public int role_id { get; set; }
        public int lang { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }
        public DateTime createDate { get; set; }

    }
}