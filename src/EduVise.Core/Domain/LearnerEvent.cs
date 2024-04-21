using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Domain
{
    public class LearnerEvent : FullAuditedEntity<Guid>
    {
        public virtual Guid LearnerId { get; set; }
        public virtual Guid EventId { get; set; }
    }
}
