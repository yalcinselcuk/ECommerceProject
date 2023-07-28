using AutoMapper;
using ECommerceProject.DTO.Responses;
using ECommerceProject.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUserRepository userRepository = null)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public IEnumerable<UserResponse> GetUsersResponse()
        {
            var users = _userRepository.GetAll();
            var response = _mapper.Map<IEnumerable<UserResponse>>(users);
            return response;
        }
    }
}
