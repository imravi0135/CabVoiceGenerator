using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabVoiceGenerator
{
    public class InvoiceGeneratorException : Exception
    {
        public ExceptionType type;
        //Enum for Declaring constants
        public enum ExceptionType
        {
            INVALID_TIME,
            INVALID_DISTANCE
        }

        //Parametrized constructor for custom exception
        public InvoiceGeneratorException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
