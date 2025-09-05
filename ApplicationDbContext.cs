using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MediCare1.AppointmentSystem.Models;
using Medicare1.AppointmentSystem.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity.CoreCompat;

namespace MediCare1.AppointmentSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        // Add DbSet for PatientProfile
        public DbSet<Specialty> Specialities { get; set; }
        public DbSet<PatientProfile> PatientProfiles { get; set; }
        public DbSet<DoctorProfile> DoctorProfiles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}

