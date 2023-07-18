using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationPractice.Exceptions
{
    class NoJSONFileException : Exception
    {
        public NoJSONFileException() : base() { }
        public NoJSONFileException(string message) : base(message) { }
    }
}