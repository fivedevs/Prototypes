using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class Vendor
    {
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public Vendor ParentVendor { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public bool IsPreffered { get; set; }

        public bool? BlockVendor { get; set; }

        public string Email { get; set; }

        public string KeyWords { get; set; }

        public string FullName { get; set; }

        public virtual ICollection<VendorAddress> Addresses { get; set; }

        public virtual ICollection<VendorAmenity> Amenities { get; set; }

        public virtual ICollection<VendorContact> Contacts { get; set; }

        public virtual ICollection<VendorFeature> Features { get; set; }

        public virtual ICollection<VendorImage> Images { get; set; }

        public virtual ICollection<VendorMenu> Menus { get; set; }

        public virtual ICollection<VendorOffer> Offers { get; set; }

        public virtual ICollection<VendorTiming> HoursOfOperation { get; set; }

        public virtual VendorType Type { get; set; }
    }

}
