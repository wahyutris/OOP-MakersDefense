using System;
namespace tesOOP
{
    public class MDException : Exception
    {
        public MDException() //contructor class
        {
        }

        public MDException(string message) : base(message)
        {
            
        }
    }

    class OutOfBoundsException : MDException
    {
        public OutOfBoundsException() //constructor class
        {
            
        }

        public OutOfBoundsException(string message) : base(message)
        {
            
        }
    }
}
