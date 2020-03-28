using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_DesignPatternsAssignment1
{
    class System_Order
    {
        List<Order> _Orders;
        

        System_Order() { }
        System_Order(List<Order>orders)
        {
            _Orders = orders;            
        }

    }
}
