﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_DesignPatternsAssignment1
{
    public class MessageBus<T>
    {
        private static MessageBus<T> _instance = null;
        private static readonly object _lock = new object();

        protected MessageBus() {}

        public static MessageBus<T> Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MessageBus<T>();
                    }
                    return _instance;
                }
            }
        }

        public event EventHandler<MessageBusEventArgs<T>> MessageRecieved;

        public void SendMessage(object sender, T Message)
        {
            if (MessageRecieved != null)
            {
                MessageRecieved(sender, new MessageBusEventArgs<T>(Message));
            }
        }
    }

}
