using System;

namespace SWD_DesignPatternsAssignment1
{
    public interface Ibus <T>
    {

        void Subscribe(Action handler)
        {
                
        }

        void Unsubscribe(Action handler)
        {
                
        }

        void Publish(TMessage<T> message)
        {
                
        }

        void Publish(Object message)
        {
                
        }

    }
    public class TMessage<T> 
    {
        public TMessage(T message)
        {
            data = message;
        }
        
        private T data;
        
        public T value 
        {
            get
            { 
                return this.data; 
            } 
            set
            { 
                this.data = value; 
            } 
        } 
    }
}