﻿using Abp.Application.Services.Dto;
using EduVise.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.LearnerServices
{
    public class LearnerDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string EmailAddress { get; set; }

        [RegularExpression(@"^\d{1,10}$")]
        public long PhoneNumber { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$")]
        public string Password { get; set; }
        public User User { get; set; }
    }
}
