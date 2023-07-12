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
    public partial class Bus
    {
        public Bus()
        {
            Package = new HashSet<Package>();
        }

        public int BusId { get; set; }
        public string BusName { get; set; }
        public int TotalSeat { get; set; }
        public int AvailableSeat { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        [NotMapped]
        [Display(Name = "Upload File")]
        public IFormFile ImageFile { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}
