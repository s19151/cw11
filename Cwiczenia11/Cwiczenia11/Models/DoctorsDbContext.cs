using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class DoctorsDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }

        public DoctorsDbContext() { }

        public DoctorsDbContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>((builder) =>
            {
                builder.HasKey(d => d.IdDoctor);
                builder.Property(d => d.IdDoctor).ValueGeneratedOnAdd();

                builder.Property(d => d.IdDoctor).IsRequired();
                builder.Property(d => d.FirstName).IsRequired();
                builder.Property(d => d.LastName).IsRequired();
                builder.Property(d => d.Email).IsRequired();

                builder.HasMany(d => d.Prescriptions)
                    .WithOne(p => p.Doctor)
                    .HasForeignKey(p => p.IdDoctor)
                    .IsRequired();
            });

            modelBuilder.Entity<Patient>((builder) =>
            {
                builder.HasKey(p => p.IdPatient);
                builder.Property(p => p.IdPatient).ValueGeneratedOnAdd();

                builder.Property(p => p.IdPatient).IsRequired();
                builder.Property(p => p.FirstName).IsRequired();
                builder.Property(p => p.LastName).IsRequired();
                builder.Property(p => p.BirthDate).IsRequired();

                builder.HasMany(p => p.Prescriptions)
                    .WithOne(p => p.Patient)
                    .HasForeignKey(p => p.IdPatient)
                    .IsRequired();
            });

            modelBuilder.Entity<Medicament>((builder) =>
            {
                builder.HasKey(m => m.IdMedicament);
                builder.Property(m => m.IdMedicament).ValueGeneratedOnAdd();

                builder.Property(m => m.IdMedicament).IsRequired();
                builder.Property(m => m.Name).IsRequired();
                builder.Property(m => m.Description).IsRequired();
                builder.Property(m => m.Type).IsRequired();

                builder.HasMany(m => m.Prescription_Medicaments)
                    .WithOne(p => p.Medicament)
                    .HasForeignKey(p => p.IdMedicament)
                    .IsRequired();
            });

            modelBuilder.Entity<Prescription>((builder) =>
            {
                builder.HasKey(p => p.IdPrescription);
                builder.Property(p => p.IdPrescription).ValueGeneratedOnAdd();

                builder.Property(p => p.IdPrescription).IsRequired();
                builder.Property(p => p.Date).IsRequired();
                builder.Property(p => p.DueDate).IsRequired();

                builder.HasMany(p => p.Prescription_Medicaments)
                    .WithOne(p => p.Prescription)
                    .HasForeignKey(p => p.IdPrescription)
                    .IsRequired();
            });

            modelBuilder.Entity<Prescription_Medicament>((builder) =>
            {
                builder.HasKey(p => new
                {
                    p.IdMedicament,
                    p.IdPrescription
                });

                builder.Property(p => p.Details).IsRequired();
            });

            modelBuilder.Seed();
        }

    }
}
