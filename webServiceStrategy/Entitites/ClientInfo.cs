using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServiceStrategy.Entitites
{
    public class ClientInfo
    {
        public bool flag { get; set; }
        public int id { get; set; }
        public string name{ get; set; }
        public string URL { get; set; }
        public string serverName { get; set; }
        public string databaseName { get; set; }
        public string dbUserName { get; set; }
        public string password { get; set; }
        public string constr { get; set; }
        public string authCode { get; set; }

        public ClientInfo()
        { }
    }
}