using Cwiczenia11.DTO.Requests;
using Cwiczenia11.DTO.Responses;
using Cwiczenia11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Services
{
    public class DoctorsDbService : IDbService
    {
        private readonly DoctorsDbContext _dbContext;

        public DoctorsDbService(DoctorsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DoctorResponse AddDoctor(AddDoctorRequest request)
        {
            var response = new DoctorResponse();

            var doctor = _dbContext.Doctors.Add(new Doctor()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            })
            .Entity;

            if (doctor != null)
            {
                _dbContext.SaveChanges();

                response.IdDoctor = doctor.IdDoctor;
                response.FirstName = doctor.FirstName;
                response.LastName = doctor.LastName;
                response.Email = doctor.Email;
            }

            else
                _dbContext.Remove(doctor);

            return response;
        }

        public DoctorResponse GetDoctor(int id)
        {
            var response = new DoctorResponse();

            var doctor = _dbContext.Doctors.Find(id);
            if (doctor != null)
            {
                response.IdDoctor = doctor.IdDoctor;
                response.FirstName = doctor.FirstName;
                response.LastName = doctor.LastName;
                response.Email = doctor.Email;
            }

            return response;
        }

        public DoctorResponse ModifyDoctor(int id, ModifyDoctorRequest request)
        {
            var response = new DoctorResponse();

            var doctor = _dbContext.Doctors.Find(id);

            if (request.FirstName != null)
                doctor.FirstName = request.FirstName;

            if (request.LastName != null)
                doctor.LastName = request.LastName;

            if (request.Email != null)
                doctor.Email = request.Email;

            _dbContext.SaveChanges();

            response.IdDoctor = doctor.IdDoctor;
            response.FirstName = doctor.FirstName;
            response.LastName = doctor.LastName;
            response.Email = doctor.Email;

            return response;
        }

        public DoctorResponse DeleteDoctor(int id)
        {
            var response = new DoctorResponse();

            var doctor = _dbContext.Doctors.Find(id);

            if (doctor != null)
            {
                _dbContext.Doctors.Remove(doctor);

                response.IdDoctor = doctor.IdDoctor;
                response.FirstName = doctor.FirstName;
                response.LastName = doctor.LastName;
                response.Email = doctor.Email;

                _dbContext.SaveChanges();
            }

            return response;
        }
    }
}
