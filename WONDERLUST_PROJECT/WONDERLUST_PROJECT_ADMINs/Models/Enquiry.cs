using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class Enquiry
    {
        public int EnquiryId { get; set; }
        public string UserId { get; set; }
        public long ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Message { get; set; }
        public bool IsBlock { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Users User { get; set; }
    }
}
