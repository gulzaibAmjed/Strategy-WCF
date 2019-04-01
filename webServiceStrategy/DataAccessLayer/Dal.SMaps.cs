using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.SqlClient;
using webServiceStrategy.Buiseness_Logic;

namespace webServiceStrategy.DataAccessLayer.SMaps
{
    public class SMaps
    {

        public static DataSet StrategyMapData(string serviceCode, string code)
        {
            DataSet ds = new DataSet();
            try
            {
                DataSet dtGroups = AuthClient.clientCode(code);
                string ConnectionString = dtGroups.Tables[0].Rows[0][7].ToString();
                if (!string.IsNullOrEmpty(ConnectionString))
                {
                    log4net.Config.XmlConfigurator.Configure();
                    Database database = new SqlDatabase(ConnectionString);
                    database.CreateConnection();
                    SqlCommand command = new SqlCommand("SELECT * FROM STRATEGY_MAP WHERE SC_ID ='" + serviceCode + "'");
                    ds = database.ExecuteDataSet(command);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet PerspectiveData(string serviceCode, string code)
        {
            DataSet ds = new DataSet();
            try
            {
                DataSet dtGroups = AuthClient.clientCode(code);
                string ConnectionString = dtGroups.Tables[0].Rows[0][7].ToString();
                if (!string.IsNullOrEmpty(ConnectionString))
                {
                    log4net.Config.XmlConfigurator.Configure();
                    Database database = new SqlDatabase(ConnectionString);
                    database.CreateConnection();
                    SqlCommand command = new SqlCommand("SELECT * FROM PERSPECTIVE WHERE SC_ID ='" + serviceCode + "'");
                    ds = database.ExecuteDataSet(command);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}