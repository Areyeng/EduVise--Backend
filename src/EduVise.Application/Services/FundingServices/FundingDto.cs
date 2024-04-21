using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.FundingServices
{
    public class FundingDto
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string InstitutionCriteria { get; set; }
        public virtual string FacultyCriteria { get; set; }
        public virtual string MarkCriteria { get; set; }

        public virtual long AnnualAmount { get; set; }
        //must be 1 digit
        public virtual int Duration { get; set; }
        public virtual DateOnly OpeningDate { get; set; }
        public virtual DateOnly ClosingDate { get; set; }
    }
}
