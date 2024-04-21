using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.LearnerFundingServices
{
    public class LearnerFundingDto
    {
        public virtual Guid LearnerId { get; set; }
        public virtual Guid FundingId { get; set; }
    }
}
