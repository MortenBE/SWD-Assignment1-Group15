using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_DesignPatternsAssignment1
{
    class Order
    {
        string _orderType { get; set; }
        double _price { get; set; }
        string _description { get; set; }
        
        public Order(string orderType, double price, string description)
        {
            _orderType = orderType;
            _price = price;
            _description = description;
        }

        public string OrderType
        {
            get
            {
                return _orderType;
            }
            set
            {
                _orderType = value;
            }
        }
        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
               
        public override string ToString()
        {
            return "Order: " + OrderType + " Price: " + Price + " Description: " + Description;
        } 
    }
}
