using ECommerceProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Infrastructure.Data.DbSeedings
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User() { Id = 1, Name = "Yalçın", Email = "yalcin@gmail.com", Password = "123", CreatedDate = DateTime.Now, CreatedUserId = 1 },
                new User() { Id = 2, Name = "Kerem", Email = "kerem@gmail.com", Password = "123", CreatedDate = DateTime.Now, CreatedUserId = 1 }
            );
        }
    }
}
