using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.LearnerCourseServices
{
    public class LearnerCourseDto
    {
        public virtual Guid LearnerId { get; set; }
        public virtual Guid CourseId { get; set; }
    }
}
