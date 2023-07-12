using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class City
    {
        public City()
        {
            Hotel = new HashSet<Hotel>();
            Package = new HashSet<Package>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
        public bool IsBlock { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Hotel> Hotel { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}
