using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.BLL.Models
{
    public class CreateUserForm
    {
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MinLength(8)]
        public string Password { get; set; }
    }
}
