using System;
namespace userDatabase
{
    class InvalidTimeException : Exception
    {
        /* Creates a new Exception class called InvalidTimeException. 
         * Creates a new default Exception constructor of type InvalidTimeException
         * Creates a new overloaded Exception constructor of type InvalidTimeException
         * Creates a new overloaded Exception constructor of type InvalidTimeException that inherits its message and 
         */
        public InvalidTimeException() : base() { }
        public InvalidTimeException(string message) : base(message) { }
        public InvalidTimeException(string message, Exception innerException) : base(message, innerException) { }
    }
}

