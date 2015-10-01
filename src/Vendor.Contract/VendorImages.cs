using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorImage
    {
        public int Id { get; set; }

        public byte[] ImageBlob { get; set; }

        public Uri ImageUrl { get; set; }

        public bool IsLogo { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public virtual Vendor Vendor { get; set; }

    }
}
