using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace webServiceStrategy.DataAccessLayer
{
    public class Dal
    {
        static string lString2 = ConfigurationManager.AppSettings["ConStr"];
        static string lUser2 = ConfigurationManager.AppSettings["DBUId"];
        static string lPwd2 = ConfigurationManager.AppSettings["DBPwd"];
        static string ConnectionString2 = lString2 + "uid=" + lUser2 + ";pwd=" + lPwd2 + ";Max Pool Size=180;";

        public static DataSet clientData(string code)
        {
            DataSet ds = new DataSet();
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                Database database = new SqlDatabase(ConnectionString2);
                database.CreateConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM CLIENT_MASTER WHERE AUTH_CODE = '" + code + "'");
                ds = database.ExecuteDataSet(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet clientAuth(string code)
        {
            DataSet ds = new DataSet();
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                Database database = new SqlDatabase(ConnectionString2);
                database.CreateConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM CLIENT_MASTER WHERE AUTH_CODE = '" + code + "'");
                ds = database.ExecuteDataSet(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}