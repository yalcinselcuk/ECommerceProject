﻿using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Infrastructure.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> IsExistsUserMailAsync(User entity);
    }
}
