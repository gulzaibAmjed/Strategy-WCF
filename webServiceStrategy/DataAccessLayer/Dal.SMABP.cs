using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using webServiceStrategy.Buiseness_Logic;

namespace webServiceStrategy.DataAccessLayer.SMABP
{
    public class Dal
    {
        static string lString = ConfigurationManager.AppSettings["ConStr"];
        static string lUser = ConfigurationManager.AppSettings["DBUId"];
        static string lPwd = ConfigurationManager.AppSettings["DBPwd"];
        static string ConnectionString = lString + "uid=" + lUser + ";pwd=" + lPwd + ";Max Pool Size=180;";


        public static bool DeviceRegistered(string version, string platform, string model, string manufacturer,string guid, string regID,string code)
        {
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            int userId = 0 ;
            try
            {
                DataSet dtGroups = AuthClient.clientCode(code);
                userId = Convert.ToInt32(dtGroups.Tables[0].Rows[0][0]);

                if (!string.IsNullOrEmpty(ConnectionString))
                {
                    log4net.Config.XmlConfigurator.Configure();
                    Database database = new SqlDatabase(ConnectionString);
                    database.CreateConnection();
                    string query = "SELECT * FROM DEVICE_MASTER WHERE DEVICE_GUID ='" + guid + "'";
                    SqlCommand command = new SqlCommand(query);
                    SqlDataAdapter lDataAdapter = new SqlDataAdapter(command);
                    ds = database.ExecuteDataSet(command);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string query1 = "UPDATE DEVICE_MASTER SET REGIS_ID ='" + regID + "',REGIS_DATE = '" + DateTime.Now + "' WHERE DEVICE_GUID = '" + guid +"'";
                        SqlCommand command1 = new SqlCommand(query1);
                        SqlDataAdapter lDataAdapter1 = new SqlDataAdapter(command1);
                        database.ExecuteNonQuery(command1);
                    }
                    else
                    {
                        string query2 = "insert into DEVICE_MASTER(CLIENT_ID,DEVICE_GUID,DEVICE_NAME, MODEL_NAME, FACTORY_NAME, DEVICE_OS, OS_VERSION, REGIS_ID, REGIS_DATE) values(" + userId + ",'" + guid + "','" + model + "','" + model + "','" + manufacturer + "','" + platform + "','" + version + "','" + regID + "','" + DateTime.Now + "')";
                        SqlCommand command2 = new SqlCommand(query2);
                        SqlDataAdapter lDataAdapter2 = new SqlDataAdapter(command2);
                        database.ExecuteNonQuery(command2);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}