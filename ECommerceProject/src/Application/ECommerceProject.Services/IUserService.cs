using ECommerceProject.DTO.Requests;
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
        IEnumerable<UserResponse> GetAllUsers();
        UserResponse? GetById(int id);
        void CreateUser(CreateUserRequest entity);
        void UpdateUser(UpdateUserRequest entity);
        void DeleteUser(DeleteUserRequest entity);
        DeleteUserRequest GetUserForDelete(int id);


        Task<IEnumerable<UserResponse>> GetAllUsersAsync();
        Task<UserResponse> GetByIdAsync(int id);
        Task CreateUserAsync(CreateUserRequest entity);
        Task UpdateUserAsync(UpdateUserRequest entity);
        Task DeleteUserAsync(DeleteUserRequest entity);
        Task<UpdateUserRequest> GetUserForUpdateAsync(int id);
        Task<DeleteUserRequest> GetUserForDeleteAsync(int id);
        Task<bool> UserIsExistsAsync(int userId);
        Task<bool> UserMailIsExitsAsync(CreateUserRequest entity);
    }
}
