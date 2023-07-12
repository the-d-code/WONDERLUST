using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class Country
    {
        public Country()
        {
            Hotel = new HashSet<Hotel>();
            Package = new HashSet<Package>();
            State = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsBlock { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Hotel> Hotel { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<State> State { get; set; }

       

    }



}
