using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SMTPSHERWIN
{
    public class SMTP
    {

        public static bool ValidateCredentials(string login, string password, string server, int port, bool enableSsl)
        {
            SmtpConnectorBase connector;
            if (enableSsl)
            {
                connector = new SmtpConnectorWithSsl(server, port);
            }
            else
            {
                connector = new SmtpConnectorWithoutSsl(server, port);
            }

            if (!connector.CheckResponse(220))
            {
                return false;
            }

            connector.SendData($"HELO {Dns.GetHostName()}{SmtpConnectorBase.EOF}");
            if (!connector.CheckResponse(250))
            {
                return false;
            }

            connector.SendData($"AUTH LOGIN{SmtpConnectorBase.EOF}");
            if (!connector.CheckResponse(334))
            {
                return false;
            }

            connector.SendData(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{login}")) + SmtpConnectorBase.EOF);
            if (!connector.CheckResponse(334))
            {
                return false;
            }

            connector.SendData(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{password}")) + SmtpConnectorBase.EOF);
            if (!connector.CheckResponse(235))
            {
                return false;
            }

            return true;
        }

        internal abstract class SmtpConnectorBase
        {
            protected string SmtpServerAddress { get; set; }
            protected int Port { get; set; }
            public const string EOF = "\r\n";

            protected SmtpConnectorBase(string smtpServerAddress, int port)
            {
                SmtpServerAddress = smtpServerAddress;
                Port = port;
            }

            public abstract bool CheckResponse(int expectedCode);
            public abstract void SendData(string data);

        }
        internal class SmtpConnectorWithoutSsl : SmtpConnectorBase
        {
            private Socket _socket = null;

            public SmtpConnectorWithoutSsl(string smtpServerAddress, int port) : base(smtpServerAddress, port)
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(smtpServerAddress);
                IPEndPoint endPoint = new IPEndPoint(hostEntry.AddressList[0], port);
                _socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                //try to connect and test the rsponse for code 220 = success
                _socket.Connect(endPoint);

            }

            ~SmtpConnectorWithoutSsl()
            {
                try
                {
                    if (_socket != null)
                    {
                        _socket.Close();
                        _socket = null;
                    }
                }
                catch (Exception)
                {
                    ;
                }

            }

            public override bool CheckResponse(int expectedCode)
            {
                while (_socket.Available == 0)
                {
                    System.Threading.Thread.Sleep(100);
                }
                byte[] responseArray = new byte[1024];
                _socket.Receive(responseArray, 0, _socket.Available, SocketFlags.None);
                string responseData = Encoding.UTF8.GetString(responseArray);
                int responseCode = Convert.ToInt32(responseData.Substring(0, 3));
                if (responseCode == expectedCode)
                {
                    return true;
                }
                return false;
            }

            public override void SendData(string data)
            {
                byte[] dataArray = Encoding.UTF8.GetBytes(data);
                _socket.Send(dataArray, 0, dataArray.Length, SocketFlags.None);
            }
        }
        internal class SmtpConnectorWithSsl : SmtpConnectorBase
        {
            private SslStream _sslStream = null;
            private TcpClient _client = null;

            public SmtpConnectorWithSsl(string smtpServerAddress, int port) : base(smtpServerAddress, port)
            {
                TcpClient client = new TcpClient(smtpServerAddress, port);

                _sslStream = new SslStream(
                    client.GetStream(),
                    false,
                    new RemoteCertificateValidationCallback(ValidateServerCertificate),
                    null
                    );
                // The server name must match the name on the server certificate.
                try
                {
                    _sslStream.AuthenticateAsClient(smtpServerAddress);
                }
                catch (AuthenticationException e)
                {
                    _sslStream = null;
                    Console.WriteLine("Exception: {0}", e.Message);
                    if (e.InnerException != null)
                    {
                        Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
                    }
                    Console.WriteLine("Authentication failed - closing the connection.");
                    client.Close();
                }
            }

            ~SmtpConnectorWithSsl()
            {
                try
                {
                    if (_sslStream != null)
                    {
                        _sslStream.Close();
                        _sslStream.Dispose();
                        _sslStream = null;
                    }
                }
                catch (Exception)
                {
                    ;
                }

                try
                {
                    if (_client != null)
                    {
                        _client.Close();
                        _client = null;
                    }
                }
                catch (Exception)
                {
                    ;
                }
            }

            // The following method is invoked by the RemoteCertificateValidationDelegate.
            private static bool ValidateServerCertificate(
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

            public override bool CheckResponse(int expectedCode)
            {
                if (_sslStream == null)
                {
                    return false;
                }
                var message = ReadMessageFromStream(_sslStream);
                int responseCode = Convert.ToInt32(message.Substring(0, 3));
                if (responseCode == expectedCode)
                {
                    return true;
                }
                return false;
            }

            public override void SendData(string data)
            {
                byte[] messsage = Encoding.UTF8.GetBytes(data);
                // Send hello message to the server. 
                _sslStream.Write(messsage);
                _sslStream.Flush();
            }

            private string ReadMessageFromStream(SslStream stream)
            {
                byte[] buffer = new byte[2048];
                StringBuilder messageData = new StringBuilder();
                int bytes = -1;
                do
                {
                    bytes = stream.Read(buffer, 0, buffer.Length);

                    // Use Decoder class to convert from bytes to UTF8
                    // in case a character spans two buffers.
                    Decoder decoder = Encoding.UTF8.GetDecoder();
                    char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
                    decoder.GetChars(buffer, 0, bytes, chars, 0);
                    messageData.Append(chars);
                    // Check for EOF.
                    if (messageData.ToString().IndexOf(EOF) != -1)
                    {
                        break;
                    }
                } while (bytes != 0);

                return messageData.ToString();
            }
        }
    }
}
