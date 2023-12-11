using LayersArchDemo.BLL.Models;
using LayersArchDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> getAll();

        User GetById(int id);

        User Create(CreateUserForm user);

        bool Update(User user, int id);

        bool Delete(int id);

        bool UpdatePassword(int id, string password);
    }
}
