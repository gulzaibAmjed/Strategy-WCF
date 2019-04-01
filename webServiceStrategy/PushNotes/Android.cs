using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.IO;

namespace webServiceStrategy.PushNotes
{
    public class Android
    {
        public static void AndroidPush(string regisId, string msgString)
        {
            string regId = regisId;
            // applicationID means google Api key                                                                                                     
            var applicationID = "AIzaSyDK6325qPiNxDa2BXyQdbuzVRCcCiHD3dE";
            // SENDER_ID is nothing but your ProjectID (from API Console- google code)
            var SENDER_ID = "510584686672";

            var value = msgString; // "New Survey ABC (3-104) is Created. Come and check."; //message text box                                                                               

            WebRequest tRequest;

            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";

            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";

            tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

            //Data post to server                                                                                                                                         
            string postData =
            "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message="
            + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" +
            regId + "";

            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);

            String sResponseFromServer = tReader.ReadToEnd();   //Get response from GCM server.

            //Label1.Text = sResponseFromServer;      //Assigning GCM response to Label text 

            tReader.Close();

            dataStream.Close();
            tResponse.Close();
        }
    }
}