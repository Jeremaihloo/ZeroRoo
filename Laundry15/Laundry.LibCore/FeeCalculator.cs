using Laundry.LibCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.LibCore
{
    public class FeeCalculator
    {
        public static FeeCalculator New()
        {
            return new FeeCalculator();
        }

        public decimal Calculate(LaundryTicket ticket)
        {
            decimal sum = 0;
            foreach (var item in ticket.ClotheRecords)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}
