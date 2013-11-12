using System;

namespace Sorter.Input.Exceptions
{
    public class FileReadException : Exception 
    {
        public FileReadException()
        {           
        }

        public FileReadException(string message) : base(message)
        {
            
        }
    }
}
