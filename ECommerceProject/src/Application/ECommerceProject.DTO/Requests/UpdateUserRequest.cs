using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DTO.Requests
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CreateadUserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
