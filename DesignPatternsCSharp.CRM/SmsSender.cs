using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsCSharp.CRM
{
    class SmsSender
    {
        public void sendSms(string mobileNumber,string message)
        {
            Debug.WriteLine("Sms message sent : "+message);
        }
    }
}
