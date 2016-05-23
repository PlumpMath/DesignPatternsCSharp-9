using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsCSharp.CRM
{
    class EmailSender
    {
        public void sendWelcomeEmail(Customer customer)
        {
            Debug.WriteLine("Welcome email was sent to customer: " + customer.FirstName);
        }
    }
}
