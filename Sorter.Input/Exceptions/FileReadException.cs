using System;

namespace Sorter.Input.Exceptions
{
    public class FileReadException : Exception 
    {
        public FileReadException()
        {           
        }

        public FileReadException(string message) 
            : base(message)
        {            
        }

        public FileReadException(string message, Exception innerException)
            : base(message, innerException)
        {        
        }
    }
}
