using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationPractice.Exceptions
{
    public class NoFilesException : Exception
    {
        public NoFilesException() : base() { }
        public NoFilesException(string message) : base(message) { }
    }
}
