using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CRM.Refactored
{

    public class Events
    {
        static List<ISystemEventsListener> systemEventListeners = new List<ISystemEventsListener>();

        public static void addListener(ISystemEventsListener systemEventListener)
        {
            systemEventListeners.Add(systemEventListener);
        }

        public static void publishOrderAddedEvent(Order order,Customer customer)
        {
            foreach(ISystemEventsListener systemEventListener in systemEventListeners)
            {
                systemEventListener.newOrderAdded(order, customer);
            }
        }       
    }
}
