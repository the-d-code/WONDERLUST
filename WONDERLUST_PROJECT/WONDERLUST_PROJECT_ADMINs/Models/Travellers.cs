using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class Travellers
    {
        public int TravellersId { get; set; }
        public int PackageBookingId { get; set; }
        public int PackageId { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public long AadharCardNo { get; set; }
        public long ContactNo { get; set; }
        public string BloodGroup { get; set; }
        public DateTime Dob { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Package Package { get; set; }
        public virtual PackageBooking PackageBooking { get; set; }
        public virtual Users User { get; set; }
    }
}
