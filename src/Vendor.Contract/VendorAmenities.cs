using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Contract
{
    public class VendorAmenity
    {
        public int Id { get; set; }

        public bool? Wifi { get; set; }

        public bool? Bar { get; set; }

        public bool? ValetParking { get; set; }

        public bool? SelfParking { get; set; }

        public bool? Indoor { get; set; }

        public bool? GreatViews { get; set; }

        public bool? OutdoorCatering { get; set; }

        public bool? RoomsAvailable { get; set; }

        public bool? HandicapAccessible { get; set; }

        public bool? MediaRoom { get; set; }

        public bool? NoDrinkingAllowed { get; set; }

        public bool? Beachfront { get; set; }

        public bool? CateringAvailable { get; set; }

        public bool? Pool { get; set; }

        public bool? Rooftop { get; set; }

        public bool? Smoking { get; set; }

        public bool? CoatCheck { get; set; }

        public bool? Delivery { get; set; }

        public string ZipCodesCovered { get; set; }

        public short? MaxDistanceFromZip { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public bool? KidsActivities { get; set; }

        public bool? RecreationalCenter { get; set; }

        public virtual Vendor Vendor { get; set; }

    }

}
