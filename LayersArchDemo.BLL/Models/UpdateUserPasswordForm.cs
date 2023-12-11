using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.BLL.Models
{
    #nullable disable
    public class UpdateUserPasswordForm
    {
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
