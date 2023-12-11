using LayersArchDemo.API.Models.DTO;
using LayersArchDemo.BLL.Models;
using LayersArchDemo.DAL.Entities;

namespace LayersArchDemo.API.Mappers
{
    public static class UserMappers
    {
        public static UserDTO ToUserDTO(this User user )
        {
            return new UserDTO()
            {
                UserId = user.UserId,
                Email = user.Email,
                Name = user.Name,
            };
        }

        public static User ToUserUpdateform(this UpdateUserForm user)
        {
            return new User()
            {
                Email = user.Email,
                Name = user.Name,
            };
        }

        public static User ToUserUpdatePasswordForm(this UpdateUserPasswordForm user)
        {
            return new User()
            {
               Password = user.Password
            };
        }
    }
}
