using BBussinesLogicLayer.Managers.Home;
using CDataAccessLayer.Data.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeManager _homeManager;

        public HomeController(IHomeManager homeManager)
        {
            _homeManager = homeManager;
        }

        [HttpGet]
        public ActionResult<ICollection<string>> GetAllSpe()
        {
            return Ok(_homeManager.GetAllSpecializations() );
        }
    }
}
