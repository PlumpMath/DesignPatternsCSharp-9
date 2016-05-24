using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CRM.Refactored
{
    public interface ISystemEventsListener
    {
        void newOrderAdded(Order order,Customer customer);
    }
}
