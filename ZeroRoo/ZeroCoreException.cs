using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public class ZeroCoreException: Exception
    {
        public ZeroCoreException(string message)
            :base(message)
        {

        }

        public ZeroCoreException(string message, Exception innerException)
            :base(message, innerException)
        {

        }
    }
}
