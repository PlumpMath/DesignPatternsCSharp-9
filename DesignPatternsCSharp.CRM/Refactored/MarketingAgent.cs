using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CRM.Refactored
{
    public class MarketingAgent : ISystemEventsListener
    {
        public void newOrderAdded(Order order, Customer customer)
        {
            DataAccess dataAccess = new DataAccess();
            int ordersCount = dataAccess.getOrdersCount(customer.getCustomerId());
            if (ordersCount == 1)
            {
                SmsSender smsSender = new SmsSender();
                string smsMessage = customer.FirstName + " ,Welcome to our store!!";
                smsSender.sendSms(customer.MobileNumber, smsMessage);
            }
            EmailSender emailSender = new EmailSender();
            emailSender.sendOrderEmail(order);
        }
    }
}
