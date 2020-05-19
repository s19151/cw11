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
            throw new NotImplementedException();
        }

        public DoctorResponse GetDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public DoctorResponse ModifyDoctor(ModifyDoctorRequest request)
        {
            throw new NotImplementedException();
        }

        public DoctorResponse DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
