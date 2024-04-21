using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.LearnerEventServices
{
    public class LearnerEventDto
    {
        public virtual Guid LearnerId { get; set; }
        public virtual Guid EventId { get; set; }
    }
}
