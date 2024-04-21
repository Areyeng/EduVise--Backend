using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.InstitutionServices
{
    public class InstitutionDto : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        //public  storedFile Image { get; set; }
        public virtual string Accreditation { get; set; }
        public virtual string Ranking { get; set; }
        public virtual int PassRate { get; set; }
        public virtual string Address { get; set; }
        public virtual string ProgrammesLink { get; set; }
        public virtual string YearbookLink { get; set; }
        public virtual string ApplicationLink { get; set; }
    }
}
