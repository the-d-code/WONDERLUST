using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class PackageBooking
    {
        public PackageBooking()
        {
            Payment = new HashSet<Payment>();
            Travellers = new HashSet<Travellers>();
        }

        public int PackageBookingId { get; set; }
        public int PackageId { get; set; }
        public string UserId { get; set; }
        public string EmailId { get; set; }
        public long ContactNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public int NoOfTravelers { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Package Package { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Travellers> Travellers { get; set; }
    }
}
