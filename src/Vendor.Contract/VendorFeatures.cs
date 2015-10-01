using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorFeature
    {
        public int Id { get; set; }

        public int? MinBookingPrice { get; set; }

        public int? MinBookingHours { get; set; }

        public int? MaxOccupancy { get; set; }

        public int? SquareFootage { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public virtual Vendor Vendor { get; set; }

    }

}
