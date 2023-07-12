using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class Payment
    {
        public int PaymetId { get; set; }
        public int PackageBookingId { get; set; }
        public int PackageId { get; set; }
        public string UserId { get; set; }
        public int Amount { get; set; }
        public bool PayemtMode { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Package Package { get; set; }
        public virtual PackageBooking PackageBooking { get; set; }
        public virtual Users User { get; set; }
    }
}
