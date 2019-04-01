using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.Entitites;

namespace webServiceStrategy
{
    public class sendAuthClientInfo
    {
        public List<ClientInfo> clientNameInfo { get; set; }

        public sendAuthClientInfo()
        {
            clientNameInfo = new List<ClientInfo>();
        }
    }
}