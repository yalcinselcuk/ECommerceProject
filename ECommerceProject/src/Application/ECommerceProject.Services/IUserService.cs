using ECommerceProject.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Services
{
    public interface IUserService
    {
        IEnumerable<UserResponse> GetUsersResponse();
    }
}
