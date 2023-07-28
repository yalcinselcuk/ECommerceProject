using AutoMapper;
using ECommerceProject.DTO.Requests;
using ECommerceProject.DTO.Responses;
using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<User, UserResponse>();
            CreateMap<CreateUserRequest, User>();
            CreateMap<UpdateUserRequest, User>().ReverseMap();
            CreateMap<DeleteUserRequest, User>().ReverseMap();
        }
    }
}
