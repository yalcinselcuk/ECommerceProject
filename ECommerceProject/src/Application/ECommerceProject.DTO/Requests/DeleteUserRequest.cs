﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DTO.Requests
{
    public class DeleteUserRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
