using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography.X509Certificates;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.IO;

namespace webServiceStrategy.PushNotes
{
    public class IOS
    {
        public static void IosPush()
        {

            int port = 2195;
            String hostname = "gateway.sandbox.push.apple.com";

            String certificatePath = HttpContext.Current.Server.MapPath(@"ExperiencesPush.p12");
            X509Certificate2 clientCertificate = new X509Certificate2(System.IO.File.ReadAllBytes(certificatePath), "");
            X509Certificate2Collection certificatesCollection = new X509Certificate2Collection(clientCertificate);

            TcpListener sslServer = new TcpListener(2195);
            //sslServer.Start();
            TcpClient client = new TcpClient(hostname, port);
            SslStream sslStream = new SslStream(client.GetStream(), false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);

            try
            {
                sslStream.AuthenticateAsClient(hostname, certificatesCollection, SslProtocols.Tls, true);
            }
            catch (AuthenticationException e)
            {
                client.Close();
                return;
            }

            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(memoryStream);
            writer.Write((byte)0);
            writer.Write((byte)0);
            writer.Write((byte)32);
            String deviceID = "9efb23d4fbd434bc0e781a702a8efda7daa9bcf0fa3656d9d4e20f94ecf7b12a";
            writer.Write(StringToByteArray(deviceID.ToUpper()));
            String payload = "{\"aps\":{\"alert\":\"" + "hello again cvc.." + "\",\"badge\":1,\"sound\":\"default\"}}";
            writer.Write((byte)0);
            writer.Write((byte)payload.Length);
            byte[] b1 = System.Text.Encoding.UTF8.GetBytes(payload);
            writer.Write(b1);
            writer.Flush();
            byte[] array = memoryStream.ToArray();
            sslStream.Write(array);
            sslStream.Flush();
            client.Close();


        }

        public static bool ValidateServerCertificate(
          object sender,
          X509Certificate certificate,
          X509Chain chain,
          SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            Console.WriteLine("Certificate error: {0}", sslPolicyErrors);

            // Do not allow this client to communicate with unauthenticated servers.
            return false;
        }


        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}