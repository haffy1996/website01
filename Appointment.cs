using System.ComponentModel.DataAnnotations;

namespace MediCare1.AppointmentSystem.Models
{
    public enum AppointmentStatus
    {
        Pending,
        Confirmed,
        Completed,
        Cancelled
    }
    public class Appointment
    {
        public int Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        public PatientProfile Patient { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public DoctorProfile Doctor { get; set; }
        [Required]
        public DateTime StartAt { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;
        [MaxLength(200)] public string? Notes { get; set; }

    }
}