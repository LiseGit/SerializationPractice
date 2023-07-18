using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationPractice.Exceptions
{
    class SeveralJSONFilesException : Exception
    {
        public SeveralJSONFilesException() : base() { }
        public SeveralJSONFilesException(string message) : base(message) { }
    }
}