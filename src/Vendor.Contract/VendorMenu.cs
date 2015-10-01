using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorMenu
    {
        public int Id { get; set; }

        public byte[] Menu { get; set; }

        public Uri MenuUrl { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual Vendor Vendor { get; set; }
    }

}
