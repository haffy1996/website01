using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicare1.AppointmentSystem.Models
{
    public class DoctorProfile
    {
        public int Id { get; set; }
        [Required] public string UserId { get; set; } = default!;
        public ApplicationUser User { get; set; }

        [Required] public int SpecialtyId { get; set; } = default!;
        public Specialty Specialty { get; set; }

        [MaxLength(120)] public string Location { get; set; } = string.Empty;
        [Column(TypeName = "decimal(10,2)")] public decimal ConsultationFee { get; set; }
    }

}
