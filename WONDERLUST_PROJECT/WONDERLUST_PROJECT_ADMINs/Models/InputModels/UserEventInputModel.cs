namespace WONDERLUST_PROJECT_ADMINs.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    public class UserEventInputModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string EventId { get; set; }
    }
}
