using System;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Data.Context;

namespace IAPT.EK.Data.Repository
{
    public class eAgencyInformationRespository: Repository<eAgencyInformation>, IeAgencyInformationRespository
    {
        public eAgencyInformationRespository(AppDbContext appDBContext) : base(appDBContext)
        {
        }
    }
}
