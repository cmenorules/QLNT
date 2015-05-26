using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace testSMS
{
    class SendSMS
    {
        private SerialPort _port;
        public SendSMS()
        {
            _port = new SerialPort("COM6", 115200);
        }
        public void send(string num, string message)
        {
            _port.Open();
            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();
            Thread.Sleep(300);
            _port.Write("AT+CMGF=1\r");
            Thread.Sleep(300);
            _port.Write("AT+CMGS=\"" + num + "\"\r");
            Thread.Sleep(300);
            message += char.ConvertFromUtf32(26) + "\r";
            _port.Write(message + "\r");
            Thread.Sleep(3000);
            _port.Close();
        }
    }
}
