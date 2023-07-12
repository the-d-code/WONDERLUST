using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class Package
    {
        public Package()
        {
            PackageBooking = new HashSet<PackageBooking>();
            Payment = new HashSet<Payment>();
            Travellers = new HashSet<Travellers>();
        }

        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int Amount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int NoOfNights { get; set; }
        public int NoOfDays { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int BusId { get; set; }
        public int HotelId { get; set; }
        public bool IsBlock { get; set; }
        public DateTime? CreatedAt { get; set; }
        [NotMapped]
        [Display(Name = "Upload File")]
        public IFormFile ImageFile { get; set; }
        public virtual Bus Bus { get; set; }
        public virtual Category Category { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<PackageBooking> PackageBooking { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Travellers> Travellers { get; set; }
    }
}
