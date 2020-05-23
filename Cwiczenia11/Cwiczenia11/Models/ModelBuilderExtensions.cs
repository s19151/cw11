using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "kowalski@mail.com" },
                new Doctor { IdDoctor = 2, FirstName = "Adam", LastName = "Nowak", Email = "anowak@mail.com" },
                new Doctor { IdDoctor = 3, FirstName = "Anna", LastName = "Kowalska", Email = "akowalska@mail.com" },
                new Doctor { IdDoctor = 4, FirstName = "Adam", LastName = "Adamowski", Email = "adamowski@mail.com" },
                new Doctor { IdDoctor = 5, FirstName = "Aleksandra", LastName = "Nowak", Email = "aleksandra.nowak@mail.com" }
            );

            modelBuilder.Entity<Patient>().HasData(
                new Patient { IdPatient = 1, FirstName = "Jan", LastName = "Janowski", BirthDate = DateTime.Parse("20.12.1990") },
                new Patient { IdPatient = 2, FirstName = "Adam", LastName = "Adamowski", BirthDate = DateTime.Parse("12.01.1980") },
                new Patient { IdPatient = 3, FirstName = "Jan", LastName = "Kowalski", BirthDate = DateTime.Parse("05.05.1996") },
                new Patient { IdPatient = 4, FirstName = "Anna", LastName = "Nowak", BirthDate = DateTime.Parse("01.01.2000") },
                new Patient { IdPatient = 5, FirstName = "Piotr", LastName = "Piotrowski", BirthDate = DateTime.Parse("15.06.2005") }
            );

            modelBuilder.Entity<Medicament>().HasData(
                new Medicament { IdMedicament = 1, Name = "A", Description = "lekarstwo a", Type = "typ 1" },
                new Medicament { IdMedicament = 2, Name = "B", Description = "lekarstwo b", Type = "typ 2" },
                new Medicament { IdMedicament = 3, Name = "C", Description = "lekarstwo c", Type = "typ 3" },
                new Medicament { IdMedicament = 4, Name = "D", Description = "lekarstwo d", Type = "typ 4" },
                new Medicament { IdMedicament = 5, Name = "E", Description = "lekarstwo e", Type = "typ 5" }
            );

            modelBuilder.Entity<Prescription>().HasData(
                new Prescription { IdPrescription = 1, Date = DateTime.Parse("01.01.2020"), DueDate = DateTime.Parse("01.02.2020"), IdPatient = 1, IdDoctor = 1 },
                new Prescription { IdPrescription = 2, Date = DateTime.Parse("05.05.2020"), DueDate = DateTime.Parse("05.06.2020"), IdPatient = 2, IdDoctor = 1 },
                new Prescription { IdPrescription = 3, Date = DateTime.Parse("12.05.2020"), DueDate = DateTime.Parse("12.06.2020"), IdPatient = 3, IdDoctor = 2 },
                new Prescription { IdPrescription = 4, Date = DateTime.Parse("16.03.2020"), DueDate = DateTime.Parse("16.04.2020"), IdPatient = 5, IdDoctor = 5 },
                new Prescription { IdPrescription = 5, Date = DateTime.Parse("17.02.2016"), DueDate = DateTime.Parse("17.03.2016"), IdPatient = 1, IdDoctor = 4 }
            );

            modelBuilder.Entity<Prescription_Medicament>().HasData(
                new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 1, Details = "aaaa" },
                new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 2, Details = "bbbb" },
                new Prescription_Medicament { IdMedicament = 3, IdPrescription = 3, Dose = 3, Details = "cccc" },
                new Prescription_Medicament { IdMedicament = 4, IdPrescription = 4, Dose = 4, Details = "dddd" },
                new Prescription_Medicament { IdMedicament = 5, IdPrescription = 5, Dose = 5, Details = "eeee" }
            );
        }
    }
}
