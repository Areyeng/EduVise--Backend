using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.AnswerServices
{
    public class AnswerDto
    {
        public virtual Guid QuestionId { get; set; }
        public virtual string AnswerText { get; set; }
    }
}
