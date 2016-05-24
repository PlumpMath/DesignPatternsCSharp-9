using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CRM.Refactored
{
    public class ECommerceLogic
    {
        public void addOrder(Order order)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.insertOrder(order);
            int customerId = order.getCustomerId();
            Customer customer = dataAccess.getCustomerById(customerId);
            Events.publishOrderAddedEvent(order,customer);
            
        }
    }
}
