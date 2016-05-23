using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsCSharp.CRM
{
    class DataAccess
    {

        public void insertCustomer(Customer customer)
        {
            Debug.WriteLine("Customer added to the database");
        }

        internal void insertOrder(Order order)
        {
            throw new NotImplementedException();
        }

        internal int getOrdersCount(int customerId)
        {
            throw new NotImplementedException();
        }

        internal Customer getCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
