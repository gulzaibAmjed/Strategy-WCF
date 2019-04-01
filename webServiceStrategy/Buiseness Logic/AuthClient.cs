using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using webServiceStrategy.DataAccessLayer;

namespace webServiceStrategy.Buiseness_Logic
{
    public class AuthClient
    {
        public static DataSet clientCode(string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.clientData(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}