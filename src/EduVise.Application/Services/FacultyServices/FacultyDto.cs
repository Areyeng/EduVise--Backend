using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.FacultyServices
{
    public class FacultyDto : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        //public virtual string RequiredSubjects { get; set; } will contain all or some of the following(Mathematic,Physical Sciences,Biology,English)
        //public virtual Institution Institutions { get; set; } list of institutions that offer faculty
        //public virtual Course Courses { get; set; } list of courses
    }
}
