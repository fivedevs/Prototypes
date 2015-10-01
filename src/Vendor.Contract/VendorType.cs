using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorType
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public DateTime? LastModifiedDate { get; set; }

        public virtual Vendor Vendor { get; set; }
    }

}
