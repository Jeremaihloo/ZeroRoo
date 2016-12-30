using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public class ZeroRooCoreException: Exception
    {
        public ZeroRooCoreException(string message)
            :base(message)
        {

        }

        public ZeroRooCoreException(string message, Exception innerException)
            :base(message, innerException)
        {

        }
    }
}
