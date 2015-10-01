using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorContact
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Mobile { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string Email { get; set; }

        public bool IsPrimary { get; set; }

        public virtual Vendor Vendor { get; set; }

    }

}
