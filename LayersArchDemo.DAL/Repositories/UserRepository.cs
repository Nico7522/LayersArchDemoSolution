using LayersArchDemo.DAL.Context;
using LayersArchDemo.DAL.Entities;
using LayersArchDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
  

        public User Create(User entity)
        {
            entity.UserId = FakeDB.User.Max(u => u.UserId);
            FakeDB.User.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            User? user = FakeDB.User.Find(u => u.UserId == id);
            if (user is null) return false;
       
            bool isDeleted = FakeDB.User.Remove(user);
            return true;
        }

        public IEnumerable<User> GetAll()
        {
            return FakeDB.User;
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User? GetUserId(int id)
        {
            User? user = FakeDB.User.SingleOrDefault(u => u.UserId == id);
            if (user is null) return null;

            return user;
        }

        public bool Update(User entity, int id)
        {
            User? user = FakeDB.User.Find(u => u.UserId == id);
            if (user is null) return false;

            int index = FakeDB.User.FindIndex(u => u.UserId == id);
            int userId = user.UserId;
            entity.UserId = userId;
            FakeDB.User[index] = entity;
            return true;
          
        }

        public bool UpdatePassword(int id, string password)
        {
            int index = FakeDB.User.FindIndex(u => u.UserId == id);
            if(index == -1) return false;

            FakeDB.User[index].Password = password;
            return true;
        }
    }
}
