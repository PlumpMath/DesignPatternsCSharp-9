using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CRM.Refactored
{
    public class PromotionsAgent : ISystemEventsListener
    {
        public void newOrderAdded(Order order, Customer customer)
        {
            DataAccess dataAccess = new DataAccess();
            double orderAmount = order.getAmount();
            if (orderAmount > 200)
            {
                dataAccess.addPointsToCustomer(customer.getCustomerId(), 10);
            }
        }
    }
}
