using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MediCare1.AppointmentSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;
    }
}
