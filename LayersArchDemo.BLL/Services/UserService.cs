using LayersArchDemo.BLL.Interfaces;
using LayersArchDemo.BLL.Mappers;
using LayersArchDemo.BLL.Models;
using LayersArchDemo.DAL.Entities;
using LayersArchDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? Create(CreateUserForm form)
        {
            User? user = _userRepository.GetByEmail(form.Email);

            if (user is null)
            {
                return _userRepository.Create(form.ToUser());
            }

            return null;
        }

        public bool Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public IEnumerable<User> getAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetUserId(id);
        }

        public bool Update(User user, int id)
        {
            return _userRepository.Update(user, id);
        }

        public bool UpdatePassword(int id, string password)
        {
            return _userRepository.UpdatePassword(id, password);
        }
    }
}
