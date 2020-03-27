using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_DesignPatternsAssignment1
{
    class System_Order
    {
        private string _order { get; set; }

        System_Order() { }
        System_Order(string myOrder)
        {
            _order = myOrder;
        }

    }
}
