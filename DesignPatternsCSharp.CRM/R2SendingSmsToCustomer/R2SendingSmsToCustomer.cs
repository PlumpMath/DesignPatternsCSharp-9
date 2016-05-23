using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CRM.R2SendingSmsToCustomer
{
    public class R2SendingSmsToCustomer
    {
        public void addOrder(Order order)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.insertOrder(order);

            int customerId = order.getCustomerId();
            int ordersCount = dataAccess.getOrdersCount(customerId);
            if(ordersCount == 1)
            {
                Customer orderCustomer = dataAccess.getCustomerById(customerId);
                SmsSender smsSender = new SmsSender();
                string smsMessage = orderCustomer.FirstName + " ,Welcome to our store!!";
                smsSender.sendSms(orderCustomer.MobileNumber, smsMessage);
            }

        }
    }
}
