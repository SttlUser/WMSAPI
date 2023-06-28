﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserMaster
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public bool ? IsActive { get; set; }
        public bool ? IsDelete { get; set; }
        public int ? DeletedBy { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public Error Error { get; set; }
    }
}
