using LayersArchDemo.BLL.Models;
using LayersArchDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.BLL.Mappers
{
    public static class UserMappers
    {
        public static User ToUser(this CreateUserForm user)
        {
            return new User()
            {
                UserId = 0,
                Email = user.Email,
                Name = user.Name,
                Password = user.Password,
            };
        }


    }
}
