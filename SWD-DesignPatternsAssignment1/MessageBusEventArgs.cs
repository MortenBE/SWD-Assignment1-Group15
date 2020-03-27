using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_DesignPatternsAssignment1
{
    public class MessageBusEventArgs<T> : EventArgs
    {
        private T _message;

        public MessageBusEventArgs(T Message)
        {
            _message = Message;
        }

        public T Message
        {
            get
            {
                return _message;
            }
        }
    }
}
