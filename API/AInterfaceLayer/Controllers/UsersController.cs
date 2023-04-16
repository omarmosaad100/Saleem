using BBussinesLogicLayer.Managers;
using CDataAccessLayer.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace A_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersManager _usersManager;

        public UsersController(IUsersManager usersManager)
        {
            _usersManager = usersManager;
        }
        [HttpGet]
        public async Task<ActionResult<AppUser>> GetUsersToInterFace()
        {
            var Users =await _usersManager.getAllUsersFromManager();
            if (Users == null)
            {
                return BadRequest();
            }
            return Ok(Users);
        }
    }
}
