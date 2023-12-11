using LayersArchDemo.API.Mappers;
using LayersArchDemo.API.Models.DTO;
using LayersArchDemo.BLL.Interfaces;
using LayersArchDemo.BLL.Models;
using LayersArchDemo.DAL.Entities;
using LayersArchDemo.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LayersArchDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]

        public ActionResult<IEnumerable<UserDTO>> GetAll() {

            return Ok(_userService.getAll().Select(u => u.ToUserDTO()));
        
        }

        [HttpGet("{id}")]
        public ActionResult<UserDTO> Get(int id) {

            User? user = _userService.GetById(id);

            if (user is null) return BadRequest();

            return Ok(user.ToUserDTO());
        }

        [HttpPost]
        public ActionResult<UserDTO> Create(CreateUserForm form) {
            User? user = _userService.Create(form);

            if (user is null)
            {
                return BadRequest();
            }

            return Ok(user);
        }

        [HttpPut("{id}/update")]
        public ActionResult Update(UpdateUserForm form, int id)
        {
            bool isUpdated = _userService.Update(form.ToUserUpdateform(), id);
            if (!isUpdated) return BadRequest();
            
            return NoContent();
        }

        [HttpPatch("{id}/password")]

        public ActionResult UpdatePassword(UpdateUserPasswordForm password, int id)
        {
            bool isPasswordChanged = _userService.UpdatePassword(id, password.ToUserUpdatePasswordForm().ToString());
            if (!isPasswordChanged) return BadRequest();

            return NoContent();
        }

        [HttpDelete("{id}/delete")]

        public ActionResult Delete(int id) { 
        
            bool isDeleted = _userService.Delete(id);
            if (!isDeleted) return BadRequest();
            
            
            return NoContent();
        }
    }
}
