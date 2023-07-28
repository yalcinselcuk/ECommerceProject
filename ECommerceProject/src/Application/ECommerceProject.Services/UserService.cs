using AutoMapper;
using ECommerceProject.DTO.Requests;
using ECommerceProject.DTO.Responses;
using ECommerceProject.Entities;
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

        public IEnumerable<UserResponse> GetAllUsers()
        {
            var users = _userRepository.GetAll();
            var response = _mapper.Map<IEnumerable<UserResponse>>(users);
            return response;
        }

        public async Task<IEnumerable<UserResponse>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<UserResponse>>(users);
            return response;
        }
        public void CreateUser(CreateUserRequest entity)
        {
            var user = _mapper.Map<User>(entity);
            _userRepository.Create(user);
        }

        public async Task CreateUserAsync(CreateUserRequest entity)
        {
            var user = _mapper.Map<User>(entity);
            await _userRepository.CreateAsync(user);
        }

        public void DeleteUser(DeleteUserRequest entity)
        {
            var user = _mapper.Map<User>(entity);
            _userRepository.DeleteAsync(user);
        }

        public async Task DeleteUserAsync(DeleteUserRequest entity)
        {
            var user = _mapper.Map<User>(entity);
            await _userRepository.DeleteAsync(user);
        }

        public UserResponse? GetById(int id)
        {
            var user = _userRepository.GetById(id);
            return _mapper.Map<UserResponse>(user);
        }

        public async Task<UserResponse> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserResponse>(user);
        }

        public DeleteUserRequest GetUserForDelete(int id)
        {
            var user = _userRepository.GetById(id);
            return _mapper.Map<DeleteUserRequest>(user);
        }

        public async Task<DeleteUserRequest> GetUserForDeleteAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<DeleteUserRequest>(user);
        }

        public async Task<UpdateUserRequest> GetUserForUpdateAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UpdateUserRequest>(user);
        }


        public void UpdateUser(UpdateUserRequest entity)
        {
            var user = _mapper.Map<User>(entity);
            _userRepository.Update(user);
        }

        public async Task UpdateUserAsync(UpdateUserRequest entity)
        {
            var user = _mapper.Map<User>(entity);
            await _userRepository.UpdateAsync(user);
        }

        public async Task<bool> UserIsExistsAsync(int userId)
        {
            return await _userRepository.IsExistsUserAsync(userId);
        }
        public async Task<bool> UserMailIsExitsAsync(CreateUserRequest entity)
        {
            var user = _mapper.Map<User>(entity);
            return await _userRepository.IsExistsUserMailAsync(user);
        }
    }
}
