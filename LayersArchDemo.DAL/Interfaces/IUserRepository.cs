using LayersArchDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.DAL.Interfaces
{
    public interface IUserRepository : IRepositoryBase<int, User>
    {
        User GetByEmail(string email);

        bool UpdatePassword(int id, string password);
    }
}
