using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class Users
    {
        public Users()
        {
            Enquiry = new HashSet<Enquiry>();
            PackageBooking = new HashSet<PackageBooking>();
            Payment = new HashSet<Payment>();
            Travellers = new HashSet<Travellers>();
        }

        public string UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Enquiry> Enquiry { get; set; }
        public virtual ICollection<PackageBooking> PackageBooking { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Travellers> Travellers { get; set; }
    }
}
