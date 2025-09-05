using MediCare1.AppointmentSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace Medicare1.AppointmentSystem.Models;
{
public record PatientProfile(int Id, ApplicationUser User, DataTime? DateOfBirth, [property: MaxLength(20)] string Gender)
{
    [Required]
    public string UserId { get; set; } = default!;
}
}
