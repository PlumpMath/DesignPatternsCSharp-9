using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsCSharp.CRM
{
    public class R1AddingOrders
    {
        public void addOrder(Order order)
        {
            //Insert customer data to the database
            DataAccess dataAccess = new DataAccess();
            dataAccess.insertOrder(order);

        }
    }
}
