using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;

namespace webServiceStrategy
{
    public class Users
    {
        public static string licenced(string Code)
        {
            string flag = Dal.licenced(Code);
            return flag;
        }

        public bool check_Login(string userName, string password, string code)
        {
            bool flag = Dal.check_Login(userName, password,code);
            return flag;
        }

        public bool UpdateUserPassword(string userName, string password, string newPassword, string code)
        {
            return Dal.UpdatePassword(userName, password, newPassword, code);
        }

        public static DataSet GetEmailTemplate(int lang, int emailtype)
        {
            DataSet dstemplate = new DataSet();
            dstemplate = Dal.GetEmailTemplate(lang, emailtype);
            return dstemplate;
        }

        //******override*********//
        public static DataSet GetUserPersonalInfo(string emailId,string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.GetUserPersonalInfo(emailId,code);
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }
        public static DataSet GetUserPersonalInfo(string emailId,string password, string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.GetUserPersonalInfo(emailId,password, code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //******************//
        public static string UpdateUserProfile(string userEmail, string fullName, string mobileNo, string Language, string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.UpdateUserProfile(userEmail, fullName, mobileNo, Language, code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet GetUserPersonalInformationByUserId(string UserId,string code)
        {
            DataSet dsuser = new DataSet();
            dsuser = Dal.GetUserPersonalInfoByUserId(UserId,code);
            return dsuser;
        }


        public static bool AddResetPasswordCode(string userid,string hashkey,string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.AddResetPasswordCode(userid, hashkey,code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ResetPassword(string hash, string password,string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.ResetPassword(hash, password,code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static DataSet serviceInfo(string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.serviceData(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataReportList(string userId, string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataReportsList(userId, code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataValidatReport(string service, string score, string yesr, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataReports(service,score,yesr,Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet PerformanceComparison(string userID, string score, string yesr, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataPerformanceCompareReports(userID, score, yesr, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet MeasurePerform(string userID, string score,string month, string yesr, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataMeasurePerformReports(userID, score, month, yesr, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet AppMeasureTrend(string score, string month, string yesr, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataAppMeasureTrend(score, month, yesr, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet PerspectiveViewData(string serviceCode, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.perspectiveViewData(serviceCode,Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataRow[] MeetingViewData(string service, string score, string userID, string month, string yesr, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.meetingViewData(service,score, userID, month, yesr, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet scoreCardInfo(string serviceCode,string code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.scoreCardsData(serviceCode,code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DataEntryValidation(string service, string userID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryValidation( service,  userID,  Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyAnnual(string service, string userID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyAnnual(service, userID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyHalfAnnual(string service, string userID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyHalfAnnual(service, userID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyQuarter(string service, string userID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyQuarter(service, userID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyAnnualResult(string service, string measureID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyAnnualResult(service, measureID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyHalfAnnualResult(string service, string measureID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyHalfAnnualResult(service, measureID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyQuarterResult(string service, string measureID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyQuarterResult(service, measureID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyMonth(string service, string userID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyMonth(service, userID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet DataEntryFrequencyMonthResult(string service, string measureID, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.dataEntryFrequencyMonthResult(service, measureID, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool EnterValueDataEntryAnnual(string score, string measure, string userID, double actual, string Code)
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                return Dal.enterValueDataEntryAnnual(score, measure,userID, actual, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}