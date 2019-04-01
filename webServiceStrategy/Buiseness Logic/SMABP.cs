using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.DataAccessLayer.SMABP;

namespace webServiceStrategy.Buiseness_Logic
{
    public class SMABP
    {
        public static bool DeviceRegister(string version, string platform, string model, string manufacturer, string guid, string regID, string code)
        {
            bool flag = Dal.DeviceRegistered( version, platform, model, manufacturer,guid, regID,code);
            return flag;
        }
    }
}