using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using webServiceStrategy.DataAccessLayer.SMaps;


namespace webServiceStrategy.Buiseness_Logic
{
    public class StrategyMap
    {

        public DataSet StrategyMapInfo(string mapID, string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();

                return DataAccessLayer.SMaps.SMaps.StrategyMapData(mapID, code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet PerspectiveInfo(string serviceCode, string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return DataAccessLayer.SMaps.SMaps.PerspectiveData(serviceCode, code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}