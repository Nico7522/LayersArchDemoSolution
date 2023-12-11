using LayersArchDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.DAL.Context
{
    internal static class FakeDB
    {
        internal static List<User> User = new List<User>()
        {
            new User()
            {
                UserId = 1,
                Name = "Test",
                Email = "test@gmail.com",
                Password = "password",
            },
            new User()
            {
                 UserId = 2,
                 Name = "JohnDoe",
                 Email = "john.doe@email.com",
                 Password = "securepassword123",
},

            new User()
            {
                UserId = 3,
                Name = "AliceSmith",
                Email = "alice.smith@email.com",
                Password = "strongpassword456",
            },

            new User()
            {   
                UserId = 4,
                Name = "BobJohnson",
                Email = "bob.johnson@email.com",
                Password = "mypassword789",
            },

            new User()
            {
                UserId = 5,
                Name = "EmilyJones",
                Email = "emily.jones@email.com",
                Password = "password1234",
            },
        };
    }
}
