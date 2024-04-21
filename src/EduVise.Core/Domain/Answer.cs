using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Domain
{
    public class Answer : FullAuditedEntity<Guid>
    {
        public virtual Guid QuestionId { get; set; }
        public virtual string AnswerText { get; set; }

       
    }
}
