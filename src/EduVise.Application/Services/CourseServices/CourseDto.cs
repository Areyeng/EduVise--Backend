using Abp.Domain.Entities;
using EduVise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.CourseServices
{
    public class CourseDto : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Faculty { get; set; }
        public virtual string Description { get; set; }

        //public virtual string JobTitles { get; set; } list of strings
        public virtual string AvgDuration { get; set; }
        public virtual string AvgTuition { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
