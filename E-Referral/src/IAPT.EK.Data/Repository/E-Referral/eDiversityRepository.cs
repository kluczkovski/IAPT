using System;
using IAPT.EK.Business.EReferral.Interfaces.Repositorys;
using IAPT.EK.Business.Models;
using IAPT.EK.Data.Context;

namespace IAPT.EK.Data.Repository.EReferral
{
    public class eDiversityRepository: Repository<eDiversity>, IeDiversityRepository
    {
        public eDiversityRepository(AppDbContext appDBContext) : base(appDBContext)
        {

        }
    }
}
