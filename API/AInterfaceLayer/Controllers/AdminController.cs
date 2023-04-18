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

        public AdminController(IAdminManager adminManager)
        {
            _AdminManager = adminManager;
        }

        #region Drug
        [HttpPost]
        [Route("AddDrug")]
        public ActionResult AddNewDrug([FromBody] DrugDto drug)
        {
            var result = _AdminManager.AddNewDrug(drug);

            if (result == 0)
                return BadRequest();
            return Ok();
        }

        //update drug

        //delete drug

        //getall drugs
        [HttpGet]
        [Route("GetAllDrugs")]
        public ActionResult GetAllDrugs([FromBody] DrugDto drug)
        {
            return Ok();
        }


        //get drug by Id  
        #endregion

        #region Doctors/Licence
        //addnewLicence
        //getAllDoctors
        #endregion

    }
}
