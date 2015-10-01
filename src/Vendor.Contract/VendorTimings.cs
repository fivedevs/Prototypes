using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorTiming
    {
        public int Id { get; set; }

        public char DayOfWeek { get; set; }

        public char Hours { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual Vendor Vendor { get; set; }

    }

}
