using Cwiczenia11.DTO.Requests;
using Cwiczenia11.DTO.Responses;
using Cwiczenia11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Services
{
    public interface IDbService
    {
        public DoctorResponse GetDoctor(int id);

        public DoctorResponse AddDoctor(AddDoctorRequest request);

        public DoctorResponse ModifyDoctor(ModifyDoctorRequest request);

        public DoctorResponse DeleteDoctor(int id);
    }
}
