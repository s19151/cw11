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
                new Doctor { }
            );

            modelBuilder.Entity<Patient>().HasData(
                new Patient { }
            );

            modelBuilder.Entity<Medicament>().HasData(
                new Medicament { }
            );

            modelBuilder.Entity<Prescription>().HasData(
                new Prescription { }
            );

            modelBuilder.Entity<Prescription_Medicament>().HasData(
                new Prescription_Medicament { }
            );
        }
    }
}
