using System;

namespace ZeroRoo.Commands
{
    public class CommandHostRetryException : ZeroCoreException
    {
        public CommandHostRetryException(string message)
            : base(message)
        {
        }

        public CommandHostRetryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}