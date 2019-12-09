using System;
namespace IAPT.EK.Business.Models
{
    public class EthnicCategory : Entity
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public int Sequence { get; set; }

        public EthnicCategory()
        {
        }
    }
}
