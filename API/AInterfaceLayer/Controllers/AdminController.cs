using BBussinesLogicLayer.Dtos;
using BBussinesLogicLayer.Managers.Admin;
using CDataAccessLayer.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace AInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminManager _AdminManager;

        public AdminController(IAdminManager adminManager ) {
            _AdminManager = adminManager;
        }

        [HttpPost]
        [Route("addDrug")]
        public ActionResult AddNewDrug([FromBody]DrugDto drug)
        {
            var result = _AdminManager.AddNewDrug(drug);
            //_logger.LogInformation(drug.ToString());

            Console.WriteLine(drug.ToString());

            if(result > 0)
                return Ok();
            else return BadRequest();
        }

    }
}
