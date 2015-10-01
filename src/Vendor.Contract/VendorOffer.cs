using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorOffer
    {
        public int Id { get; set; }

        public string OfferText { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual Vendor Vendor { get; set; }

    }

}
